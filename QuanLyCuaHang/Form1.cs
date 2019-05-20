using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        }

        #region Bar Action
        private void btn_Minisize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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
                bt_LogoAnimation.Hide(pbx_Logo);
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
                bt_MenuAnimation.ShowSync(pnl_Menu);
                bt_LogoAnimation.ShowSync(pbx_Logo);
            }
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            DialogResult temp_close = MessageBox.Show("Do you want to logout ?", "Warning !!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (temp_close == DialogResult.Yes) this.Close();
        }
    }
}
