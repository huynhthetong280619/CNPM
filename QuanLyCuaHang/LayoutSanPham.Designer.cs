namespace QuanLyCuaHang
{
    partial class LayoutSanPham
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
            this.pnlDetail = new QuanLyCuaHang.Gradient();
            this.lb_name = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.pbxSanPham = new System.Windows.Forms.PictureBox();
            this.nudSoLuong = new System.Windows.Forms.NumericUpDown();
            this.btnShowDetail = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gradient1.SuspendLayout();
            this.pnlDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // gradient1
            // 
            this.gradient1.ColorBottom = System.Drawing.Color.Red;
            this.gradient1.ColorTop = System.Drawing.Color.Lime;
            this.gradient1.Controls.Add(this.pnlDetail);
            this.gradient1.Controls.Add(this.nudSoLuong);
            this.gradient1.Controls.Add(this.btnShowDetail);
            this.gradient1.Controls.Add(this.label1);
            this.gradient1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradient1.Location = new System.Drawing.Point(0, 0);
            this.gradient1.Name = "gradient1";
            this.gradient1.Size = new System.Drawing.Size(188, 279);
            this.gradient1.TabIndex = 0;
            // 
            // pnlDetail
            // 
            this.pnlDetail.ColorBottom = System.Drawing.Color.Empty;
            this.pnlDetail.ColorTop = System.Drawing.Color.Empty;
            this.pnlDetail.Controls.Add(this.label3);
            this.pnlDetail.Controls.Add(this.label2);
            this.pnlDetail.Controls.Add(this.lb_name);
            this.pnlDetail.Controls.Add(this.lbPrice);
            this.pnlDetail.Controls.Add(this.pbxSanPham);
            this.pnlDetail.Location = new System.Drawing.Point(2, 3);
            this.pnlDetail.Name = "pnlDetail";
            this.pnlDetail.Size = new System.Drawing.Size(180, 234);
            this.pnlDetail.TabIndex = 0;
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_name.Location = new System.Drawing.Point(107, 186);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(15, 17);
            this.lb_name.TabIndex = 1;
            this.lb_name.Text = "0";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.Location = new System.Drawing.Point(107, 208);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(15, 17);
            this.lbPrice.TabIndex = 1;
            this.lbPrice.Text = "0";
            // 
            // pbxSanPham
            // 
            this.pbxSanPham.Location = new System.Drawing.Point(-2, 1);
            this.pbxSanPham.Name = "pbxSanPham";
            this.pbxSanPham.Size = new System.Drawing.Size(180, 179);
            this.pbxSanPham.TabIndex = 0;
            this.pbxSanPham.TabStop = false;
            // 
            // nudSoLuong
            // 
            this.nudSoLuong.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudSoLuong.Location = new System.Drawing.Point(85, 245);
            this.nudSoLuong.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSoLuong.Name = "nudSoLuong";
            this.nudSoLuong.Size = new System.Drawing.Size(29, 25);
            this.nudSoLuong.TabIndex = 8;
            this.nudSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnShowDetail
            // 
            this.btnShowDetail.Active = false;
            this.btnShowDetail.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnShowDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnShowDetail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnShowDetail.BorderRadius = 0;
            this.btnShowDetail.ButtonText = "Detail";
            this.btnShowDetail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowDetail.DisabledColor = System.Drawing.Color.Gray;
            this.btnShowDetail.Iconcolor = System.Drawing.Color.Transparent;
            this.btnShowDetail.Iconimage = null;
            this.btnShowDetail.Iconimage_right = null;
            this.btnShowDetail.Iconimage_right_Selected = null;
            this.btnShowDetail.Iconimage_Selected = null;
            this.btnShowDetail.IconMarginLeft = 0;
            this.btnShowDetail.IconMarginRight = 0;
            this.btnShowDetail.IconRightVisible = true;
            this.btnShowDetail.IconRightZoom = 0D;
            this.btnShowDetail.IconVisible = true;
            this.btnShowDetail.IconZoom = 90D;
            this.btnShowDetail.IsTab = false;
            this.btnShowDetail.Location = new System.Drawing.Point(120, 243);
            this.btnShowDetail.Name = "btnShowDetail";
            this.btnShowDetail.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnShowDetail.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnShowDetail.OnHoverTextColor = System.Drawing.Color.White;
            this.btnShowDetail.selected = false;
            this.btnShowDetail.Size = new System.Drawing.Size(62, 29);
            this.btnShowDetail.TabIndex = 9;
            this.btnShowDetail.Text = "Detail";
            this.btnShowDetail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnShowDetail.Textcolor = System.Drawing.Color.White;
            this.btnShowDetail.TextFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Quantity:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "PRICE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "NAME";
            // 
            // LayoutSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gradient1);
            this.Name = "LayoutSanPham";
            this.Size = new System.Drawing.Size(188, 279);
            this.gradient1.ResumeLayout(false);
            this.gradient1.PerformLayout();
            this.pnlDetail.ResumeLayout(false);
            this.pnlDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Gradient gradient1;
        private Bunifu.Framework.UI.BunifuFlatButton btnShowDetail;
        private System.Windows.Forms.NumericUpDown nudSoLuong;
        private System.Windows.Forms.Label label1;
        private Gradient pnlDetail;
        private System.Windows.Forms.PictureBox pbxSanPham;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}
