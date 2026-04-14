using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ejercicio_5.src.Modules.VehiclesStatus.Infrastructure.Entity
{
    public sealed class VehiclesStatusEntityConfiguracion
        : IEntityTypeConfiguration<VehiclesStatusEntity>
    {
        public void Configure(EntityTypeBuilder<VehiclesStatusEntity> builder)
        {
            builder.ToTable("vehicles");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).HasColumnName("id").HasColumnType("int").IsRequired();
            builder
                .Property(x => x.Name)
                .HasColumnName("name")
                .HasColumnType("varchar(50)")
                .IsRequired();
        }
    }
}
