using AVMTravel.Tours.API.Domain.Entities;
using AVMTravel.Tours.API.Domain.Entities.Common;
using AVMTravel.Tours.API.Domain.Helpers;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace AVMTravel.Tours.API.Persistence.Contexts
{
    public class BaseContext : DbContext
    {
        public BaseContext(DbContextOptions<BaseContext> options) 
            : base(options)
        {
            ChangeTracker.LazyLoadingEnabled = false;
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        //public DbSet<Client> Clients { get; set; }
        public DbSet<Tour> Tours { get; set; }
        //public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Location> Locations { get; set; }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var entry in ChangeTracker.Entries<AuditableBaseEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.CreatedAt = DateHelper.CurrenctUtcNow();
                        entry.Entity.UpdatedAt = DateHelper.CurrenctUtcNow();
                        break;
                    case EntityState.Modified:
                        entry.Entity.UpdatedAt = DateHelper.CurrenctUtcNow();
                        break;

                }
            }
            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
