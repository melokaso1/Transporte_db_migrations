using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ejercicio_5.src.Modules.TypesVehicles.Infrastructure.Entity
{
    public sealed class TypeVehiclesEntityConfiguration
        : IEntityTypeConfiguration<TypesVehiclesEntity>
    {
        public void Configure(EntityTypeBuilder<TypesVehiclesEntity> builder)
        {
            builder.ToTable("TypeVehicles");

            builder.HasKey(x => x.id);
            builder.Property(x => x.id).HasColumnName("id").HasColumnType("uuid").IsRequired();

            builder
                .Property(x => x.name)
                .HasColumnName("name")
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder
                .Property(x => x.CapacityKg)
                .HasColumnName("capacity_kg")
                .HasColumnType("decimal(12,2)")
                .IsRequired();

            builder.Property(x => x.Axles).HasColumnName("axles").HasColumnType("int").IsRequired();

            builder
                .Property(x => x.CapacityM3)
                .HasColumnName("capacity_m3")
                .HasColumnType("decimal(12,2)")
                .IsRequired();

            builder
                .Property(x => x.description)
                .HasColumnName("description")
                .HasColumnType("text")
                .IsRequired();
        }
    }
}
