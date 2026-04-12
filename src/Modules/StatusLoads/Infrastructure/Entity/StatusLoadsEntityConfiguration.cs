using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ejercicio_5.src.Modules.StatusLoads.Infrastructure.Entity;

namespace ejercicio_5.src.Modules.StatusLoads.Infrastructure.Entity
{
    public class StatusLoadsEntityConfigurations : IEntityTypeConfiguration<StatusLoadsEntity>
    {
        public void Configure(EntityTypeBuilder<StatusLoadsEntity> builder)
        {
            builder.ToTable("StatusLoads");
            
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .HasColumnName("id")
                .HasColumnType("uuid")
                .IsRequired();
            
            builder.Property(x => x.Name)
                .HasColumnName("Name")
                .HasColumnType("varchar(50)")
                .IsRequired();
        }
    }
}