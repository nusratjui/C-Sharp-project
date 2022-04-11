using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperShopMainV1._00
{
    public partial class LoagingScreenFlashCard : Form
    {
        public LoagingScreenFlashCard()
        {
            InitializeComponent();
        }

        private void loadtimer_Tick(object sender, EventArgs e)
        {
            loadpanlesecond.Width += 3;
            if (loadpanlesecond.Width >= 529)
            {
                loadtimer.Stop();
                Login loginstarter = new Login();
                this.Hide();
                loginstarter.Show();
            }
            
            
        }
    }
}
