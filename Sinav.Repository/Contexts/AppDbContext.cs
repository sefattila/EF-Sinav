using Castle.Core.Resource;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Sinav.Core.Entities;
using Sinav.Repository.MappingSeedData;
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
        public DbSet<Album> Albums { get; set; }
        public DbSet<Kullanici> Kullanicis { get; set; }
        public DbSet<Sanatci> Sanatcis { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
            optionsBuilder.UseSqlServer("Server=KDK-403-PC13-YZ;Database=SinavDB;Trusted_Connection=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AlbumMapping())
                .ApplyConfiguration(new KullaniciMapping())
                .ApplyConfiguration(new SanatciMapping());
        }
    }
}
