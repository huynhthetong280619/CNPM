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
    public partial class LayoutSanPham : UserControl
    {
        uct_detailLayout detailLayout = new uct_detailLayout();
        public LayoutSanPham()
        {
            InitializeComponent();
        }

        public void SetDetail(string manhinh, string camtruoc, string camsau, string os, string ram, string rom, string pin, string chip)
        {
            detailLayout.SetValue(manhinh, camtruoc, camsau, os, ram, rom, pin, chip);
            pnlDetail.Controls.Add(detailLayout);
        }

        // Set giá trị cho layout
        public void SetValue(Image image,  string ten, int gia)
        {
            pbxSanPham.Image = image;
            lb_name.Text = ten;
            lbPrice.Text += gia;
        }

        private void btnShowDetail_Click(object sender, EventArgs e)
        {
            if (!pnlDetail.Visible)
                pnlDetail.Visible = true;
            else
                pnlDetail.Visible = false;
        }
    }
}
