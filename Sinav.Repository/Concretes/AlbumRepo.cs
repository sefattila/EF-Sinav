using Sinav.Core.Entities;
using Sinav.Core.Enums;
using Sinav.Repository.Contexts;
using Sinav.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Sinav.Repository.Concretes
{
    public class AlbumRepo : BaseRepo<Album>, IAlbumRepo
    {
        private readonly AppDbContext _context;
        public AlbumRepo(AppDbContext context) : base(context)
        {
            this._context = context;
        }

        public IList<Album> SatistaOlanlar()
        {
            return _context.Albums.Where(x => x.SatisDurum == true && x.Status != Status.Passive).ToList();
        }

        public IList<Album> SatistaOlmayanlar()
        {
            return _context.Albums.Where(x => x.SatisDurum == false && x.Status != Status.Passive).ToList();
        }

        public IList<Album> SonOnAlbum()
        {
            return _context.Albums.Where(x=>x.Status!=Status.Passive).OrderByDescending(x => x.CreateDate).Take(10).ToList();
        }
    }
}
