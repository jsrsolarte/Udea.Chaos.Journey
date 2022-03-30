using Microsoft.Azure.Cosmos;
using Udea.Chaos.Journey.Domain.Entities;

namespace Udea.Chaos.Journey.Infrastructure
{
    public interface IContainerContext<T> where T : EntityBase<string>
    {
        string ContainerName { get; }

        string GenerateId(T entity);

        PartitionKey ResolvePartitionKey(string entityId);
    }
}