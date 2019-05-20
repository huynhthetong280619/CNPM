using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DATA_TRANFER_OBJECT;
using DATA_ACCESS_LAYER;
using BUSSINESS_LOGIC_LAYER;
using TOOLS;
using System.IO;

namespace QuanLyCuaHang
{
    public partial class uct_Product : UserControl
    {
        public uct_Product()
        {
            InitializeComponent();

            flag = "L";
            lstProduct_DTO = SANPHAM_BUL.LayDanhSachSanPham(flag);
            LoadDaTaProduct(flag);
            lb_soluong.Text = lstProduct_DTO.Count.ToString();
        }
        
        private void btn_Add_Click(object sender, EventArgs e)
        {
            frm_AddProduct temp = new frm_AddProduct();
            temp.ShowDialog();
        }
        //Danh sach product
        List<SANPHAM_DTO> lstProduct_DTO = new List<SANPHAM_DTO>();
        string flag = "";
        ConvertImage cvImg;
    

        private void fbtnAllofthem_Click(object sender, EventArgs e)
        {
             flag = "";
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

        private void btn_SmartPhone_Click(object sender, EventArgs e)
        {
             flag = "S";
            lstProduct_DTO = SANPHAM_BUL.LayDanhSachSanPham(flag);
            LoadDaTaProduct(flag);
            lb_soluong.Text = lstProduct_DTO.Count.ToString();
        }

        private void btn_ExtraDevice_Click(object sender, EventArgs e)
        {
             flag = "E";
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

        private void dtgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lb_nameProduct.Text = dtgvProduct.SelectedRows[0].Cells["name"].Value.ToString();
            lb_Price.Text = dtgvProduct.SelectedRows[0].Cells["price"].Value.ToString();

            lbChiTiet.Text = dtgvProduct.SelectedRows[0].Cells["thongtinchitiet"].Value.ToString();
            //lb_Detail.Text = dtgvProduct.SelectedRows[0].Cells["thongtinchitiet"].Value.ToString();
            List<SANPHAM_DTO> single = SANPHAM_BUL.GetSingleProduct(dtgvProduct.SelectedRows[0].Cells["idsanpham"].Value.ToString());
            if (single[0].image != null)
            {
                cvImg = new ConvertImage();
                ptb_img.Image = cvImg.ByteToImage(single[0].image);
            }
            else
            {
                ptb_img.Image = null;
            }
        }

        private void btn_Export_Click(object sender, EventArgs e)
        {
            // creating Excel Application  
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            // creating new WorkBook within Excel application  
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            // creating new Excelsheet in workbook  
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            // see the excel sheet behind the program  
            app.Visible = true;

            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            // changing the name of active sheet  
            worksheet.Name = "Exported from gridview";
            // storing header part in Excel  
            for (int i = 1; i < dtgvProduct.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dtgvProduct.Columns[i - 1].HeaderText;
            }
            // storing Each row and column value to excel sheet  
            for (int i = 0; i < dtgvProduct.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dtgvProduct.Columns.Count; j++)
                {
                    if (dtgvProduct.Rows[i].Cells[j].Value != null)
                    {
                        worksheet.Cells[i + 2, j + 1] = dtgvProduct.Rows[i].Cells[j].Value.ToString();
                    }
                    else
                    {
                        worksheet.Cells[i + 2, j + 1] = "";
                    }
                }
            }
            CreateID ID = new CreateID();
            // save the application  
            workbook.SaveAs("..\\File"+ID.ID("File"), Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            // Exit from the application  
            app.Quit();
            MessageBox.Show("Xuất file thành công!", "Notice", MessageBoxButtons.OK);
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            DialogPromt dilogPromt = new DialogPromt();
            string iput = dilogPromt.ShowDialog("Quanity", "Số lượng sản phẩm cần xóa");
            int qDelete;
            try
            {
                qDelete = int.Parse(iput);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Bắt buộc phải nhập số nguyên ?", "Error", MessageBoxButtons.OK);
                return;
            }
            
            int quanityCurrent = int.Parse(dtgvProduct.SelectedRows[0].Cells["soluong"].Value.ToString());
            if ( qDelete< quanityCurrent && qDelete > 0)
            {
                BANG_SANPHAM sp = new BANG_SANPHAM();

                sp.idsanpham = dtgvProduct.SelectedRows[0].Cells["idsanpham"].Value.ToString();
                sp.soluong = quanityCurrent - qDelete;
                sp.idcategory = dtgvProduct.SelectedRows[0].Cells["idcategory"].Value.ToString();
                sp.iddetail = dtgvProduct.SelectedRows[0].Cells["iddetail"].Value.ToString();
                sp.idblock = dtgvProduct.SelectedRows[0].Cells["idblock"].Value.ToString();
                sp.price = int.Parse(dtgvProduct.SelectedRows[0].Cells["price"].Value.ToString());
                sp.image = (byte[])dtgvProduct.SelectedRows[0].Cells["image"].Value;
                sp.name = dtgvProduct.SelectedRows[0].Cells["name"].Value.ToString();
                sp.datesell = null;


                SANPHAM_DTO result=SANPHAM_BUL.SuaSanPham(sp);
                if (result != null)
                {
                    MessageBox.Show("Delete success!", "Notice", MessageBoxButtons.OK);
                    UpdateCate(result.idcategory, result.name);
                }
                else
                {
                    MessageBox.Show("Delete error!", "Notice", MessageBoxButtons.OK);
                }
            }
            if(qDelete== quanityCurrent || qDelete==0)
            {
                bool result =SANPHAM_BUL.XoaSanPham(dtgvProduct.SelectedRows[0].Cells["idsanpham"].Value.ToString());
                if (result)
                {
                    MessageBox.Show("Delete success!", "Notice", MessageBoxButtons.OK);
                    string nameCate=CATEGORY_BUL.GetNameCate(dtgvProduct.SelectedRows[0].Cells["idcategory"].Value.ToString());

                    UpdateCate(dtgvProduct.SelectedRows[0].Cells["idcategory"].Value.ToString(), nameCate);
                    
                }
                else
                {
                    MessageBox.Show("Delete error!", "Notice", MessageBoxButtons.OK);
                }
            }

            int quanity = SANPHAM_BUL.QuantityFlBlock(dtgvProduct.SelectedRows[0].Cells["idblock"].Value.ToString());
            CapNhatBlock(dtgvProduct.SelectedRows[0].Cells["idblock"].Value.ToString(), quanity);
        }
        //Cap nhat lai kho
        private void CapNhatBlock(string idBlock,int quantity)
        {
            BANG_BLOCK bl = new BANG_BLOCK();
            bl.idblock = idBlock;
            bl.name = BLOCK_BUL.GetNameThrKeyBlock(idBlock);
            bl.soluong = quantity;
            BLOCK_BUL.SuaKhoHang(bl);
        }

        private void UpdateCate(string idCate, string nameCate)
        {
            int quanity = SANPHAM_BUL.Quanity(idCate);

            BANG_CATEGORY cate = new BANG_CATEGORY();
            cate.idcategory = idCate;
            cate.name = nameCate;
            cate.quanity = quanity;

            CATEGORY_DTO result = CATEGORY_BUL.SuaTheLoai(cate);
            if (result != null)
            {
                MessageBox.Show("Complete!");
            }
            else
            {
                MessageBox.Show("Error!");
            }
        }

        private void btn_Repair_Click(object sender, EventArgs e)
        {

            DialogPromt diPromt = new DialogPromt();
            int quanity;
            try
            {
                quanity = int.Parse(diPromt.ShowDialog("Bạn muốn chỉnh sửa bao nhiều sản phẩm ?", "Số lượng sản phẩm cần chỉnh sửa"));
            }
            catch(Exception ex)
            {
                MessageBox.Show("Bắt buộc phải nhập số nguyên ?", "Error", MessageBoxButtons.OK);
                return;
            }
            

            if (quanity <=0 || quanity >int.Parse(dtgvProduct.SelectedRows[0].Cells["soluong"].Value.ToString()))
            {
                MessageBox.Show("Bạn cần phải nhập đúng số lượng bắt buộc phải lớn hơn 0 và nhỏ hơn hoặc bằng số lượng sản phẩm hiện tại.", "Warning", MessageBoxButtons.OK);
                return;
            }

            frm_repairProduct temp = new frm_repairProduct(dtgvProduct.SelectedRows[0].Cells["idsanpham"].Value.ToString(),quanity);
            temp.ShowDialog();
        }

        private void btn_Find_Click(object sender, EventArgs e)
        {
            if (tbx_key.Text.Trim() == "")
            {
                MessageBox.Show("Nhập vào từ khóa cần tìm!");
            }

            List<SANPHAM_DTO> lstSanPhamTimThay = lstProduct_DTO.Where(n => n.name.ToLower().Contains(tbx_key.Text.Trim().ToLower())).ToList();
            dtgvProduct.DataSource = typeof(List<SANPHAM_DTO>);
            dtgvProduct.DataSource = lstSanPhamTimThay;
            lb_soluong.Text = lstSanPhamTimThay.Count.ToString();
        }
    }
}
