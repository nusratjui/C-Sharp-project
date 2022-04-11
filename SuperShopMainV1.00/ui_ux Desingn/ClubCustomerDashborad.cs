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
    public partial class ClubCustomerDashborad : Form
    {
        SqlConnection son = new SqlConnection(@"Data Source=DESKTOP-19J77QP;Initial Catalog=SuperShopMSDB;Integrated Security=True");
        public ClubCustomerDashborad()
        {
            InitializeComponent();
            son.Open();
            SqlDataAdapter sdpt = new SqlDataAdapter("select MEMBER.MEMBER_ID, CONTACT.CONTACT_ID, CONTACT.NAME, CONTACT.EMAIL, CONTACT.ADDRESS FROM MEMBER,CONTACT WHERE MEMBER.CONTACT_ID=CONTACT.CONTACT_ID;", son);
            son.Close();
            SqlCommandBuilder cb = new SqlCommandBuilder(sdpt);
            DataTable dt = new DataTable();
            sdpt.Fill(dt);
            clubcustomerdatagrid.DataSource = dt;
            son.Close();
        }

        private void ClubCustomerDashboarplanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SalesButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SalesmanDashboar ssld = new SalesmanDashboar();
            ssld.Show();
        }

        private void logoutbutton_Click(object sender, EventArgs e)
        {
            this.Close();
            Login logout = new Login();
            logout.Show();
        }

        private void addedbutton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-19J77QP;Initial Catalog=SuperShopMSDB;Integrated Security=True");
                con.Open();
                string insertclubquery = "INSERT INTO CUSTOMER VALUES('" + CustomerNameTextboxSales.Text.Trim() + "','" + clubcustomeraddress.Text.Trim() + "','" + CustomerEmailTextbox.Text.Trim() + "','" + PhneTextClub.Text.Trim() + "','" + SalesData.Value.Date + "')";
                SqlDataAdapter sqldata = new SqlDataAdapter(insertclubquery, con);
                sqldata.SelectCommand.ExecuteNonQuery();
                MessageBox.Show("SUCCESSFULLY INSERTD");
                SqlDataAdapter sdpt = new SqlDataAdapter("SELECT * FROM CUSTOMER ORDER BY CUSTOMER_ID ", son);
                con.Close();
                SqlCommandBuilder cb = new SqlCommandBuilder(sdpt);
                DataTable dt = new DataTable();
                sdpt.Fill(dt);
                clubcustomerdatagrid.DataSource = dt;

            }
            catch
            {
                MessageBox.Show("ERROR");
            }
            finally
            {
                CustomerEmailTextbox.Text = " ";
                CustomerNameTextboxSales.Text = " ";
                clubcustomeraddress.Text = " ";
                PhneTextClub.Text = " ";
                
            }


        }

        private void refreshclubmemberbtn_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void Addcutomerbutton_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        /*private void RemoveBtn_Click(object sender, EventArgs e)  
        {

            foreach (DataGridViewRow item in this.clubcustomerdatagrid.SelectedRows) //Delete Funciton
            {
                clubcustomerdatagrid.Rows.RemoveAt(item.Index);
            }
        
        }*/
    }
}
