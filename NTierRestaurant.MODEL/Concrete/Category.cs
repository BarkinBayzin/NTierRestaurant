using NTierRestaurant.MODEL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierRestaurant.MODEL.Concrete
{
    public class Category:BaseEntity
    {
        public Category()
        {

        }
        public Category(string name, string description)
        {
            Description = description;
            Name = name;
        }
        public string Name { get; set; }
        public string Description { get; set; }

        //Relations

        public virtual List<Product> Products { get; set; }
    }
}
