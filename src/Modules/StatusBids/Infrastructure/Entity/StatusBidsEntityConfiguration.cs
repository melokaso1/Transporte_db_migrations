using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ejercicio_5.src.Modules.StatusBids.Infrastructure.Entity
{
    public sealed class StatusBidsEntityConfiguration : IEntityTypeConfiguration<StatusBidsEntity>
    {
        public void Configure(EntityTypeBuilder<StatusBidsEntity> builder)
        {
            builder.ToTable("StatusBids");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("id").HasColumnType("uuid").IsRequired();

            builder
                .Property(x => x.Name)
                .HasColumnName("Name")
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder.Property(x => x.Description).HasColumnName("Description").HasColumnType("text");
        }
    }
}
