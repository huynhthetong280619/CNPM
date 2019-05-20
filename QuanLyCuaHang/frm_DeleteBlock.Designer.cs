namespace QuanLyCuaHang
{
    partial class frm_DeleteBlock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_DeleteBlock));
            this.gradient1 = new QuanLyCuaHang.Gradient();
            this.btnExit = new QuanLyCuaHang.CircleButton();
            this.circleButton3 = new QuanLyCuaHang.CircleButton();
            this.circleButton2 = new QuanLyCuaHang.CircleButton();
            this.btn_movedelete = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cmbox_block = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gradient1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gradient1
            // 
            this.gradient1.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(12)))), ((int)(((byte)(41)))));
            this.gradient1.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(43)))), ((int)(((byte)(99)))));
            this.gradient1.Controls.Add(this.btnExit);
            this.gradient1.Controls.Add(this.circleButton3);
            this.gradient1.Controls.Add(this.circleButton2);
            this.gradient1.Controls.Add(this.btn_movedelete);
            this.gradient1.Controls.Add(this.cmbox_block);
            this.gradient1.Controls.Add(this.label4);
            this.gradient1.Controls.Add(this.label6);
            this.gradient1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradient1.Location = new System.Drawing.Point(0, 0);
            this.gradient1.Name = "gradient1";
            this.gradient1.Size = new System.Drawing.Size(549, 251);
            this.gradient1.TabIndex = 0;
            this.gradient1.Paint += new System.Windows.Forms.PaintEventHandler(this.ptb_Exit_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(531, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(15, 15);
            this.btnExit.TabIndex = 119;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.ptb_Exit_Click);
            // 
            // circleButton3
            // 
            this.circleButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(255)))));
            this.circleButton3.FlatAppearance.BorderSize = 0;
            this.circleButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circleButton3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circleButton3.ForeColor = System.Drawing.Color.White;
            this.circleButton3.Location = new System.Drawing.Point(489, 3);
            this.circleButton3.Name = "circleButton3";
            this.circleButton3.Size = new System.Drawing.Size(15, 15);
            this.circleButton3.TabIndex = 120;
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
            this.circleButton2.Location = new System.Drawing.Point(510, 3);
            this.circleButton2.Name = "circleButton2";
            this.circleButton2.Size = new System.Drawing.Size(15, 15);
            this.circleButton2.TabIndex = 121;
            this.circleButton2.UseVisualStyleBackColor = false;
            // 
            // btn_movedelete
            // 
            this.btn_movedelete.Active = false;
            this.btn_movedelete.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(48)))), ((int)(((byte)(69)))));
            this.btn_movedelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(53)))), ((int)(((byte)(91)))));
            this.btn_movedelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_movedelete.BorderRadius = -20;
            this.btn_movedelete.ButtonText = "MOVE AND DELETE BLOCK";
            this.btn_movedelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_movedelete.DisabledColor = System.Drawing.Color.Gray;
            this.btn_movedelete.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_movedelete.Iconimage = null;
            this.btn_movedelete.Iconimage_right = null;
            this.btn_movedelete.Iconimage_right_Selected = null;
            this.btn_movedelete.Iconimage_Selected = null;
            this.btn_movedelete.IconMarginLeft = 0;
            this.btn_movedelete.IconMarginRight = 0;
            this.btn_movedelete.IconRightVisible = true;
            this.btn_movedelete.IconRightZoom = 0D;
            this.btn_movedelete.IconVisible = true;
            this.btn_movedelete.IconZoom = 40D;
            this.btn_movedelete.IsTab = false;
            this.btn_movedelete.Location = new System.Drawing.Point(173, 153);
            this.btn_movedelete.Name = "btn_movedelete";
            this.btn_movedelete.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(53)))), ((int)(((byte)(91)))));
            this.btn_movedelete.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(48)))), ((int)(((byte)(69)))));
            this.btn_movedelete.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_movedelete.selected = false;
            this.btn_movedelete.Size = new System.Drawing.Size(202, 48);
            this.btn_movedelete.TabIndex = 112;
            this.btn_movedelete.Text = "MOVE AND DELETE BLOCK";
            this.btn_movedelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_movedelete.Textcolor = System.Drawing.Color.White;
            this.btn_movedelete.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_movedelete.Click += new System.EventHandler(this.btn_movedelete_Click);
            // 
            // cmbox_block
            // 
            this.cmbox_block.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbox_block.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbox_block.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbox_block.FormattingEnabled = true;
            this.cmbox_block.Location = new System.Drawing.Point(159, 94);
            this.cmbox_block.Name = "cmbox_block";
            this.cmbox_block.Size = new System.Drawing.Size(283, 29);
            this.cmbox_block.TabIndex = 111;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(48, 97);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 21);
            this.label4.TabIndex = 110;
            this.label4.Text = "ID Block:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(181, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(249, 37);
            this.label6.TabIndex = 109;
            this.label6.Text = "CHỌN KHO HÀNG";
            // 
            // frm_DeleteBlock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(549, 251);
            this.Controls.Add(this.gradient1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_DeleteBlock";
            this.Text = "frm_DeleteBlock";
            this.Load += new System.EventHandler(this.frm_DeleteBlock_Load);
            this.gradient1.ResumeLayout(false);
            this.gradient1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Gradient gradient1;
        private Bunifu.Framework.UI.BunifuFlatButton btn_movedelete;
        private System.Windows.Forms.ComboBox cmbox_block;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private CircleButton btnExit;
        private CircleButton circleButton3;
        private CircleButton circleButton2;
    }
}