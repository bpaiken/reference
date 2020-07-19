using System.Threading.Tasks;
using Reference.Core.Domain;

namespace Reference.Core.Data
{
    public interface IRepository<TEntity>
        where TEntity : class
    {
        Task<TEntity> InsertAsync(TEntity entity);
        Task<TEntity> UpdateAsync(TEntity entity);
        Task<TEntity> GetByIdAsync(object id);
        Task<TEntity> DeleteAsync(object id);
    }
}
