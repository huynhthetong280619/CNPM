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
using System.IO;
using Microsoft.Office;

namespace QuanLyCuaHang
{
    public partial class btn_Sale : UserControl
    {
        public btn_Sale()
        {
            InitializeComponent();
            flag = "S";
            lstNhanVienDTO = NHANVIEN_BUL.LayDanhSachNhanVien(flag);
            LoadDaTaNhanVien(flag);
            lb_soluong.Text = lstNhanVienDTO.Count.ToString();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            frm_AddEmployee temp = new frm_AddEmployee();
            temp.ShowDialog();
        }
        //Danh sách nhân viên 
        List<NHANVIEN_DTO> lstNhanVienDTO = new List<NHANVIEN_DTO>();

        string flag = "";

        private void btn_Allofstaff_Click(object sender, EventArgs e)
        {
            flag = "";
            LoadDaTaNhanVien(flag);
            lb_soluong.Text = lstNhanVienDTO.Count.ToString();
        }

        private void btn_Warehouse_Click(object sender, EventArgs e)
        {
            flag = "W";
            lstNhanVienDTO = NHANVIEN_BUL.LayDanhSachNhanVien(flag);
            LoadDaTaNhanVien(flag);
            lb_soluong.Text = lstNhanVienDTO.Count.ToString();
        }

        private void btnSale_Click(object sender, EventArgs e)
        {
            flag= "S";
            lstNhanVienDTO = NHANVIEN_BUL.LayDanhSachNhanVien(flag);
            LoadDaTaNhanVien(flag);
            lb_soluong.Text = lstNhanVienDTO.Count.ToString();
        }

        public void LoadDaTaNhanVien(string flag, int page = 1)
        {
            lstNhanVienDTO = NHANVIEN_BUL.LayDanhSachNhanVien(flag);
            LoadNumberPage();
            dtgvEmployee.DataSource = typeof(NHANVIEN_DTO);
            dtgvEmployee.DataSource = lstNhanVienDTO;

            LoadNhanVien(page);
        }

        public void LoadNhanVien(int page)
        {
            int trangSo = page;
            int soDong = 10;
            int skipRow = (trangSo - 1) * soDong;

            List<NHANVIEN_DTO> lstNhanVienPhanTrang = lstNhanVienDTO.Skip(skipRow).Take(soDong).ToList();
            dtgvEmployee.DataSource = typeof(List<NHANVIEN_DTO>);
            dtgvEmployee.DataSource = lstNhanVienPhanTrang;

            dtgvEmployee.Columns["idnhanvien"].Visible = false;
            dtgvEmployee.Columns["username"].Visible = true;
            dtgvEmployee.Columns["password"].Visible = true;
            dtgvEmployee.Columns["name"].Visible = true;
            dtgvEmployee.Columns["phonenumber"].Visible = true;
            dtgvEmployee.Columns["idcard"].Visible = false;
            dtgvEmployee.Columns["address"].Visible = true;
            dtgvEmployee.Columns["idhistorysell"].Visible = false;
            dtgvEmployee.Columns["position"].Visible = true;
            dtgvEmployee.Columns["avatar"].Visible = false;
            dtgvEmployee.Columns["gender"].Visible = true;

        }
        //Chuc nang phan trang
        private void nbud_PhanTrang_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown nud =(NumericUpDown)sender;
            int trang = int.Parse(nud.Value.ToString());
            LoadDaTaNhanVien(flag,trang);
        }

        public void LoadNumberPage()
        {
            int soDongHienThi = 10;
            int tongSoTrang = lstNhanVienDTO.Count / soDongHienThi;
            if(lstNhanVienDTO.Count % soDongHienThi != 0)
            {
                tongSoTrang += 1;
            }

            nbud_PhanTrang.Minimum = 1;
            nbud_PhanTrang.Maximum = tongSoTrang;
        }

        private void dtgvEmployee_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            tbx_Name.Text= dtgvEmployee.SelectedRows[0].Cells["name"].Value.ToString();
            if ((bool)dtgvEmployee.SelectedRows[0].Cells["Gender"].Value)
            {
                rdb_Nam.Checked = true;
            }
            else
            {
                rdb_Nu.Checked = true;
            }
            tbx_DiaChi.Text = dtgvEmployee.SelectedRows[0].Cells["address"].Value.ToString();
            List<NHANVIEN_DTO> single = NHANVIEN_BUL.GetSingleEmployee(dtgvEmployee.SelectedRows[0].Cells["idnhanvien"].Value.ToString());
            if (single[0].avatar != null)
            {
                ptb_avatar.Image = ByteToImage(single[0].avatar);
            }
            else
            {
                ptb_avatar.Image = null;
            }
            
        }

        public static Bitmap ByteToImage(byte[] blob)
        {
            MemoryStream mStream = new MemoryStream();
            byte[] pData = blob;
            mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            Bitmap bm = new Bitmap(mStream, false);
            mStream.Dispose();

            return bm;
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            string idNv=dtgvEmployee.SelectedRows[0].Cells["idnhanvien"].Value.ToString();

            bool result = NHANVIEN_BUL.XoaNhanVien(idNv);
            if (result)
            {
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK);
                NHANVIEN_DTO nvDTO = lstNhanVienDTO.Single(n => n.idnhanvien == idNv);
                lstNhanVienDTO.Remove(nvDTO);

                dtgvEmployee.DataSource = typeof(List<NHANVIEN_DTO>);
                dtgvEmployee.DataSource = lstNhanVienDTO;
            }
            else
            {
                MessageBox.Show("Xóa thất bại", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btn_Repair_Click(object sender, EventArgs e)
        {
            frm_repairEmployee temp = new frm_repairEmployee(dtgvEmployee.SelectedRows[0].Cells["idnhanvien"].Value.ToString());
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
            for (int i = 1; i < dtgvEmployee.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dtgvEmployee.Columns[i - 1].HeaderText;
            }
            // storing Each row and column value to excel sheet  
            for (int i = 0; i < dtgvEmployee.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dtgvEmployee.Columns.Count; j++)
                {
                    if (dtgvEmployee.Rows[i].Cells[j].Value != null)
                    {
                        worksheet.Cells[i + 2, j + 1] = dtgvEmployee.Rows[i].Cells[j].Value.ToString();
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

        private void btn_Find_Click(object sender, EventArgs e)
        {
            if(tbx_key.Text.Trim() == "")
            {
                MessageBox.Show("Nhập vào từ khóa cần tìm!");
            }
            
            List<NHANVIEN_DTO> lstNhanVienTimThay = lstNhanVienDTO.Where(n => n.name.ToLower().Contains(tbx_key.Text.Trim().ToLower())).ToList();
            dtgvEmployee.DataSource = typeof(List<NHANVIEN_DTO>);
            dtgvEmployee.DataSource = lstNhanVienTimThay;
        }
    }
}
