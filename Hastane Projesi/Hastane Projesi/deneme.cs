using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastane_Projesi
{
    public partial class deneme : Form
    {
        private UserService userService;
        public deneme(UserService userService)
        {
            this.userService = userService;
            InitializeComponent();
        }
        
        private void kaydet_Click(object sender, EventArgs e)
        {
            this.userService.addUser(1,tc.Text,sifre.Text);

        }
    }
}
