using MediatR;
using Udea.Chaos.Journey.Application.Dtos;
using Udea.Chaos.Journey.Application.Extensions;
using Udea.Chaos.Journey.Domain.Ports;

namespace Udea.Chaos.Journey.Application.Queries
{
    public class GetJourneyDetailHandler : IRequestHandler<GetJourneyDetail, JourneyDto?>
    {
        private readonly IJourneyRepository _journeyRepository;

        public GetJourneyDetailHandler(IJourneyRepository journeyRepository)
        {
            _journeyRepository = journeyRepository;
        }

        public async Task<JourneyDto?> Handle(GetJourneyDetail request, CancellationToken cancellationToken)
        {
            var journey = await _journeyRepository.GetByIdAsync(request.Id.ToString());
            if (journey == null) return null;
            return journey.ToDto();
        }
    }
}