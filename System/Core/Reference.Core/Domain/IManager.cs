using System;
using System.Threading.Tasks;

namespace Reference.Core.Domain
{
    public interface IManager<in TId, TEntity> where TEntity : EntityBase<TId>
    {
        Task<TEntity> GetByIdAsync(TId id);
    }

    public interface IManager<TEntity> : IManager<Guid, TEntity>
        where TEntity : EntityBase<Guid>
    {
    }
}
