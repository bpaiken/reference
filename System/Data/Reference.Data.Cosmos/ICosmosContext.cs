using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Reference.Core.Data;
using Reference.Data.Cosmos.Entity;

namespace Reference.Data.Cosmos
{
    public interface ICosmosContext : IContext
    {
        Task<TEntity> InsertAsync<TId, TEntity>(TEntity entity) where TEntity : CosmosEntity;
        new Task<TEntity> UpdateAsync<TId, TEntity>(TEntity entity) where TEntity : CosmosEntity;
        new Task<TEntity> GetByIdAsync<TId, TEntity>(object id) where TEntity : CosmosEntity;
        new Task<TEntity> DeleteAsync<TId, TEntity>(object id) where TEntity : CosmosEntity;
        Task<IEnumerable<TEntity>> GetAsync<TEntity>(Expression<Func<TEntity, bool>> predicate, string documentType);
    }
}
