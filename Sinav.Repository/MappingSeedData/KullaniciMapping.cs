using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sinav.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Sinav.Repository.MappingSeedData
{
    public class KullaniciMapping : IEntityTypeConfiguration<Kullanici>
    {
        public void Configure(EntityTypeBuilder<Kullanici> builder)
        {
            builder.HasData(
                    new Kullanici() { Id = 1, FirstName = "Sefa", LastName = "Attila", UserName = "admin", Password = sha256_hash("sssSSS**") }
                );
        }

        private string sha256_hash(string sifre)
        {
            using (SHA256 hash = SHA256Managed.Create())
            {
                return string.Concat(hash.ComputeHash(Encoding.UTF8.GetBytes(sifre)).Select(l => l.ToString("X2")));
            }
        }

    }
}
