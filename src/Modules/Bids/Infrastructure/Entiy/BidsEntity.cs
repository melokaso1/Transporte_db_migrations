using System;

namespace ejercicio_5.src.Modules.Bids.Infrastructure.Entiy
{
    public class BidsEntity
    {
        public Guid Id { get; set; }
        public int LoadId { get; set; }
        public int DriverId { get; set; }
        public int VehicleId { get; set; }
        public decimal amount { get; set; }
        public TimeSpan AteToPickup { get; set; }
        public int StatusBidsId { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
