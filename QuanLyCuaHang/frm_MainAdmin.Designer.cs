namespace QuanLyCuaHang
{
    partial class frm_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Main));
            this.pnl_Bar = new System.Windows.Forms.Panel();
            this.btn_Exit = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_Minisize = new Bunifu.Framework.UI.BunifuImageButton();
            this.lbl_Position = new System.Windows.Forms.Label();
            this.lbl_IconPosition = new System.Windows.Forms.PictureBox();
            this.pnl_Menu = new System.Windows.Forms.Panel();
            this.gradient1 = new QuanLyCuaHang.Gradient();
            this.btnBackupPassword = new System.Windows.Forms.PictureBox();
            this.ptcInfor = new System.Windows.Forms.PictureBox();
            this.ptbSale = new System.Windows.Forms.PictureBox();
            this.ptcChat = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Info = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Help = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Customer = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Employee = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Logout = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_History = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Product = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Profile = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Depot = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pnl_Main = new QuanLyCuaHang.Gradient();
            this.pnl_Bar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Minisize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_IconPosition)).BeginInit();
            this.pnl_Menu.SuspendLayout();
            this.gradient1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBackupPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptcInfor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptcChat)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Bar
            // 
            this.pnl_Bar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.pnl_Bar.Controls.Add(this.btn_Exit);
            this.pnl_Bar.Controls.Add(this.btn_Minisize);
            this.pnl_Bar.Controls.Add(this.lbl_Position);
            this.pnl_Bar.Controls.Add(this.lbl_IconPosition);
            this.pnl_Bar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Bar.Location = new System.Drawing.Point(0, 0);
            this.pnl_Bar.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_Bar.Name = "pnl_Bar";
            this.pnl_Bar.Size = new System.Drawing.Size(1265, 46);
            this.pnl_Bar.TabIndex = 1;
            this.pnl_Bar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_Bar_MouseDown);
            this.pnl_Bar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_Bar_MouseMove);
            this.pnl_Bar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnl_Bar_MouseUp);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Image = ((System.Drawing.Image)(resources.GetObject("btn_Exit.Image")));
            this.btn_Exit.ImageActive = null;
            this.btn_Exit.Location = new System.Drawing.Point(1235, 12);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(19, 20);
            this.btn_Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Exit.TabIndex = 28;
            this.btn_Exit.TabStop = false;
            this.btn_Exit.Zoom = 10;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // btn_Minisize
            // 
            this.btn_Minisize.Image = ((System.Drawing.Image)(resources.GetObject("btn_Minisize.Image")));
            this.btn_Minisize.ImageActive = null;
            this.btn_Minisize.Location = new System.Drawing.Point(1208, 12);
            this.btn_Minisize.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Minisize.Name = "btn_Minisize";
            this.btn_Minisize.Size = new System.Drawing.Size(22, 24);
            this.btn_Minisize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Minisize.TabIndex = 4;
            this.btn_Minisize.TabStop = false;
            this.btn_Minisize.Zoom = 10;
            this.btn_Minisize.Click += new System.EventHandler(this.btn_Minisize_Click);
            // 
            // lbl_Position
            // 
            this.lbl_Position.AutoSize = true;
            this.lbl_Position.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Position.ForeColor = System.Drawing.Color.White;
            this.lbl_Position.Location = new System.Drawing.Point(38, 10);
            this.lbl_Position.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Position.Name = "lbl_Position";
            this.lbl_Position.Size = new System.Drawing.Size(147, 22);
            this.lbl_Position.TabIndex = 1;
            this.lbl_Position.Text = "Position: Admin";
            this.lbl_Position.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_Bar_MouseDown);
            this.lbl_Position.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_Bar_MouseMove);
            this.lbl_Position.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnl_Bar_MouseUp);
            // 
            // lbl_IconPosition
            // 
            this.lbl_IconPosition.Image = global::QuanLyCuaHang.Properties.Resources.xx;
            this.lbl_IconPosition.Location = new System.Drawing.Point(2, 3);
            this.lbl_IconPosition.Margin = new System.Windows.Forms.Padding(2);
            this.lbl_IconPosition.Name = "lbl_IconPosition";
            this.lbl_IconPosition.Size = new System.Drawing.Size(40, 36);
            this.lbl_IconPosition.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lbl_IconPosition.TabIndex = 0;
            this.lbl_IconPosition.TabStop = false;
            this.lbl_IconPosition.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_Bar_MouseDown);
            this.lbl_IconPosition.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_Bar_MouseMove);
            this.lbl_IconPosition.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnl_Bar_MouseUp);
            // 
            // pnl_Menu
            // 
            this.pnl_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.pnl_Menu.Controls.Add(this.gradient1);
            this.pnl_Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_Menu.Location = new System.Drawing.Point(0, 46);
            this.pnl_Menu.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_Menu.Name = "pnl_Menu";
            this.pnl_Menu.Size = new System.Drawing.Size(209, 577);
            this.pnl_Menu.TabIndex = 0;
            // 
            // gradient1
            // 
            this.gradient1.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(12)))), ((int)(((byte)(41)))));
            this.gradient1.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(43)))), ((int)(((byte)(99)))));
            this.gradient1.Controls.Add(this.btnBackupPassword);
            this.gradient1.Controls.Add(this.ptcInfor);
            this.gradient1.Controls.Add(this.ptbSale);
            this.gradient1.Controls.Add(this.ptcChat);
            this.gradient1.Controls.Add(this.panel1);
            this.gradient1.Controls.Add(this.btn_Info);
            this.gradient1.Controls.Add(this.btn_Help);
            this.gradient1.Controls.Add(this.btn_Customer);
            this.gradient1.Controls.Add(this.btn_Employee);
            this.gradient1.Controls.Add(this.btn_Logout);
            this.gradient1.Controls.Add(this.btn_History);
            this.gradient1.Controls.Add(this.btn_Product);
            this.gradient1.Controls.Add(this.btn_Profile);
            this.gradient1.Controls.Add(this.btn_Depot);
            this.gradient1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gradient1.Location = new System.Drawing.Point(0, 0);
            this.gradient1.Name = "gradient1";
            this.gradient1.Size = new System.Drawing.Size(209, 577);
            this.gradient1.TabIndex = 0;
            // 
            // btnBackupPassword
            // 
            this.btnBackupPassword.BackColor = System.Drawing.Color.Transparent;
            this.btnBackupPassword.Image = global::QuanLyCuaHang.Properties.Resources.key;
            this.btnBackupPassword.Location = new System.Drawing.Point(167, 102);
            this.btnBackupPassword.Name = "btnBackupPassword";
            this.btnBackupPassword.Size = new System.Drawing.Size(27, 27);
            this.btnBackupPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnBackupPassword.TabIndex = 29;
            this.btnBackupPassword.TabStop = false;
            this.btnBackupPassword.Click += new System.EventHandler(this.btnBackupPassword_Click);
            // 
            // ptcInfor
            // 
            this.ptcInfor.BackColor = System.Drawing.Color.Transparent;
            this.ptcInfor.Image = global::QuanLyCuaHang.Properties.Resources.png;
            this.ptcInfor.Location = new System.Drawing.Point(167, 69);
            this.ptcInfor.Name = "ptcInfor";
            this.ptcInfor.Size = new System.Drawing.Size(27, 27);
            this.ptcInfor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptcInfor.TabIndex = 29;
            this.ptcInfor.TabStop = false;
            this.ptcInfor.Click += new System.EventHandler(this.ptcInfor_Click);
            // 
            // ptbSale
            // 
            this.ptbSale.BackColor = System.Drawing.Color.Transparent;
            this.ptbSale.Image = global::QuanLyCuaHang.Properties.Resources.sale;
            this.ptbSale.Location = new System.Drawing.Point(167, 5);
            this.ptbSale.Name = "ptbSale";
            this.ptbSale.Size = new System.Drawing.Size(27, 27);
            this.ptbSale.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbSale.TabIndex = 29;
            this.ptbSale.TabStop = false;
            this.ptbSale.Click += new System.EventHandler(this.ptbSale_Click);
            // 
            // ptcChat
            // 
            this.ptcChat.BackColor = System.Drawing.Color.Transparent;
            this.ptcChat.Image = global::QuanLyCuaHang.Properties.Resources.iconfinder_Facebook_Messenger_1298720;
            this.ptcChat.Location = new System.Drawing.Point(167, 36);
            this.ptcChat.Name = "ptcChat";
            this.ptcChat.Size = new System.Drawing.Size(27, 27);
            this.ptcChat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptcChat.TabIndex = 29;
            this.ptcChat.TabStop = false;
            this.ptcChat.Click += new System.EventHandler(this.ptcChat_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::QuanLyCuaHang.Properties.Resources.xx;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(21, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(131, 131);
            this.panel1.TabIndex = 24;
            // 
            // btn_Info
            // 
            this.btn_Info.Active = false;
            this.btn_Info.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(206)))));
            this.btn_Info.BackColor = System.Drawing.Color.Transparent;
            this.btn_Info.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Info.BorderRadius = 0;
            this.btn_Info.ButtonText = "    Report";
            this.btn_Info.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Info.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Info.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Info.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Info.Iconimage")));
            this.btn_Info.Iconimage_right = null;
            this.btn_Info.Iconimage_right_Selected = null;
            this.btn_Info.Iconimage_Selected = null;
            this.btn_Info.IconMarginLeft = 0;
            this.btn_Info.IconMarginRight = 0;
            this.btn_Info.IconRightVisible = true;
            this.btn_Info.IconRightZoom = 0D;
            this.btn_Info.IconVisible = true;
            this.btn_Info.IconZoom = 40D;
            this.btn_Info.IsTab = true;
            this.btn_Info.Location = new System.Drawing.Point(2, 478);
            this.btn_Info.Name = "btn_Info";
            this.btn_Info.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_Info.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(206)))));
            this.btn_Info.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Info.selected = false;
            this.btn_Info.Size = new System.Drawing.Size(207, 48);
            this.btn_Info.TabIndex = 19;
            this.btn_Info.Text = "    Report";
            this.btn_Info.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Info.Textcolor = System.Drawing.Color.White;
            this.btn_Info.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Info.Click += new System.EventHandler(this.btn_Info_Click);
            // 
            // btn_Help
            // 
            this.btn_Help.Active = false;
            this.btn_Help.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(206)))));
            this.btn_Help.BackColor = System.Drawing.Color.Transparent;
            this.btn_Help.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Help.BorderRadius = 0;
            this.btn_Help.ButtonText = "    Notification";
            this.btn_Help.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Help.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Help.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Help.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Help.Iconimage")));
            this.btn_Help.Iconimage_right = null;
            this.btn_Help.Iconimage_right_Selected = null;
            this.btn_Help.Iconimage_Selected = null;
            this.btn_Help.IconMarginLeft = 0;
            this.btn_Help.IconMarginRight = 0;
            this.btn_Help.IconRightVisible = true;
            this.btn_Help.IconRightZoom = 0D;
            this.btn_Help.IconVisible = true;
            this.btn_Help.IconZoom = 40D;
            this.btn_Help.IsTab = true;
            this.btn_Help.Location = new System.Drawing.Point(2, 430);
            this.btn_Help.Name = "btn_Help";
            this.btn_Help.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_Help.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(206)))));
            this.btn_Help.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Help.selected = false;
            this.btn_Help.Size = new System.Drawing.Size(207, 48);
            this.btn_Help.TabIndex = 18;
            this.btn_Help.Text = "    Notification";
            this.btn_Help.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Help.Textcolor = System.Drawing.Color.White;
            this.btn_Help.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Help.Click += new System.EventHandler(this.btn_Help_Click);
            // 
            // btn_Customer
            // 
            this.btn_Customer.Active = false;
            this.btn_Customer.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(206)))));
            this.btn_Customer.BackColor = System.Drawing.Color.Transparent;
            this.btn_Customer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Customer.BorderRadius = 0;
            this.btn_Customer.ButtonText = "    Customer";
            this.btn_Customer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Customer.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Customer.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Customer.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Customer.Iconimage")));
            this.btn_Customer.Iconimage_right = null;
            this.btn_Customer.Iconimage_right_Selected = null;
            this.btn_Customer.Iconimage_Selected = null;
            this.btn_Customer.IconMarginLeft = 0;
            this.btn_Customer.IconMarginRight = 0;
            this.btn_Customer.IconRightVisible = true;
            this.btn_Customer.IconRightZoom = 0D;
            this.btn_Customer.IconVisible = true;
            this.btn_Customer.IconZoom = 40D;
            this.btn_Customer.IsTab = true;
            this.btn_Customer.Location = new System.Drawing.Point(2, 286);
            this.btn_Customer.Name = "btn_Customer";
            this.btn_Customer.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_Customer.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(206)))));
            this.btn_Customer.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Customer.selected = false;
            this.btn_Customer.Size = new System.Drawing.Size(207, 48);
            this.btn_Customer.TabIndex = 17;
            this.btn_Customer.Text = "    Customer";
            this.btn_Customer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Customer.Textcolor = System.Drawing.Color.White;
            this.btn_Customer.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Customer.Click += new System.EventHandler(this.btn_Customer_Click);
            // 
            // btn_Employee
            // 
            this.btn_Employee.Active = false;
            this.btn_Employee.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(206)))));
            this.btn_Employee.BackColor = System.Drawing.Color.Transparent;
            this.btn_Employee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Employee.BorderRadius = 0;
            this.btn_Employee.ButtonText = "    Employee";
            this.btn_Employee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Employee.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Employee.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Employee.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Employee.Iconimage")));
            this.btn_Employee.Iconimage_right = null;
            this.btn_Employee.Iconimage_right_Selected = null;
            this.btn_Employee.Iconimage_Selected = null;
            this.btn_Employee.IconMarginLeft = 0;
            this.btn_Employee.IconMarginRight = 0;
            this.btn_Employee.IconRightVisible = true;
            this.btn_Employee.IconRightZoom = 0D;
            this.btn_Employee.IconVisible = true;
            this.btn_Employee.IconZoom = 40D;
            this.btn_Employee.IsTab = true;
            this.btn_Employee.Location = new System.Drawing.Point(2, 190);
            this.btn_Employee.Name = "btn_Employee";
            this.btn_Employee.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_Employee.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(206)))));
            this.btn_Employee.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Employee.selected = false;
            this.btn_Employee.Size = new System.Drawing.Size(207, 48);
            this.btn_Employee.TabIndex = 14;
            this.btn_Employee.Text = "    Employee";
            this.btn_Employee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Employee.Textcolor = System.Drawing.Color.White;
            this.btn_Employee.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Employee.Click += new System.EventHandler(this.btn_Employee_Click);
            // 
            // btn_Logout
            // 
            this.btn_Logout.Active = false;
            this.btn_Logout.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(206)))));
            this.btn_Logout.BackColor = System.Drawing.Color.Transparent;
            this.btn_Logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Logout.BorderRadius = 0;
            this.btn_Logout.ButtonText = "    Logout";
            this.btn_Logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Logout.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Logout.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Logout.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Logout.Iconimage")));
            this.btn_Logout.Iconimage_right = null;
            this.btn_Logout.Iconimage_right_Selected = null;
            this.btn_Logout.Iconimage_Selected = null;
            this.btn_Logout.IconMarginLeft = 0;
            this.btn_Logout.IconMarginRight = 0;
            this.btn_Logout.IconRightVisible = true;
            this.btn_Logout.IconRightZoom = 0D;
            this.btn_Logout.IconVisible = true;
            this.btn_Logout.IconZoom = 40D;
            this.btn_Logout.IsTab = true;
            this.btn_Logout.Location = new System.Drawing.Point(2, 526);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_Logout.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(206)))));
            this.btn_Logout.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Logout.selected = false;
            this.btn_Logout.Size = new System.Drawing.Size(207, 48);
            this.btn_Logout.TabIndex = 21;
            this.btn_Logout.Text = "    Logout";
            this.btn_Logout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Logout.Textcolor = System.Drawing.Color.White;
            this.btn_Logout.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // btn_History
            // 
            this.btn_History.Active = false;
            this.btn_History.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(206)))));
            this.btn_History.BackColor = System.Drawing.Color.Transparent;
            this.btn_History.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_History.BorderRadius = 0;
            this.btn_History.ButtonText = "    History";
            this.btn_History.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_History.DisabledColor = System.Drawing.Color.Gray;
            this.btn_History.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_History.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_History.Iconimage")));
            this.btn_History.Iconimage_right = null;
            this.btn_History.Iconimage_right_Selected = null;
            this.btn_History.Iconimage_Selected = null;
            this.btn_History.IconMarginLeft = 0;
            this.btn_History.IconMarginRight = 0;
            this.btn_History.IconRightVisible = true;
            this.btn_History.IconRightZoom = 0D;
            this.btn_History.IconVisible = true;
            this.btn_History.IconZoom = 40D;
            this.btn_History.IsTab = true;
            this.btn_History.Location = new System.Drawing.Point(2, 382);
            this.btn_History.Name = "btn_History";
            this.btn_History.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_History.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(206)))));
            this.btn_History.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_History.selected = false;
            this.btn_History.Size = new System.Drawing.Size(207, 48);
            this.btn_History.TabIndex = 23;
            this.btn_History.Text = "    History";
            this.btn_History.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_History.Textcolor = System.Drawing.Color.White;
            this.btn_History.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_History.Click += new System.EventHandler(this.btn_History_Click);
            // 
            // btn_Product
            // 
            this.btn_Product.Active = false;
            this.btn_Product.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(206)))));
            this.btn_Product.BackColor = System.Drawing.Color.Transparent;
            this.btn_Product.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Product.BorderRadius = 0;
            this.btn_Product.ButtonText = "    Product";
            this.btn_Product.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Product.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Product.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Product.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Product.Iconimage")));
            this.btn_Product.Iconimage_right = null;
            this.btn_Product.Iconimage_right_Selected = null;
            this.btn_Product.Iconimage_Selected = null;
            this.btn_Product.IconMarginLeft = 0;
            this.btn_Product.IconMarginRight = 0;
            this.btn_Product.IconRightVisible = true;
            this.btn_Product.IconRightZoom = 0D;
            this.btn_Product.IconVisible = true;
            this.btn_Product.IconZoom = 40D;
            this.btn_Product.IsTab = true;
            this.btn_Product.Location = new System.Drawing.Point(2, 238);
            this.btn_Product.Name = "btn_Product";
            this.btn_Product.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_Product.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(206)))));
            this.btn_Product.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Product.selected = false;
            this.btn_Product.Size = new System.Drawing.Size(207, 48);
            this.btn_Product.TabIndex = 16;
            this.btn_Product.Text = "    Product";
            this.btn_Product.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Product.Textcolor = System.Drawing.Color.White;
            this.btn_Product.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Product.Click += new System.EventHandler(this.btn_Product_Click);
            // 
            // btn_Profile
            // 
            this.btn_Profile.Active = true;
            this.btn_Profile.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(206)))));
            this.btn_Profile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(206)))));
            this.btn_Profile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Profile.BorderRadius = 0;
            this.btn_Profile.ButtonText = "    Profile";
            this.btn_Profile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Profile.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Profile.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Profile.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Profile.Iconimage")));
            this.btn_Profile.Iconimage_right = null;
            this.btn_Profile.Iconimage_right_Selected = null;
            this.btn_Profile.Iconimage_Selected = null;
            this.btn_Profile.IconMarginLeft = 0;
            this.btn_Profile.IconMarginRight = 0;
            this.btn_Profile.IconRightVisible = true;
            this.btn_Profile.IconRightZoom = 0D;
            this.btn_Profile.IconVisible = true;
            this.btn_Profile.IconZoom = 40D;
            this.btn_Profile.IsTab = true;
            this.btn_Profile.Location = new System.Drawing.Point(2, 138);
            this.btn_Profile.Name = "btn_Profile";
            this.btn_Profile.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_Profile.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(206)))));
            this.btn_Profile.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Profile.selected = true;
            this.btn_Profile.Size = new System.Drawing.Size(207, 48);
            this.btn_Profile.TabIndex = 15;
            this.btn_Profile.Text = "    Profile";
            this.btn_Profile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Profile.Textcolor = System.Drawing.Color.White;
            this.btn_Profile.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Profile.Click += new System.EventHandler(this.btn_Profile_Click);
            // 
            // btn_Depot
            // 
            this.btn_Depot.Active = false;
            this.btn_Depot.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(206)))));
            this.btn_Depot.BackColor = System.Drawing.Color.Transparent;
            this.btn_Depot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Depot.BorderRadius = 0;
            this.btn_Depot.ButtonText = "    Block";
            this.btn_Depot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Depot.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Depot.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Depot.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Depot.Iconimage")));
            this.btn_Depot.Iconimage_right = null;
            this.btn_Depot.Iconimage_right_Selected = null;
            this.btn_Depot.Iconimage_Selected = null;
            this.btn_Depot.IconMarginLeft = 0;
            this.btn_Depot.IconMarginRight = 0;
            this.btn_Depot.IconRightVisible = true;
            this.btn_Depot.IconRightZoom = 0D;
            this.btn_Depot.IconVisible = true;
            this.btn_Depot.IconZoom = 40D;
            this.btn_Depot.IsTab = true;
            this.btn_Depot.Location = new System.Drawing.Point(2, 334);
            this.btn_Depot.Name = "btn_Depot";
            this.btn_Depot.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_Depot.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(206)))));
            this.btn_Depot.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Depot.selected = false;
            this.btn_Depot.Size = new System.Drawing.Size(207, 48);
            this.btn_Depot.TabIndex = 22;
            this.btn_Depot.Text = "    Block";
            this.btn_Depot.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Depot.Textcolor = System.Drawing.Color.White;
            this.btn_Depot.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Depot.Click += new System.EventHandler(this.btn_Depot_Click);
            // 
            // pnl_Main
            // 
            this.pnl_Main.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(12)))), ((int)(((byte)(41)))));
            this.pnl_Main.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(43)))), ((int)(((byte)(99)))));
            this.pnl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Main.Location = new System.Drawing.Point(209, 46);
            this.pnl_Main.Name = "pnl_Main";
            this.pnl_Main.Size = new System.Drawing.Size(1056, 577);
            this.pnl_Main.TabIndex = 2;
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(1265, 623);
            this.Controls.Add(this.pnl_Main);
            this.Controls.Add(this.pnl_Menu);
            this.Controls.Add(this.pnl_Bar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pnl_Bar.ResumeLayout(false);
            this.pnl_Bar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Minisize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_IconPosition)).EndInit();
            this.pnl_Menu.ResumeLayout(false);
            this.gradient1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnBackupPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptcInfor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptcChat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnl_Bar;
        private System.Windows.Forms.PictureBox lbl_IconPosition;
        private System.Windows.Forms.Label lbl_Position;
        private Bunifu.Framework.UI.BunifuImageButton btn_Minisize;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Info;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Help;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Customer;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Product;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Employee;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Profile;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Logout;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Depot;
        private Bunifu.Framework.UI.BunifuImageButton btn_Exit;
        private Bunifu.Framework.UI.BunifuFlatButton btn_History;
        private System.Windows.Forms.PictureBox ptcChat;
        private Gradient pnl_Main;
        private System.Windows.Forms.Panel pnl_Menu;
        private Gradient gradient1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox ptcInfor;
        private System.Windows.Forms.PictureBox ptbSale;
        private System.Windows.Forms.PictureBox btnBackupPassword;
    }
}

