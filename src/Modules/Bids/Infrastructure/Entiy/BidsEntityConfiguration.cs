using ejercicio_5.src.Modules.Drivers.Infrastructure.Entity;
using ejercicio_5.src.Modules.Loads.Infrastructure.Entity;
using ejercicio_5.src.Modules.StatusBids.Infrastructure.Entity;
using ejercicio_5.src.Modules.Vehicles.Infrastructure.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ejercicio_5.src.Modules.Bids.Infrastructure.Entiy
{
    public sealed class BidsEntityConfiguration : IEntityTypeConfiguration<BidsEntity>
    {
        public void Configure(EntityTypeBuilder<BidsEntity> builder)
        {
            builder.ToTable("Bids");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("id").HasColumnType("uuid").IsRequired();

            builder
                .Property(x => x.LoadId)
                .HasColumnName("load_id")
                .HasColumnType("uuid")
                .IsRequired();
            builder
                .HasOne<LoadsEntity>()
                .WithMany()
                .HasForeignKey(x => x.LoadId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .Property(x => x.DriverId)
                .HasColumnName("driver_id")
                .HasColumnType("uuid")
                .IsRequired();
            builder
                .HasOne<DriversEntity>()
                .WithMany()
                .HasForeignKey(x => x.DriverId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .Property(x => x.VehicleId)
                .HasColumnName("vehicle_id")
                .HasColumnType("uuid")
                .IsRequired();
            builder
                .HasOne<VehiclesEntity>()
                .WithMany()
                .HasForeignKey(x => x.VehicleId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .Property(x => x.amount)
                .HasColumnName("amount")
                .HasColumnType("decimal(19,2)")
                .IsRequired();

            builder
                .Property(x => x.AteToPickup)
                .HasColumnName("AteToPickup")
                .HasColumnType("time")
                .IsRequired();

            builder
                .Property(x => x.StatusBidsId)
                .HasColumnName("StatusBidsId")
                .HasColumnType("uuid")
                .IsRequired();
            builder
                .HasOne<StatusBidsEntity>()
                .WithMany()
                .HasForeignKey(x => x.StatusBidsId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .Property(x => x.CreatedAt)
                .HasColumnName("CreatedAt")
                .HasColumnType("timestamp")
                .IsRequired();
        }
    }
}
