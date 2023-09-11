using Sinav.BLL.Utilities;
using Sinav.Core.Entities;
using Sinav.Core.Enums;
using Sinav.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Sinav.BLL.KullaniciService
{
    public class KullaniciService : IKullaniciService
    {
        private readonly IKullaniciRepo _repo;

        public KullaniciService(IKullaniciRepo repo)
        {
            this._repo = repo;
        }

        public bool Any(Expression<Func<Kullanici, bool>> expression)
        {
            return _repo.Any(expression);
        }

        public void Create(Kullanici entity)
        {
            if (Any(x => x.UserName.ToLower() == entity.UserName.ToLower()))
            {
                throw new Exception("Böyle Bir Kullanıcı Var");
            }
            if (!ServiceHelper.PasswordControl(entity.Password))
            {
                throw new Exception("Şifre gerekli formatlarda değil");
            }
            entity.Password = ServiceHelper.sha256_hash(entity.Password);
            _repo.Create(entity);
        }

        public void Delete(Kullanici entity)
        {
            if (entity == null)
            {
                throw new Exception("Silinecek Kullanıcı Yok");
            }
            entity.DeletedDate = DateTime.Now;
            entity.Status = Status.Passive;
            _repo.Delete(entity);
        }

        public Kullanici GirisKontrol(string userName, string password)
        {
            Kullanici kullanici = _repo.GetDefault(x => x.UserName == userName && x.Status != Status.Passive);
            if (kullanici == null)
            {
                throw new Exception("Böyle Bir Kullanıcı Yok veya Silnmiş Hesap");
            }
            if (kullanici.Password != ServiceHelper.sha256_hash(password))
            {
                throw new Exception("Şifre Yanlış");
            }
            return kullanici;
        }

        public void Update(Kullanici entity)
        {
            if (entity == null)
            {
                throw new Exception("Güncellenecek Kullanıcı Yok");
            }
            entity.UpdateDate = DateTime.Now;
            entity.Status = Status.Modified;
            _repo.Update(entity);
        }
    }
}
