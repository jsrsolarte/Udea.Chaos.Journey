using MediatR;
using System.ComponentModel.DataAnnotations;

namespace Udea.Chaos.Journey.Application.Commands
{
    public class CreateJourney: IRequest
    {
        [Required]
        public double Kilometers { get; set; }

        [Required]
        public double PricePerKilometer { get; set; }

        [Required]
        public DateTime InitialDateTime { get; set; }

        [Required]
        public DateTime FinalDateTime { get; set; }

        [Required]
        public Guid VehicleId { get; set; }

        [Required]
        public string UserEmail { get; set; } = string.Empty;
    }
}