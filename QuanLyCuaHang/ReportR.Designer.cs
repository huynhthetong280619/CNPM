namespace QuanLyCuaHang
{
    partial class ReportR
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gradient1 = new QuanLyCuaHang.Gradient();
            this.btnShow = new Bunifu.UI.WinForms.BunifuRadioButton();
            this.gradient1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gradient1
            // 
            this.gradient1.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(23)))), ((int)(((byte)(18)))));
            this.gradient1.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(247)))));
            this.gradient1.Controls.Add(this.btnShow);
            this.gradient1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradient1.Location = new System.Drawing.Point(0, 0);
            this.gradient1.Name = "gradient1";
            this.gradient1.Size = new System.Drawing.Size(219, 279);
            this.gradient1.TabIndex = 0;
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.Transparent;
            this.btnShow.Checked = true;
            this.btnShow.Location = new System.Drawing.Point(79, 204);
            this.btnShow.Name = "btnShow";
            this.btnShow.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.btnShow.RadioColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.btnShow.Size = new System.Drawing.Size(61, 61);
            this.btnShow.TabIndex = 0;
            this.btnShow.Text = null;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // ReportR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.gradient1);
            this.Name = "ReportR";
            this.Size = new System.Drawing.Size(219, 279);
            this.gradient1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Gradient gradient1;
        private Bunifu.UI.WinForms.BunifuRadioButton btnShow;
    }
}
