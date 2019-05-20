using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyCuaHang;
using DATA_TRANFER_OBJECT;
using BUSSINESS_LOGIC_LAYER;
using TOOLS;
using System.Threading;

namespace QuanLyCuaHang
{
    public partial class frm_Main : Form
    {
        int origin_menu_width;
        List<NHANVIEN_DTO> session = new List<NHANVIEN_DTO>();
        public frm_Main(List<NHANVIEN_DTO> lstNhanVienDTO)
        {
            Thread trd = new Thread(new ThreadStart(formRun));
            trd.Start();
            Thread.Sleep(6000);
            InitializeComponent();
            trd.Abort();
            origin_menu_width = pnl_Menu.Width;
            session = lstNhanVienDTO;
            pnl_Main.Controls.Add(new uct_Profile(session));
            
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

            session = NHANVIEN_BUL.PhanQuyen(session[0].username, session[0].password);
            uct_Profile Profile = new uct_Profile(session);
            Profile.Dock = DockStyle.Fill;
            pnl_Main.Controls.Add(Profile);
        }
        private void btn_Employee_Click(object sender, EventArgs e)
        {
            pnl_Main.Controls.Clear();
            btn_Sale Employee = new btn_Sale();
            Employee.Dock = DockStyle.Fill;
            pnl_Main.Controls.Add(Employee);
        }

        private void btn_Product_Click(object sender, EventArgs e)
        {
            pnl_Main.Controls.Clear();
            uct_Product Product = new uct_Product();
            Product.Dock = DockStyle.Fill;
            pnl_Main.Controls.Add(Product);
        }

        private void btn_Customer_Click(object sender, EventArgs e)
        {
            pnl_Main.Controls.Clear();
            uct_Customer Customer = new uct_Customer();
            Customer.Dock = DockStyle.Fill;
            pnl_Main.Controls.Add(Customer);
        }

        private void btn_Depot_Click(object sender, EventArgs e)
        {
            pnl_Main.Controls.Clear();
            uct_Block Block = new uct_Block();
            Block.Dock = DockStyle.Fill;
            pnl_Main.Controls.Add(Block);
        }

        private void btn_History_Click(object sender, EventArgs e)
        {
            pnl_Main.Controls.Clear();
            uct_History History = new uct_History();
            History.Dock = DockStyle.Fill;
            pnl_Main.Controls.Add(History);
        }

        private void btn_Help_Click(object sender, EventArgs e)
        {
            pnl_Main.Controls.Clear();
            uct_Help Help = new uct_Help();
            Help.Dock = DockStyle.Fill;
            pnl_Main.Controls.Add(Help);
        }

        private void btn_Info_Click(object sender, EventArgs e)
        {
            //pnl_Main.Controls.Clear();
            //int x = 0;
            //for (int i = 0; i < 1; i++)
            //{
            //    ReportR rpr = new ReportR(pnl_Main);
            //    rpr.Location = new Point(10+x, 10);
            //    rpr.BorderStyle = BorderStyle.None;
            //    pnl_Main.Controls.Add(rpr);
            //    x += rpr.Height;
            //    x += 10;
            //}

            pnl_Main.Controls.Clear();
            DoanhThu ffrm_doanhthu = new DoanhThu();
            ffrm_doanhthu.Dock = DockStyle.Fill;
            pnl_Main.Controls.Add(ffrm_doanhthu);

        }

        private void ptcChat_Click(object sender, EventArgs e)
        {
            pnl_Main.Controls.Clear();
            chat temp = new chat();
            temp.Dock = DockStyle.Fill;
            pnl_Main.Controls.Add(temp);
        }

        private void ptcInfor_Click(object sender, EventArgs e)
        {
            pnl_Main.Controls.Clear();
            uct_Info info = new uct_Info();
            info.Dock = DockStyle.Fill;
            pnl_Main.Controls.Add(info);
        }

        private void ptbSale_Click(object sender, EventArgs e)
        {
            Discount frm_discount = new Discount();
            frm_discount.ShowDialog();
        }
    }
}
