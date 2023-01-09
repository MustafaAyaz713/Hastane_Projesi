using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Hastane_Projesi
{
    internal class User
    {

        private int userId { get; set; }
        public int UserId { 
        
         get { return userId; }
         set { userId = value; }

         }
        private string tc { get; set; }
        public string Tc { 
        
            get { return tc; }
            set { tc = value; }


        }

        private int password { get; set; }

        public int Password
        {
            get { return password; }
            set { password = value; }
        }

        
            


    }
}
