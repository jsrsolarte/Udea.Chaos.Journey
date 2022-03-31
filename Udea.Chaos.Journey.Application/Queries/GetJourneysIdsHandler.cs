using MediatR;
using Udea.Chaos.Journey.Domain.Ports;
using Udea.Chaos.Journey.Domain.Specifications;

namespace Udea.Chaos.Journey.Application.Queries
{
    public class GetJourneysIdsHandler : IRequestHandler<GetJourneysIds, IEnumerable<Guid>>
    {
        private readonly IJourneyRepository _journeyRepository;

        public GetJourneysIdsHandler(IJourneyRepository journeyRepository)
        {
            _journeyRepository = journeyRepository;
        }

        public async Task<IEnumerable<Guid>> Handle(GetJourneysIds request, CancellationToken cancellationToken)
        {
            var spec = new GetJourneysIdsSpec();
            var journeysIds = await _journeyRepository.ListAsync(spec, cancellationToken);
            return journeysIds.Select(_ => Guid.Parse(_));
        }
    }
}