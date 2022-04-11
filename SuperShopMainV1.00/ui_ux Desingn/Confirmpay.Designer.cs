namespace SuperShopMainV1._00
{
    partial class Confirmpay
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Confirmpay));
            this.listBoxitem = new System.Windows.Forms.ListBox();
            this.Login_PictureBox = new System.Windows.Forms.PictureBox();
            this.payconfirmpanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.paymethodselector = new System.Windows.Forms.ComboBox();
            this.paymentmethodselector = new System.Windows.Forms.Label();
            this.recievedcashbox = new System.Windows.Forms.TextBox();
            this.recieved = new System.Windows.Forms.Label();
            this.payconfigtotalpay = new System.Windows.Forms.TextBox();
            this.totalpayconfirmlable = new System.Windows.Forms.Label();
            this.payconfcnametext = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Login_PictureBox)).BeginInit();
            this.payconfirmpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxitem
            // 
            this.listBoxitem.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.listBoxitem, "listBoxitem");
            this.listBoxitem.FormattingEnabled = true;
            this.listBoxitem.Name = "listBoxitem";
            // 
            // Login_PictureBox
            // 
            this.Login_PictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Login_PictureBox.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.Login_PictureBox, "Login_PictureBox");
            this.Login_PictureBox.Name = "Login_PictureBox";
            this.Login_PictureBox.TabStop = false;
            // 
            // payconfirmpanel
            // 
            this.payconfirmpanel.BackColor = System.Drawing.SystemColors.Info;
            this.payconfirmpanel.Controls.Add(this.button1);
            this.payconfirmpanel.Controls.Add(this.paymethodselector);
            this.payconfirmpanel.Controls.Add(this.paymentmethodselector);
            this.payconfirmpanel.Controls.Add(this.recievedcashbox);
            this.payconfirmpanel.Controls.Add(this.recieved);
            this.payconfirmpanel.Controls.Add(this.payconfigtotalpay);
            this.payconfirmpanel.Controls.Add(this.totalpayconfirmlable);
            resources.ApplyResources(this.payconfirmpanel, "payconfirmpanel");
            this.payconfirmpanel.Name = "payconfirmpanel";
            this.payconfirmpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            resources.ApplyResources(this.button1, "button1");
            this.button1.ForeColor = System.Drawing.Color.Blue;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // paymethodselector
            // 
            resources.ApplyResources(this.paymethodselector, "paymethodselector");
            this.paymethodselector.Cursor = System.Windows.Forms.Cursors.Default;
            this.paymethodselector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.paymethodselector.FormattingEnabled = true;
            this.paymethodselector.Items.AddRange(new object[] {
            resources.GetString("paymethodselector.Items"),
            resources.GetString("paymethodselector.Items1"),
            resources.GetString("paymethodselector.Items2"),
            resources.GetString("paymethodselector.Items3"),
            resources.GetString("paymethodselector.Items4")});
            this.paymethodselector.Name = "paymethodselector";
            this.paymethodselector.SelectedIndexChanged += new System.EventHandler(this.RoleSelect_SelectedIndexChanged);
            // 
            // paymentmethodselector
            // 
            resources.ApplyResources(this.paymentmethodselector, "paymentmethodselector");
            this.paymentmethodselector.Name = "paymentmethodselector";
            // 
            // recievedcashbox
            // 
            resources.ApplyResources(this.recievedcashbox, "recievedcashbox");
            this.recievedcashbox.Name = "recievedcashbox";
            // 
            // recieved
            // 
            resources.ApplyResources(this.recieved, "recieved");
            this.recieved.Name = "recieved";
            // 
            // payconfigtotalpay
            // 
            resources.ApplyResources(this.payconfigtotalpay, "payconfigtotalpay");
            this.payconfigtotalpay.Name = "payconfigtotalpay";
            this.payconfigtotalpay.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // totalpayconfirmlable
            // 
            resources.ApplyResources(this.totalpayconfirmlable, "totalpayconfirmlable");
            this.totalpayconfirmlable.Name = "totalpayconfirmlable";
            // 
            // payconfcnametext
            // 
            resources.ApplyResources(this.payconfcnametext, "payconfcnametext");
            this.payconfcnametext.Name = "payconfcnametext";
            // 
            // Confirmpay
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.payconfcnametext);
            this.Controls.Add(this.payconfirmpanel);
            this.Controls.Add(this.Login_PictureBox);
            this.Controls.Add(this.listBoxitem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Confirmpay";
            ((System.ComponentModel.ISupportInitialize)(this.Login_PictureBox)).EndInit();
            this.payconfirmpanel.ResumeLayout(false);
            this.payconfirmpanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListBox listBoxitem;
        private System.Windows.Forms.PictureBox Login_PictureBox;
        private System.Windows.Forms.Panel payconfirmpanel;
        private System.Windows.Forms.Label totalpayconfirmlable;
        private System.Windows.Forms.Label recieved;
        public System.Windows.Forms.TextBox payconfigtotalpay;
        public System.Windows.Forms.Label paymentmethodselector;
        public System.Windows.Forms.TextBox recievedcashbox;
        public System.Windows.Forms.TextBox payconfcnametext;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox paymethodselector;
    }
}