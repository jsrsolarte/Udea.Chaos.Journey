﻿namespace Udea.Chaos.Journey.Domain.Entities
{
    public class Journey : EntityBase<string>
    {
        public double Kilometers { get; set; }
        public double PricePerKilometer { get; set; }
        public DateTime InitialDateTime { get; set; }
        public DateTime FinalDateTime { get; set; }
        public Guid VehicleId { get; set; }
        public string UserEmail { get; set; } = string.Empty;
    }
}