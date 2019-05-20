using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DATA_ACCESS_LAYER;
using TOOLS;
using DATA_TRANFER_OBJECT;
using BUSSINESS_LOGIC_LAYER;

namespace QuanLyCuaHang
{
    public partial class uct_Help : UserControl
    {
        public uct_Help()
        {
            InitializeComponent();
        }

        private void btn_addthongbao_Click(object sender, EventArgs e)
        {
            BANG_THONGBAO btb = new BANG_THONGBAO();
            CreateID idR = new CreateID();
            Random rd = new Random();
            string idtb= "TB0" + idR.ID(rd.Next(100, 100).ToString()); 
            btb.idthongbao = idtb;
            btb.tieude = tbx_tieude.Text;
            btb.noidung = rtbx_noidung.Text;
            btb.createdate = DateTime.Now.Date;

            THONGBAO_DTO result = THONGBAO_BUL.ThemThongBao(btb);

            if (result != null)
            {
                MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Thêm bị lỗi!", "Thông báo", MessageBoxButtons.OK);
            }

        }
    }
}
