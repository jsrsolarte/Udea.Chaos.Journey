using MediatR;
using Udea.Chaos.Journey.Application.Dtos;
using Udea.Chaos.Journey.Application.Extensions;
using Udea.Chaos.Journey.Domain.Ports;
using Udea.Chaos.Journey.Domain.Specifications;

namespace Udea.Chaos.Journey.Application.Queries
{
    public class GetAllJourneysByVehicleHandler : IRequestHandler<GetAllJourneysByVehicle, IEnumerable<JourneyDto>>
    {
        private readonly IJourneyRepository _journeyRepository;

        public GetAllJourneysByVehicleHandler(IJourneyRepository journeyRepository)
        {
            _journeyRepository = journeyRepository;
        }

        public async Task<IEnumerable<JourneyDto>> Handle(GetAllJourneysByVehicle request, CancellationToken cancellationToken)
        {
            var spec = new GetJourneysByVehicleIdSpec(request.VehicleId);
            var journeys = await _journeyRepository.ListAsync(spec, cancellationToken);
            return journeys.Select(_ => _.ToDto());
        }
    }
}