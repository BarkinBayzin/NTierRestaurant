using NTierRestaurant.MODEL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierRestaurant.MODEL.Concrete
{
    public class Shipper:BaseEntity
    {
        public string CompanyName { get; set; }
        public string Phone { get; set; }

        //Relations Begin

        public virtual List<Order> Orders { get; set; }
    }
}
