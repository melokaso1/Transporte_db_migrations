using System;

namespace ejercicio_5.src.Modules.Drivers.Infrastructure.Entity
{
    public class DriversEntity
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public string? licenseCategory { get; set; }
        public int ExperienceYears { get; set; }
        public bool IsAviable { get; set; }
    }
}
