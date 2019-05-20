using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUSSINESS_LOGIC_LAYER;
using DATA_ACCESS_LAYER;
using DATA_TRANFER_OBJECT;
using TOOLS;

namespace QuanLyCuaHang
{
    public partial class frm_repairEmployee : Form
    {
        List<NHANVIEN_DTO> lstNV = new List<NHANVIEN_DTO>();
        byte[] image = null;
        ConvertImage cvImage = new ConvertImage();
        public frm_repairEmployee(string idNV)
        {
            InitializeComponent();
            lstNV = NHANVIEN_BUL.GetSingleEmployee(idNV);
        }

        private void frm_repairEmployee_Load(object sender, EventArgs e)
        {
            tbx_username.Text = lstNV[0].username;
            tbx_name.Text = lstNV[0].name;
            tbx_password.Text = lstNV[0].password;
            tbx_phonenumber.Text = lstNV[0].phonenumber.ToString();
            tbx_address.Text = lstNV[0].address;
            tbx_position.Text = lstNV[0].position;
            tbx_idcard.Text = lstNV[0].idcard.ToString();
            if (lstNV[0].gender)
            {
                rdb_Nam.Checked = true;
            }
            else
            {
                rdb_Nu.Checked = true;
            }
            ConvertImage cvImage = new ConvertImage();
            if (lstNV[0].avatar != null)
            {
                ptb_avatar.Image = cvImage.ByteToImage(lstNV[0].avatar);
            }
            else
            {
                ptb_avatar.Image = null;
            }

        }

        private void ptb_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if(tbx_username.Text=="" | tbx_name.Text=="" | tbx_position.Text == "")
            {
                MessageBox.Show("Điền đầy đủ thông tin", "Error", MessageBoxButtons.OK);
                return;
            }
            try
            {
                int.Parse(tbx_idcard.Text);
                int.Parse(tbx_phonenumber.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show("IDCARD và SỐ ĐIỆN THOẠI bắt buộc phải toàn là chữ số","Error",MessageBoxButtons.OK);
                return;
            }
            BANG_NHANVIEN nv = new BANG_NHANVIEN();
            MD5 hash = new MD5();
            
            nv.idnhanvien = lstNV[0].idnhanvien;

            nv.username = tbx_username.Text;
            nv.password = lstNV[0].password;
            nv.name = tbx_name.Text;
            nv.phonenumber = int.Parse(tbx_phonenumber.Text);
            nv.idcard = int.Parse(tbx_idcard.Text);
            nv.address = tbx_address.Text;

            nv.idhistorysell = null;
            nv.position = tbx_position.Text;
            nv.avatar = image;



            NHANVIEN_DTO nvUpdate = NHANVIEN_BUL.SuaNhanVien(nv);
            if (nvUpdate != null)
            {
                MessageBox.Show("Chỉnh sửa thành công!", "Thông báo", MessageBoxButtons.OK);

            }
            else
            {
                MessageBox.Show("Chỉnh sửa thất bại", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void ptb_avatar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "JPG | *.jpg | PNG | .*PNG | All File | *.*";
            if (openFile.ShowDialog() == DialogResult.OK)
            {

            }

            if (openFile.FileName.Trim() != "")
            {
                FileStream fileStream = new FileStream(openFile.FileName, FileMode.Open, FileAccess.Read);
                BinaryReader bnr = new BinaryReader(fileStream);
                image = bnr.ReadBytes((int)fileStream.Length);
                ptb_avatar.Image = cvImage.ByteToImage(image);
            }
        }

        private void circleButton3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
