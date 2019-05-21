namespace QuanLyCuaHang
{
    partial class frm_MainEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_MainEmployee));
            this.btn_Exit = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_Minisize = new Bunifu.Framework.UI.BunifuImageButton();
            this.lbl_Position = new System.Windows.Forms.Label();
            this.lbl_IconPosition = new System.Windows.Forms.PictureBox();
            this.pnl_Menu1 = new System.Windows.Forms.Panel();
            this.pnl_Menu = new QuanLyCuaHang.Gradient();
            this.ptcChat = new System.Windows.Forms.PictureBox();
            this.btn_Help = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Product = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Notification = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Logout = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Sell = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Profile = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pnl_Bar = new System.Windows.Forms.Panel();
            this.pnl_Main = new QuanLyCuaHang.Gradient();
            this.ViewDetail = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Minisize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_IconPosition)).BeginInit();
            this.pnl_Menu1.SuspendLayout();
            this.pnl_Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptcChat)).BeginInit();
            this.pnl_Bar.SuspendLayout();
            this.SuspendLayout();
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
            this.lbl_Position.Location = new System.Drawing.Point(47, 10);
            this.lbl_Position.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Position.Name = "lbl_Position";
            this.lbl_Position.Size = new System.Drawing.Size(177, 22);
            this.lbl_Position.TabIndex = 1;
            this.lbl_Position.Text = "Position: Employee";
            this.lbl_Position.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_Bar_MouseDown);
            this.lbl_Position.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_Bar_MouseMove);
            this.lbl_Position.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnl_Bar_MouseUp);
            // 
            // lbl_IconPosition
            // 
            this.lbl_IconPosition.Image = global::QuanLyCuaHang.Properties.Resources.xx;
            this.lbl_IconPosition.Location = new System.Drawing.Point(4, 3);
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
            // pnl_Menu1
            // 
            this.pnl_Menu1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.pnl_Menu1.Controls.Add(this.pnl_Menu);
            this.pnl_Menu1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_Menu1.Location = new System.Drawing.Point(0, 46);
            this.pnl_Menu1.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_Menu1.Name = "pnl_Menu1";
            this.pnl_Menu1.Size = new System.Drawing.Size(209, 577);
            this.pnl_Menu1.TabIndex = 3;
            // 
            // pnl_Menu
            // 
            this.pnl_Menu.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(12)))), ((int)(((byte)(41)))));
            this.pnl_Menu.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(43)))), ((int)(((byte)(99)))));
            this.pnl_Menu.Controls.Add(this.ptcChat);
            this.pnl_Menu.Controls.Add(this.btn_Help);
            this.pnl_Menu.Controls.Add(this.panel1);
            this.pnl_Menu.Controls.Add(this.btn_Product);
            this.pnl_Menu.Controls.Add(this.ViewDetail);
            this.pnl_Menu.Controls.Add(this.btn_Notification);
            this.pnl_Menu.Controls.Add(this.btn_Logout);
            this.pnl_Menu.Controls.Add(this.btn_Sell);
            this.pnl_Menu.Controls.Add(this.btn_Profile);
            this.pnl_Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_Menu.Location = new System.Drawing.Point(0, 0);
            this.pnl_Menu.Name = "pnl_Menu";
            this.pnl_Menu.Size = new System.Drawing.Size(209, 577);
            this.pnl_Menu.TabIndex = 0;
            // 
            // ptcChat
            // 
            this.ptcChat.BackColor = System.Drawing.Color.Transparent;
            this.ptcChat.Image = global::QuanLyCuaHang.Properties.Resources.iconfinder_Facebook_Messenger_1298720;
            this.ptcChat.Location = new System.Drawing.Point(158, 68);
            this.ptcChat.Name = "ptcChat";
            this.ptcChat.Size = new System.Drawing.Size(27, 27);
            this.ptcChat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptcChat.TabIndex = 33;
            this.ptcChat.TabStop = false;
            this.ptcChat.Click += new System.EventHandler(this.ptcChat_Click);
            // 
            // btn_Help
            // 
            this.btn_Help.Active = false;
            this.btn_Help.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(206)))));
            this.btn_Help.BackColor = System.Drawing.Color.Transparent;
            this.btn_Help.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Help.BorderRadius = 0;
            this.btn_Help.ButtonText = "    Information";
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
            this.btn_Help.Location = new System.Drawing.Point(1, 472);
            this.btn_Help.Name = "btn_Help";
            this.btn_Help.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_Help.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(206)))));
            this.btn_Help.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Help.selected = false;
            this.btn_Help.Size = new System.Drawing.Size(207, 48);
            this.btn_Help.TabIndex = 25;
            this.btn_Help.Text = "    Information";
            this.btn_Help.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Help.Textcolor = System.Drawing.Color.White;
            this.btn_Help.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Help.Click += new System.EventHandler(this.btn_Help_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::QuanLyCuaHang.Properties.Resources.xx;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(12, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(131, 131);
            this.panel1.TabIndex = 32;
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
            this.btn_Product.Location = new System.Drawing.Point(1, 255);
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
            // btn_Notification
            // 
            this.btn_Notification.Active = false;
            this.btn_Notification.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(206)))));
            this.btn_Notification.BackColor = System.Drawing.Color.Transparent;
            this.btn_Notification.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Notification.BorderRadius = 0;
            this.btn_Notification.ButtonText = "    Notification";
            this.btn_Notification.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Notification.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Notification.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Notification.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Notification.Iconimage")));
            this.btn_Notification.Iconimage_right = null;
            this.btn_Notification.Iconimage_right_Selected = null;
            this.btn_Notification.Iconimage_Selected = null;
            this.btn_Notification.IconMarginLeft = 0;
            this.btn_Notification.IconMarginRight = 0;
            this.btn_Notification.IconRightVisible = true;
            this.btn_Notification.IconRightZoom = 0D;
            this.btn_Notification.IconVisible = true;
            this.btn_Notification.IconZoom = 40D;
            this.btn_Notification.IsTab = true;
            this.btn_Notification.Location = new System.Drawing.Point(1, 417);
            this.btn_Notification.Name = "btn_Notification";
            this.btn_Notification.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_Notification.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(206)))));
            this.btn_Notification.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Notification.selected = false;
            this.btn_Notification.Size = new System.Drawing.Size(207, 48);
            this.btn_Notification.TabIndex = 23;
            this.btn_Notification.Text = "    Notification";
            this.btn_Notification.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Notification.Textcolor = System.Drawing.Color.White;
            this.btn_Notification.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Notification.Click += new System.EventHandler(this.btn_Notification_Click);
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
            this.btn_Logout.Location = new System.Drawing.Point(1, 526);
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
            // btn_Sell
            // 
            this.btn_Sell.Active = false;
            this.btn_Sell.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(206)))));
            this.btn_Sell.BackColor = System.Drawing.Color.Transparent;
            this.btn_Sell.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Sell.BorderRadius = 0;
            this.btn_Sell.ButtonText = "    Sell";
            this.btn_Sell.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Sell.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Sell.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Sell.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Sell.Iconimage")));
            this.btn_Sell.Iconimage_right = null;
            this.btn_Sell.Iconimage_right_Selected = null;
            this.btn_Sell.Iconimage_Selected = null;
            this.btn_Sell.IconMarginLeft = 0;
            this.btn_Sell.IconMarginRight = 0;
            this.btn_Sell.IconRightVisible = true;
            this.btn_Sell.IconRightZoom = 0D;
            this.btn_Sell.IconVisible = true;
            this.btn_Sell.IconZoom = 40D;
            this.btn_Sell.IsTab = true;
            this.btn_Sell.Location = new System.Drawing.Point(1, 309);
            this.btn_Sell.Name = "btn_Sell";
            this.btn_Sell.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_Sell.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(206)))));
            this.btn_Sell.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Sell.selected = false;
            this.btn_Sell.Size = new System.Drawing.Size(207, 48);
            this.btn_Sell.TabIndex = 24;
            this.btn_Sell.Text = "    Sell";
            this.btn_Sell.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Sell.Textcolor = System.Drawing.Color.White;
            this.btn_Sell.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sell.Click += new System.EventHandler(this.btn_Sell_Click);
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
            this.btn_Profile.Location = new System.Drawing.Point(1, 200);
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
            this.pnl_Bar.TabIndex = 4;
            this.pnl_Bar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_Bar_MouseDown);
            this.pnl_Bar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_Bar_MouseMove);
            this.pnl_Bar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnl_Bar_MouseUp);
            // 
            // pnl_Main
            // 
            this.pnl_Main.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(12)))), ((int)(((byte)(41)))));
            this.pnl_Main.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(43)))), ((int)(((byte)(99)))));
            this.pnl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Main.Location = new System.Drawing.Point(209, 46);
            this.pnl_Main.Name = "pnl_Main";
            this.pnl_Main.Size = new System.Drawing.Size(1056, 577);
            this.pnl_Main.TabIndex = 5;
            // 
            // ViewDetail
            // 
            this.ViewDetail.Active = false;
            this.ViewDetail.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(206)))));
            this.ViewDetail.BackColor = System.Drawing.Color.Transparent;
            this.ViewDetail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ViewDetail.BorderRadius = 0;
            this.ViewDetail.ButtonText = "    View Product";
            this.ViewDetail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ViewDetail.DisabledColor = System.Drawing.Color.Gray;
            this.ViewDetail.Iconcolor = System.Drawing.Color.Transparent;
            this.ViewDetail.Iconimage = ((System.Drawing.Image)(resources.GetObject("ViewDetail.Iconimage")));
            this.ViewDetail.Iconimage_right = null;
            this.ViewDetail.Iconimage_right_Selected = null;
            this.ViewDetail.Iconimage_Selected = null;
            this.ViewDetail.IconMarginLeft = 0;
            this.ViewDetail.IconMarginRight = 0;
            this.ViewDetail.IconRightVisible = true;
            this.ViewDetail.IconRightZoom = 0D;
            this.ViewDetail.IconVisible = true;
            this.ViewDetail.IconZoom = 40D;
            this.ViewDetail.IsTab = true;
            this.ViewDetail.Location = new System.Drawing.Point(1, 363);
            this.ViewDetail.Name = "ViewDetail";
            this.ViewDetail.Normalcolor = System.Drawing.Color.Transparent;
            this.ViewDetail.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(206)))));
            this.ViewDetail.OnHoverTextColor = System.Drawing.Color.White;
            this.ViewDetail.selected = false;
            this.ViewDetail.Size = new System.Drawing.Size(207, 48);
            this.ViewDetail.TabIndex = 23;
            this.ViewDetail.Text = "    View Product";
            this.ViewDetail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ViewDetail.Textcolor = System.Drawing.Color.White;
            this.ViewDetail.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewDetail.Click += new System.EventHandler(this.ViewDetail_Click);
            // 
            // frm_MainEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 623);
            this.Controls.Add(this.pnl_Main);
            this.Controls.Add(this.pnl_Menu1);
            this.Controls.Add(this.pnl_Bar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_MainEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_MainEmployee";
            ((System.ComponentModel.ISupportInitialize)(this.btn_Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Minisize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_IconPosition)).EndInit();
            this.pnl_Menu1.ResumeLayout(false);
            this.pnl_Menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptcChat)).EndInit();
            this.pnl_Bar.ResumeLayout(false);
            this.pnl_Bar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuFlatButton btn_Notification;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Logout;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Product;
        private Bunifu.Framework.UI.BunifuImageButton btn_Exit;
        private Bunifu.Framework.UI.BunifuImageButton btn_Minisize;
        private System.Windows.Forms.Label lbl_Position;
        private System.Windows.Forms.PictureBox lbl_IconPosition;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Profile;
        private System.Windows.Forms.Panel pnl_Menu1;
        private System.Windows.Forms.Panel pnl_Bar;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Sell;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Help;
        private Gradient pnl_Main;
        private Gradient pnl_Menu;
        private System.Windows.Forms.PictureBox ptcChat;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton ViewDetail;
    }
}