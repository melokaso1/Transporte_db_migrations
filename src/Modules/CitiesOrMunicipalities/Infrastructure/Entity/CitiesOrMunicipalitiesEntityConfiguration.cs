using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ejercicio_5.src.Modules.CitiesOrMunicipalities.Infrastructure.Entity
{
    public class CitiesOrMunicipalitiesEntityConfiguration : IEntityTypeConfiguration<CitiesOrMunicipalitiesEntity>
    {
        public void Configure(EntityTypeBuilder<CitiesOrMunicipalitiesEntity> builder)
        {
            builder.ToTable("CitiesOrMunicipalities");
            
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .HasColumnName("id")
                .HasColumnType("uuid")
                .IsRequired();
            
            builder.Property(x => x.Name)
                .HasColumnName("name")
                .HasColumnType("varchar(60)")
                .IsRequired();
            
            builder.Property(x => x.StateregId)
                .HasColumnName("statereg_id")
                .HasColumnType("uuid")
                .IsRequired();
            builder.HasOne<StateOrRegionsEntity>()
                .WithMany()
                .HasForeignKey(x => x.StateregId)
                .OnDelete(DeleteBehavior.Restrict);
            
            builder.Property(x => x.Code)
                .HasColumnName("code")
                .HasColumnType("varchar(10)")
                .IsRequired();
            
            builder.Property(x => x.Coordinates)
                .HasColumnName("coordinates")
                .HasColumnType("Point")
                .IsRequired();
        }
    }
}