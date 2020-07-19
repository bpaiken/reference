using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Reference.Core.Data;

namespace Disclone.Data.Cosmos.Context
{
    public interface ICosmosContext : IDataContext
    {
        Task<IEnumerable<TEntity>> GetAsync<TEntity>(Expression<Func<TEntity, bool>> predicate, string documentType);
    }

    public class CosmosContext
    {
        // public CosmosContext(ICosmosClient )
        // {
        //
        // }
    }
}
