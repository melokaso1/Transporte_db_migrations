using ejercicio_5.src.Modules.Persons.Infrastructure.Entity;
using ejercicio_5.src.Modules.TypesVehicles.Infrastructure.Entity;
using ejercicio_5.src.Modules.VehiclesStatus.Infrastructure.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ejercicio_5.src.Modules.Vehicles.Infrastructure.Entity
{
    public sealed class VehiclesEntityConfiguration : IEntityTypeConfiguration<VehiclesEntity>
    {
        public void Configure(EntityTypeBuilder<VehiclesEntity> builder)
        {
            builder.ToTable("Vehicles");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("id").HasColumnType("int").IsRequired();

            builder
                .Property(x => x.Plate)
                .HasColumnName("plate")
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder
                .Property(x => x.TypeVehicleId)
                .HasColumnName("type_vehicle_id")
                .HasColumnType("int")
                .IsRequired();
            builder
                .HasOne<TypesVehiclesEntity>()
                .WithMany()
                .HasForeignKey(x => x.TypeVehicleId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .Property(x => x.brand)
                .HasColumnName("brand")
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder
                .Property(x => x.model)
                .HasColumnName("model")
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder
                .Property(x => x.year)
                .HasColumnName("year")
                .HasColumnType("varchar(4)")
                .IsRequired();

            builder
                .Property(x => x.color)
                .HasColumnName("color")
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder
                .Property(x => x.OwnerId)
                .HasColumnName("owner_id")
                .HasColumnType("int")
                .IsRequired();
            builder
                .HasOne<PersonsEntity>()
                .WithMany()
                .HasForeignKey(x => x.OwnerId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .Property(x => x.StatusVehicleId)
                .HasColumnName("status_vehicle_id")
                .HasColumnType("int")
                .IsRequired();
            builder
                .HasOne<VehiclesStatusEntity>()
                .WithMany()
                .HasForeignKey(x => x.StatusVehicleId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .Property(x => x.chassisNumber)
                .HasColumnName("chassis_number")
                .HasColumnType("int")
                .IsRequired();

            builder
                .Property(x => x.created_at)
                .HasColumnName("created_at")
                .HasColumnType("timestamp")
                .IsRequired();
        }
    }
}
