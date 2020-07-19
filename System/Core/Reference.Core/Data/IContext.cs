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
        Task<TEntity> InsertAsync<TEntity>(TEntity entity) where TEntity : Entity;
        Task<TEntity> UpdateAsync<TEntity>(TEntity entity) where TEntity : Entity;
        Task<TEntity> GetByIdAsync<TEntity>(object id) where TEntity : Entity;
        Task<TEntity> DeleteAsync<TEntity>(object id) where TEntity : Entity;
    }
}
