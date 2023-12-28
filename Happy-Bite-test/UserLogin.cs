using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Common;

namespace Happy_Bite
{
    public partial class UserLogin : Form
    {
        private Home home = new Home();
        private UserRegister reg = new UserRegister();
        public UserLogin()
        {
            InitializeComponent();
        }

        private string conString = "Data Source=CHAMO-PC\\SQLEXPRESS;Initial Catalog=HappyBites;Integrated Security=True";

        private void buttonLogin_Click(object sender, EventArgs e)
        {
                if (textBoxusername.Text == "" && textBoxpassword.Text == "")
                {
                    errorProviderUserName.SetError(textBoxusername, "Username Required");
                    errorProviderPwd.SetError(textBoxpassword, "Password Required");
                    MessageBox.Show("Username and Password are required!");
                    textBoxusername.Focus();
                }
                else
                {
                    SqlConnection con = new SqlConnection(conString);
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Users where UserName=@Username AND Password@Pwd");
                    cmd.Parameters.AddWithValue("@Username", textBoxusername.Text);
                    cmd.Parameters.AddWithValue("@Pwd", textBoxpassword.Text);

                    con.Open();
                    SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adpt.Fill(ds);
                    con.Close();

                    int count = ds.Tables[0].Rows.Count;
                    if (count == 1)
                    {
                        MessageBox.Show("Successfully Login");
                        this.Hide();
                        home.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Username and Password!");
                    }
                }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            reg.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
