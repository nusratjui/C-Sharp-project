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
    public partial class AdminDashboard : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-19J77QP;Initial Catalog=SuperShopMSDB;Integrated Security=True");
        private SqlConnection connection;

        public object Command { get; private set; }

        private object adapter;
        private object textBoxValueToSearch;

        public DataTable DataTable { get; private set; }

        public AdminDashboard()
        {
            InitializeComponent();
            binddatagrid();
        }

        private void binddatagrid()
        {

            SqlDataAdapter sda = new SqlDataAdapter("SELECT *from  PRODUCT", sqlcon);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;

        }



        private void Phone_Click(object sender, EventArgs e)
        {

        }

        private void Inventory_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void logoutbutton_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void RemonveProduct_Click(object sender, EventArgs e)
        {
            DeleteProductsFromInventory delpd = new DeleteProductsFromInventory();
            delpd.Show();
            this.Hide();
        }

        private void Reports_Click(object sender, EventArgs e)
        {
            adminReport adm = new adminReport();
            adm.Show();
            this.Hide();
        }

        private void addedbuttoninventory_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            SqlCommand cmd = new SqlCommand("insert into PRODUCT values(@PRODUCT_NAME,@CATAGORY,@BUYING_PRICE,@SELLING_PRICE,@INITIAL_STOCK,@SOLD)", sqlcon);
            cmd.Parameters.AddWithValue("@PRODUCT_NAME", CustomerNameTextboxSales.Text);
            cmd.Parameters.AddWithValue("@CATAGORY", comboBox1.Text);
            cmd.Parameters.AddWithValue("@BUYING_PRICE", float.Parse(Priceadmin.Text));
            cmd.Parameters.AddWithValue("@INITIAL_STOCK", int.Parse(addproductqtybox.Text));
            cmd.Parameters.AddWithValue("@SELLING_PRICE", float.Parse(RetailPricebox.Text));
            cmd.Parameters.AddWithValue("@SOLD", 0);
            int i = cmd.ExecuteNonQuery();

            if (i == 1)
            {
                MessageBox.Show("Data Saved");
                binddatagrid();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void searchinventory_Click(object sender, EventArgs e)
        {

            string query = "SELECT *FROM PRODUCT WHERE PRODUCT_NAME like '%" + textBox4.Text + "%'";

            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable dtb = new DataTable();
            sda.Fill(dtb);
            dataGridView1.DataSource = dtb;



        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'superShopMSDBDataSet1.PRODUCT' table. You can move, or remove it, as needed.
            //this.pRODUCTTableAdapter1.Fill(this.superShopMSDBDataSet1.PRODUCT);
            // TODO: This line of code loads data into the 'superShopMSDBDataSet.PRODUCT' table. You can move, or remove it, as needed.
            // this.pRODUCTTableAdapter.Fill(this.superShopMSDBDataSet.PRODUCT);
            searchinventory_Click(" ");

        }

        private void admindashboarlogo_Click(object sender, EventArgs e)
        {

        }

        private void CustomerNameTextboxSales_TextChanged(object sender, EventArgs e)
        {

        }

        private void ProductCata_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            string valuToSearch = textBox4.Text.ToString();
            searchinventory_Click(valuToSearch);
        }

        private void searchinventory_Click(string valuToSearch)
        {
            //throw new NotImplementedException();
        }
    }
}
