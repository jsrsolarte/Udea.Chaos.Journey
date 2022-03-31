using MediatR;
using Microsoft.AspNetCore.Mvc;
using Udea.Chaos.Journey.Application.Commands;
using Udea.Chaos.Journey.Application.Dtos;
using Udea.Chaos.Journey.Application.Queries;

namespace Udea.Chaos.Journey.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class JourneyController
    {
        private readonly IMediator _mediator;

        public JourneyController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IEnumerable<Guid>> GetJourneyIds()
        {
            return await _mediator.Send(new GetJourneysIds());
        }

        [HttpGet("detail/{id}")]
        public async Task<JourneyDto?> GetOwnerDetail(Guid id)
        {
            var owner = await _mediator.Send(new GetJourneyDetail(id));

            if (owner == null) return null;
            return owner;
        }

        [HttpGet("by-vehicle/{vehicleId}")]
        public async Task<IEnumerable<JourneyDto>> GetJourneysByVehicle(Guid vehicleId)
        {
            return await _mediator.Send(new GetAllJourneysByVehicle(vehicleId));
        }

        [HttpPost]
        public async Task CreateJourney(CreateJourney createJourney)
        {
            await _mediator.Send(createJourney);
        }
    }
}