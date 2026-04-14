using System;
using ejercicio_5.src.Modules.DocumentStatus.Infrastructura.Entity;
using ejercicio_5.src.Modules.Drivers.Infrastructure.Entity;
using ejercicio_5.src.Modules.TypeDocuments.Infrastructure.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ejercicio_5.src.Modules.DocumentsDrivers.Infrastructure.Entity
{
    public sealed class DocumentsDriversEntityConfiguration
        : IEntityTypeConfiguration<DocumentDriversEntity>
    {
        public void Configure(EntityTypeBuilder<DocumentDriversEntity> builder)
        {
            builder.ToTable("DocumentsDrivers");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("id").HasColumnType("int").IsRequired();

            builder
                .Property(x => x.DriverId)
                .HasColumnName("driver_id")
                .HasColumnType("int")
                .IsRequired();
            builder
                .HasOne<DriversEntity>()
                .WithMany()
                .HasForeignKey(x => x.DriverId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .Property(x => x.TypeDocumentId)
                .HasColumnName("type_document_id")
                .HasColumnType("int")
                .IsRequired();
            builder
                .HasOne<TypeDocumentsEntity>()
                .WithMany()
                .HasForeignKey(x => x.TypeDocumentId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .Property(x => x.DocumentNumber)
                .HasColumnName("document_number")
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder
                .Property(x => x.ExpirationDate)
                .HasColumnName("expiration_date")
                .HasColumnType("timestamp")
                .IsRequired();

            builder
                .Property(x => x.FileUrl)
                .HasColumnName("file_url")
                .HasColumnType("varchar(255)")
                .IsRequired();

            builder
                .Property(x => x.DocumentStatusId)
                .HasColumnName("document_status_id")
                .HasColumnType("int")
                .IsRequired();
            builder
                .HasOne<DocumentStatusEntity>()
                .WithMany()
                .HasForeignKey(x => x.DocumentStatusId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
