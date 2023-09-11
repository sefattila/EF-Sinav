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
    public class AlbumMapping : IEntityTypeConfiguration<Album>
    {
        public void Configure(EntityTypeBuilder<Album> builder)
        {
            builder.HasData(
                    new Album() { Id = 1, AlbumAdi = "Deneme1", CikisTarihi = DateTime.Now.AddYears(2), Fiyat = 150, IndirimOrani = 15, SatisDurum = true, SanatciId = 1 },
                    new Album() { Id = 2, AlbumAdi = "Deneme2", CikisTarihi = DateTime.Now.AddYears(1), Fiyat = 150, IndirimOrani = 15, SatisDurum = true, SanatciId = 2 },
                    new Album() { Id = 3, AlbumAdi = "Deneme3", CikisTarihi = DateTime.Now.AddYears(10), Fiyat = 150, IndirimOrani = 15, SatisDurum = true, SanatciId = 3 },
                    new Album() { Id = 4, AlbumAdi = "Deneme4", CikisTarihi = DateTime.Now.AddYears(7), Fiyat = 150, IndirimOrani = 15, SatisDurum = true, SanatciId = 4 },
                    new Album() { Id = 5, AlbumAdi = "Deneme5", CikisTarihi = DateTime.Now.AddYears(12), Fiyat = 150, IndirimOrani = 15, SatisDurum = true, SanatciId = 5 },
                    new Album() { Id = 6, AlbumAdi = "Deneme6", CikisTarihi = DateTime.Now.AddYears(8), Fiyat = 150, IndirimOrani = 15, SatisDurum = true, SanatciId = 6 },
                    new Album() { Id = 7, AlbumAdi = "Deneme7", CikisTarihi = DateTime.Now.AddYears(3), Fiyat = 150, IndirimOrani = 15, SatisDurum = true, SanatciId = 1 },
                    new Album() { Id = 8, AlbumAdi = "Deneme8", CikisTarihi = DateTime.Now.AddYears(4), Fiyat = 150, IndirimOrani = 15, SatisDurum = true, SanatciId = 2 },
                    new Album() { Id = 9, AlbumAdi = "Deneme9", CikisTarihi = DateTime.Now.AddYears(5), Fiyat = 150, IndirimOrani = 15, SatisDurum = true, SanatciId = 1 }
                );

            builder.HasOne(x => x.Sanatci)
                .WithMany(x => x.Albums)
                .HasForeignKey(x => x.SanatciId);
                
        }
    }
}
