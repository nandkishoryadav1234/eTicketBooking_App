using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using eTicketBookingApp.Models;

namespace eTicketBookingApp.Data
{
    public class eTicketBookingAppContext : DbContext
    {
        public eTicketBookingAppContext (DbContextOptions<eTicketBookingAppContext> options)
            : base(options)
        {
        }

        public DbSet<eTicketBookingApp.Models.Registration> Registration { get; set; }
    }
}
