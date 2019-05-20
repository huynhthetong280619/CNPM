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
    public partial class frm_DeleteBlock : Form
    {
        string ibblockDelete = "";
        public frm_DeleteBlock(string idblock)
        {
            InitializeComponent();
            ibblockDelete = idblock;
        }
        List<BLOCK_DTO> lstBlock = new List<BLOCK_DTO>();
        private void ptb_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_DeleteBlock_Load(object sender, EventArgs e)
        {
            lstBlock = BLOCK_BUL.LayDanhSachKhoHang();
            cmbox_block.DataSource = lstBlock;
            cmbox_block.DisplayMember = "name";
            cmbox_block.ValueMember = "idblock";
        }

        private void btn_movedelete_Click(object sender, EventArgs e)
        {
            if(ibblockDelete == cmbox_block.SelectedValue.ToString())
            {
                MessageBox.Show("Bạn đang chuẩn bị xóa kho hàng này vui lòng chọn kho hàng khác !", "Notice", MessageBoxButtons.OK);
                return;
            }

            List<SANPHAM_DTO> lstSanPhamCanDiChuyen = new List<SANPHAM_DTO>();
            lstSanPhamCanDiChuyen = SANPHAM_BUL.GetProductFlBlock(ibblockDelete);

            ChangeIDBlock(lstSanPhamCanDiChuyen);

            bool result=BLOCK_BUL.XoaKhoHang(ibblockDelete);

            if (result)
            {
                CapNhatSanPhamChange(lstSanPhamCanDiChuyen);
                MessageBox.Show("Xóa thành công!", "Notice", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Failure!", "Error", MessageBoxButtons.OK);
            }

        }

        public void CapNhatSanPhamChange(List<SANPHAM_DTO> lstSp)
        {
            foreach (var Sp in lstSp)
            {
                BANG_SANPHAM spn = new BANG_SANPHAM();
                spn.idsanpham = Sp.idsanpham;
                spn.idcategory = Sp.idcategory;
                spn.name = Sp.name;
                spn.price = Sp.price;
                spn.idblock = Sp.idblock;
                spn.iddetail = Sp.iddetail;
                spn.datesell = Sp.datesell;
                spn.soluong = Sp.soluong;
                spn.image = Sp.image;

                SANPHAM_BUL.ThemSanPham(spn);

            }
        }
        public void ChangeIDBlock(List<SANPHAM_DTO> lstSanPhamCanDiChuyen)
        {
            foreach (var sp in lstSanPhamCanDiChuyen)
            {
                sp.idblock = cmbox_block.SelectedValue.ToString();
            }
        }

        private void circleButton3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
