using System;
using NetTopologySuite.Geometries;

namespace ejercicio_5.src.Modules.CitiesOrMunicipalities.Infrastructure.Entity
{
    public class CitiesOrMunicipalitiesEntity
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public int StateregId { get; set; }
        public string? Code { get; set; }
        public Point? Coordinates { get; set; }
    }
}
