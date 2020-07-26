using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Reference.Core.Domain;

namespace Reference.Core.Data
{
    public interface IContext
    {
    }

    public interface IDataContext : IContext
    {
        Task<TEntity> InsertAsync<TId, TEntity>(TEntity entity) where TEntity : EntityBase<TId>;
        Task<TEntity> UpdateAsync<TId, TEntity>(TEntity entity) where TEntity : EntityBase<TId>;
        Task<TEntity> GetByIdAsync<TId, TEntity>(object id) where TEntity : EntityBase<TId>;
        Task<TEntity> DeleteAsync<TId, TEntity>(object id) where TEntity : EntityBase<TId>;
    }
}
