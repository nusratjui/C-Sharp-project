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
    public partial class adminReport : Form
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-19J77QP;Initial Catalog=SuperShopMSDB;Integrated Security=True");
        public adminReport()
        {
            InitializeComponent();
            display();
        }

        void display()
        {
            try
            {
                sqlConnection.Open();
                SqlCommand cmd = sqlConnection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from REPORT";
                cmd.ExecuteNonQuery();// executing the CommandText

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd); //here the sql datadapter is catching the data  using sql language
                da.Fill(dt); //here the sql datadapter is filling the data into the datatable
                dgvReport.DataSource = dt; //the datatable is showing into the data grid view


                sqlConnection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }


        }

        private void logoutbutton_Click(object sender, EventArgs e)
        {
            Login logout = new Login();
            logout.Show();
            this.Hide();
        }

        private void RemonveProduct_Click(object sender, EventArgs e)
        {
            DeleteProductsFromInventory dld = new DeleteProductsFromInventory();
            dld.Show();
            this.Hide();
        }

        private void Reports_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void Inventory_Click(object sender, EventArgs e)
        {
            AdminDashboard add = new AdminDashboard();
            this.Hide();
            add.Show();
        }

        private void adminReport_Load(object sender, EventArgs e)
        {
            display();
        }

        private void SalesReport_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Rportinventorybtn_Click_1(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand cmd = sqlConnection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * from REPORT where MONTH = '" + SalesReport.Text + "'";

            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd); //here the sql datadapter is catching the data using sql language
            da.Fill(dt); //here the sql datadapter is filling the data into the datatable
            dgvReport.DataSource = dt; //the datatable is showing into the data grid view

            sqlConnection.Close();

        }
    }
}