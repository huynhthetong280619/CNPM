using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DATA_TRANFER_OBJECT;
using BUSSINESS_LOGIC_LAYER;

namespace QuanLyCuaHang
{
    public partial class uct_Notification : UserControl
    {
        public uct_Notification()
        {
            InitializeComponent();
        }
        List<THONGBAO_DTO> lstThongBao;
        private void uct_Notification_Load(object sender, EventArgs e)
        {
            lstThongBao = THONGBAO_BUL.LayDanhSachThongBao();
            lstThongBao.OrderByDescending(tb => tb.createdate);

            dtgvThongBao.DataSource = lstThongBao;

            dtgvThongBao.Columns["idthongbao"].Visible = false;
            dtgvThongBao.Columns["tieude"].Visible = true;
            dtgvThongBao.Columns["noidung"].Visible = true;
            dtgvThongBao.Columns["createdate"].Visible = true;
        }
    }
}
