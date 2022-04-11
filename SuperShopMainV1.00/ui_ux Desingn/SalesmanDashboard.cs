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
    public partial class SalesmanDashboar : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-19J77QP;Initial Catalog=SuperShopMSDB;Integrated Security=True");
        public static double totalcounter = 0.00;
        public string cnt = "";
        public string csid = "";
        DateTime dateTime = DateTime.UtcNow.Date;
        public SalesmanDashboar()
        {   
            InitializeComponent();
            Qtytextbox.Text = "1";
            grandtotalcount.Text = "0.00";
            datetimeviewer.Text = dateTime.ToString("dd-MM-yyyy");
           
        }

        private void SalesmanDashboar_Load(object sender, EventArgs e)
        {

        }

        private void Dashboradpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Membershipdropdown_Click(object sender, EventArgs e)
        {

        }

        private void AmountLabel_Click(object sender, EventArgs e)
        {

        }


        private void logoutbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void Addcutomerbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ClubCustomerDashborad cclb = new ClubCustomerDashborad();
            cclb.Show();
        }

        private void SalesButton_Click(object sender, EventArgs e)
        {
            this.Show();
        }


        private void addedbutton_Click(object sender, EventArgs e)
        {
            if(productidtextbox.Text!=""&&cnametextbox.Text!="")
            {
                  try
                {
                    string price;
                    sqlcon.Open();
                    string query = "Select PRODUCT_NAME,SELLING_PRICE from PRODUCT WHERE PRODUCT_ID =" + int.Parse(productidtextbox.Text);
                    SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
                    DataTable dtb = new DataTable();
                    sda.Fill(dtb);
                    ProductNametextBox.Text = dtb.Rows[0][0].ToString();
                    price = dtb.Rows[0][1].ToString();
                    float fineprice = float.Parse(price);
                    int qtyp = int.Parse(Qtytextbox.Text);
                    float sum = qtyp * fineprice;
                    customersalesdatagrid.Rows.Add(productidtextbox.Text, ProductNametextBox.Text, Qtytextbox.Text, price, sum.ToString());
                    totalcounter = totalcounter + sum;
                    totaltextbox.Text = totalcounter.ToString();
               


                }
                catch (Exception exd)
                {

                    MessageBox.Show(exd.Message);
                }
            }
            else
            {
                MessageBox.Show("Customer Name field or Product ID field is Empty");
            }
            sqlcon.Close();

         
           
        }


        private void Qtytextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            grandtotalcount.Text = totalcounter.ToString();
        }

        private void iDelete()
        {
            foreach (DataGridViewRow item in this.customersalesdatagrid.SelectedRows) //Delete Funciton
            {
                customersalesdatagrid.Rows.RemoveAt(item.Index);
            }
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            iDelete();
        }

        private void customersalesdatagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void productidtextbox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void proccedtopay_Click(object sender, EventArgs e)
        {

        }
        private void datetimeviewer_TextChanged(object sender, EventArgs e)
        {
            
        }
        public void payconfig(Confirmpay psd)
        {
            string[,] Datavalue = new string[customersalesdatagrid.Rows.Count, customersalesdatagrid.Columns.Count];
            foreach (DataGridViewRow row in customersalesdatagrid.Rows)
            {
                foreach (DataGridViewColumn col in customersalesdatagrid.Columns)
                {
                    Datavalue[row.Index, col.Index] = customersalesdatagrid.Rows[row.Index].Cells[col.Index].Value.ToString();

                }
            }
            int i = 1;
            string strval = "";
            foreach(string ss in Datavalue)
            {
                strval += ss+" ";
                if (i == 5)
                {
                    psd.listBoxitem.Items.Add(strval);
                    strval = " ";
                    i = 0;
                }
                i++;

            }
            
        }







        public void insbdetails()
        {
   
            string query = "Select BILL_ID from BILL WHERE CUSTOMER_ID  =" +int.Parse(csid);
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable dtb = new DataTable();
            sda.Fill(dtb);
            string bid = dtb.Rows[0][0].ToString();
            for (int i = 0; i < customersalesdatagrid.Rows.Count; i++)
            {
                SqlCommand cmd = new SqlCommand("insert into BILLDETAILS values(@BILL_ID,@PRODUCT_ID)", sqlcon);
                cmd.Parameters.AddWithValue("@BILL_ID", bid);
                cmd.Parameters.AddWithValue("@PRODUCT_ID", int.Parse(customersalesdatagrid.Rows[i].Cells[0].Value.ToString()));
                int j = cmd.ExecuteNonQuery();
                if (j == 1)
                {
                    MessageBox.Show("Data Saved");
                }
            }
            sqlcon.Close();
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (productidtextbox.Text!="")
            {
                try
                {
                    SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-19J77QP;Initial Catalog=SuperShopMSDB;Integrated Security=True");
                    sqlcon.Open();
                    string query = "Select PRODUCT_NAME,SELLING_PRICE from PRODUCT WHERE PRODUCT_ID =" + int.Parse(productidtextbox.Text);
                    SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
                    DataTable dtb = new DataTable();
                    sda.Fill(dtb);
                    ProductNametextBox.Text = dtb.Rows[0][0].ToString();

                }
                catch (Exception)
                {
                    MessageBox.Show("PRODUCT NOT FOUND");
                    productidtextbox.Text = " ";
                }
            }
            else
            {
                MessageBox.Show("Product ID Is Empty ");
            }
        }
        public void inscnt()
        {
            SqlCommand cmd = new SqlCommand("insert into CONTACT values(@NAME,@EMAIL,@PHONE,@ADDRESS,@CATAGORY)", sqlcon);
            cmd.Parameters.AddWithValue("@NAME",cnametextbox.Text);
            cmd.Parameters.AddWithValue("@EMAIL",DBNull.Value);
            cmd.Parameters.AddWithValue("@PHONE",int.Parse(custphonetextbox.Text));
            cmd.Parameters.AddWithValue("@ADDRESS",DBNull.Value);
            cmd.Parameters.AddWithValue("@CATAGORY","CUSTOMER");
            int i = cmd.ExecuteNonQuery();
            if (i == 1)
            {
                MessageBox.Show("Data Saved");
            }
        }
        public void insbill()
        {
            string query = "Select CUSTOMER_ID from CUSTOMER WHERE CONTACT_ID ="+int.Parse(cnt);
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable dtb = new DataTable();
            sda.Fill(dtb);
            string cstid = dtb.Rows[0][0].ToString();
            csid = cstid;
            SqlCommand cmd = new SqlCommand("insert into BILL values(@CUSTOMER_ID,@PAYMENT_METHOD,@VAT,@DISCOUNT,@TOTAL_PAYABLE,@RECIEVED_CASH,@CHANGE,@ISSUE_DATE)", sqlcon);
            cmd.Parameters.AddWithValue("@CUSTOMER_ID", cstid);
            cmd.Parameters.AddWithValue("@PAYMENT_METHOD",paymethondselector.Text);
            cmd.Parameters.AddWithValue("@VAT",DBNull.Value);
            cmd.Parameters.AddWithValue("@DISCOUNT", DBNull.Value);
            cmd.Parameters.AddWithValue("@TOTAL_PAYABLE",totalcounter.ToString());
            cmd.Parameters.AddWithValue("@RECIEVED_CASH", CashRecievetextbox.Text);
            cmd.Parameters.AddWithValue("@CHANGE", (double.Parse(CashRecievetextbox.Text)-totalcounter).ToString());
            cmd.Parameters.AddWithValue("@ISSUE_DATE", dateTime.ToString("dd-MM-yyyy"));
            int i = cmd.ExecuteNonQuery();
            if(i==1)
            {
                MessageBox.Show("Data Saved");
            }
        }

        public void inscust()
        {
            string query = "Select CONTACT_ID from CONTACT WHERE PHONE =" + int.Parse(custphonetextbox.Text);
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable dtb = new DataTable();
            sda.Fill(dtb);
            string cntid = dtb.Rows[0][0].ToString();
            cnt = cntid;
            SqlCommand smd = new SqlCommand("insert into CUSTOMER values(@CONTACT_ID,@MEMBER_ID)", sqlcon);
            smd.Parameters.AddWithValue("@CONTACT_ID",cntid);
            smd.Parameters.AddWithValue("MEMBER_ID", DBNull.Value);
            int i = smd.ExecuteNonQuery();
            if(i==1)
            {
                MessageBox.Show("Data Saved");
            }

        }


   
        private void proceedtopay_Click(object sender, EventArgs e)
        {
            if (memberdropdown.Text == "Member")
            {
                if (memberidcheckbox.Text != "")
                {
                    sqlcon.Open();
                    string ipql = "SELECT MEMBER_ID FROM MEMBER WHERE MEMBER_ID=" + int.Parse(memberidcheckbox.Text);
                    SqlDataAdapter aqd = new SqlDataAdapter(ipql, sqlcon);
                    DataTable dtl = new DataTable();
                    aqd.Fill(dtl);
                    if (dtl.Rows[0][0].ToString() == memberidcheckbox.Text.Trim())
                    {
                        inscnt();
                        inscust();
                        insbill();
                        insbdetails();
                        MessageBox.Show("Thank You");

                    }
                    else
                    {
                        MessageBox.Show("ID Not found!");
                    }
                }
                if (memberidcheckbox.Text == "")
                {
                    MessageBox.Show("You have selected Member status but did not enter Member ID");
                }
                sqlcon.Close();
            }
            if(memberdropdown.Text=="Non Member")
            {
                if (memberidcheckbox.Text != "")
                {
                    MessageBox.Show("You have selected Non-Member status but Member ID is not empty");
                }
                if (memberidcheckbox.Text == "")
                {
                    sqlcon.Open();
                    inscnt();
                    inscust();
                    insbill();
                    insbdetails();
                    MessageBox.Show("Thank You Non Member");
                }
            }
            if(memberdropdown.Text=="")
            {
                MessageBox.Show("Enter Membership Status");
            }




            

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }


    }
}
