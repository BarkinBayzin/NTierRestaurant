using NTierRestaurant.MODEL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierRestaurant.MODEL.Concrete
{
    public class Profile:BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Relation Beging
        public virtual AppUser AppUser { get; set; }
    }
}
