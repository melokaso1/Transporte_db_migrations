using System;
using ejercicio_5.src.Modules.DocumentCategory.Infrastructure.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ejercicio_5.src.Modules.TypeDocuments.Infrastructure.Entity
{
    public sealed class TypeDocumentsEntityConfiguration : IEntityTypeConfiguration<TypeDocumentsEntity>
    {
        public void Configure(EntityTypeBuilder<TypeDocumentsEntity> builder)
        {
            builder.ToTable("TypeDocuments");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("id").HasColumnType("uuid").IsRequired();

            builder
                .Property(x => x.Name)
                .HasColumnName("name")
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder
                .Property(x => x.CategoryId)
                .HasColumnName("category_id")
                .HasColumnType("uuid")
                .IsRequired();
            builder
                .HasOne<DocumentCategoryEntity>()
                .WithMany()
                .HasForeignKey(x => x.CategoryId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
