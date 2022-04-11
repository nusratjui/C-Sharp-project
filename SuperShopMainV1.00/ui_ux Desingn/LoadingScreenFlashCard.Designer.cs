namespace SuperShopMainV1._00
{
    partial class LoagingScreenFlashCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoagingScreenFlashCard));
            this.loadscreenpanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.loadpanelmain = new System.Windows.Forms.Panel();
            this.loadpanlesecond = new System.Windows.Forms.Panel();
            this.loadtimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // loadscreenpanel
            // 
            this.loadscreenpanel.BackColor = System.Drawing.Color.Transparent;
            this.loadscreenpanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("loadscreenpanel.BackgroundImage")));
            this.loadscreenpanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.loadscreenpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.loadscreenpanel.Location = new System.Drawing.Point(0, 0);
            this.loadscreenpanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.loadscreenpanel.MaximumSize = new System.Drawing.Size(794, 174);
            this.loadscreenpanel.MinimumSize = new System.Drawing.Size(794, 174);
            this.loadscreenpanel.Name = "loadscreenpanel";
            this.loadscreenpanel.Size = new System.Drawing.Size(794, 174);
            this.loadscreenpanel.TabIndex = 0;
            this.loadscreenpanel.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(560, 178);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Version 1.00";
            // 
            // loadpanelmain
            // 
            this.loadpanelmain.BackColor = System.Drawing.Color.Transparent;
            this.loadpanelmain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.loadpanelmain.Location = new System.Drawing.Point(0, 439);
            this.loadpanelmain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.loadpanelmain.Name = "loadpanelmain";
            this.loadpanelmain.Size = new System.Drawing.Size(794, 15);
            this.loadpanelmain.TabIndex = 2;
            // 
            // loadpanlesecond
            // 
            this.loadpanlesecond.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.loadpanlesecond.Location = new System.Drawing.Point(0, 438);
            this.loadpanlesecond.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.loadpanlesecond.Name = "loadpanlesecond";
            this.loadpanlesecond.Size = new System.Drawing.Size(39, 15);
            this.loadpanlesecond.TabIndex = 3;
            // 
            // loadtimer
            // 
            this.loadtimer.Enabled = true;
            this.loadtimer.Interval = 15;
            this.loadtimer.Tick += new System.EventHandler(this.loadtimer_Tick);
            // 
            // LoagingScreenFlashCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(794, 454);
            this.Controls.Add(this.loadpanlesecond);
            this.Controls.Add(this.loadpanelmain);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loadscreenpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(794, 454);
            this.MinimumSize = new System.Drawing.Size(794, 454);
            this.Name = "LoagingScreenFlashCard";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoagingScreenFlashCard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel loadscreenpanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel loadpanelmain;
        private System.Windows.Forms.Panel loadpanlesecond;
        private System.Windows.Forms.Timer loadtimer;
    }
}