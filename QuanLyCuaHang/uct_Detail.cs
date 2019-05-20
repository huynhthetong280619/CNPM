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
    public partial class uct_Detail : UserControl
    {
        public uct_Detail()
        {
            InitializeComponent();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            frm_AddDetail addCt = new frm_AddDetail();
            addCt.ShowDialog();
        }
        List<DETAIL_DTO> lstDetail;
        private void uct_Detail_Load(object sender, EventArgs e)
        {
            lstDetail = DETAIL_BUL.LayDanhSachChiTietSanPham();

            LoadDaTaDetail();
            lb_soluong.Text = lstDetail.Count.ToString();
        }

        public void LoadDaTaDetail(int page = 1)
        {
            lstDetail = DETAIL_BUL.LayDanhSachChiTietSanPham();
            LoadNumberPage();
            dtgvDetail.DataSource = typeof(NHANVIEN_DTO);
            dtgvDetail.DataSource = lstDetail;

            LoadDetail(page);
        }

        public void LoadDetail(int page)
        {
            int trangSo = page;
            int soDong = 10;
            int skipRow = (trangSo - 1) * soDong;

            List<DETAIL_DTO> lstDetailPhanTrang = lstDetail.Skip(skipRow).Take(soDong).ToList();
            dtgvDetail.DataSource = typeof(List<NHANVIEN_DTO>);
            dtgvDetail.DataSource = lstDetailPhanTrang;

            dtgvDetail.Columns["manhinh"].HeaderText = "MÀN HÌNH";
            dtgvDetail.Columns["iddetail"].HeaderText = "ID";
            dtgvDetail.Columns["iddetail"].Width = 80;
            dtgvDetail.Columns["cameratruoc"].HeaderText = "CAM TRƯỚC";
            dtgvDetail.Columns["camerasau"].HeaderText = "CAM SAU";
            dtgvDetail.Columns["os"].HeaderText = "OS";
            dtgvDetail.Columns["ram"].HeaderText = "RAM";
            dtgvDetail.Columns["rom"].HeaderText = "ROM";
            dtgvDetail.Columns["dungluongpin"].HeaderText = "PIN";
            dtgvDetail.Columns["chip"].HeaderText = "CHIP";
            dtgvDetail.Columns["chip"].Width = 70;
        }
        //Chuc nang phan trang
        private void nbud_PhanTrang_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown nud = (NumericUpDown)sender;
            int trang = int.Parse(nud.Value.ToString());
            LoadDaTaDetail(trang);
        }

        public void LoadNumberPage()
        {
            int soDongHienThi = 10;
            int tongSoTrang = lstDetail.Count / soDongHienThi;
            if (lstDetail.Count % soDongHienThi != 0)
            {
                tongSoTrang += 1;
            }

            nbud_PhanTrang.Minimum = 1;
            nbud_PhanTrang.Maximum = tongSoTrang;
        }

        private void btn_Repair_Click(object sender, EventArgs e)
        {
            frm_RepairDetail rpd = new frm_RepairDetail(dtgvDetail.SelectedRows[0].Cells["iddetail"].Value.ToString());
            rpd.ShowDialog();
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
            for (int i = 1; i < dtgvDetail.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dtgvDetail.Columns[i - 1].HeaderText;
            }
            // storing Each row and column value to excel sheet  
            for (int i = 0; i < dtgvDetail.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dtgvDetail.Columns.Count; j++)
                {
                    if (dtgvDetail.Rows[i].Cells[j].Value != null)
                    {
                        worksheet.Cells[i + 2, j + 1] = dtgvDetail.Rows[i].Cells[j].Value.ToString();
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

        List<DETAIL_DTO> lstTimThay;
        private void btn_Find_Click(object sender, EventArgs e)
        {
            lstTimThay = new List<DETAIL_DTO>();
            string option = drpdproperties.Text;
            if (option.Contains( "SCREEN"))
            {
                lstTimThay=DETAIL_BUL.GetDetailScreen(tbx_key.Text);
                dtgvDetail.DataSource = lstTimThay;
            }
            else if (option.Contains("CAMERAF"))
            {
                lstTimThay= DETAIL_BUL.GetDetailCameraF(tbx_key.Text);
                dtgvDetail.DataSource = lstTimThay;
            }
            else if (option.Contains("CAMERAB"))
            {
                lstTimThay=DETAIL_BUL.GetDetailCameraB(tbx_key.Text);
                dtgvDetail.DataSource = lstTimThay;
            }
            else if (option.Contains("OS"))
            {
                lstTimThay=DETAIL_BUL.GetDetailOS(tbx_key.Text);
                dtgvDetail.DataSource = lstTimThay;
            }
            else if (option.Contains("RAM"))
            {
                lstTimThay=DETAIL_BUL.GetDetailRam(tbx_key.Text);
                dtgvDetail.DataSource = lstTimThay;
            }
            else if (option.Contains("ROM"))
            {
                lstTimThay=DETAIL_BUL.GetDetailRom(tbx_key.Text);
                dtgvDetail.DataSource = lstTimThay;
            }
            else if (option.Contains("PIN"))
            {
                lstTimThay=DETAIL_BUL.GetDetailPin(tbx_key.Text);
                dtgvDetail.DataSource = lstTimThay;
            }
            else if (option.Contains("CHIP"))
            {
                lstTimThay=DETAIL_BUL.GetDetailChip(tbx_key.Text);
                dtgvDetail.DataSource = lstTimThay;
            }
            else
            {
                return;
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            bool r=DETAIL_BUL.XoaChiTiet(dtgvDetail.SelectedRows[0].Cells["iddetail"].Value.ToString());
            if (r)
            {
                MessageBox.Show("Xóa thành công", "Success", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Xóa thất bại", "Error", MessageBoxButtons.OK);
            }
        }
    }
}
