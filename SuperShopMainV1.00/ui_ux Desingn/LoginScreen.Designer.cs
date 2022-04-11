namespace SuperShopMainV1._00
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.Login_PictureBox = new System.Windows.Forms.PictureBox();
            this.SelectRole = new System.Windows.Forms.Label();
            this.UserID = new System.Windows.Forms.Label();
            this.UserID_textBox = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.passwrodbox = new System.Windows.Forms.TextBox();
            this.Loginbutton = new System.Windows.Forms.Button();
            this.RoleSelect = new System.Windows.Forms.ComboBox();
            this.Exitbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Login_PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Login_PictureBox
            // 
            this.Login_PictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Login_PictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Login_PictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Login_PictureBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.Login_PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("Login_PictureBox.Image")));
            this.Login_PictureBox.Location = new System.Drawing.Point(166, 12);
            this.Login_PictureBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Login_PictureBox.Name = "Login_PictureBox";
            this.Login_PictureBox.Size = new System.Drawing.Size(312, 103);
            this.Login_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Login_PictureBox.TabIndex = 0;
            this.Login_PictureBox.TabStop = false;
            this.Login_PictureBox.Click += new System.EventHandler(this.Login_PictureBox_Click);
            // 
            // SelectRole
            // 
            this.SelectRole.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectRole.AutoSize = true;
            this.SelectRole.Cursor = System.Windows.Forms.Cursors.Default;
            this.SelectRole.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectRole.Location = new System.Drawing.Point(148, 161);
            this.SelectRole.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SelectRole.Name = "SelectRole";
            this.SelectRole.Size = new System.Drawing.Size(128, 25);
            this.SelectRole.TabIndex = 2;
            this.SelectRole.Text = "Select Role: ";
            // 
            // UserID
            // 
            this.UserID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserID.AutoSize = true;
            this.UserID.Cursor = System.Windows.Forms.Cursors.Default;
            this.UserID.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserID.Location = new System.Drawing.Point(148, 196);
            this.UserID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UserID.Name = "UserID";
            this.UserID.Size = new System.Drawing.Size(80, 23);
            this.UserID.TabIndex = 3;
            this.UserID.Text = "User ID:";
            // 
            // UserID_textBox
            // 
            this.UserID_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserID_textBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.UserID_textBox.Location = new System.Drawing.Point(238, 194);
            this.UserID_textBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.UserID_textBox.Name = "UserID_textBox";
            this.UserID_textBox.Size = new System.Drawing.Size(301, 28);
            this.UserID_textBox.TabIndex = 4;
            // 
            // Password
            // 
            this.Password.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Password.AutoSize = true;
            this.Password.Cursor = System.Windows.Forms.Cursors.Default;
            this.Password.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(148, 230);
            this.Password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(109, 25);
            this.Password.TabIndex = 5;
            this.Password.Text = "Password:";
            // 
            // passwrodbox
            // 
            this.passwrodbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwrodbox.Cursor = System.Windows.Forms.Cursors.Default;
            this.passwrodbox.Location = new System.Drawing.Point(238, 230);
            this.passwrodbox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.passwrodbox.Name = "passwrodbox";
            this.passwrodbox.PasswordChar = '*';
            this.passwrodbox.Size = new System.Drawing.Size(301, 28);
            this.passwrodbox.TabIndex = 6;
            // 
            // Loginbutton
            // 
            this.Loginbutton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Loginbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Loginbutton.Cursor = System.Windows.Forms.Cursors.Default;
            this.Loginbutton.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loginbutton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Loginbutton.Location = new System.Drawing.Point(238, 267);
            this.Loginbutton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Loginbutton.Name = "Loginbutton";
            this.Loginbutton.Size = new System.Drawing.Size(97, 38);
            this.Loginbutton.TabIndex = 7;
            this.Loginbutton.Text = "Login";
            this.Loginbutton.UseVisualStyleBackColor = false;
            this.Loginbutton.Click += new System.EventHandler(this.Loginbutton_Click);
            // 
            // RoleSelect
            // 
            this.RoleSelect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RoleSelect.Cursor = System.Windows.Forms.Cursors.Default;
            this.RoleSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RoleSelect.FormattingEnabled = true;
            this.RoleSelect.Items.AddRange(new object[] {
            "Admin",
            "Salesman"});
            this.RoleSelect.Location = new System.Drawing.Point(238, 161);
            this.RoleSelect.Name = "RoleSelect";
            this.RoleSelect.Size = new System.Drawing.Size(301, 30);
            this.RoleSelect.TabIndex = 8;
            // 
            // Exitbtn
            // 
            this.Exitbtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Exitbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Exitbtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.Exitbtn.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exitbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Exitbtn.Location = new System.Drawing.Point(442, 267);
            this.Exitbtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Exitbtn.Name = "Exitbtn";
            this.Exitbtn.Size = new System.Drawing.Size(97, 38);
            this.Exitbtn.TabIndex = 9;
            this.Exitbtn.Text = "Exit";
            this.Exitbtn.UseVisualStyleBackColor = false;
            this.Exitbtn.Click += new System.EventHandler(this.Exitbtn_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(666, 312);
            this.Controls.Add(this.Exitbtn);
            this.Controls.Add(this.RoleSelect);
            this.Controls.Add(this.Loginbutton);
            this.Controls.Add(this.passwrodbox);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.UserID_textBox);
            this.Controls.Add(this.UserID);
            this.Controls.Add(this.SelectRole);
            this.Controls.Add(this.Login_PictureBox);
            this.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(688, 368);
            this.MinimumSize = new System.Drawing.Size(688, 368);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.Login_PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Login_PictureBox;
        private System.Windows.Forms.Label SelectRole;
        private System.Windows.Forms.Label UserID;
        private System.Windows.Forms.TextBox UserID_textBox;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox passwrodbox;
        private System.Windows.Forms.Button Loginbutton;
        private System.Windows.Forms.ComboBox RoleSelect;
        private System.Windows.Forms.Button Exitbtn;
    }
}

