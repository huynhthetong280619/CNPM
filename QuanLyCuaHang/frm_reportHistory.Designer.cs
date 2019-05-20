namespace QuanLyCuaHang
{
    partial class frm_reportHistory
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_reportHistory));
            this.BANG_KHACHHANGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QUANLYSHOPDataSet = new QuanLyCuaHang.QUANLYSHOPDataSet();
            this.BANG_KHACHHANGTableAdapter = new QuanLyCuaHang.QUANLYSHOPDataSetTableAdapters.BANG_KHACHHANGTableAdapter();
            this.gradient1 = new QuanLyCuaHang.Gradient();
            this.label1 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnExit = new QuanLyCuaHang.CircleButton();
            this.circleButton3 = new QuanLyCuaHang.CircleButton();
            this.circleButton2 = new QuanLyCuaHang.CircleButton();
            ((System.ComponentModel.ISupportInitialize)(this.BANG_KHACHHANGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QUANLYSHOPDataSet)).BeginInit();
            this.gradient1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BANG_KHACHHANGBindingSource
            // 
            this.BANG_KHACHHANGBindingSource.DataMember = "BANG_KHACHHANG";
            this.BANG_KHACHHANGBindingSource.DataSource = this.QUANLYSHOPDataSet;
            // 
            // QUANLYSHOPDataSet
            // 
            this.QUANLYSHOPDataSet.DataSetName = "QUANLYSHOPDataSet";
            this.QUANLYSHOPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BANG_KHACHHANGTableAdapter
            // 
            this.BANG_KHACHHANGTableAdapter.ClearBeforeFill = true;
            // 
            // gradient1
            // 
            this.gradient1.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(12)))), ((int)(((byte)(41)))));
            this.gradient1.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(43)))), ((int)(((byte)(99)))));
            this.gradient1.Controls.Add(this.label1);
            this.gradient1.Controls.Add(this.reportViewer1);
            this.gradient1.Controls.Add(this.btnExit);
            this.gradient1.Controls.Add(this.circleButton3);
            this.gradient1.Controls.Add(this.circleButton2);
            this.gradient1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradient1.Location = new System.Drawing.Point(0, 0);
            this.gradient1.Name = "gradient1";
            this.gradient1.Size = new System.Drawing.Size(831, 623);
            this.gradient1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(214, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(394, 37);
            this.label1.TabIndex = 102;
            this.label1.Text = "REPORT TABLE KHÁCH HÀNG";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.BANG_KHACHHANGBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyCuaHang.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 93);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(798, 518);
            this.reportViewer1.TabIndex = 101;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(809, 15);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(15, 15);
            this.btnExit.TabIndex = 98;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // circleButton3
            // 
            this.circleButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(255)))));
            this.circleButton3.FlatAppearance.BorderSize = 0;
            this.circleButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circleButton3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circleButton3.ForeColor = System.Drawing.Color.White;
            this.circleButton3.Location = new System.Drawing.Point(767, 15);
            this.circleButton3.Name = "circleButton3";
            this.circleButton3.Size = new System.Drawing.Size(15, 15);
            this.circleButton3.TabIndex = 99;
            this.circleButton3.UseVisualStyleBackColor = false;
            this.circleButton3.Click += new System.EventHandler(this.circleButton3_Click);
            // 
            // circleButton2
            // 
            this.circleButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.circleButton2.FlatAppearance.BorderSize = 0;
            this.circleButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circleButton2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circleButton2.ForeColor = System.Drawing.Color.White;
            this.circleButton2.Location = new System.Drawing.Point(788, 15);
            this.circleButton2.Name = "circleButton2";
            this.circleButton2.Size = new System.Drawing.Size(15, 15);
            this.circleButton2.TabIndex = 100;
            this.circleButton2.UseVisualStyleBackColor = false;
            // 
            // frm_reportHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 623);
            this.Controls.Add(this.gradient1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_reportHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_reportHistory";
            this.Load += new System.EventHandler(this.frm_reportHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BANG_KHACHHANGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QUANLYSHOPDataSet)).EndInit();
            this.gradient1.ResumeLayout(false);
            this.gradient1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Gradient gradient1;
        private CircleButton btnExit;
        private CircleButton circleButton3;
        private CircleButton circleButton2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource BANG_KHACHHANGBindingSource;
        private QUANLYSHOPDataSet QUANLYSHOPDataSet;
        private QUANLYSHOPDataSetTableAdapters.BANG_KHACHHANGTableAdapter BANG_KHACHHANGTableAdapter;
        private System.Windows.Forms.Label label1;
    }
}