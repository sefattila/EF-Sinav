using Sinav.Core.Entities;
using Sinav.Repository.Contexts;
using Sinav.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinav.Repository.Concretes
{
    public class KullaniciRepo : BaseRepo<Kullanici>, IKullaniciRepo
    {
        public KullaniciRepo(AppDbContext context) : base(context)
        {
        }
    }
}
