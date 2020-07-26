using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.Azure.Cosmos;
using Reference.Core.Data;
using Reference.Core.Domain;
using Reference.Data.Cosmos.Client;
using Reference.Data.Cosmos.Configuration;
using Reference.Data.Cosmos.Entity;

namespace Reference.Data.Cosmos
{
    public class CosmosContext : ICosmosContext
    {
        private readonly ICosmosClientProvider _clientProvider;
        private readonly ICosmosDatabaseConfiguration _databaseConfiguration;
        private readonly ICosmosContainerConfiguration _containerConfiguration;
        private readonly Container _container;

        public CosmosContext(
            ICosmosClientProvider clientProvider,
            ICosmosDatabaseConfiguration databaseConfiguration,
            ICosmosContainerConfiguration containerConfiguration)
        {
            _clientProvider = clientProvider;
            _databaseConfiguration = databaseConfiguration;
            _containerConfiguration = containerConfiguration;
            _container = GetContainer();
            ReadContainer();
        }

        private Container GetContainer()
        {

            return _clientProvider.GetContainer(_containerConfiguration.DatabaseId,
                _containerConfiguration.ContainerId);
        }

        private void ReadContainer()
        {
            try
            {
                _container.ReadContainerAsync();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public Task<TEntity> InsertAsync<TId, TEntity>(TEntity entity) where TEntity : CosmosEntity
        {
            return await _container.CreateItemAsync()
        }

        public Task<TEntity> UpdateAsync<TId, TEntity>(TEntity entity) where TEntity : CosmosEntity
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> GetByIdAsync<TId, TEntity>(object id) where TEntity : CosmosEntity
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> DeleteAsync<TId, TEntity>(object id) where TEntity : CosmosEntity
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TEntity>> GetAsync<TEntity>(Expression<Func<TEntity, bool>> predicate, string documentType)
        {
            throw new NotImplementedException();
        }
    }
}
