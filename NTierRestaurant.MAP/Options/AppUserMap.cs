using NTierRestaurant.MODEL.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierRestaurant.MAP.Options
{
    public class AppUserMap:BaseMap<AppUser>
    {
        public AppUserMap()
        {
            //IsRequired methodu ilgili alanın SQL'e not nullable olarak gitmesini sağlar.
            Property(x => x.UserName).HasColumnName("Kullanıcı Adı").IsRequired();
            Property(x => x.Password).HasColumnName("Kullanıcı Şifresi").IsRequired();
            Property(x => x.Email).HasColumnName("E-Posta").IsRequired();

            ToTable("Kullanıcılar"); //Tablo ismini kullanıcılar olarak belirledik.

            //One to One İlişki
            //HasOptional == nullable
            HasOptional(x => x.Profile).WithRequired(x => x.AppUser);
        }
    }
}
