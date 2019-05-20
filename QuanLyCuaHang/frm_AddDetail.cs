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
using TOOLS;

namespace QuanLyCuaHang
{
    public partial class frm_AddDetail : Form
    {
        public frm_AddDetail()
        {
            InitializeComponent();
        }

    

        private void btn_AddDetail_Click_1(object sender, EventArgs e)
        {
            BANG_DETAIL bdt = new BANG_DETAIL();
            CreateID crID = new CreateID();
            Random rd = new Random();
            string idDT = "DT0" + crID.ID(rd.Next(100, 100).ToString());
            bdt.iddetail = idDT;
            bdt.manhinh = tbx_manhinh.Text;
            bdt.os = tbxos.Text;
            bdt.ram = tbxram.Text;
            bdt.rom = tbx_rom.Text;
            bdt.camerasau = tbx_camerasau.Text;
            bdt.cameratruoc = tbx_cameratruoc.Text;
            bdt.dungluongpin = tbx_pin.Text;
            bdt.chip = tbx_chip.Text;

            DETAIL_DTO result=DETAIL_BUL.ThemChiTietSanPham(bdt);

            if (result != null)
            {
                MessageBox.Show("Them thanh cong", "Thong bao", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Them that bai", "Thong bao", MessageBoxButtons.OK);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void circleButton3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
