using Microsoft.Azure.Cosmos;

namespace Udea.Chaos.Journey.Infrastructure
{
    public interface ICosmosContainerFactory
    {
        Container GetContainer(string containerName);
    }
}