using Sinav.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Sinav.Repository.Interfaces
{
    public interface IAlbumRepo : IBaseRepo<Album>
    {
        IList<Album> SatistaOlanlar();
        IList<Album> SatistaOlmayanlar();
        IList<Album> SonOnAlbum();
    }
}
