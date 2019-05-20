using DATA_ACCESS_LAYER;
using TOOLS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DATA_TRANFER_OBJECT;
using BUSSINESS_LOGIC_LAYER;

namespace QuanLyCuaHang
{
    public partial class frm_AddCustomer : Form
    {
        public frm_AddCustomer()
        {
            InitializeComponent();
        }



        private void ptb_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_AddCustomer_Click(object sender, EventArgs e)
        {
            CreateID idKh = new CreateID();
            BANG_KHACHHANG kh = new BANG_KHACHHANG();
            Random rd = new Random();
            string idKH = "KH0" + idKh.ID(rd.Next(10, 10).ToString());

            kh.idkhachhang = idKH;
            kh.name = tbx_name.Text;
            kh.phonenumber = tbx_phone.Text;
            kh.address = tbx_address.Text;
            if (rdb_Nam.Checked)
            {
                kh.gender = true;
            }
            else
            {
                kh.gender = false;
            }
            if (cmbox_promotion.Text != "")
            {
                kh.idkhuyenmai = cmbox_promotion.SelectedValue.ToString();
            }
            else
            {
                kh.idkhuyenmai = null;
            }
            kh.Chitiet = null;
            kh.Old = int.Parse(tbx_old.Text);
            kh.createdate = DateTime.Now.Date;

            KHACHHANG_DTO result = KHACHHANG_BUL.ThemKhachHang(kh);

            if (result != null)
            {
                MessageBox.Show("Add consumer success !", "Notice", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Add consumer falure !", "Notice", MessageBoxButtons.OK);
            }


        }
        List<KHUYENMAI_DTO> lstIDPro = new List<KHUYENMAI_DTO>();
        private void frm_AddCustomer_Load(object sender, EventArgs e)
        {
            lstIDPro = KHUYENMAI_BUL.LayDanhSachKhuyenMai();
            cmbox_promotion.DataSource = lstIDPro;
            cmbox_promotion.DisplayMember = "makhuyenmai";
            cmbox_promotion.ValueMember = "idkhuyenmai";
        }

        private void circleButton3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
