using Udea.Chaos.Journey.Application.Commands;
using Udea.Chaos.Journey.Application.Dtos;

namespace Udea.Chaos.Journey.Application.Extensions
{
    public static class DtosExtension
    {
        public static JourneyDto ToDto(this Domain.Entities.Journey journey)
        {
            return new JourneyDto(journey.Kilometers, journey.PricePerKilometer, journey.InitialDateTime, journey.FinalDateTime, journey.VehicleId, journey.UserEmail);
        }

        public static Domain.Entities.Journey ToEntity(this CreateJourney journey)
        {
            return new Domain.Entities.Journey
            {
                Kilometers = journey.Kilometers,
                PricePerKilometer = journey.PricePerKilometer,
                InitialDateTime = journey.InitialDateTime,
                FinalDateTime = journey.FinalDateTime,
                VehicleId = journey.VehicleId,
                UserEmail = journey.UserEmail
            };
        }
    }
}