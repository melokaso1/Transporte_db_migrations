using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ejercicio_5.src.Modules.Costumers.Infrastructure.Entity
{
    public class CostumersEntityConfiguration : IEntityTypeConfiguration<CostumersEntity>
    {
        public void Configure(EntityTypeBuilder<CostumersEntity> builder)
        {
            builder.ToTable("Costumers");
            
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .HasColumnName("id")
                .HasColumnType("uuid")
                .IsRequired();
            
            builder.Property(x => x.Person_id)
                .HasColumnName("person_id")
                .HasColumnType("uuid")
                .IsRequired();
            
            builder.Property(x => x.Is_frequent)
                .HasColumnName("is_frequent")
                .HasColumnType("boolean")
                .IsRequired();
        }
    }
}