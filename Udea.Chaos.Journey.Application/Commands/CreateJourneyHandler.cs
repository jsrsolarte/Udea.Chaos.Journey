using MediatR;
using Udea.Chaos.Journey.Application.Extensions;
using Udea.Chaos.Journey.Domain.Ports;

namespace Udea.Chaos.Journey.Application.Commands
{
    public class CreateJourneyHandler : AsyncRequestHandler<CreateJourney>
    {
        private readonly IJourneyRepository _journeyRepository;

        public CreateJourneyHandler(IJourneyRepository journeyRepository)
        {
            _journeyRepository = journeyRepository;
        }

        protected override async Task Handle(CreateJourney request, CancellationToken cancellationToken)
        {
            var entity = request.ToEntity();
            await _journeyRepository.AddAsync(entity, cancellationToken);
        }
    }
}