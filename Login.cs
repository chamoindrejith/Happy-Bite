using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Happy_Bite
{
    public partial class Login : Form
    {
        private Home home = new Home();
        private UserLogin login = new UserLogin();

        public Login()
        {
            InitializeComponent();
        }

        private void btnGetStart_Click(object sender, EventArgs e)
        {
            this.Hide();
            login.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
