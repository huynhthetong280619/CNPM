namespace QuanLyCuaHang
{
    partial class uct_History
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uct_History));
            this.gradient1 = new QuanLyCuaHang.Gradient();
            this.dtpkdate = new Bunifu.Framework.UI.BunifuDatepicker();
            this.dtgvHistory = new QuanLyCuaHang.gridViewLinear();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lb_soluong = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nbud_PhanTrang = new System.Windows.Forms.NumericUpDown();
            this.btn_Find = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_Export = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_Delete = new Bunifu.Framework.UI.BunifuTileButton();
            this.gradient1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbud_PhanTrang)).BeginInit();
            this.SuspendLayout();
            // 
            // gradient1
            // 
            this.gradient1.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(12)))), ((int)(((byte)(41)))));
            this.gradient1.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(43)))), ((int)(((byte)(99)))));
            this.gradient1.Controls.Add(this.dtpkdate);
            this.gradient1.Controls.Add(this.dtgvHistory);
            this.gradient1.Controls.Add(this.button4);
            this.gradient1.Controls.Add(this.button3);
            this.gradient1.Controls.Add(this.button2);
            this.gradient1.Controls.Add(this.button1);
            this.gradient1.Controls.Add(this.lb_soluong);
            this.gradient1.Controls.Add(this.label2);
            this.gradient1.Controls.Add(this.label1);
            this.gradient1.Controls.Add(this.nbud_PhanTrang);
            this.gradient1.Controls.Add(this.btn_Find);
            this.gradient1.Controls.Add(this.btn_Export);
            this.gradient1.Controls.Add(this.btn_Delete);
            this.gradient1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradient1.Location = new System.Drawing.Point(0, 0);
            this.gradient1.Name = "gradient1";
            this.gradient1.Size = new System.Drawing.Size(1056, 577);
            this.gradient1.TabIndex = 0;
            // 
            // dtpkdate
            // 
            this.dtpkdate.BackColor = System.Drawing.Color.SeaGreen;
            this.dtpkdate.BorderRadius = 0;
            this.dtpkdate.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkdate.ForeColor = System.Drawing.Color.White;
            this.dtpkdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkdate.FormatCustom = "dd.MM.yyyy";
            this.dtpkdate.Location = new System.Drawing.Point(698, 15);
            this.dtpkdate.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dtpkdate.Name = "dtpkdate";
            this.dtpkdate.Size = new System.Drawing.Size(38, 36);
            this.dtpkdate.TabIndex = 105;
            this.dtpkdate.Value = new System.DateTime(2019, 5, 20, 16, 48, 26, 0);
            // 
            // dtgvHistory
            // 
            this.dtgvHistory.AllowUserToAddRows = false;
            this.dtgvHistory.AllowUserToDeleteRows = false;
            this.dtgvHistory.AllowUserToResizeColumns = false;
            this.dtgvHistory.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtgvHistory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvHistory.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dtgvHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvHistory.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(12)))), ((int)(((byte)(41)))));
            this.dtgvHistory.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(43)))), ((int)(((byte)(99)))));
            this.dtgvHistory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvHistory.ColumnHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvHistory.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvHistory.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgvHistory.DoubleBuffered = true;
            this.dtgvHistory.EnableHeadersVisualStyles = false;
            this.dtgvHistory.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dtgvHistory.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.dtgvHistory.Location = new System.Drawing.Point(0, 157);
            this.dtgvHistory.MultiSelect = false;
            this.dtgvHistory.Name = "dtgvHistory";
            this.dtgvHistory.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgvHistory.RowHeadersVisible = false;
            this.dtgvHistory.RowTemplate.Height = 43;
            this.dtgvHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvHistory.Size = new System.Drawing.Size(1056, 420);
            this.dtgvHistory.TabIndex = 104;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(677, 114);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(379, 43);
            this.button4.TabIndex = 100;
            this.button4.Text = "CHI TIẾT";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(221, 114);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(243, 43);
            this.button3.TabIndex = 101;
            this.button3.Text = "MÃ KHÁCH HÀNG";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(0, 114);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(222, 43);
            this.button2.TabIndex = 102;
            this.button2.Text = "MÃ NHÂN VIÊN";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(463, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(215, 43);
            this.button1.TabIndex = 103;
            this.button1.Text = "NGÀY BÁN";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // lb_soluong
            // 
            this.lb_soluong.AutoSize = true;
            this.lb_soluong.BackColor = System.Drawing.Color.Transparent;
            this.lb_soluong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_soluong.ForeColor = System.Drawing.Color.White;
            this.lb_soluong.Location = new System.Drawing.Point(909, 78);
            this.lb_soluong.Name = "lb_soluong";
            this.lb_soluong.Size = new System.Drawing.Size(19, 21);
            this.lb_soluong.TabIndex = 97;
            this.lb_soluong.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(813, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 21);
            this.label2.TabIndex = 98;
            this.label2.Text = "SỐ LƯỢNG";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(934, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 21);
            this.label1.TabIndex = 99;
            this.label1.Text = "TRANG";
            // 
            // nbud_PhanTrang
            // 
            this.nbud_PhanTrang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nbud_PhanTrang.ForeColor = System.Drawing.Color.Black;
            this.nbud_PhanTrang.Location = new System.Drawing.Point(1004, 75);
            this.nbud_PhanTrang.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nbud_PhanTrang.Name = "nbud_PhanTrang";
            this.nbud_PhanTrang.Size = new System.Drawing.Size(34, 29);
            this.nbud_PhanTrang.TabIndex = 96;
            this.nbud_PhanTrang.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nbud_PhanTrang.ValueChanged += new System.EventHandler(this.nbud_PhanTrang_ValueChanged);
            // 
            // btn_Find
            // 
            this.btn_Find.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Find.BackColor = System.Drawing.Color.Transparent;
            this.btn_Find.color = System.Drawing.Color.Transparent;
            this.btn_Find.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(25)))), ((int)(((byte)(198)))));
            this.btn_Find.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Find.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Find.ForeColor = System.Drawing.Color.White;
            this.btn_Find.Image = ((System.Drawing.Image)(resources.GetObject("btn_Find.Image")));
            this.btn_Find.ImagePosition = 14;
            this.btn_Find.ImageZoom = 30;
            this.btn_Find.LabelPosition = 29;
            this.btn_Find.LabelText = "Find";
            this.btn_Find.Location = new System.Drawing.Point(608, 1);
            this.btn_Find.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_Find.Name = "btn_Find";
            this.btn_Find.Size = new System.Drawing.Size(88, 75);
            this.btn_Find.TabIndex = 94;
            this.btn_Find.Click += new System.EventHandler(this.btn_Find_Click);
            // 
            // btn_Export
            // 
            this.btn_Export.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Export.BackColor = System.Drawing.Color.Transparent;
            this.btn_Export.color = System.Drawing.Color.Transparent;
            this.btn_Export.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(25)))), ((int)(((byte)(198)))));
            this.btn_Export.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Export.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Export.ForeColor = System.Drawing.Color.White;
            this.btn_Export.Image = ((System.Drawing.Image)(resources.GetObject("btn_Export.Image")));
            this.btn_Export.ImagePosition = 14;
            this.btn_Export.ImageZoom = 30;
            this.btn_Export.LabelPosition = 29;
            this.btn_Export.LabelText = "Export";
            this.btn_Export.Location = new System.Drawing.Point(430, 0);
            this.btn_Export.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_Export.Name = "btn_Export";
            this.btn_Export.Size = new System.Drawing.Size(88, 75);
            this.btn_Export.TabIndex = 93;
            this.btn_Export.Click += new System.EventHandler(this.btn_Export_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Delete.BackColor = System.Drawing.Color.Transparent;
            this.btn_Delete.color = System.Drawing.Color.Transparent;
            this.btn_Delete.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(25)))), ((int)(((byte)(198)))));
            this.btn_Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Delete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.ForeColor = System.Drawing.Color.White;
            this.btn_Delete.Image = ((System.Drawing.Image)(resources.GetObject("btn_Delete.Image")));
            this.btn_Delete.ImagePosition = 14;
            this.btn_Delete.ImageZoom = 30;
            this.btn_Delete.LabelPosition = 29;
            this.btn_Delete.LabelText = "Delete";
            this.btn_Delete.Location = new System.Drawing.Point(245, 0);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(88, 75);
            this.btn_Delete.TabIndex = 92;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // uct_History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(58)))));
            this.Controls.Add(this.gradient1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "uct_History";
            this.Size = new System.Drawing.Size(1056, 577);
            this.Load += new System.EventHandler(this.uct_History_Load);
            this.gradient1.ResumeLayout(false);
            this.gradient1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbud_PhanTrang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Gradient gradient1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lb_soluong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nbud_PhanTrang;
        private Bunifu.Framework.UI.BunifuTileButton btn_Find;
        private Bunifu.Framework.UI.BunifuTileButton btn_Export;
        private Bunifu.Framework.UI.BunifuTileButton btn_Delete;
        private gridViewLinear dtgvHistory;
        private Bunifu.Framework.UI.BunifuDatepicker dtpkdate;
    }
}
