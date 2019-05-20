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
    public partial class frm_repairBlock : Form
    {
        List<BLOCK_DTO> singleBlock = new List<BLOCK_DTO>();
        public frm_repairBlock(string idBlock)
        {
            InitializeComponent();
            singleBlock = BLOCK_BUL.GetSingleBlock(idBlock);
        }

        private void frm_repairBlock_Load(object sender, EventArgs e)
        {
            tbx_username.Text = singleBlock[0].name;
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            BANG_BLOCK bl = new BANG_BLOCK();
            bl.name = tbx_username.Text;
            bl.soluong = singleBlock[0].soluong;
            bl.idblock = singleBlock[0].idblock;

            BLOCK_DTO result=BLOCK_BUL.SuaKhoHang(bl);
            if (result != null)
            {
                MessageBox.Show("Cập nhật thành công!", "Notice", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Cập nhật error!", "Error", MessageBoxButtons.OK);
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
