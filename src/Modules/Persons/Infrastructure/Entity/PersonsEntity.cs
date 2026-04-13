using System;
using System.Runtime.InteropServices;

namespace ejercicio_5.src.Modules.Persons.Infrastructure.Entity
{
    public class PersonsEntity
    {
        public Guid id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Phone { get; set; }
        public int CityId { get; set; }
        public DateTime created_at { get; set; }
        public int PersonStatusId { get; set; }
    }
}
