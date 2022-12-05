using NTierRestaurant.MODEL.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierRestaurant.MAP.Options
{
    public class OrderMap:BaseMap<Order>
    {
        public OrderMap()
        {
            Property(x => x.ShippedAddress).HasColumnName("Gönderim Adresi");
            ToTable("Siparişler");
        }
    }
}
