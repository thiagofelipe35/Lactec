using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using HistoricoClimatologico.Models;
using HistoricoClimatologico.Interfaces.Repository;

namespace HistoricoClimatologico.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IHistoricoRepository _historicoRepository;
        private readonly ICidadeRepository _cidadeRepository;

        public HomeController(ILogger<HomeController> logger, IHistoricoRepository historicoRepository, ICidadeRepository cidadeRepository)
        {
            _logger = logger;
            _historicoRepository = historicoRepository;
            _cidadeRepository = cidadeRepository;
        }

        public IActionResult Index(int? codigoCidade)
        {
            codigoCidade ??= 3464975;

            var cidades = _cidadeRepository.ObterListaAsync().Result.ToList();
            var medias = _historicoRepository.ObterMediaAsync(7, codigoCidade ?? 3464975);
            var medidaAtual = _historicoRepository.ObterUltimaMedicaoAsync(codigoCidade ?? 3464975);

            ViewBag.Cidades = cidades;
            ViewBag.CidadeAtual = codigoCidade;
            ViewBag.TemperaturaAtual = medidaAtual.Temperatura;
            ViewBag.UmidadeAtual = medidaAtual.Umidade;

            ViewBag.DiasTemperaturasMedias = string.Join(",", medias.Select(x => "'" + x.Data.ToString("dd/MM") + "'").ToList()).Trim();
            ViewBag.TemperaturasMedias = string.Join(",", medias.Select(x => Math.Round(x.TemperaturaMedia, 2)).ToList()).Trim();

            ViewBag.DiasUmidadesMedias = string.Join(",", medias.Select(x => "'" + x.Data.ToString("dd/MM") + "'").ToList()).Trim();
            ViewBag.UmidadesMedias = string.Join(",", medias.Select(x => Math.Round(x.UmidadeMedia, 2)).ToList()).Trim();

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
