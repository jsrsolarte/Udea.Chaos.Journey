using MediatR;
using Udea.Chaos.Journey.Application.Dtos;

namespace Udea.Chaos.Journey.Application.Queries
{
    public record GetAllJourneysByVehicle(Guid VehicleId) : IRequest<IEnumerable<JourneyDto>>;
}