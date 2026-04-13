using System;
using ejercicio_5.src.Modules.Countries.Infrastructure.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ejercicio_5.src.Modules.StatesOrRegions.Infrastructure.Entity
{
    public sealed class StatesOrRegionsEntityConfigurations
        : IEntityTypeConfiguration<StatesOrRegionsEntity>
    {
        public void Configure(EntityTypeBuilder<StatesOrRegionsEntity> builder)
        {
            builder.ToTable("StatesOrRegions");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("id").HasColumnType("uuid").IsRequired();

            builder
                .Property(x => x.Name)
                .HasColumnName("name")
                .HasColumnType("varchar(60)")
                .IsRequired();

            builder
                .Property(x => x.CountryId)
                .HasColumnName("country_id")
                .HasColumnType("int")
                .IsRequired();
            builder
                .HasOne<CountriesEntity>()
                .WithMany()
                .HasForeignKey(x => x.CountryId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .Property(x => x.Code)
                .HasColumnName("code")
                .HasColumnType("varchar(10)")
                .IsRequired();
            builder.HasIndex(x => x.Code).IsUnique();
        }
    }
}
