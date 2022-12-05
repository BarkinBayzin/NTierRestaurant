using NTierRestaurant.MODEL.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierRestaurant.MAP.Options
{
    public class ProfileMap:BaseMap<Profile>
    {
        public ProfileMap()
        {
            ToTable("Kullanıcı Profilleri");
            Property(x => x.FirstName).HasColumnName("İsim").IsRequired();
            Property(x => x.LastName).HasColumnName("Soyisim").IsRequired();
        }
    }
}
