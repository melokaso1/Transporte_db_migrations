using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace ejercicio_5.src.Shared.context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);

            // FORZAR: sacar del modelo cualquier tipo llamado "Coordinate"
            var coordinateTypes = modelBuilder
                .Model.GetEntityTypes()
                .Where(t => string.Equals(t.ClrType.Name, "Coordinate", StringComparison.Ordinal))
                .Select(t => t.ClrType)
                .ToList();

            foreach (var clrType in coordinateTypes)
            {
                modelBuilder.Ignore(clrType);
            }
        }
    }
}
