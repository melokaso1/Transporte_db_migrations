using System;
using Microsoft.EntityFrameworkCore;

namespace ejercicio_5.src.Modules.Costumers.Infrastructure.Entity
{
    public class CostumersEntity
    {
        public Guid Id { get; set; }
        public int Person_id { get; set; }
        public bool Is_frequent { get; set; }
    }
}