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
    public partial class DeleteProductsFromInventory : Form
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-19J77QP;Initial Catalog=SuperShopMSDB;Integrated Security=True");
        public DeleteProductsFromInventory()
        {
            InitializeComponent();
            sqlConnection.Open();
            SqlCommand cmd = sqlConnection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from PRODUCT";
            cmd.ExecuteNonQuery();// executing the CommandText

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd); //here the sql datadapter is catching the data  using sql language
            da.Fill(dt); //here the sql datadapter is filling the data into the datatable
            dgvRemoveProduct.DataSource = dt;//the datatable is showing into the data grid view


            sqlConnection.Close();
        }
        void display()
        {
            sqlConnection.Open();
            SqlCommand cmd = sqlConnection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from PRODUCT";
            cmd.ExecuteNonQuery();// executing the CommandText

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd); //here the sql datadapter is catching the data  using sql language
            da.Fill(dt); //here the sql datadapter is filling the data into the datatable
            dgvRemoveProduct.DataSource = dt;//the datatable is showing into the data grid view


            sqlConnection.Close();

        }

        private void logoutbutton_Click(object sender, EventArgs e)
        {
            Login logut = new Login();
            logut.Show();
            this.Hide();
        }

        private void RemonveProduct_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void Reports_Click(object sender, EventArgs e)
        {
            adminReport adr = new adminReport();
            adr.Show();
            this.Hide();
        }

        private void Inventory_Click(object sender, EventArgs e)
        {
            AdminDashboard adm = new AdminDashboard();
            this.Hide();
            adm.Show();

        }

        private void Removeinventorybtn_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select PRODUCT_ID from PRODUCT where PRODUCT_ID = '" + Product_ID_Textbox.Text + "'", sqlConnection);
            //Checking whether the Product is available or Not 
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count == 1) //if the Product_ID is available in datatable
            {

                DialogResult dlt = MessageBox.Show("Do you want to delete the product?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dlt == DialogResult.Yes)
                {
                    sqlConnection.Open();

                    SqlCommand cmd = sqlConnection.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "delete from PRODUCT where PRODUCT_ID = '" + Product_ID_Textbox.Text + "'";
                    cmd.ExecuteNonQuery(); // executing the CommandText

                    sqlConnection.Close();
                    MessageBox.Show("Product is deleted from the database", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    display();

                }
                else
                {
                    MessageBox.Show("Product is not deleted", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else //if the Product_ID is not available in datatable
            {

                MessageBox.Show("Product Id is not found!", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                display();
            }
            Product_ID_Textbox.Text = "";
            
        }
    }
}
