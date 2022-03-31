using Ardalis.Specification;

namespace Udea.Chaos.Journey.Domain.Specifications
{
    public class GetJourneysIdsSpec : Specification<Entities.Journey, string>
    {
        public GetJourneysIdsSpec()
        {
            Query.Select(_ => _.Id);
        }
    }
}