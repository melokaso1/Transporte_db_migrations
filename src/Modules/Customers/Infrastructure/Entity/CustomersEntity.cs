using System;

namespace ejercicio_5.src.Modules.Customers.Infrastructure.Entity
{
    public class CustomersEntity
    {
        public Guid Id { get; set; }
        public int Person_id { get; set; }
        public bool Is_frequent { get; set; }
    }
}
