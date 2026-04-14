using ejercicio_5.src.Modules.CitiesOrMunicipalities.Infrastructure.Entity;
using ejercicio_5.src.Modules.Customers.Infrastructure.Entity;
using ejercicio_5.src.Modules.StatusLoads.Infrastructure.Entity;
using ejercicio_5.src.Modules.TypeLoad.Infrastructure.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ejercicio_5.src.Modules.Loads.Infrastructure.Entity
{
    public sealed class LoadEntityConfiguration : IEntityTypeConfiguration<LoadsEntity>
    {
        public void Configure(EntityTypeBuilder<LoadsEntity> builder)
        {
            builder.ToTable("Loads");

            builder.HasKey(x => x.id);
            builder.Property(x => x.id).HasColumnName("id").HasColumnType("int").IsRequired();

            builder
                .Property(x => x.CustomerId)
                .HasColumnName("CustomerId")
                .HasColumnType("int")
                .IsRequired();
            builder
                .HasOne<CustomersEntity>()
                .WithMany()
                .HasForeignKey(x => x.CustomerId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .Property(x => x.TypeLoadId)
                .HasColumnName("TypeLoadId")
                .HasColumnType("int")
                .IsRequired();
            builder
                .HasOne<TypeLoadEntity>()
                .WithMany()
                .HasForeignKey(x => x.TypeLoadId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .Property(x => x.OriginCityId)
                .HasColumnName("OriginCityId")
                .HasColumnType("int")
                .IsRequired();
            builder
                .HasOne<CitiesOrMunicipalitiesEntity>()
                .WithMany()
                .HasForeignKey(x => x.OriginCityId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .Property(x => x.DestinationCityId)
                .HasColumnName("DestinationCityId")
                .HasColumnType("int")
                .IsRequired();
            builder
                .HasOne<CitiesOrMunicipalitiesEntity>()
                .WithMany()
                .HasForeignKey(x => x.DestinationCityId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .Property(x => x.OriginAddress)
                .HasColumnName("OriginAddress")
                .HasColumnType("text")
                .IsRequired();

            builder
                .Property(x => x.DestinationAddress)
                .HasColumnName("DestinationAddress")
                .HasColumnType("text")
                .IsRequired();

            builder
                .Property(x => x.WeightTons)
                .HasColumnName("WeightTons")
                .HasColumnType("decimal(10,2)")
                .IsRequired();

            builder
                .Property(x => x.VolumeM3)
                .HasColumnName("VolumeM3")
                .HasColumnType("decimal(10,2)")
                .IsRequired();

            builder
                .Property(x => x.PickupDate)
                .HasColumnName("PickupDate")
                .HasColumnType("timestamp")
                .IsRequired();

            builder
                .Property(x => x.OfferedPrice)
                .HasColumnName("OfferedPrice")
                .HasColumnType("decimal(19,2)")
                .IsRequired();

            builder
                .Property(x => x.StatusId)
                .HasColumnName("StatusId")
                .HasColumnType("int")
                .IsRequired();
            builder
                .HasOne<StatusLoadsEntity>()
                .WithMany()
                .HasForeignKey(x => x.StatusId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .Property(x => x.CreatedAt)
                .HasColumnName("CreatedAt")
                .HasColumnType("timestamp")
                .IsRequired();
        }
    }
}
