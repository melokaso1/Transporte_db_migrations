using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ejercicio_5.src.Modules.DocumentStatus.Infrastructura.Entity
{
    public sealed class DocumentStatusEntityConfiguration
        : IEntityTypeConfiguration<DocumentStatusEntity>
    {
        public void Configure(EntityTypeBuilder<DocumentStatusEntity> builder)
        {
            builder.ToTable("DocumentStatus");

            builder.HasKey(x => x.id);
            builder.Property(x => x.id).HasColumnName("id").HasColumnType("int").IsRequired();

            builder
                .Property(x => x.name)
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
