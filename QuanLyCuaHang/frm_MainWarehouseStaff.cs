using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DATA_TRANFER_OBJECT;

namespace QuanLyCuaHang
{
    public partial class frm_MainWarehouseStaff : Form
    {
        int origin_menu_width;
        List<NHANVIEN_DTO> session = new List<NHANVIEN_DTO>();
        public frm_MainWarehouseStaff(List<NHANVIEN_DTO> lstNhanVien)
        {
            Thread trd = new Thread(new ThreadStart(formRun));
            trd.Start();
            Thread.Sleep(6000);
            InitializeComponent();
            trd.Abort();
            origin_menu_width = xx.Width;
            pnl_Main.Controls.Add(new uct_Profile(lstNhanVien));
            session = lstNhanVien;
        }

        private void formRun()
        {
            Application.Run(new frmLoading());
        }

        #region Bar Action
        private void btn_Minisize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void btn_Logout_Click(object sender, EventArgs e)
        {
            DialogResult temp_close = MessageBox.Show("Do you want to logout ?", "Warning !!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (temp_close == DialogResult.Yes) this.Close();
        }
        #endregion

        #region Move Form
        Bunifu.Framework.UI.Drag MoveForm = new Bunifu.Framework.UI.Drag();
        private void pnl_Bar_MouseDown(object sender, MouseEventArgs e)
        {
            MoveForm.Grab(this);
        }

        private void pnl_Bar_MouseMove(object sender, MouseEventArgs e)
        {
            MoveForm.MoveObject();
        }

        private void pnl_Bar_MouseUp(object sender, MouseEventArgs e)
        {
            MoveForm.Release();
        }
        #endregion

        
        private void btn_Profile_Click(object sender, EventArgs e)
        {
            pnl_Main.Controls.Clear();
            uct_Profile Profile = new uct_Profile(session);
            Profile.Dock = DockStyle.Fill;
            pnl_Main.Controls.Add(Profile);
        }
        private void btn_Notification_Click(object sender, EventArgs e)
        {
            pnl_Main.Controls.Clear();
            uct_Notification Notification = new uct_Notification();
            Notification.Dock = DockStyle.Fill;
            pnl_Main.Controls.Add(Notification);
        }

        private void btn_AddProduct_Click(object sender, EventArgs e)
        {
            pnl_Main.Controls.Clear();
            uct_Product Product = new uct_Product();
            Product.Dock = DockStyle.Fill;
            pnl_Main.Controls.Add(Product);
        }

        private void btn_Detail_Click(object sender, EventArgs e)
        {
            pnl_Main.Controls.Clear();
            uct_Detail detail = new uct_Detail();
            detail.Dock = DockStyle.Fill;
            pnl_Main.Controls.Add(detail);
        }


        private void ptcChat_Click(object sender, EventArgs e)
        {
            pnl_Main.Controls.Clear();
            chat temp = new chat();
            pnl_Main.Controls.Add(temp);
        }

        private void btn_Help_Click(object sender, EventArgs e)
        {
            pnl_Main.Controls.Clear();
            uct_Info info = new uct_Info();
            info.Dock = DockStyle.Fill;
            pnl_Main.Controls.Add(info);
        }
    }
}
