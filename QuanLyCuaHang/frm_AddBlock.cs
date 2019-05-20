using BUSSINESS_LOGIC_LAYER;
using DATA_ACCESS_LAYER;
using DATA_TRANFER_OBJECT;
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
    public partial class frm_AddBlock : Form
    {
        public frm_AddBlock()
        {
            InitializeComponent();
        }

        

        private void btn_add_Click(object sender, EventArgs e)
        {
            if(tbx_Block.Text =="" || tbx_name.Text== "")
            {
                MessageBox.Show("Không được để trống !", "Error", MessageBoxButtons.OK);
                return;
            }
            BANG_BLOCK bl = new BANG_BLOCK();
            bl.idblock = tbx_Block.Text;
            bl.name = tbx_name.Text;

            BLOCK_DTO result=BLOCK_BUL.ThemKhoHang(bl);
            if (result != null)
            {
                MessageBox.Show("Thêm thành công", "Notice", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Thêm thất bại!", "Error", MessageBoxButtons.OK);
            }
        }

        private void ptb_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void circleButton3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
