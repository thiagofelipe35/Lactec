using HistoricoClimatologico.Database;
using HistoricoClimatologico.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HistoricoClimatologico.Repository
{
    public class HistoricoRepository : BaseRepository<Historico>, IHistoricoRepository
    {
        public virtual Historico ObterUltimaMedicaoAsync(int codigoCidade)
        {
            using var context = new HistoricoClimatologicoContext();
            return context.Historico.Where(x => x.CodigoCidade == codigoCidade).OrderByDescending(x => x.Id).FirstOrDefault();
        }

        public virtual IEnumerable<HistoricoMedia> ObterMediaAsync(int quantidadeDias, int codigoCidade)
        {
            using var context = new HistoricoClimatologicoContext();
            var historico = context.Historico.Where(x => x.DataConsulta >= DateTime.Now.AddDays(-quantidadeDias).Date && x.CodigoCidade == codigoCidade).ToList();
            var medias = historico
                .GroupBy(x => new { Data = x.DataConsulta.Date, x.NomeCidade })
                .Select(x => new HistoricoMedia
                {
                    Data = x.Key.Data,
                    NomeCidade = x.Key.NomeCidade,
                    TemperaturaMedia = x.Select(y => y.Temperatura).Average(),
                    UmidadeMedia = x.Select(y => y.Umidade).Average()
                })
               .ToList();

            return medias;
        }
    }
}
