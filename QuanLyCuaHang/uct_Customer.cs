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

namespace QuanLyCuaHang
{
    public partial class uct_Customer : UserControl
    {
        public uct_Customer()
        {
            InitializeComponent();
        }
        List<KHACHHANG_DTO> lstKhachHang = new List<KHACHHANG_DTO>();
        private void btn_Add_Click(object sender, EventArgs e)
        {
            frm_AddCustomer temp = new frm_AddCustomer();
            temp.ShowDialog();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            string idKhachHang = dtgv_KhachHang.SelectedRows[0].Cells["idkhachhang"].Value.ToString();

            bool result=KHACHHANG_BUL.XoaKhachHang(idKhachHang);

            if (result)
            {
                MessageBox.Show("Delete success!", "Notice", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Delete failure", "Error", MessageBoxButtons.OK);
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
            for (int i = 1; i < dtgv_KhachHang.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dtgv_KhachHang.Columns[i - 1].HeaderText;
            }
            // storing Each row and column value to excel sheet  
            for (int i = 0; i < dtgv_KhachHang.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dtgv_KhachHang.Columns.Count; j++)
                {
                    if (dtgv_KhachHang.Rows[i].Cells[j].Value != null)
                    {
                        worksheet.Cells[i + 2, j + 1] = dtgv_KhachHang.Rows[i].Cells[j].Value.ToString();
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

        private void btn_Find_Click(object sender, EventArgs e)
        {
            if (tbx_key.Text.Trim() == "")
            {
                MessageBox.Show("Nhập vào từ khóa cần tìm!");
            }

            List<KHACHHANG_DTO> lstKhachHangTimThay = lstKhachHang.Where(n => n.name.ToLower().Contains(tbx_key.Text.Trim().ToLower())).ToList();
            dtgv_KhachHang.DataSource = typeof(List<KHACHHANG_DTO>);
            dtgv_KhachHang.DataSource = lstKhachHangTimThay;
            lb_soluong.Text = lstKhachHangTimThay.Count.ToString();
        }
        //Load data and phân trang.
        private void uct_Customer_Load(object sender, EventArgs e)
        {
            lstKhachHang = KHACHHANG_BUL.LayDanhSachKhachHang();
            LoadDataKhachHang();
            lb_soluong.Text = lstKhachHang.Count.ToString();
        }

        //Load data product
        public void LoadDataKhachHang(int page = 1)
        {
            
            LoadNumberPage();
            dtgv_KhachHang.DataSource = typeof(KHACHHANG_DTO);
            dtgv_KhachHang.DataSource = lstKhachHang;

            LoadKhachHang(page);
        }

        public void LoadKhachHang(int page)
        {
            int trangSo = page;
            int soDong = 20;
            int skipRow = (trangSo - 1) * soDong;

            List<KHACHHANG_DTO> lstKhachHangPhanTrang = lstKhachHang.Skip(skipRow).Take(soDong).ToList();
            dtgv_KhachHang.DataSource = typeof(List<NHANVIEN_DTO>);
            dtgv_KhachHang.DataSource = lstKhachHangPhanTrang;

            dtgv_KhachHang.Columns["idkhachhang"].Visible = false;
            dtgv_KhachHang.Columns["name"].Visible = true;
            dtgv_KhachHang.Columns["phonenumber"].Visible = true;
            dtgv_KhachHang.Columns["address"].Visible = false;
            dtgv_KhachHang.Columns["idkhuyenmai"].Visible = false;
            dtgv_KhachHang.Columns["gender"].Visible = true;
            dtgv_KhachHang.Columns["gender"].Width = 70;
            dtgv_KhachHang.Columns["Old"].Visible = true;
            dtgv_KhachHang.Columns["Old"].Width = 75;
            dtgv_KhachHang.Columns["createdate"].Visible = true;
            dtgv_KhachHang.Columns["createdate"].Width = 120;
            dtgv_KhachHang.Columns["Chitiet"].Visible = true;
            dtgv_KhachHang.Columns["makhuyenmai"].Visible = false;

        }

        public void LoadNumberPage()
        {
            int soDongHienThi = 20;
            int tongSoTrang = lstKhachHang.Count / soDongHienThi;
            if (lstKhachHang.Count % soDongHienThi != 0)
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
            LoadDataKhachHang(trang);
        }
    }
}
