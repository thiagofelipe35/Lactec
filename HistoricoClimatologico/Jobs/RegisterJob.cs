using FluentScheduler;
using HistoricoClimatologico.Interfaces.Repository;

namespace HistoricoClimatologico.Job
{
    public class RegisterJob : Registry
    {
        public RegisterJob(IHistoricoRepository historicoRepository, ICidadeRepository cidadeRepository)
        {
            Schedule(() => new AtualizarClimaJob(historicoRepository, cidadeRepository)).ToRunNow().AndEvery(15).Minutes();
        }
    }
}
