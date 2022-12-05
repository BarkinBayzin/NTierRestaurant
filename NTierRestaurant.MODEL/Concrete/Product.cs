using NTierRestaurant.MODEL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierRestaurant.MODEL.Concrete
{
    public class Product:BaseEntity
    {
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
        //Relations Begin
        public virtual List<OrderProduct> OrderProducts { get; set; }
        public virtual Category Category { get; set; }
    }
}
