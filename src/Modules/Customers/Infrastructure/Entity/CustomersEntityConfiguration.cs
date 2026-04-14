using ejercicio_5.src.Modules.Persons.Infrastructure.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ejercicio_5.src.Modules.Customers.Infrastructure.Entity
{
    public sealed class CostumersEntityConfiguration : IEntityTypeConfiguration<CustomersEntity>
    {
        public void Configure(EntityTypeBuilder<CustomersEntity> builder)
        {
            builder.ToTable("Costumers");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("id").HasColumnType("int").IsRequired();

            builder
                .Property(x => x.Person_id)
                .HasColumnName("person_id")
                .HasColumnType("int")
                .IsRequired();
            builder
                .HasOne<PersonsEntity>()
                .WithMany()
                .HasForeignKey(x => x.Person_id)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .Property(x => x.Is_frequent)
                .HasColumnName("is_frequent")
                .HasColumnType("boolean")
                .IsRequired();
        }
    }
}
