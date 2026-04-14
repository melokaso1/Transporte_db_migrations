using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ejercicio_5.src.Modules.Vehicles.Infrastructure.Entity
{
    public class VehiclesEntity
    {
        public int Id { get; set; }
        public string? Plate { get; set; }
        public int TypeVehicleId { get; set; }
        public string? brand { get; set; }
        public string? model { get; set; }
        public string? year { get; set; }
        public string? color { get; set; }
        public int OwnerId { get; set; }
        public int StatusVehicleId { get; set; }
        public int? chassisNumber { get; set; }
        public DateTime created_at { get; set; }
    }
}
