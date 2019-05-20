using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUSSINESS_LOGIC_LAYER;

namespace QuanLyCuaHang
{
    public partial class DoanhThu : UserControl
    {
        public DoanhThu()
        {
            InitializeComponent();
        }

        private void cmbox_doanhthu_SelectedIndexChanged(object sender, EventArgs e)
        {
            string month = cmbox_doanhthu.Text;

            double dt=HOADON_BUL.DoanhThu(month);

            lbdoanhthu.Text = dt.ToString();
        }
    }
}
