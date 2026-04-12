using System;

namespace ejercicio_5.src.Modules.StatesOrRegions.Infrastructure.Entity
{
    public class StatesOrRegionsEntity
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public int CountryId { get; set; }
        public string? Code { get; set; }
    }
}