using System;

namespace ejercicio_5.src.Modules.DocumentCategory.Infrastructure.Entity
{
    public class DocumentCategoryEntity
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
    }
}
