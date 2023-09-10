using Sinav.Core.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Sinav.Repository.Interfaces
{
    public interface IBaseRepo<T> where T : BaseEntity
    {
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);

        /// <summary>
        /// Expression'daki koşulu sağlıyorsa True sağlamıyorsa False dönecek
        /// </summary>
        /// <param name="expression"></param>
        /// <returns></returns>
        bool Any(Expression<Func<T, bool>> expression);
        
        /// <summary>
        /// Verilen expressiondaki koşulu sağlayan entity return ediliyor
        /// </summary>
        /// <param name="expression"></param>
        /// <returns></returns>
        T GetDefault(Expression<Func<T, bool>> expression);
        
        /// <summary>
        /// Verilen Id değerine göre entity return ediliyor
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        T GetDefaultById(int id);
        
        /// <summary>
        /// Verilen expressiondaki koşula göre bir veya birden fazla entity içeren list return ediliyor
        /// </summary>
        /// <param name="expression"></param>
        /// <returns></returns>
        List<T> GetDefaults(Expression<Func<T, bool>> expression);
        
        /// <summary>
        /// Gelen entity'nin bütün değerlerini geri döndür
        /// </summary>
        /// <returns></returns>
        List<T> GetAll();
    }
}
