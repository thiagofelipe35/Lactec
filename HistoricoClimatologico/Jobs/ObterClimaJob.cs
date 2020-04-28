using FluentScheduler;
using HistoricoClimatologico.Database;
using HistoricoClimatologico.Interfaces.Repository;
using HistoricoClimatologico.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace HistoricoClimatologico.Job
{
    public class AtualizarClimaJob : IJob
    {
        private readonly IHistoricoRepository _historicoRepository;
        private readonly ICidadeRepository _cidadeRepository;

        public AtualizarClimaJob(IHistoricoRepository historicoRepository, ICidadeRepository cidadeRepository)
        {
            _historicoRepository = historicoRepository;
            _cidadeRepository = cidadeRepository;
        }

        public void Execute()
        {
            try
            {
                var codigoCidades = _cidadeRepository.ObterListaAsync().Result?.Select(x => x.Codigo).ToList() ?? new List<string>();

                foreach (var codigo in codigoCidades)
                {
                    var clima = ObterClima(codigo).Result;

                    var historico = new Historico
                    {
                        Base = clima.Base,
                        DataConsulta = DateTime.Now,
                        Visibilidade = clima.Visibilidade,
                        Data = clima.Data,
                        Timezone = clima.Timezone,
                        NomeCidade = clima.NomeCidade,
                        CodigoCidade = clima.CodigoCidade,
                        Temperatura = clima.Principal?.Temperatura ?? 0,
                        Umidade = clima.Principal?.Umidade ?? 0,
                    };

                    var result = _historicoRepository.AdicionarAsync(historico).Result;
                }
            }
            catch 
            {
                // TODO: Tratar erro de consultas
            }
        }

        public async Task<ClimaModel> ObterClima(string codigo)
        {
            var apiKey = "1972107980eeea35fde3e93f8108cd13";

            using var client = new HttpClient { Timeout = TimeSpan.FromMinutes(2) };
            var response = await client.GetAsync($"http://api.openweathermap.org/data/2.5/weather?id={codigo}&appid={apiKey}&units=metric&lang=pt_br");

            if (response.IsSuccessStatusCode)
                return JsonConvert.DeserializeObject<ClimaModel>(response.Content.ReadAsStringAsync().Result);
            else
                return default;
        }
    }
}
