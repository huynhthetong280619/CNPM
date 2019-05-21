namespace QuanLyCuaHang
{
    partial class uct_backuppass
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
            this.btnSend = new System.Windows.Forms.Button();
            this.tbx_sodienthoai = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tbx_To = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gradient1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gradient1
            // 
            this.gradient1.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(12)))), ((int)(((byte)(41)))));
            this.gradient1.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(43)))), ((int)(((byte)(99)))));
            this.gradient1.Controls.Add(this.btnSend);
            this.gradient1.Controls.Add(this.tbx_sodienthoai);
            this.gradient1.Controls.Add(this.tbx_To);
            this.gradient1.Controls.Add(this.label2);
            this.gradient1.Controls.Add(this.label1);
            this.gradient1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradient1.Location = new System.Drawing.Point(0, 0);
            this.gradient1.Name = "gradient1";
            this.gradient1.Size = new System.Drawing.Size(1056, 577);
            this.gradient1.TabIndex = 0;
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.Transparent;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.ForeColor = System.Drawing.Color.White;
            this.btnSend.Location = new System.Drawing.Point(490, 229);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(207, 53);
            this.btnSend.TabIndex = 10;
            this.btnSend.Text = "Send reset password";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // tbx_sodienthoai
            // 
            this.tbx_sodienthoai.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbx_sodienthoai.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbx_sodienthoai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(43)))), ((int)(((byte)(99)))));
            this.tbx_sodienthoai.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbx_sodienthoai.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbx_sodienthoai.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_sodienthoai.ForeColor = System.Drawing.Color.White;
            this.tbx_sodienthoai.HintForeColor = System.Drawing.Color.Empty;
            this.tbx_sodienthoai.HintText = "";
            this.tbx_sodienthoai.isPassword = false;
            this.tbx_sodienthoai.LineFocusedColor = System.Drawing.Color.Blue;
            this.tbx_sodienthoai.LineIdleColor = System.Drawing.Color.Gray;
            this.tbx_sodienthoai.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tbx_sodienthoai.LineThickness = 4;
            this.tbx_sodienthoai.Location = new System.Drawing.Point(414, 168);
            this.tbx_sodienthoai.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tbx_sodienthoai.MaxLength = 32767;
            this.tbx_sodienthoai.Name = "tbx_sodienthoai";
            this.tbx_sodienthoai.Size = new System.Drawing.Size(380, 41);
            this.tbx_sodienthoai.TabIndex = 8;
            this.tbx_sodienthoai.Text = "SỐ ĐIỆN THOẠI";
            this.tbx_sodienthoai.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tbx_To
            // 
            this.tbx_To.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbx_To.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbx_To.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(43)))), ((int)(((byte)(99)))));
            this.tbx_To.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbx_To.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbx_To.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_To.ForeColor = System.Drawing.Color.White;
            this.tbx_To.HintForeColor = System.Drawing.Color.Empty;
            this.tbx_To.HintText = "";
            this.tbx_To.isPassword = false;
            this.tbx_To.LineFocusedColor = System.Drawing.Color.Blue;
            this.tbx_To.LineIdleColor = System.Drawing.Color.Gray;
            this.tbx_To.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tbx_To.LineThickness = 4;
            this.tbx_To.Location = new System.Drawing.Point(414, 105);
            this.tbx_To.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tbx_To.MaxLength = 32767;
            this.tbx_To.Name = "tbx_To";
            this.tbx_To.Size = new System.Drawing.Size(380, 41);
            this.tbx_To.TabIndex = 9;
            this.tbx_To.Text = "Email";
            this.tbx_To.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(262, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "SỐ ĐIỆN THOẠI";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(262, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "EMAIL CẦN GỬI";
            // 
            // uct_backuppass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gradient1);
            this.Name = "uct_backuppass";
            this.Size = new System.Drawing.Size(1056, 577);
            this.gradient1.ResumeLayout(false);
            this.gradient1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Gradient gradient1;
        private System.Windows.Forms.Button btnSend;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbx_sodienthoai;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbx_To;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
