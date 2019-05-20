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
    public partial class frmLoading : Form
    {
        public frmLoading()
        {
            InitializeComponent();
        }
        int move = 2;
        private void timer1_Tick(object sender, EventArgs e)
        {
            pnlSlide.Left += 2;
            if (pnlSlide.Left > 366)
            {
                pnlSlide.Left = 0;
            }

            if (pnlSlide.Left < 0)
            {
                move = 2;
            }
        }

        private void frmLoading_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
