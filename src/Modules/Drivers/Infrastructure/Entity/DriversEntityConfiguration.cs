using System;
using ejercicio_5.src.Modules.Persons.Infrastructure.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ejercicio_5.src.Modules.Drivers.Infrastructure.Entity
{
    public sealed class DriversEntityConfiguration : IEntityTypeConfiguration<DriversEntity>
    {
        public void Configure(EntityTypeBuilder<DriversEntity> builder)
        {
            builder.ToTable("Drivers");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("id").HasColumnType("int").IsRequired();

            builder
                .Property(x => x.PersonId)
                .HasColumnName("person_id")
                .HasColumnType("int")
                .IsRequired();
            builder
                .HasOne<PersonsEntity>()
                .WithMany()
                .HasForeignKey(x => x.PersonId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .Property(x => x.licenseCategory)
                .HasColumnName("license_category")
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder
                .Property(x => x.ExperienceYears)
                .HasColumnName("experience_years")
                .HasColumnType("int")
                .IsRequired();

            builder
                .Property(x => x.IsAviable)
                .HasColumnName("is_aviable")
                .HasColumnType("boolean")
                .IsRequired();
        }
    }
}
