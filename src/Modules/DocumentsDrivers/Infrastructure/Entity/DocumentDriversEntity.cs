using System;

namespace ejercicio_5.src.Modules.DocumentsDrivers.Infrastructure.Entity
{
    public class DocumentDriversEntity
    {
        public int Id { get; set; }
        public int DriverId { get; set; }
        public int TypeDocumentId { get; set; }
        public string? DocumentNumber { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public string? FileUrl { get; set; }
        public int DocumentStatusId { get; set; }
    }
}
