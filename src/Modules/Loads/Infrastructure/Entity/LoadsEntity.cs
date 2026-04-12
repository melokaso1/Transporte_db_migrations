using System;
using System.Collections.Generic;
using NetTopologySuite.Geometries;

namespace ejercicio_5.src.Modules.Loads.Infrastructure.Entity
{
    public class LoadsEntity
    {
    
    // Columnas Tabla
        public Guid id { get; set;}
        public int Coustumer_id {get; set;}
        public int Type_load_id {get; set;}
        public int Origin_city_id {get; set;}
        public int Destination_city_id {get; set;}
        public string? Origin_address {get; set;}
        public string? Destination_address {get; set;}
        public Point? Origin_cords {get; set;}
        public Point? Destination_cords {get; set;}
        public Decimal Weight_tons {get; set;}
        public Decimal Volume_m3 {get; set;}
        public DateTime Pickup_date {get; set;}
        public Decimal Offered_price {get; set;}
        public int Status_id {get; set;}
        public DateTime Created_at {get; set;}
    }
}