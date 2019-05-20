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
using BUSSINESS_LOGIC_LAYER;

namespace QuanLyCuaHang
{
    public partial class uct_History : UserControl
    {
        public uct_History()
        {
            InitializeComponent();
        }

      
        List<HISTORY_DTO> lstHd;
        private void uct_History_Load(object sender, EventArgs e)
        {
            lstHd = HISTORY_BUL.LayDanhSachLichSu();
            LoadDaTaProduct();
            lb_soluong.Text = lstHd.Count.ToString();
        }

        //Load data product
        public void LoadDaTaProduct(int page = 1)
        {
            lstHd = HISTORY_BUL.LayDanhSachLichSu();
            LoadNumberPage();
            dtgvHistory.DataSource = typeof(HISTORY_DTO);
            dtgvHistory.DataSource = lstHd;

            
            LoadProduct(page);
        }

        public void LoadProduct(int page)
        {
            int trangSo = page;
            int soDong = 10;
            int skipRow = (trangSo - 1) * soDong;

            List<HISTORY_DTO> lstSanPhamPhanTrang = lstHd.Skip(skipRow).Take(soDong).ToList();
            dtgvHistory.DataSource = typeof(List<SANPHAM_DTO>);
            dtgvHistory.DataSource = lstSanPhamPhanTrang;

            
            dtgvHistory.Columns["ngayban"].Visible = true;
            dtgvHistory.Columns["ngayban"].Width = 146;
            dtgvHistory.Columns["idnhanvien"].Visible = true;
            dtgvHistory.Columns["idnhanvien"].Width = 143;
            dtgvHistory.Columns["idkhachhang"].Visible = true;
            dtgvHistory.Columns["idkhachhang"].Width = 156;
            dtgvHistory.Columns["chitiet"].Visible = true;
            dtgvHistory.Columns["chitiet"].Width = 244;
            dtgvHistory.Columns["idhistory"].Visible = false;
            dtgvHistory.Columns["ngayluukho"].Visible = false;
            dtgvHistory.Columns["nhanvien"].Visible = false;
            dtgvHistory.Columns["khachhang"].Visible = false;

        }

        public void LoadNumberPage()
        {
            int soDongHienThi = 10;
            int tongSoTrang = lstHd.Count / soDongHienThi;
            if (lstHd.Count % soDongHienThi != 0)
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
            LoadDaTaProduct(trang);
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            
            if(MessageBox.Show("Bạn có muốn xuất file thông kê trước khi xóa lịch sử không", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                bool result =HISTORY_BUL.XoaLichSu(dtgvHistory.SelectedRows[0].Cells["idhistory"].Value.ToString());
                if (result)
                {
                    MessageBox.Show("Xóa thành công!", "Success", MessageBoxButtons.OK);
                    lstHd.RemoveAll(x => x.idhistory == dtgvHistory.SelectedRows[0].Cells["idhistory"].Value.ToString());
                    dtgvHistory.DataSource = lstHd;
                }else
                {
                    MessageBox.Show("Xóa thất bại!", "Error", MessageBoxButtons.OK);
                }
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
            for (int i = 1; i < dtgvHistory.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dtgvHistory.Columns[i - 1].HeaderText;
            }
            // storing Each row and column value to excel sheet  
            for (int i = 0; i < dtgvHistory.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dtgvHistory.Columns.Count; j++)
                {
                    if (dtgvHistory.Rows[i].Cells[j].Value != null)
                    {
                        worksheet.Cells[i + 2, j + 1] = dtgvHistory.Rows[i].Cells[j].Value.ToString();
                    }
                    else
                    {
                        worksheet.Cells[i + 2, j + 1] = "";
                    }
                }
            }
            // save the application  
            workbook.SaveAs("..\\File", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            // Exit from the application  
            app.Quit();
            MessageBox.Show("Xuất file thành công!", "Notice", MessageBoxButtons.OK);
        }
        List<HISTORY_DTO> lstTimThay;
        private void btn_Find_Click(object sender, EventArgs e)
        {

            lstTimThay=lstHd.Where(x => x.ngayban.Value.Date==dtpkdate.Value.Date).ToList();
            dtgvHistory.DataSource = typeof(HISTORY_DTO);
            dtgvHistory.DataSource = lstTimThay;

            dtgvHistory.Columns["ngayban"].Visible = true;
            dtgvHistory.Columns["ngayban"].Width = 146;
            dtgvHistory.Columns["idnhanvien"].Visible = true;
            dtgvHistory.Columns["idnhanvien"].Width = 143;
            dtgvHistory.Columns["idkhachhang"].Visible = true;
            dtgvHistory.Columns["idkhachhang"].Width = 156;
            dtgvHistory.Columns["chitiet"].Visible = true;
            dtgvHistory.Columns["chitiet"].Width = 244;
            dtgvHistory.Columns["idhistory"].Visible = false;
            dtgvHistory.Columns["ngayluukho"].Visible = false;
            dtgvHistory.Columns["nhanvien"].Visible = false;
            dtgvHistory.Columns["khachhang"].Visible = false;
        }


    }
}
