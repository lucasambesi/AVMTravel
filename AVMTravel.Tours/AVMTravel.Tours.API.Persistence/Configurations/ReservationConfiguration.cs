using AVMTravel.Tours.API.Domain.Constants;
using AVMTravel.Tours.API.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AVMTravel.Tours.API.Persistence.Configurations
{
    public class ReservationConfiguration : IEntityTypeConfiguration<Reservation>
    {
        public void Configure(EntityTypeBuilder<Reservation> builder)
        {
            builder.ToTable("Reservations", Constants.DbPrefix);

            builder.HasKey(e => e.Id).IsClustered(false);

            builder.Property(e => e.Id).ValueGeneratedOnAdd();

            builder.Property(e => e.Status)
                .IsRequired();

            builder.Property(e => e.CreatedAt)
                .IsRequired();

            builder.Property(e => e.UpdatedAt)
                .IsRequired();

            builder.HasOne(d => d.Client);

            builder.HasOne(d => d.Tour);
        }
    }
}
