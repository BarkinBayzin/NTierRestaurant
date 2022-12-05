using NTierRestaurant.MODEL.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierRestaurant.MAP.Options
{
    public class ShipperMap:BaseMap<Shipper>
    {
        public ShipperMap()
        {
            ToTable("Kargocular");
            Property(x => x.CompanyName).HasColumnName("Şirket İsmi").IsRequired();
            Property(x => x.Phone).HasColumnName("Telefon").IsRequired();
        }
    }
}
