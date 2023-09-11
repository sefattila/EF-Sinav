using Sinav.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Sinav.BLL.AlbumService
{
    public interface IAlbumService
    {
        void Create(Album entity);
        void Update(Album entity);
        void Delete(Album entity);

        /// <summary>
        /// Expression'daki koşulu sağlıyorsa True sağlamıyorsa False dönecek
        /// </summary>
        /// <param name="expression"></param>
        /// <returns></returns>
        bool Any(Expression<Func<Album, bool>> expression);

        /// <summary>
        /// Verilen expressiondaki koşulu sağlayan entity return ediliyor
        /// </summary>
        /// <param name="expression"></param>
        /// <returns></returns>
        Album GetDefault(Expression<Func<Album, bool>> expression);

        /// <summary>
        /// Verilen Id değerine göre entity return ediliyor
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Album GetDefaultById(int id);

        /// <summary>
        /// Verilen expressiondaki koşula göre bir veya birden fazla entity içeren list return ediliyor
        /// </summary>
        /// <param name="expression"></param>
        /// <returns></returns>
        List<Album> GetDefaults(Expression<Func<Album, bool>> expression);

        /// <summary>
        /// Gelen entity'nin bütün değerlerini geri döndür
        /// </summary>
        /// <returns></returns>
        List<Album> GetAll();

        /// <summary>
        /// Koşula göre sıralı ifadeler
        /// </summary>
        /// <typeparam name="TKey"></typeparam>
        /// <param name="expression"></param>
        /// <returns></returns>
        List<Album> OrderByAsc<TKey>(Expression<Func<Album, TKey>> expression);
        List<Album> OrderByDesc<TKey>(Expression<Func<Album, TKey>> expression);
        //..

        IList<Album> SatistaOlanlar();
        IList<Album> SatistaOlmayanlar();
        IList<Album> SonOnAlbum();
    }
}
