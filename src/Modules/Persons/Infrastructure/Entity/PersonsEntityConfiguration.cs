using System;
using ejercicio_5.src.Modules.CitiesOrMunicipalities.Infrastructure.Entity;
using ejercicio_5.src.Modules.PersonStatus.Infrastructure.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ejercicio_5.src.Modules.Persons.Infrastructure.Entity
{
    public sealed class PersonsEntityConfigurations : IEntityTypeConfiguration<PersonsEntity>
    {
        public void Configure(EntityTypeBuilder<PersonsEntity> builder)
        {
            builder.ToTable("Persons");

            builder.HasKey(p => p.id);
            builder.Property(p => p.id).HasColumnName("id").HasColumnType("int").IsRequired();

            builder
                .Property(p => p.FirstName)
                .HasColumnName("first_name")
                .HasColumnType("varchar(60)")
                .IsRequired();

            builder
                .Property(p => p.LastName)
                .HasColumnName("last_name")
                .HasColumnType("varchar(60)")
                .IsRequired();

            builder
                .Property(p => p.Phone)
                .HasColumnName("phone")
                .HasColumnType("varchar(15)")
                .IsRequired();

            builder
                .Property(p => p.CityId)
                .HasColumnName("city_id")
                .HasColumnType("int")
                .IsRequired();
            builder
                .HasOne<CitiesOrMunicipalitiesEntity>()
                .WithMany()
                .HasForeignKey(p => p.CityId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .Property(p => p.created_at)
                .HasColumnName("created_at")
                .HasColumnType("date")
                .IsRequired();

            builder
                .Property(p => p.PersonStatusId)
                .HasColumnName("person_status_id")
                .HasColumnType("int")
                .IsRequired();
            builder
                .HasOne<PersonStatusEntity>()
                .WithMany()
                .HasForeignKey(p => p.PersonStatusId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
