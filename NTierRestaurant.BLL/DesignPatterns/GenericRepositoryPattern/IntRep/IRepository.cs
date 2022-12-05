using NTierRestaurant.MODEL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NTierRestaurant.BLL.DesignPatterns.GenericRepositoryPattern.IntRep
{
    public interface IRepository<T> where T : BaseEntity
    {
        //Listeleme

        /// <summary>
        /// Bütün datayı çeken method.
        /// </summary>
        /// <returns></returns>
        List<T> GetAll();

        /// <summary>
        /// Id parametresine göre veri getiren method
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        T Find(int id);

        /// <summary>
        /// Status durumu aktif olan dataları çekmeye yarayan method
        /// </summary>
        /// <returns></returns>
        List<T> GetActives();

        /// <summary>
        /// Status durumu pasif olan dataları çekmeye yarayan method
        /// </summary>
        /// <returns></returns>
        List<T> GetPassives();

        /// <summary>
        /// Status durumu güncellenmiş olan dataları çekmeye yarayan method
        /// </summary>
        /// <returns></returns>
        List<T> GetModifieds();

        //Modifikasyon

        /// <summary>
        /// Veriyi Ekleyen Method
        /// </summary>
        /// <param name="item"></param>
        void Add(T item);
        /// <summary>
        /// Veriyi güncelleyen method
        /// </summary>
        /// <param name="item"></param>
        void Update(T item);
        /// <summary>
        /// Veririn statü durumunu pasife çeken method
        /// </summary>
        /// <param name="item"></param>
        void Delete(T item);
        /// <summary>
        /// Veriyi yok eden method
        /// </summary>
        /// <param name="item"></param>
        void Destroy(T item);

        //Linq metotları
        //Siz bir methoda parametre verdiğinizde argüman parametrenizin tipinde olmak zorundadır.
        //db.Products.Where(x => x.ProductName == "Chai")
        //Delegate'ler birden fazla methodu içlerinde tutan yapılardır.

        /// <summary>
        /// Verilen expression'a uygun koleksiyonu getirir.
        /// </summary>
        /// <param name="exp"></param>
        /// <returns>Experession uygun koleksiyon döner</returns>
        List<T> Where(Expression<Func<T, bool>> exp);
        /// <summary>
        /// Verilen expression'a uygun datayı getirir.
        /// </summary>
        /// <param name="exp"></param>
        /// <returns>Experession uygun datayı döner</returns>
        T GetDefault(Expression<Func<T, bool>> exp);
        /// <summary>
        /// Verilen expression'a uygun datanın varlığı kontrol eder.
        /// </summary>
        /// <param name="exp"></param>
        /// <returns>Data yakalırsa true, aksi takdir false döner</returns>
        bool Any(Expression<Func<T, bool>> exp);

        /// <summary>
        /// Verilen expressiona uygun result set döndürmeye yarar.
        /// </summary>
        /// <param name="exp"></param>
        /// <returns></returns>
        object Select(Expression<Func<T, bool>> exp);

    }
}
