namespace SuperShopMainV1._00
{
    partial class memconfirmation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(memconfirmation));
            this.memidcheckbox = new System.Windows.Forms.TextBox();
            this.memconflebel = new System.Windows.Forms.Label();
            this.memcheckbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // memidcheckbox
            // 
            this.memidcheckbox.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memidcheckbox.Location = new System.Drawing.Point(108, 183);
            this.memidcheckbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.memidcheckbox.Name = "memidcheckbox";
            this.memidcheckbox.Size = new System.Drawing.Size(666, 44);
            this.memidcheckbox.TabIndex = 0;
            // 
            // memconflebel
            // 
            this.memconflebel.AutoSize = true;
            this.memconflebel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.memconflebel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memconflebel.ForeColor = System.Drawing.Color.Black;
            this.memconflebel.Location = new System.Drawing.Point(266, 111);
            this.memconflebel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.memconflebel.Name = "memconflebel";
            this.memconflebel.Size = new System.Drawing.Size(315, 37);
            this.memconflebel.TabIndex = 1;
            this.memconflebel.Text = "Enter Membership ID";
            // 
            // memcheckbtn
            // 
            this.memcheckbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.memcheckbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.memcheckbtn.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memcheckbtn.Location = new System.Drawing.Point(352, 263);
            this.memcheckbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.memcheckbtn.Name = "memcheckbtn";
            this.memcheckbtn.Size = new System.Drawing.Size(160, 60);
            this.memcheckbtn.TabIndex = 2;
            this.memcheckbtn.Text = "Check";
            this.memcheckbtn.UseVisualStyleBackColor = false;
            this.memcheckbtn.Click += new System.EventHandler(this.memcheckbtn_Click);
            // 
            // memconfirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(852, 503);
            this.Controls.Add(this.memcheckbtn);
            this.Controls.Add(this.memconflebel);
            this.Controls.Add(this.memidcheckbox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "memconfirmation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Member Confirmation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox memidcheckbox;
        private System.Windows.Forms.Label memconflebel;
        private System.Windows.Forms.Button memcheckbtn;
    }
}