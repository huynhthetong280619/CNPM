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
using DATA_TRANFER_OBJECT;

namespace QuanLyCuaHang
{
    public partial class uct_ProductView : UserControl
    {
        public uct_ProductView()
        {
            InitializeComponent();
            flag = "L";
            lstProduct_DTO = SANPHAM_BUL.LayDanhSachSanPham(flag);
            LoadDaTaProduct(flag);
            lb_soluong.Text = lstProduct_DTO.Count.ToString();
        }
        //Danh sach product
        List<SANPHAM_DTO> lstProduct_DTO = new List<SANPHAM_DTO>();
        string flag = "";
        private void btnAll_Click(object sender, EventArgs e)
        {
            flag = "";
            lstProduct_DTO = SANPHAM_BUL.LayDanhSachSanPham(flag);
            LoadDaTaProduct(flag);
            lb_soluong.Text = lstProduct_DTO.Count.ToString();
        }

        private void btn_Extra_Click(object sender, EventArgs e)
        {
            flag = "E";
            lstProduct_DTO = SANPHAM_BUL.LayDanhSachSanPham(flag);
            LoadDaTaProduct(flag);
            lb_soluong.Text = lstProduct_DTO.Count.ToString();
        }

        private void btn_Smart_Click(object sender, EventArgs e)
        {
            flag = "S";
            lstProduct_DTO = SANPHAM_BUL.LayDanhSachSanPham(flag);
            LoadDaTaProduct(flag);
            lb_soluong.Text = lstProduct_DTO.Count.ToString();
        }

        private void btn_Laptop_Click(object sender, EventArgs e)
        {
            flag = "L";
            lstProduct_DTO = SANPHAM_BUL.LayDanhSachSanPham(flag);
            LoadDaTaProduct(flag);
            lb_soluong.Text = lstProduct_DTO.Count.ToString();
        }

        //Load data product
        public void LoadDaTaProduct(string flag, int page = 1)
        {
            lstProduct_DTO = SANPHAM_BUL.LayDanhSachSanPham(flag);
            LoadNumberPage();
            dtgvProduct.DataSource = typeof(SANPHAM_DTO);
            dtgvProduct.DataSource = lstProduct_DTO;

            LoadProduct(page);
        }

        public void LoadProduct(int page)
        {
            int trangSo = page;
            int soDong = 10;
            int skipRow = (trangSo - 1) * soDong;

            List<SANPHAM_DTO> lstSanPhamPhanTrang = lstProduct_DTO.Skip(skipRow).Take(soDong).ToList();
            dtgvProduct.DataSource = typeof(List<SANPHAM_DTO>);
            dtgvProduct.DataSource = lstSanPhamPhanTrang;

            dtgvProduct.Columns["idsanpham"].Visible = false;
            dtgvProduct.Columns["idcategory"].Visible = false;
            dtgvProduct.Columns["name"].Visible = true;
            dtgvProduct.Columns["price"].Visible = true;
            dtgvProduct.Columns["idblock"].Visible = false;
            dtgvProduct.Columns["iddetail"].Visible = false;
            dtgvProduct.Columns["datesell"].Visible = false;
            dtgvProduct.Columns["image"].Visible = false;
            dtgvProduct.Columns["soluong"].Visible = true;
            dtgvProduct.Columns["tenkho"].Visible = false;
            dtgvProduct.Columns["category"].Visible = false;
            dtgvProduct.Columns["thongtinchitiet"].Visible = true;

        }

        public void LoadNumberPage()
        {
            int soDongHienThi = 10;
            int tongSoTrang = lstProduct_DTO.Count / soDongHienThi;
            if (lstProduct_DTO.Count % soDongHienThi != 0)
            {
                tongSoTrang += 1;
            }

            nbud_PhanTrang.Minimum = 1;
            nbud_PhanTrang.Maximum = tongSoTrang;
        }

        private void nbud_PhanTrang_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown nud = (NumericUpDown)sender;
            int trang = int.Parse(nud.Value.ToString());
            LoadDaTaProduct(flag, trang);
        }

        private void btn_Find_Click(object sender, EventArgs e)
        {
            List<SANPHAM_DTO> lstTimKiem;
            if (cmbox_timkiem.Text == "Name")
            {
                lstTimKiem = lstProduct_DTO.Where(x => x.name.ToLower().Contains(tbx_key.Text.ToLower())).ToList();
                dtgvProduct.DataSource = typeof(SANPHAM_DTO);
                dtgvProduct.DataSource = lstTimKiem;
                lb_soluong.Text = lstTimKiem.Count.ToString();
                dtgvProduct.Columns["idsanpham"].Visible = false;
                dtgvProduct.Columns["idcategory"].Visible = false;
                dtgvProduct.Columns["name"].Visible = true;
                dtgvProduct.Columns["price"].Visible = true;
                dtgvProduct.Columns["idblock"].Visible = false;
                dtgvProduct.Columns["iddetail"].Visible = false;
                dtgvProduct.Columns["datesell"].Visible = false;
                dtgvProduct.Columns["image"].Visible = false;
                dtgvProduct.Columns["soluong"].Visible = true;
                dtgvProduct.Columns["tenkho"].Visible = false;
                dtgvProduct.Columns["category"].Visible = false;
                dtgvProduct.Columns["thongtinchitiet"].Visible = true;
            }
        }
    }
}
