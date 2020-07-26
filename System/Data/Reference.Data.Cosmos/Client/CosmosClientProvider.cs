using System.Threading.Tasks;
using Microsoft.Azure.Cosmos;
using Reference.Data.Cosmos.Configuration;

namespace Reference.Data.Cosmos.Client
{
    public interface ICosmosClientProvider
    {
        Container GetContainer(string databaseId, string containerId);
    }

    public class CosmosClientProvider : ICosmosClientProvider
    {
        private readonly ICosmosClientConfiguration _config;
        private readonly CosmosClient _client;

        public CosmosClientProvider(ICosmosClientConfiguration config)
        {
            _config = config;
            InitializeClient();
        }

        private CosmosClient InitializeClient()
        {
            var cosmosClient = new CosmosClient(
                _config.ConnectionString,
                new CosmosClientOptions()
                {
                    ApplicationRegion = _config.ApplicationRegion
                });

            // Todo: CreateDatabaseIfNotExists - needed here?
            return cosmosClient;
        }

        public Container GetContainer(string databaseId, string containerId)
        {
            return _client.GetContainer(databaseId, containerId);
        }
    }
}
