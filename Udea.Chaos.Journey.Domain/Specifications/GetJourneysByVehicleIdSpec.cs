using Ardalis.Specification;

namespace Udea.Chaos.Journey.Domain.Specifications
{
    public class GetJourneysByVehicleIdSpec : Specification<Entities.Journey>
    {
        public GetJourneysByVehicleIdSpec(Guid vehicleId)
        {
            Query.Where(_ => _.VehicleId == vehicleId);
        }
    }
}