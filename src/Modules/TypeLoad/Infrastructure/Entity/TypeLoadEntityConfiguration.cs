using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ejercicio_5.src.Modules.TypeLoad.Infrastructure.Entity
{
    public class TypeLoadEntityConfiguration : IEntityTypeConfiguration<TypeLoadEntity>
    {
        public void Configure(EntityTypeBuilder<TypeLoadEntity> builder)
        {
            builder.ToTable("Type_loads");

            builder.HasKey(x => x.id);
            builder.Property(x => x.id)
            .HasColumnName("id")
            .HasColumnType("uuid")
            .IsRequired();
            
            builder.Property(x => x.name)
            .HasColumnName("name")
            .HasColumnType("varchar(50)")
            .IsRequired();
            
            builder.Property(x => x.description)
            .HasColumnName("description")
            .HasColumnType("text")
            .IsRequired();
        }
    }
}