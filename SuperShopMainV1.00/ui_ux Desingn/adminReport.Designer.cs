namespace SuperShopMainV1._00
{
    partial class adminReport
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminReport));
            this.AdminDashboardPanel = new System.Windows.Forms.Panel();
            this.Reports = new System.Windows.Forms.Button();
            this.logoutbutton = new System.Windows.Forms.Button();
            this.RemonveProduct = new System.Windows.Forms.Button();
            this.Inventory = new System.Windows.Forms.Button();
            this.clubdashboardpicbox = new System.Windows.Forms.PictureBox();
            this.ReportAdmin = new System.Windows.Forms.Panel();
            this.datelabel = new System.Windows.Forms.Label();
            this.SalesReport = new System.Windows.Forms.DateTimePicker();
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.REPORT_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MONTH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PROFIT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rportinventorybtn = new System.Windows.Forms.Button();
            this.superShopMSDBDataSet2 = new SuperShopMainV1._00.SuperShopMSDBDataSet2();
            this.superShopMSDBDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AdminDashboardPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clubdashboardpicbox)).BeginInit();
            this.ReportAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.superShopMSDBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.superShopMSDBDataSet2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // AdminDashboardPanel
            // 
            this.AdminDashboardPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.AdminDashboardPanel.Controls.Add(this.Reports);
            this.AdminDashboardPanel.Controls.Add(this.logoutbutton);
            this.AdminDashboardPanel.Controls.Add(this.RemonveProduct);
            this.AdminDashboardPanel.Controls.Add(this.Inventory);
            this.AdminDashboardPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.AdminDashboardPanel.Location = new System.Drawing.Point(0, 0);
            this.AdminDashboardPanel.Name = "AdminDashboardPanel";
            this.AdminDashboardPanel.Size = new System.Drawing.Size(177, 749);
            this.AdminDashboardPanel.TabIndex = 4;
            // 
            // Reports
            // 
            this.Reports.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Reports.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.Reports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reports.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reports.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Reports.Location = new System.Drawing.Point(12, 147);
            this.Reports.Name = "Reports";
            this.Reports.Size = new System.Drawing.Size(150, 47);
            this.Reports.TabIndex = 3;
            this.Reports.Text = "Reports";
            this.Reports.UseVisualStyleBackColor = true;
            this.Reports.Click += new System.EventHandler(this.Reports_Click);
            // 
            // logoutbutton
            // 
            this.logoutbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.logoutbutton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.logoutbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.logoutbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutbutton.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.logoutbutton.Location = new System.Drawing.Point(12, 673);
            this.logoutbutton.Name = "logoutbutton";
            this.logoutbutton.Size = new System.Drawing.Size(150, 40);
            this.logoutbutton.TabIndex = 2;
            this.logoutbutton.Text = "Logout";
            this.logoutbutton.UseVisualStyleBackColor = true;
            this.logoutbutton.Click += new System.EventHandler(this.logoutbutton_Click);
            // 
            // RemonveProduct
            // 
            this.RemonveProduct.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.RemonveProduct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.RemonveProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemonveProduct.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemonveProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.RemonveProduct.Location = new System.Drawing.Point(12, 83);
            this.RemonveProduct.Name = "RemonveProduct";
            this.RemonveProduct.Size = new System.Drawing.Size(150, 47);
            this.RemonveProduct.TabIndex = 1;
            this.RemonveProduct.Text = "Delete Product";
            this.RemonveProduct.UseVisualStyleBackColor = true;
            this.RemonveProduct.Click += new System.EventHandler(this.RemonveProduct_Click);
            // 
            // Inventory
            // 
            this.Inventory.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Inventory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.Inventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Inventory.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inventory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Inventory.Location = new System.Drawing.Point(12, 21);
            this.Inventory.Name = "Inventory";
            this.Inventory.Size = new System.Drawing.Size(150, 47);
            this.Inventory.TabIndex = 0;
            this.Inventory.Text = "Add Products";
            this.Inventory.UseVisualStyleBackColor = true;
            this.Inventory.Click += new System.EventHandler(this.Inventory_Click);
            // 
            // clubdashboardpicbox
            // 
            this.clubdashboardpicbox.BackColor = System.Drawing.Color.Transparent;
            this.clubdashboardpicbox.Dock = System.Windows.Forms.DockStyle.Top;
            this.clubdashboardpicbox.Image = ((System.Drawing.Image)(resources.GetObject("clubdashboardpicbox.Image")));
            this.clubdashboardpicbox.Location = new System.Drawing.Point(177, 0);
            this.clubdashboardpicbox.Name = "clubdashboardpicbox";
            this.clubdashboardpicbox.Size = new System.Drawing.Size(817, 105);
            this.clubdashboardpicbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.clubdashboardpicbox.TabIndex = 5;
            this.clubdashboardpicbox.TabStop = false;
            this.clubdashboardpicbox.UseWaitCursor = true;
            // 
            // ReportAdmin
            // 
            this.ReportAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ReportAdmin.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ReportAdmin.Controls.Add(this.datelabel);
            this.ReportAdmin.Controls.Add(this.SalesReport);
            this.ReportAdmin.Location = new System.Drawing.Point(203, 122);
            this.ReportAdmin.Name = "ReportAdmin";
            this.ReportAdmin.Size = new System.Drawing.Size(779, 58);
            this.ReportAdmin.TabIndex = 21;
            // 
            // datelabel
            // 
            this.datelabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.datelabel.AutoSize = true;
            this.datelabel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datelabel.Location = new System.Drawing.Point(548, 24);
            this.datelabel.Name = "datelabel";
            this.datelabel.Size = new System.Drawing.Size(160, 25);
            this.datelabel.TabIndex = 7;
            this.datelabel.Text = "Report Month :";
            // 
            // SalesReport
            // 
            this.SalesReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SalesReport.CustomFormat = "MMMM";
            this.SalesReport.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.SalesReport.Location = new System.Drawing.Point(649, 21);
            this.SalesReport.Name = "SalesReport";
            this.SalesReport.ShowUpDown = true;
            this.SalesReport.Size = new System.Drawing.Size(121, 28);
            this.SalesReport.TabIndex = 1;
            // 
            // dgvReport
            // 
            this.dgvReport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReport.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.REPORT_ID,
            this.MONTH,
            this.PROFIT});
            this.dgvReport.Location = new System.Drawing.Point(203, 284);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.Size = new System.Drawing.Size(779, 313);
            this.dgvReport.TabIndex = 22;
            // 
            // REPORT_ID
            // 
            this.REPORT_ID.DataPropertyName = "REPORT_ID";
            this.REPORT_ID.HeaderText = "REPORT_ID";
            this.REPORT_ID.Name = "REPORT_ID";
            // 
            // MONTH
            // 
            this.MONTH.DataPropertyName = "MONTH";
            this.MONTH.HeaderText = "MONTH";
            this.MONTH.Name = "MONTH";
            // 
            // PROFIT
            // 
            this.PROFIT.DataPropertyName = "PROFIT";
            this.PROFIT.HeaderText = "PROFIT";
            this.PROFIT.Name = "PROFIT";
            // 
            // Rportinventorybtn
            // 
            this.Rportinventorybtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Rportinventorybtn.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Rportinventorybtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Rportinventorybtn.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rportinventorybtn.ForeColor = System.Drawing.Color.Black;
            this.Rportinventorybtn.Location = new System.Drawing.Point(817, 220);
            this.Rportinventorybtn.Name = "Rportinventorybtn";
            this.Rportinventorybtn.Size = new System.Drawing.Size(165, 38);
            this.Rportinventorybtn.TabIndex = 23;
            this.Rportinventorybtn.Text = "Show Report\r\n";
            this.Rportinventorybtn.UseVisualStyleBackColor = false;
            this.Rportinventorybtn.Click += new System.EventHandler(this.Rportinventorybtn_Click_1);
            // 
            // superShopMSDBDataSet2
            // 
            this.superShopMSDBDataSet2.DataSetName = "SuperShopMSDBDataSet2";
            this.superShopMSDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // superShopMSDBDataSet2BindingSource
            // 
            this.superShopMSDBDataSet2BindingSource.DataSource = this.superShopMSDBDataSet2;
            this.superShopMSDBDataSet2BindingSource.Position = 0;
            // 
            // adminReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(994, 749);
            this.Controls.Add(this.Rportinventorybtn);
            this.Controls.Add(this.dgvReport);
            this.Controls.Add(this.ReportAdmin);
            this.Controls.Add(this.clubdashboardpicbox);
            this.Controls.Add(this.AdminDashboardPanel);
            this.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1010, 736);
            this.Name = "adminReport";
            this.Text = "Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.AdminDashboardPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clubdashboardpicbox)).EndInit();
            this.ReportAdmin.ResumeLayout(false);
            this.ReportAdmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.superShopMSDBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.superShopMSDBDataSet2BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel AdminDashboardPanel;
        private System.Windows.Forms.Button Reports;
        private System.Windows.Forms.Button logoutbutton;
        private System.Windows.Forms.Button RemonveProduct;
        private System.Windows.Forms.Button Inventory;
        private System.Windows.Forms.PictureBox clubdashboardpicbox;
        private System.Windows.Forms.Panel ReportAdmin;
        private System.Windows.Forms.Label datelabel;
        private System.Windows.Forms.DateTimePicker SalesReport;
        private System.Windows.Forms.DataGridView dgvReport;
        private System.Windows.Forms.Button Rportinventorybtn;
        private System.Windows.Forms.BindingSource superShopMSDBDataSet2BindingSource;
        private SuperShopMSDBDataSet2 superShopMSDBDataSet2;
        private System.Windows.Forms.DataGridViewTextBoxColumn REPORT_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MONTH;
        private System.Windows.Forms.DataGridViewTextBoxColumn PROFIT;
    }
}