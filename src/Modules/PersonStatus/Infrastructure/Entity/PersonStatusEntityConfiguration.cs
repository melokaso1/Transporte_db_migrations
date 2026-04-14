using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ejercicio_5.src.Modules.PersonStatus.Infrastructure.Entity
{
    public sealed class PersonStatusEntityConfiguration
        : IEntityTypeConfiguration<PersonStatusEntity>
    {
        public void Configure(EntityTypeBuilder<PersonStatusEntity> builder)
        {
            builder.ToTable("PersonStatus");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("id").HasColumnType("int").IsRequired();

            builder
                .Property(x => x.Name)
                .HasColumnName("name")
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder
                .Property(x => x.description)
                .HasColumnName("description")
                .HasColumnType("text")
                .IsRequired();
        }
    }
}
