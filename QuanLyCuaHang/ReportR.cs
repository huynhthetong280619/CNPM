using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHang
{
    public partial class ReportR : UserControl
    {
        Panel y = null;
        public ReportR(Panel x)
        {
            InitializeComponent();
            y = x;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            frm_reportHistory frmReport = new frm_reportHistory();
            frmReport.ShowDialog();
        }
    }
}
