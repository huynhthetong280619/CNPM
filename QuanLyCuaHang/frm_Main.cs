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

namespace QuanLyCuaHang
{
    public partial class frm_Main : Form
    {
        int origin_menu_width;
        int slide_menu_width;
        public frm_Main()
        {
            InitializeComponent();
            origin_menu_width = pnl_Menu.Width;
            slide_menu_width = 68;
            pnl_Main.Controls.Add(new uct_Profile());
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

        private void btn_Menu_Click(object sender, EventArgs e)
        {
            if (pnl_Menu.Width == origin_menu_width)
            {
                //Collapse
                pbx_Logo.Visible = false;
                pnl_Menu.Visible = false;
                pnl_Menu.Width = slide_menu_width;
                bt_MenuAnimation.ShowSync(pnl_Menu);
                pbx_LogoSlide.Visible = true;
            }
            else
            {
                //Expand
                pnl_Menu.Visible = false;
                pnl_Menu.Width = origin_menu_width;
                pbx_LogoSlide.Visible = false;
                pbx_Logo.Visible = true;
                bt_MenuAnimation.ShowSync(pnl_Menu);
                
            }
        }

        
        private void btn_Profile_Click(object sender, EventArgs e)
        {
            pnl_Main.Controls.Clear();
            uct_Profile Profile = new uct_Profile();
            Profile.Dock = DockStyle.Fill;
            pnl_Main.Controls.Add(Profile);
        }
        private void btn_Employee_Click(object sender, EventArgs e)
        {
            pnl_Main.Controls.Clear();
            uct_Employee Employee = new uct_Employee();
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
            pnl_Main.Controls.Clear();
            uct_Info Info = new uct_Info();
            Info.Dock = DockStyle.Fill;
            pnl_Main.Controls.Add(Info);
        }
    }
}
