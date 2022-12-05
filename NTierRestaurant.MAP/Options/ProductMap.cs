using NTierRestaurant.MODEL.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierRestaurant.MAP.Options
{
    public class ProductMap:BaseMap<Product>
    {
        public ProductMap()
        {
            ToTable("Ürünler");
            Property(x => x.ProductName).HasColumnName("Ürün İsmi").IsRequired();
            Property(x => x.UnitPrice).HasColumnName("Ürün Fiyatı").HasColumnType("money");
            Property(x => x.UnitsInStock).HasColumnName("Ürün Stok Sayısı");
        }
    }
}
