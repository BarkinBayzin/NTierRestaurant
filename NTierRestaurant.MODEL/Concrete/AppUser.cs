using NTierRestaurant.MODEL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierRestaurant.MODEL.Concrete
{
    public class AppUser:BaseEntity
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        //Relations begin
        public virtual Profile Profile { get; set; }
        public virtual List<Order> Orders { get; set; }
    }
}
