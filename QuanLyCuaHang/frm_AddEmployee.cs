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
using DATA_ACCESS_LAYER;
using DATA_TRANFER_OBJECT;
using BUSSINESS_LOGIC_LAYER;
using TOOLS;

namespace QuanLyCuaHang
{
    public partial class frm_AddEmployee : Form
    {
        public frm_AddEmployee()
        {
            InitializeComponent();
        }

        byte[] image = null;
        

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
                ptb_avatar.Image = ByteToImage(image);
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

        private void ptb_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void btn_Add_Click(object sender, EventArgs e)
        {
            BANG_NHANVIEN nv = new BANG_NHANVIEN();
            CreateID crID = new CreateID();
            Random rd = new Random();
            MD5 hash = new MD5();
            string idNV = "NV0" + crID.ID(rd.Next(10, 10).ToString());
            if (NHANVIEN_BUL.CheckExist(idNV))
            {
                MessageBox.Show("Hệ thống đang update! Vui lòng thử lại!", "Warning", MessageBoxButtons.OK);
                return;
            }

            nv.idnhanvien = idNV;

            nv.username = tbx_username.Text;
            nv.password = hash.CreateMD5(tbx_password.Text);
            nv.name = tbx_name.Text;
            nv.phonenumber = int.Parse(tbx_phonenumber.Text);
            nv.idcard = int.Parse(tbx_idcard.Text);
            nv.address = tbx_address.Text;

            nv.idhistorysell = null;
            nv.position = tbx_position.Text;
            nv.avatar = image;


            NHANVIEN_DTO nvDTO = NHANVIEN_BUL.ThemNhanVien(nv);

            if (nvDTO != null)
            {
                MessageBox.Show("Thông báo ! Bạn đã thêm thành công !", "Notice", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Đã xảy ra lỗi!", "Error", MessageBoxButtons.OK);
            }
        }

        private void circleButton3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
