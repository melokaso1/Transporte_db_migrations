using System;

namespace ejercicio_5.src.Modules.TypeDocuments.Infrastructure.Entity
{
    public class TypeDocumentsEntity
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public int CategoryId { get; set; }
    }
}
