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
using TOOLS;
using DATA_ACCESS_LAYER;

namespace QuanLyCuaHang
{
    public partial class uct_SellProduct : UserControl
    {
        public uct_SellProduct()
        {
            InitializeComponent();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            frm_AddCustomer temp = new frm_AddCustomer();
            temp.ShowDialog();
        }
        string idKM = "";
        private void tbx_phoneCus_KeyUp(object sender, KeyEventArgs e)
        {
            List<KHACHHANG_DTO> lstKH = KHACHHANG_BUL.SellGroceries(tbx_phoneCus.Text);

            dtgvCustomerExist.DataSource = lstKH;

            dtgvCustomerExist.Columns["name"].Visible = true;
            dtgvCustomerExist.Columns["phonenumber"].Visible = true;
            dtgvCustomerExist.Columns["address"].Visible = false;
            dtgvCustomerExist.Columns["idkhuyenmai"].Visible = false;
            dtgvCustomerExist.Columns["gender"].Visible = false;
            dtgvCustomerExist.Columns["Old"].Visible = true;
            dtgvCustomerExist.Columns["createdate"].Visible = false;
            dtgvCustomerExist.Columns["Chitiet"].Visible = false;
            dtgvCustomerExist.Columns["makhuyenmai"].Visible = true;
            dtgvCustomerExist.Columns["idkhachhang"].Visible = false;

        }
        List<SANPHAM_DTO> lstSP;
        private void tbx_product_KeyUp(object sender, KeyEventArgs e)
        {
            lstSP = new List<SANPHAM_DTO>();
            lstSP = SANPHAM_BUL.TimKiemSanPham(tbx_product.Text);

            dtgvProduct.DataSource = lstSP;

            CustomizeColumns(dtgvProduct);
        }
        List<SANPHAM_DTO> spSale = new List<SANPHAM_DTO>();
        int soluong = 0;
        double fee=0;
        private void btn_ADDSALE_Click(object sender, EventArgs e)
        {

            SANPHAM_DTO sp = new SANPHAM_DTO();

            sp.idsanpham = dtgvProduct.SelectedRows[0].Cells["idsanpham"].Value.ToString();
            if (soluong <= int.Parse(dtgvProduct.SelectedRows[0].Cells["soluong"].Value.ToString()) && soluong>0)
            {
                sp.soluong = soluong;
            }
            else
            {
                sp.soluong = int.Parse(dtgvProduct.SelectedRows[0].Cells["soluong"].Value.ToString());
            }

            sp.idcategory = dtgvProduct.SelectedRows[0].Cells["idcategory"].Value.ToString(); ;
            sp.iddetail = dtgvProduct.SelectedRows[0].Cells["iddetail"].Value.ToString();
            sp.idblock = dtgvProduct.SelectedRows[0].Cells["idblock"].Value.ToString();
            sp.price = int.Parse(dtgvProduct.SelectedRows[0].Cells["price"].Value.ToString());
            sp.image = SANPHAM_BUL.GetSingleProduct(dtgvProduct.SelectedRows[0].Cells["idsanpham"].Value.ToString())[0].image;
            sp.name = dtgvProduct.SelectedRows[0].Cells["name"].Value.ToString();
            sp.datesell = null;

            spSale.Add(sp);

            dtgvSaled.DataSource = typeof(SANPHAM_DTO);
            dtgvSaled.DataSource = spSale;

            CustomizeColumns(dtgvSaled);

             fee= Totally(spSale);

            tbx_TotallFee.Text = (fee -(fee * double.Parse(tbx_IDDiscount.Text)) / 100).ToString();
         }

        public static double Totally(List<SANPHAM_DTO> spSale)
        {
            double t = 0;
            foreach(SANPHAM_DTO sp in spSale)
            {
                t += double.Parse(sp.price.ToString())* double.Parse(sp.soluong.ToString());
            }

            return t;
        }

        private void CustomizeColumns(Bunifu.Framework.UI.BunifuCustomDataGrid dtgv)
        {
            dtgv.Columns["name"].Visible = true;
            dtgv.Columns["price"].Visible = true;
            dtgv.Columns["soluong"].Visible = true;
            dtgv.Columns["datesell"].Visible = false;
            dtgv.Columns["idcategory"].Visible = false;
            dtgv.Columns["idblock"].Visible = false;
            dtgv.Columns["iddetail"].Visible = false;
            dtgv.Columns["image"].Visible = false;
            dtgv.Columns["idsanpham"].Visible = false;
            dtgv.Columns["tenkho"].Visible = false;
            dtgv.Columns["category"].Visible = false;
            dtgv.Columns["thongtinchitiet"].Visible = false;
        }
        string tempIDKhachHang = "";
        private void dtgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogPromt dilogP = new DialogPromt();
            soluong = int.Parse(dilogP.ShowDialog("So luong san pham can ban", "?"));
            
        }

        private void dtgvCustomerExist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (MessageBox.Show("Xac nhan chon", "Identify", MessageBoxButtons.OKCancel)==DialogResult.OK)
            {
                tempIDKhachHang = dtgvCustomerExist.SelectedRows[0].Cells["idkhachhang"].Value.ToString();
                tbx_XNKH.Text = dtgvCustomerExist.SelectedRows[0].Cells["name"].Value.ToString();
                if(dtgvCustomerExist.SelectedRows[0].Cells["makhuyenmai"].Value!=null)
                {
                    tbx_IDDiscount.Text = dtgvCustomerExist.SelectedRows[0].Cells["makhuyenmai"].Value.ToString();
                    idKM = dtgvCustomerExist.SelectedRows[0].Cells["idkhuyenmai"].Value.ToString();
                }
                else
                {
                    tbx_IDDiscount.Text = "0";
                    idKM = null;
                }

                
            }
        }

        private void btn_Sell_Click(object sender, EventArgs e)
        {

            BANG_HOADON hd = new BANG_HOADON();
            CreateID idhd = new CreateID();
            Random rd = new Random();
            string idHD = "HD0" + idhd.ID(rd.Next(1000000, 1000000).ToString());
            hd.idhoadon = idHD;
            hd.idnhanvien = frm_Login.idLogin;
            hd.idkhachhang = tempIDKhachHang;
            hd.ngayban = DateTime.Now.Date;
            hd.tongtien = Convert.ToInt32(fee);
            hd.tongtiencuoi = int.Parse(tbx_TotallFee.Text);
            hd.soluong = 1;

            HOADON_BUL.ThemHoaDon(hd);

            foreach(SANPHAM_DTO sp in spSale)
            {
                BANG_CHITIETHOADON cthd = new BANG_CHITIETHOADON();
                cthd.idhoadon = idHD;
                cthd.idsanpham = sp.idsanpham;
                cthd.dongia = sp.price;

                CHITIETHOADON_BUL.ThemChiTietHoaDon(cthd);
            }
            

            foreach (SANPHAM_DTO sp in spSale)
            {
                if(sp.soluong!= SANPHAM_BUL.GetSingleProduct(sp.idsanpham)[0].soluong)
                {
                    BANG_SANPHAM spx = new BANG_SANPHAM();

                    spx.idblock = sp.idblock;
                    spx.idsanpham = sp.idsanpham;
                    spx.idcategory = sp.idcategory;
                    spx.iddetail = sp.iddetail;
                    spx.price = sp.price;
                    spx.soluong = SANPHAM_BUL.GetSingleProduct(sp.idsanpham)[0].soluong - sp.soluong;
                    spx.image = sp.image;
                    spx.name = sp.name;
                    spx.datesell = null;

                    SANPHAM_BUL.SuaSanPham(spx);
                }
                else
                {
                    SANPHAM_BUL.XoaSanPham(sp.idsanpham);
                }
               
            }

            //Cap nhat chi tiet mua hang cho khach hang
            List<KHACHHANG_DTO> kh = KHACHHANG_BUL.GetSingleCustomer(tempIDKhachHang);
            BANG_KHACHHANG cpKh = new BANG_KHACHHANG();
            string ct = "";
            foreach(SANPHAM_DTO spsp in spSale)
            {
                ct += "TEN KHACH HANG " + kh[0].name + " Phone : " + kh[0].phonenumber + " \n";
                ct += "Detail Buy: " + DateTime.Now.Date + "\nSan pham mua gom: " + spsp.name +"x"+spsp.soluong+ " Gia :" + spsp.price+ "\n";
            }
            ct += "Ma giam gia " + kh[0].makhuyenmai + "\n";
            ct += "Tong tien: " + fee;
            ct+="\nTong tien phai tra: "+ int.Parse(tbx_TotallFee.Text);
            try
            {
                cpKh.idkhachhang = kh[0].idkhachhang;
                cpKh.idkhuyenmai = null;
                cpKh.name = kh[0].name;
                cpKh.phonenumber = kh[0].phonenumber;
                cpKh.address = kh[0].address;
                cpKh.gender = kh[0].gender;
                cpKh.Chitiet = ct;
                cpKh.Old = kh[0].Old;
                cpKh.createdate = kh[0].createdate;

                KHACHHANG_BUL.SuaKhachHang(cpKh);
            }catch (Exception ex)
            {
                
            }
            


            BANG_HISTORY hst = new BANG_HISTORY();
            hst.idhistory= "HS0" + idhd.ID(rd.Next(100000, 100000).ToString());
            hst.idkhachhang = kh[0].idkhachhang;
            hst.idnhanvien = frm_Login.idLogin;
            hst.ngayban = DateTime.Now.Date;
            hst.ngayluukho = null;
            hst.chitiet = ct;

            HISTORY_BUL.ThemLichSu(hst);
            
            MessageBox.Show("Xac nhan ban hang thanh cong ");

        }
    }
}
