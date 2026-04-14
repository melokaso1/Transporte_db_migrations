using System;
using NetTopologySuite.Geometries;

namespace ejercicio_5.src.Modules.CitiesOrMunicipalities.Infrastructure.Entity
{
    public class CitiesOrMunicipalitiesEntity
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int StateregId { get; set; }
        public string? Code { get; set; }
        public string? coordinates { get; set; }
    }
}
