using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TOOLS;
using DATA_TRANFER_OBJECT;
using BUSSINESS_LOGIC_LAYER;
using DATA_ACCESS_LAYER;

namespace QuanLyCuaHang
{
    public partial class uct_Block : UserControl
    {
        public uct_Block()
        {
            InitializeComponent();
        }
        List<BLOCK_DTO> lstBlock = new List<BLOCK_DTO>();
        private void btn_Add_Click(object sender, EventArgs e)
        {
            frm_AddBlock temp = new frm_AddBlock();
            temp.ShowDialog();
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
            for (int i = 1; i < dtgv_Block.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dtgv_Block.Columns[i - 1].HeaderText;
            }
            // storing Each row and column value to excel sheet  
            for (int i = 0; i < dtgv_Block.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dtgv_Block.Columns.Count; j++)
                {
                    if (dtgv_Block.Rows[i].Cells[j].Value != null)
                    {
                        worksheet.Cells[i + 2, j + 1] = dtgv_Block.Rows[i].Cells[j].Value.ToString();
                    }
                    else
                    {
                        worksheet.Cells[i + 2, j + 1] = "";
                    }
                }
            }
            CreateID ID = new CreateID();
            // save the application  
            workbook.SaveAs("..\\File" + ID.ID("File"), Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            // Exit from the application  
            app.Quit();
            MessageBox.Show("Xuất file thành công!", "Notice", MessageBoxButtons.OK);
        }

        private void uct_Block_Load(object sender, EventArgs e)
        {
            CapNhatBlock();
            lstBlock = BLOCK_BUL.LayDanhSachKhoHang();
            LoadDataKhoHang();
            lb_soluong.Text = lstBlock.Count.ToString();
        }

        private void CapNhatBlock()
        {
            foreach(BLOCK_DTO bl in BLOCK_BUL.LayDanhSachKhoHang())
            {
                int quanity = SANPHAM_BUL.QuantityFlBlock(bl.idblock);

                SuaKho(quanity, bl.idblock);
            }
        }

        private void SuaKho(int quantity, string idBlock)
        {
            BANG_BLOCK bl = new BANG_BLOCK();
            bl.idblock = idBlock;
            bl.name = BLOCK_BUL.GetNameThrKeyBlock(idBlock);
            bl.soluong = quantity;
            BLOCK_BUL.SuaKhoHang(bl);
        }


        //Load data product
        public void LoadDataKhoHang(int page = 1)
        {

            LoadNumberPage();
            dtgv_Block.DataSource = typeof(BLOCK_DTO);
            dtgv_Block.DataSource = lstBlock;

            LoadKhoHang(page);
        }

        public void LoadKhoHang(int page)
        {
            int trangSo = page;
            int soDong = 20;
            int skipRow = (trangSo - 1) * soDong;

            List<BLOCK_DTO> lstKhoHangPhanTrang = lstBlock.Skip(skipRow).Take(soDong).ToList();
            dtgv_Block.DataSource = typeof(List<NHANVIEN_DTO>);
            dtgv_Block.DataSource = lstKhoHangPhanTrang;

        }

        public void LoadNumberPage()
        {
            int soDongHienThi = 20;
            int tongSoTrang = lstBlock.Count / soDongHienThi;
            if (lstBlock.Count % soDongHienThi != 0)
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
            LoadDataKhoHang(trang);
        }

        private void btn_Repair_Click(object sender, EventArgs e)
        {
            frm_repairBlock temp = new frm_repairBlock(dtgv_Block.SelectedRows[0].Cells["idblock"].Value.ToString());
            temp.ShowDialog();
        }

        private void btn_Find_Click(object sender, EventArgs e)
        {
            if (tbx_key.Text.Trim() == "")
            {
                MessageBox.Show("Nhập vào từ khóa cần tìm!");
            }

            List<BLOCK_DTO> lstBlockTimThay = lstBlock.Where(n => n.name.ToLower().Contains(tbx_key.Text.Trim().ToLower())).ToList();
            dtgv_Block.DataSource = typeof(List<KHACHHANG_DTO>);
            dtgv_Block.DataSource = lstBlockTimThay;
            lb_soluong.Text = lstBlockTimThay.Count.ToString();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            frm_DeleteBlock temp = new frm_DeleteBlock(dtgv_Block.SelectedRows[0].Cells["idblock"].Value.ToString());
            temp.ShowDialog();
        }
    }
}
