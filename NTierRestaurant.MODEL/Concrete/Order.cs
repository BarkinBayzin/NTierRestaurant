using NTierRestaurant.MODEL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierRestaurant.MODEL.Concrete
{
    public class Order:BaseEntity
    {
        public int AppUserID { get; set; }
        public int ShipperID { get; set; }
        public string ShippedAddress { get; set; }

        //Relations Begin
        public virtual AppUser AppUser { get; set; }
        public virtual Shipper Shipper{ get; set; }
        public virtual List<OrderProduct> OrderProducts { get; set; }

    }
}
