using NTierRestaurant.BLL.DesignPatterns.GenericRepositoryPattern.IntRep;
using NTierRestaurant.BLL.DesignPatterns.SingletonPattern;
using NTierRestaurant.DAL.Context;
using NTierRestaurant.MODEL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NTierRestaurant.BLL.DesignPatterns.GenericRepositoryPattern.BaseRep
{
    public abstract class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        protected MyContext _db; //Protected vermemizin nedeni özellikle miras verilecek yerlerde müdagelere edebilme ihtimalimizi korumaktır.
        public BaseRepository()
        {
            _db = DBTool.DbInstance; //Singleton patterinimiz burada kullanıyoruz.
        }
        public void Add(T item)
        {
            //GenericRepository tüketilerken, CRUD operasyonları için gelen T Tipinin bir entity'e set edilmesi gerekir. Aksi takdirde sistem T tipine bağlı bir entity göremeceğinden ekleme, silme vb işlemler gerçekleştiremeyecektir.
            _db.Set<T>().Add(item);
            Save();
        }

        private void Save()
        {
            _db.SaveChanges();
        }

        public bool Any(Expression<Func<T, bool>> exp) => _db.Set<T>().Any(exp);
        

        public void Delete(T item)
        {
            item.Status = Status.Passive;
            item.DeletedDate = DateTime.Now;
            Save();
        }

        public void Destroy(T item)
        {
            _db.Set<T>().Remove(item);
            Save();
        }

        public T Find(int id) => _db.Set<T>().Find(id);

        public List<T> GetActives() => _db.Set<T>().Where(x => x.Status == Status.Active).ToList();

        public List<T> GetAll() => _db.Set<T>().ToList();

        public T GetDefault(Expression<Func<T, bool>> exp) => _db.Set<T>().FirstOrDefault(exp);

        public List<T> GetModifieds() => _db.Set<T>().Where(x => x.Status == Status.Modified).ToList();

        public List<T> GetPassives() => _db.Set<T>().Where(x => x.Status == Status.Passive).ToList();

        public object Select(Expression<Func<T, bool>> exp) => _db.Set<T>().Select(exp).ToList();

        public void Update(T item)
        {
            //Önce güncellenecek verinin veritabanından yakalanması lazım
            //Sonra buraya gelen argümanın verilerinin komple veritabnındaki orjinal verilere replace edilmesi lazım(değiştirlemesi lazım)
            T guncellenecek = Find(item.Id);//Burada parametremizin ID'sinden güncellenecek veriyi buldum.
            //db.Entry => bu ifade, Database'inizde var olan bir bilgi için güncelleme yapılağını belirtir.
            _db.Entry(guncellenecek).CurrentValues.SetValues(item);//Bu ifadede dediğimiz şey, db'ye bir güncelleme girişi var. Bu güncellenecek nesnesi üzerindne yapılacak. Yakalanan nesnenin mevcut değerleri(genüz mdeğiştirilmemiş olan SQL'deki orjinal değerleri) item'dakilerle (C# tarafında değişik olan bilgilerler) set edilsin..(ayarlansın)
            item.ModifiedDate = DateTime.Now;
            item.Status = Status.Modified;
            Save();
        }

        public List<T> Where(Expression<Func<T, bool>> exp) => _db.Set<T>().Where(exp).ToList();
    }
}
