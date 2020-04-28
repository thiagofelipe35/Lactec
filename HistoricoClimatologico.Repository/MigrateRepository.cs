using HistoricoClimatologico.Database;
using HistoricoClimatologico.Interfaces.Repository;
using Microsoft.EntityFrameworkCore;

namespace HistoricoClimatologico.Repository
{
    public class MigrateRepository : IMigrateRepository
    {
        public void Migrate()
        {
            using var context = new HistoricoClimatologicoContext();
            context.Database.Migrate();
        }
    }
}
