using System.Threading.Tasks;
using Reference.Core.Domain;

namespace Reference.Core.Data
{
    /// <summary>
    /// Base implementation of a CRUD operations Repository
    /// </summary>
    public abstract class RepositoryBase<TEntity> : IRepository<TEntity>
        where TEntity : Entity
    {
        private readonly IDataContext _context;

        public RepositoryBase(IDataContext context)
        {
            _context = context;
        }

        public Task<TEntity> InsertAsync(TEntity entity)
        {
            return _context.InsertAsync(entity);
        }

        public Task<TEntity> UpdateAsync(TEntity entity)
        {
            return _context.UpdateAsync(entity);
        }

        public Task<TEntity> GetByIdAsync(object id)
        {
            return _context.GetByIdAsync<TEntity>(id);
        }

        public Task<TEntity> DeleteAsync(object id)
        {
            return _context.DeleteAsync<TEntity>(id);
        }
    }
}
