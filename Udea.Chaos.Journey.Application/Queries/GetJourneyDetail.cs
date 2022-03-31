using MediatR;
using Udea.Chaos.Journey.Application.Dtos;

namespace Udea.Chaos.Journey.Application.Queries
{
    public record GetJourneyDetail(Guid Id) : IRequest<JourneyDto?>;
}