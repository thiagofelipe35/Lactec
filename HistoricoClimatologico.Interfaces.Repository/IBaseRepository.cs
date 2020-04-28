using HistoricoClimatologico.Database;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace HistoricoClimatologico.Interfaces.Repository
{
    public interface IBaseRepository<TEntity>
        where TEntity : BaseEntity
    {
        Task<IEnumerable<TEntity>> ObterListaAsync(Expression<Func<TEntity, bool>> match);
        Task<IEnumerable<TEntity>> ObterListaAsync();
        Task<TEntity> AdicionarAsync(TEntity t);
    }
}
