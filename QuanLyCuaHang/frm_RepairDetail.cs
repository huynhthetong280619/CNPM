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
    public partial class frm_RepairDetail : Form
    {
        List<DETAIL_DTO> lstDetail;
        public frm_RepairDetail(string iddetail)
        {
            InitializeComponent();
            lstDetail = DETAIL_BUL.GetSingleDetail(iddetail);
        }

        private void ptb_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_RepairDetail_Load(object sender, EventArgs e)
        {
            tbx_id.Text = lstDetail[0].iddetail;
            tbx_manhinh.Text = lstDetail[0].manhinh;
            tbxos.Text = lstDetail[0].os;
            tbxram.Text = lstDetail[0].ram;
            tbx_rom.Text = lstDetail[0].rom;
            tbx_camerasau.Text = lstDetail[0].camerasau;
            tbx_cameratruoc.Text = lstDetail[0].cameratruoc;
            tbx_pin.Text = lstDetail[0].dungluongpin;
            tbx_chip.Text = lstDetail[0].chip;
        }

        private void btn_UpdateDetail_Click(object sender, EventArgs e)
        {
            BANG_DETAIL bdt = new BANG_DETAIL();
            bdt.iddetail = lstDetail[0].iddetail;
            bdt.manhinh=tbx_manhinh.Text;
            bdt.os=tbxos.Text;
            bdt.ram=tbxram.Text ;
            bdt.rom=tbx_rom.Text ;
            bdt.camerasau=tbx_camerasau.Text ;
            bdt.cameratruoc=tbx_cameratruoc.Text ;
            bdt.dungluongpin=tbx_pin.Text ;
            bdt.chip=tbx_chip.Text;

            DETAIL_DTO result=DETAIL_BUL.SuaChiTietSanPham(bdt);
            if (result != null)
            {
                MessageBox.Show("Update success!", "Notice", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Update failure!", "Notice", MessageBoxButtons.OK);
            }

        }

        private void circleButton3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
