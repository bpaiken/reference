using System;
using Reference.Core.Domain;

namespace Reference.Data.Cosmos.Entity
{
    public class CosmosEntity : EntityBase<Guid?>
    {
        public string DocumentType { get; set; }
        public string PartitionKey { get; set; }
    }
}
