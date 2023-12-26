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

namespace Happy_Bite
{
    public partial class UserRegister : Form
    {
        private UserLogin login = new UserLogin();
        public UserRegister()
        {
            InitializeComponent();
        }
        private string conString = "Data Source=CHAMO-PC\\SQLEXPRESS;Initial Catalog=HappyBites;Integrated Security=True";

        private Boolean isValid()
        {
            String Uname = textBoxusername.Text;
            String pass = textBoxpassword.Text;
            String email = textBoxemail.Text;
            String tele = textBoxtel.Text;
            String addr = textBoxaddress.Text;


            if (String.IsNullOrEmpty(Uname))
            {
                errorProviderUserName.SetError(textBoxusername, "Username Required");
                MessageBox.Show("Username Required");
                textBoxusername.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(pass))
            {
                errorProviderPwd.SetError(textBoxpassword, "Password Required");
                MessageBox.Show("Password Required");
                textBoxpassword.Focus();
                return false;
            }
            if (!email.Contains("@") && !email.Contains(".") && !email.Contains("com"))
            {
                errorProviderEmail.SetError(textBoxemail, "format 'paulcruise12@example.com'");
                MessageBox.Show("Email Required");
                return false;
            }
            if (String.IsNullOrEmpty(tele))
            {
                errorProviderTel.SetError(textBoxtel, "Email Required");
                MessageBox.Show("Tel Required");
                textBoxtel.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(addr))
            {
                errorProviderAddress.SetError(textBoxaddress, "Email Required");
                MessageBox.Show("Address Required");
                textBoxaddress.Focus();
                return false;
            }
            return true;

        }
        public String getusername()
        {
            return textBoxusername.Text;
        }
        public String getpassword()
        {
            return textBoxpassword.Text;
        }
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            
            if (isValid() == true)
            {
                SqlConnection conn = new SqlConnection(conString);
                conn.Open();
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    string q = " INESRT INTO Users(UserName,Password,Email,Tel,Address) VALUES('" + textBoxusername.ToString() +
                        "','" + textBoxpassword.ToString() + "','" + textBoxemail.ToString() +
                        "','" + textBoxtel.ToString() + "','" + textBoxaddress.ToString()+"')";
                    SqlCommand cmd = new SqlCommand(q, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registration Successful ");
                    this.Hide();
                    login.Show();
                }
            }
            else
            {
                MessageBox.Show("Registration Failed ");
            }

            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            login.Show();
        }
    }
}
