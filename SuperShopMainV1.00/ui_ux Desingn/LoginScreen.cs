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

namespace SuperShopMainV1._00
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Loginbutton_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-19J77QP;Initial Catalog=SuperShopMSDB;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM LOGIN WHERE USER_ID= '" + UserID_textBox.Text + "'and ROLE='" + RoleSelect.Text + "' and PASSWORD='" + passwrodbox.Text + "'", sqlcon);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows[0][0].ToString() == "1") 
            {
                this.Hide();
                if (RoleSelect.Text == "Admin")
                {
                    AdminDashboard ss = new AdminDashboard();
                    ss.Show();
                }
                if (RoleSelect.Text == "Salesman")
                {
                    SalesmanDashboar sdb = new SalesmanDashboar();
                    sdb.Show();
                }
               
            }
            else
            {
                MessageBox.Show("ERROR PASSWORD TRY AGAIN");
                Login log = new Login();
                log.Show();
            }
            
        }

        private void Exitbtn_Click(object sender, EventArgs e) //Close window with exit button click
        {
            this.Close();
        }

        private void Login_PictureBox_Click(object sender, EventArgs e)
        {

        }

 
    }
}
