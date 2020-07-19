using System;
using System.Threading.Tasks;
using Reference.Core.Data;

namespace Reference.Core.Domain
{
    public abstract class ManagerBase<TId, TEntity> : IManager<TId, TEntity>
        where TEntity : EntityBase<TId>
    {
        private readonly IRepository<TEntity> _repository;

        protected ManagerBase(IRepository<TEntity> repository)
        {
            _repository = repository;
        }

        public Task<TEntity> GetByIdAsync(TId id)
        {
            return _repository.GetByIdAsync(id);
        }
    }

    public abstract class ManagerBase<TEntity> : ManagerBase<Guid, TEntity>, IManager<TEntity>
        where TEntity : EntityBase<Guid>
    {
        protected ManagerBase(IRepository<TEntity> repository) : base(repository)
        {
        }
    }
}
