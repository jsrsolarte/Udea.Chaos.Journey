using Udea.Chaos.Journey.Domain.Ports;

namespace Udea.Chaos.Journey.Infrastructure.Adapters
{
    public class JourneyRepository : CosmosRepository<Domain.Entities.Journey>, IJourneyRepository
    {
        public JourneyRepository(ICosmosContainerFactory cosmosDbContainerFactory) : base(cosmosDbContainerFactory)
        {
        }
    }
}