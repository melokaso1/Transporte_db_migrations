using System;
using System.Collections.Generic;
using NetTopologySuite.Geometries;

namespace ejercicio_5.src.Modules.Loads.Infrastructure.Entity
{
    public class LoadsEntity
    {
    
    // Columnas Tabla
        public Guid id { get; set;}
        public int CustomerId {get; set;}
        public int TypeLoadId {get; set;}
        public int OriginCityId {get; set;}
        public int DestinationCityId {get; set;}
        public string? OriginAddress {get; set;}
        public string? DestinationAddress {get; set;}
        public Point? OriginCords {get; set;}
        public Point? DestinationCords {get; set;}
        public Decimal WeightTons {get; set;}
        public Decimal VolumeM3 {get; set;}
        public DateTime PickupDate {get; set;}
        public Decimal OfferedPrice {get; set;}
        public int StatusId {get; set;}
        public DateTime CreatedAt {get; set;}
    }
}