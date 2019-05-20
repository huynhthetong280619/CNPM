namespace QuanLyCuaHang
{
    partial class frmLoading
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoading));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gradient1 = new QuanLyCuaHang.Gradient();
            this.gradient2 = new QuanLyCuaHang.Gradient();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlSlide = new System.Windows.Forms.Panel();
            this.gradient1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // gradient1
            // 
            this.gradient1.BackColor = System.Drawing.Color.Transparent;
            this.gradient1.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(12)))), ((int)(((byte)(41)))));
            this.gradient1.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(43)))), ((int)(((byte)(99)))));
            this.gradient1.Controls.Add(this.gradient2);
            this.gradient1.Controls.Add(this.panel1);
            this.gradient1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradient1.Location = new System.Drawing.Point(0, 0);
            this.gradient1.Name = "gradient1";
            this.gradient1.Size = new System.Drawing.Size(1265, 623);
            this.gradient1.TabIndex = 0;
            // 
            // gradient2
            // 
            this.gradient2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gradient2.BackgroundImage = global::QuanLyCuaHang.Properties.Resources.xx;
            this.gradient2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.gradient2.ColorBottom = System.Drawing.Color.Empty;
            this.gradient2.ColorTop = System.Drawing.Color.Empty;
            this.gradient2.Location = new System.Drawing.Point(467, 157);
            this.gradient2.Name = "gradient2";
            this.gradient2.Size = new System.Drawing.Size(330, 293);
            this.gradient2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(43)))), ((int)(((byte)(99)))));
            this.panel1.Controls.Add(this.pnlSlide);
            this.panel1.Location = new System.Drawing.Point(416, 456);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(432, 10);
            this.panel1.TabIndex = 0;
            // 
            // pnlSlide
            // 
            this.pnlSlide.BackColor = System.Drawing.Color.Orange;
            this.pnlSlide.Location = new System.Drawing.Point(351, 0);
            this.pnlSlide.Name = "pnlSlide";
            this.pnlSlide.Size = new System.Drawing.Size(81, 10);
            this.pnlSlide.TabIndex = 0;
            // 
            // frmLoading
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1265, 623);
            this.Controls.Add(this.gradient1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLoading";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLoading";
            this.Load += new System.EventHandler(this.frmLoading_Load);
            this.gradient1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Gradient gradient1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlSlide;
        private System.Windows.Forms.Timer timer1;
        private Gradient gradient2;
    }
}