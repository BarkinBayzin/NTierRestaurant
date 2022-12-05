using NTierRestaurant.MODEL.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierRestaurant.MAP.Options
{
    public class OrderProductMap:BaseMap<OrderProduct>
    {
        public OrderProductMap()
        {
            ToTable("Satışlar");

            //BaseEntity'den gelen ver PK olarak işaretlenen property'i ignorlayarak pk eşlemesinin düşmesini sağlıyorum.
            Ignore(x => x.Id);

            //Composite Key uyguluyorum
            HasKey(x => new
            {
                x.OrderID,
                x.ProductID
            });
        }
    }
}
