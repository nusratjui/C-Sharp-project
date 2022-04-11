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
    public partial class memconfirmation : Form
    {
        public memconfirmation()
        {
            InitializeComponent();
        }

        private void memcheckbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (memidcheckbox.Text != "")
                {
                    SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-19J77QP;Initial Catalog=SuperShopMSDB;Integrated Security=True");
                    string ipql = "SELECT MEMBER_ID,CONTACT_ID FROM MEMBER WHERE MEMBER_ID=" + int.Parse(memidcheckbox.Text);
                    SqlDataAdapter aqd = new SqlDataAdapter(ipql, sqlcon);
                    DataTable dtl = new DataTable();
                    aqd.Fill(dtl);
                    if (dtl.Rows[0][0].ToString() == memidcheckbox.Text.Trim())
                    {
                        SalesmanDashboar ssl = new SalesmanDashboar();
                        Confirmpay cof = new Confirmpay(ssl.cnametextbox.Text,SalesmanDashboar.totalcounter.ToString());
                        ssl.payconfig(cof);
                        cof.Show();

                    }
                    else
                    {
                        MessageBox.Show("ID Not found!");
                    }
                }
            }
            catch(Exception eds)
            {
                MessageBox.Show(eds.Message);

            }

        }
    }
}
