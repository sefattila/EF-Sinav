using Sinav.Core.Entities;
using Sinav.Core.Enums;
using Sinav.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Sinav.BLL.AlbumService
{
    public class AlbumService : IAlbumService
    {
        private readonly IAlbumRepo _repo;

        public AlbumService(IAlbumRepo repo)
        {
            this._repo = repo;
        }

        public bool Any(Expression<Func<Album, bool>> expression)
        {
            return _repo.Any(expression);
        }

        public void Create(Album entity)
        {
            if (Any(x => x.AlbumAdi.ToLower() == entity.AlbumAdi.ToLower()))
            {
                throw new Exception("Bu Albüm Adı Mevcut");
            }
            _repo.Create(entity);
        }

        public void Delete(Album entity)
        {
            if (GetDefaultById(entity.Id) == null)
            {
                throw new Exception("Böyle Bir Albüm Yok Silemezsiniz");
            }
            entity.DeletedDate= DateTime.Now;
            entity.Status = Status.Passive;
            _repo.Delete(entity);
        }

        public List<Album> GetAll()
        {
            return _repo.GetAll();
        }

        public Album GetDefault(Expression<Func<Album, bool>> expression)
        {
            return _repo.GetDefault(expression);
        }

        public Album GetDefaultById(int id)
        {
            return _repo.GetDefaultById(id);
        }

        public List<Album> GetDefaults(Expression<Func<Album, bool>> expression)
        {
            return _repo.GetDefaults(expression);
        }

        public List<Album> OrderByAsc<TKey>(Expression<Func<Album, TKey>> expression)
        {
            return _repo.OrderByAsc(expression);
        }

        public List<Album> OrderByDesc<TKey>(Expression<Func<Album, TKey>> expression)
        {
            return _repo.OrderByDesc(expression);
        }

        public IList<Album> SatistaOlanlar()
        {
            return _repo.SatistaOlanlar();
        }

        public IList<Album> SatistaOlmayanlar()
        {
            return _repo.SatistaOlmayanlar();
        }

        public IList<Album> SonOnAlbum()
        {
            return _repo.SonOnAlbum();
        }

        public void Update(Album entity)
        {
            if(entity==null)
            {
                throw new Exception("Böyle Bir Albüm Yok");
            }
            entity.UpdateDate = DateTime.Now;
            entity.Status = Status.Modified;
            _repo.Update(entity);
        }
    }
}
