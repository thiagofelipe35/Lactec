using HistoricoClimatologico.Database;
using HistoricoClimatologico.Interfaces.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace HistoricoClimatologico.Repository
{
    public class BaseRepository<T> : IBaseRepository<T>
        where T : BaseEntity
    {

        public virtual async Task<IEnumerable<T>> ObterListaAsync(Expression<Func<T, bool>> match)
        {
            using (var context = new HistoricoClimatologicoContext())
            {
                var query = context.Set<T>().AsQueryable();
                if (match != null)
                    query = query.Where(match);

                return await query.ToListAsync();
            }
        }

        public virtual async Task<IEnumerable<T>> ObterListaAsync()
        {
            return await ObterListaAsync(null);
        }

        public virtual async Task<T> AdicionarAsync(T t)
        {
            using var context = new HistoricoClimatologicoContext();
            var data = context.Set<T>().Add(t);
            await context.SaveChangesAsync();
            return data.Entity;
        }
    }
}
