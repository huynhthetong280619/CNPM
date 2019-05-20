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
    public partial class frm_reportHistory : Form
    {
        public frm_reportHistory()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_reportHistory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QUANLYSHOPDataSet.BANG_KHACHHANG' table. You can move, or remove it, as needed.
            this.BANG_KHACHHANGTableAdapter.Fill(this.QUANLYSHOPDataSet.BANG_KHACHHANG);

            this.reportViewer1.RefreshReport();
        }

        private void circleButton3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
