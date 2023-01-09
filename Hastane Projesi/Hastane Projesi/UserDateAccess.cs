using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane_Projesi
{
    
    internal class UserDateAccess
    {
        sqlbaglantisi bgl = new sqlbaglantisi();
        public User addUser(User user)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_User (tc,sifre) values (@p1,@p2)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", user.Tc);
            komut.Parameters.AddWithValue("@p2", user.Password);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            return user;
        }
        
    }
}
