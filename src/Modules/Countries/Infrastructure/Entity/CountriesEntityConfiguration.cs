using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ejercicio_5.src.Modules.Countries.Infrastructure.Entity
{
    public sealed class CountriesEntityConfiguration : IEntityTypeConfiguration<CountriesEntity>
    {
        public void Configure(EntityTypeBuilder<CountriesEntity> builder)
        {
            builder.ToTable("Countries");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("id").HasColumnType("uuid").IsRequired();

            builder
                .Property(x => x.IsoCode)
                .HasColumnName("iso_code")
                .HasColumnType("char(3)")
                .IsRequired();
            builder.HasIndex(x => x.IsoCode).IsUnique();

            builder
                .Property(x => x.Name)
                .HasColumnName("name")
                .HasColumnType("varchar(60)")
                .IsRequired();

            builder
                .Property(x => x.PhoneCode)
                .HasColumnName("phone_code")
                .HasColumnType("varchar(5)")
                .IsRequired();
        }
    }
}
