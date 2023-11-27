using AVMTravel.Tours.API.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVMTravel.Tours.API.Persistence.Contexts
{
    public interface IBaseContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Tour> Tours { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
    }
}
