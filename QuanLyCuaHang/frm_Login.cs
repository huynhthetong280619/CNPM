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
using TOOLS;

namespace QuanLyCuaHang
{
    public partial class frm_Login : Form
    {
        public static string idLogin = "";
        public frm_Login()
        {
            InitializeComponent();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            DialogResult temp_close = MessageBox.Show("Do you want to exit ?", "Warning !!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (temp_close == DialogResult.Yes) Application.Exit();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            List<NHANVIEN_DTO> lstNhanVienDTO = new List<NHANVIEN_DTO>();
            MD5 hash = new MD5();
            lstNhanVienDTO = NHANVIEN_BUL.PhanQuyen(tbx_UserName.Text, hash.CreateMD5(txt_PassWord.Text));
     
            if (lstNhanVienDTO.Count > 0)
            {
                string quyenHan = lstNhanVienDTO[0].position;
                if (quyenHan.Contains("ADMIN"))
                {
                    this.Hide();
                    frm_Main temp_main = new frm_Main(lstNhanVienDTO);
                    temp_main.ShowDialog();
                    this.Show();
                }
                else if (quyenHan.Contains("SALE"))
                {
                    this.Hide();
                    idLogin = lstNhanVienDTO[0].idnhanvien;
                    frm_MainEmployee temp_main = new frm_MainEmployee(lstNhanVienDTO);
                    temp_main.ShowDialog();
                    this.Show();

                }
                else
                {
                    this.Hide();
                    frm_MainWarehouseStaff temp_main = new frm_MainWarehouseStaff(lstNhanVienDTO);
                    temp_main.ShowDialog();
                    this.Show();

                }
            }
            else
            {
                MessageBox.Show("Tài khoản của bạn không tôn tài! Vui lòng nhập lại!", "Notice", MessageBoxButtons.OK);
            }
           
           
        }

        private void tbx_UserName_Enter(object sender, EventArgs e)
        {
            if(tbx_UserName.Text=="User Name")
            {
                tbx_UserName.Text = "";
            }
        }

        private void txt_PassWord_Enter(object sender, EventArgs e)
        {
            if(txt_PassWord.Text== "************")
            {
                txt_PassWord.Text = "";
            }
        }

        private void tbx_UserName_Leave(object sender, EventArgs e)
        {
            if (tbx_UserName.Text == "")
            {
                tbx_UserName.Text = "User Name";
            }
        }

        private void txt_PassWord_Leave(object sender, EventArgs e)
        {
            if (txt_PassWord.Text == "")
            {
                txt_PassWord.Text = "************";
            }
        }

        private void circleButton3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
