using System;

namespace ejercicio_5.src.Modules.TypesVehicles.Infrastructure.Entity
{
    public class TypesVehiclesEntity
    {
        public Guid id { get; set; }
        public string? name { get; set; }
        public decimal CapacityKg { get; set; }
        public int Axles { get; set; }
        public decimal? CapacityM3 { get; set; }
        public string? description { get; set; }
    }
}
