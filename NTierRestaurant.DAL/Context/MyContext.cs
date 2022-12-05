using NTierRestaurant.MAP.Options;
using NTierRestaurant.MODEL.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierRestaurant.DAL.Context
{
    public class MyContext:DbContext
    {
        public MyContext() : base("MyConnection")
        {
            //Burdaki My Connection ismi UI katmanının App.Config'inde.
            //Ancak buranın UI'daki App.Configi ile direkt bir iletişimi yok.
            //WINUI katmanını set as start up olarak ayarladığımız için kendisi otomatik olarak hangisini olduğunu algılıyor.
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Bu metotta hazır halde bulunan Map sınıflarımı tetiklenecektir.
            modelBuilder.Configurations.Add(new AppUserMap());
            modelBuilder.Configurations.Add(new ProfileMap());
            modelBuilder.Configurations.Add(new OrderMap());
            modelBuilder.Configurations.Add(new OrderProductMap());
            modelBuilder.Configurations.Add(new CategoryMap());
            modelBuilder.Configurations.Add(new ShipperMap());
            modelBuilder.Configurations.Add(new ProductMap());
        }

        public DbSet<AppUser> AppUsers{ get; set; }
        public DbSet<Profile> Profiles{ get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderProduct> OrderProducts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Shipper> Shippers { get; set; }
    }
}
