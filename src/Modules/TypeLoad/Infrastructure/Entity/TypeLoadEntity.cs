using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ejercicio_5.src.Modules.Type_load.Infrastructure.Entity
{
    public class TypeLoadEntity
    {
        public Guid id { get; set; }
        public string? name { get; set; }
        public string? description { get; set; }
    }
}