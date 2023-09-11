using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sinav.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinav.Repository.MappingSeedData
{
    public class SanatciMapping : IEntityTypeConfiguration<Sanatci>
    {
        public void Configure(EntityTypeBuilder<Sanatci> builder)
        {
            builder.HasData(
                    new Sanatci() { Id = 1, FirstName = "Ali", LastName = "Gündüz" },
                    new Sanatci() { Id = 2, FirstName = "Mehmet", LastName = "Uzun" },
                    new Sanatci() { Id = 3, FirstName = "Veli", LastName = "Kısa" },
                    new Sanatci() { Id = 4, FirstName = "Adnan", LastName = "Ziya" },
                    new Sanatci() { Id = 5, FirstName = "Fatih", LastName = "Aslan" },
                    new Sanatci() { Id = 6, FirstName = "Furkan", LastName = "Kartal" }
                );
        }
    }
}
