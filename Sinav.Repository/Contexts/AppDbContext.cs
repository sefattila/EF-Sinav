using Castle.Core.Resource;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Sinav.Repository.Contexts
{
    public class AppDbContext : DbContext
    {
        //public DbSet<Category> Categories { get; set; }
        //public DbSet<Customer> Customers { get; set; }
        //public DbSet<Event> Events { get; set; }
        //public DbSet<EventDetail> EventDetails { get; set; }
        //public DbSet<Ticket> Tickets { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
            optionsBuilder.UseSqlServer("Server=KDK-403-PC13-YZ;Database=SinavDB;Trusted_Connection=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
