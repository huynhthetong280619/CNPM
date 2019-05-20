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
    public partial class Discount : Form
    {
        public Discount()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_adddIS_Click(object sender, EventArgs e)
        {
            if(tbx_dis.Text =="" | tbx_madis.Text == "")
            {
                MessageBox.Show("Cần nhập đầy đủ không được để trống!", "Error", MessageBoxButtons.OK);
                return;
            }

            BANG_KHUYENMAI bkm = new BANG_KHUYENMAI();
            bkm.idkhuyenmai = tbx_dis.Text;
            bkm.giamgia = tbx_madis.Text;

            KHUYENMAI_DTO result =KHUYENMAI_BUL.ThemMaKhuyenMai(bkm);
            if (result != null)
            {
                MessageBox.Show("Thêm thành công !", "Success", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Thêm thất bại !", "Error", MessageBoxButtons.OK);
            }

        }
    }
}
