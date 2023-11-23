using AVMTravel.Tours.API.Domain.Constants;
using AVMTravel.Tours.API.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AVMTravel.Tours.API.Persistence.Configurations
{
    public class ClientConfiguration : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.ToTable("Clients", Constants.DbPrefix);

            builder.HasKey(e => e.Id).IsClustered(false);

            builder.Property(e => e.Id).ValueGeneratedOnAdd();

            builder.Property(e => e.FullName)
                .IsRequired()
                .HasMaxLength(150)
                .IsUnicode(false);

            builder.Property(e => e.Password)
                .IsRequired()
                .IsUnicode(false);

            builder.Property(e => e.Email)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false);
        }
    }
}
