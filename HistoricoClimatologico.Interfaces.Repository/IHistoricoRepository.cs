using HistoricoClimatologico.Database;
using System.Collections.Generic;

namespace HistoricoClimatologico.Interfaces.Repository
{
    public interface IHistoricoRepository : IBaseRepository<Historico>
    {
        Historico ObterUltimaMedicaoAsync(int codigoCidade);
        IEnumerable<HistoricoMedia> ObterMediaAsync(int quantidadeDias, int codigoCidade);
    }
}
