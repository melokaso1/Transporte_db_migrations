using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ejercicio_5.src.Modules.DocumentCategory.Infrastructure.Entity
{
    public sealed class DocumentCategoryEntityConfiguration
        : IEntityTypeConfiguration<DocumentCategoryEntity>
    {
        public void Configure(EntityTypeBuilder<DocumentCategoryEntity> builder)
        {
            builder.ToTable("DocumentCategory");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("id").HasColumnType("uuid").IsRequired();

            builder
                .Property(x => x.Name)
                .HasColumnName("name")
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder
                .Property(x => x.Description)
                .HasColumnName("description")
                .HasColumnType("text")
                .IsRequired();
        }
    }
}
