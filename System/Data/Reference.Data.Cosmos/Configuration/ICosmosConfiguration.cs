﻿using Reference.Core.Configuration;

namespace Reference.Data.Cosmos.Configuration
{
    public interface ICosmosClientConfiguration : IConfiguration
    {
        string ConnectionString { get; set; }
        string ApplicationRegion { get; set; }
    }

    public interface ICosmosDatabaseConfiguration : IConfiguration
    {
        string DatabaseId { get; set; }
    }

    public interface ICosmosContainerConfiguration
    {
        string DatabaseId { get; set; }
        string ContainerId { get; set; }
    }
}
