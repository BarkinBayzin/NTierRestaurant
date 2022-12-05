using NTierRestaurant.MODEL.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierRestaurant.MAP.Options
{
    //Burada BaseMap sınıfımız generic bir tip alarak bu generic tipini, miras aldığı EntityTypeConfiguration'a aktarıyor... Aynı zamanda bu generic tipin kesinlikle bir BaseEntity tipinde olması gerektiğiniz where T:BaseEntity ifadesiyle belirtiyoruz.
    public abstract class BaseMap<T>: EntityTypeConfiguration<T> where T : BaseEntity
    {
        //Bütün sınfıları ayarlayacak bir sınıfım var, bunu gidip görev yapıcağı yer genel bir tiptir. Burdaki ayarlamada Gelen gipin BaseEntity'den miras alması lazımdır(Liskov Substion uygulanma alanıdır!!)
        //Yani burda demek istediğimiz şey BaseEntity'den miras alacak bir sınıf olacak/yaratılacak ise bu kesinlikte tablo olacaktır.

        public BaseMap()
        {
            //Eğer siz müdahele etmezseniz C# referans tiplerinizi Sql'e otomatik olarak null geçilebilir gider. Ama değer tipleriniz de null geçilemez olarak gider..
            Property(x => x.CreatedBy).HasColumnName("Yaratan Kişi");
            Property(x => x.CreatedDate).HasColumnName("Veri Giriş Tarihi");
            Property(x => x.ModifiedDate).HasColumnName("Güncelleme Tarihi").IsOptional();//IsOptional bir sütunun null geçilebilecğini bildirir. Tabii ki biz kendisine ? sembolü verdiğimiz için ModifiedDate'imiz zaten null geçilebilir, yani bu durumda yazmış olduğumuza gerek yoktur
            Property(x => x.DeletedDate).HasColumnName("Veri Silme Tarihi").HasColumnType("datetime2");//Sütün tipini de belirleyebilrisiniz. Ancak bu tipi SQL'deki tip olması gerekir.
            Property(x => x.ModifiedBy).HasColumnName("Güncelleyen Kişi");
            Property(x => x.DeletedBy).HasColumnName("Silen Kişi");
            Property(x => x.Status).HasColumnName("Veri Durumu");
        }
    }
}
