using System;

namespace ejercicio_5.src.Modules.Countries.Infrastructure.Entity
{
    public class CountriesEntity
    {
        public Guid Id { get; set; }
        public string? IsoCode { get; set; }
        public string? Name { get; set; }
        public string? PhoneCode { get; set; }

    }
}