using AVMTravel.Tours.API.Domain.Constants;
using AVMTravel.Tours.API.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Diagnostics.CodeAnalysis;

namespace AVMTravel.Tours.API.Persistence.Configurations
{
    [ExcludeFromCodeCoverage]
    public class TourConfiguration : IEntityTypeConfiguration<Tour>
    {
        public void Configure(EntityTypeBuilder<Tour> builder)
        {
            builder.ToTable("Tours", Constants.DbPrefix);

            builder.HasKey(e => e.Id).IsClustered(false);

            builder.Property(e => e.Id).ValueGeneratedOnAdd();

            builder.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            builder.Property(e => e.Description)
                .IsRequired(false)
                .HasMaxLength(250)
                .IsUnicode(false);

            builder.Property(e => e.StartDate)
                .IsRequired();

            builder.Property(e => e.DurationHours)
                .IsRequired();

            //builder.Property(e => e.Location)
            //    .IsRequired(false)
            //    .IsUnicode(false);

            builder.Property(e => e.TourGuide)
                .IsRequired(false)
                .HasMaxLength(100)
                .IsUnicode(false);

            builder.Property(e => e.Price)
                .IsRequired();

            builder.Property(e => e.DifficultyLevel)
                .IsRequired();

            builder.Property(e => e.CreatedAt)
                .IsRequired();

            builder.Property(e => e.UpdatedAt)
                .IsRequired();

            builder.HasOne(d => d.Location);
                //.WithMany(p => p.Tours)
                //.HasForeignKey(d => d.LocationId)
                //.OnDelete(DeleteBehavior.NoAction);
        }
    }
}
