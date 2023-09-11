using Sinav.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Sinav.BLL.KullaniciService
{
    public interface IKullaniciService
    {
        void Create(Kullanici entity);
        void Update(Kullanici entity);
        void Delete(Kullanici entity);
        bool Any(Expression<Func<Kullanici, bool>> expression);
        Kullanici GirisKontrol(string userName,string password);
    }
}
