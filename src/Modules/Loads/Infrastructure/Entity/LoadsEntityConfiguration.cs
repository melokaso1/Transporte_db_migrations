using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ejercicio_5.src.Modules.Loads.Infrastructure.Entity
{
    public sealed class LoadEntityConfiguration : IEntityTypeConfiguration<LoadsEntity>
    {
        public void Configure(EntityTypeBuilder<LoadsEntity> builder)
        {
            builder.ToTable("Loads");
            
            builder.HasKey(x => x.id);
            builder.Property(x => x.id)
            .HasColumnName("id")
            .HasColumnType("uuid")
            .IsRequired();

            builder.Property(x => x.Coustumer_id)
            .HasColumnName("Coustumer_id")
            .HasColumnType("uuid")
            .IsRequired();
            builder.HasMany(x => x.Coustumer_id)
                .WithOne()
                .HasForeignKey(x => x.Coustumer_id)
                .OnDelete(DeleteBehavior.Restrict);
            
            builder.Property(x => x.Type_load_id)
            .HasColumnName("Type_load_id")
            .HasColumnType("uuid")
            .IsRequired();
            builder.HasMany(x => x.Type_load_id)
                .WithOne()
                .HasForeignKey(x => x.Type_load_id)
                .OnDelete(DeleteBehavior.Restrict);
            
            builder.Property(x => x.Origin_city_id)
            .HasColumnName("Origin_city_id")
            .HasColumnType("uuid")
            .IsRequired();
            builder.HasMany(x => x.Origin_city_id)
                .WithOne()
                .HasForeignKey(x => x.Origin_city_id)
                .OnDelete(DeleteBehavior.Restrict);
            
            builder.Property(x => x.Destination_city_id)
            .HasColumnName("Destination_city_id")
            .HasColumnType("uuid")
            .IsRequired();
            builder.HasMany(x => x.Destination_city_id)
                .WithOne()
                .HasForeignKey(x => x.Destination_city_id)
                .OnDelete(DeleteBehavior.Restrict);
            
            builder.Property(x => x.Origin_address)
            .HasColumnName("Origin_address")
            .HasColumnType("Point")
            .IsRequired();

            builder.Property(x => x.Destination_address)
            .HasColumnName("Destination_address")
            .HasColumnType("Point")
            .IsRequired();

            builder.Property(x => x.Weight_tons)
            .HasColumnName("Weight_tons")
            .HasColumnType("decimal(10,2)")
            .IsRequired();

            builder.Property(x => x.Volume_m3)
            .HasColumnName("Volume_m3")
            .HasColumnType("decimal(10,2)")
            .IsRequired();

            builder.Property(x => x.Pickup_date)
            .HasColumnName("Pickup_date")
            .HasColumnType("timestamp")
            .IsRequired();

            builder.Property(x => x.Offered_price)
            .HasColumnName("Offered_price")
            .HasColumnType("decimal(19,2)")
            .IsRequired();

            builder.Property(x => x.Status_id)
            .HasColumnName("Status_id")
            .HasColumnType("uuid")
            .IsRequired();
            builder.HasMany(x => x.Status_id)
                .WithOne()
                .HasForeignKey(x => x.Status_id)
                .OnDelete(DeleteBehavior.Restrict);
            
            builder.Property(x => x.Created_at)
            .HasColumnName("Created_at")
            .HasColumnType("timestamp")
            .IsRequired();
        }
    }
}