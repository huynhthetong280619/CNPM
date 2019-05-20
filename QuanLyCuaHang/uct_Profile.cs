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
using DATA_ACCESS_LAYER.DataAccess;
using TOOLS;
using System.IO;

namespace QuanLyCuaHang
{
    public partial class uct_Profile : UserControl
    {
        List<NHANVIEN_DTO> session = new List<NHANVIEN_DTO>();
        byte[] image = null;
        public uct_Profile(List<NHANVIEN_DTO> lstNhanVien)
        {
            InitializeComponent();
            Bunifu.Framework.Lib.Elipse.Apply(btn_UploadAvatar, 30);
            Bunifu.Framework.Lib.Elipse.Apply(btn_UpdateInformation, 30);
            session = lstNhanVien.ToList();
        }

        private void uct_Profile_Load(object sender, EventArgs e)
        {
            tbx_Name.Text=session[0].name;
            tbx_PhoneNumber.Text = session[0].phonenumber.ToString();
            tbx_idcard.Text = session[0].idcard.ToString();
            tbx_address.Text = session[0].address;
            tbx_UserName.Text = session[0].username;
            tbx_Password.Text = session[0].password;
            if(session[0].avatar!=null)
            {
                pbx_Avatar.Image = ByteToImage(session[0].avatar);
            }
            else
            {
                pbx_Avatar.Image = null;
            }
            

            tbx_Name.Enabled = false;
            tbx_PhoneNumber.Enabled = false;
            tbx_idcard.Enabled = false;
            tbx_address.Enabled = false;
            tbx_UserName.Enabled = false;
            tbx_Password.Enabled = false;
            tbx_ConfirmPassword.Enabled = false;
        }
        //Kích hoạt chế độ chỉnh sửa
        private void btn_Edit_Click(object sender, EventArgs e)
        {
            tbx_Name.Enabled = true;
            tbx_PhoneNumber.Enabled = true;
            tbx_idcard.Enabled = true;
            tbx_address.Enabled = true;
            tbx_Password.Enabled = true;
            tbx_ConfirmPassword.Enabled = true;
            btn_UpdateInformation.Enabled = true;

        }
        //Cập nhật thông tin
        private void btn_UpdateInformation_Click(object sender, EventArgs e)
        {
            if (tbx_Password.Text != tbx_ConfirmPassword.Text)
            {
                MessageBox.Show("Mật khẩu xác nhạt không khớp .Bạn vui lòng thử lại !", "Warning", MessageBoxButtons.OK);
                return;
            }

             BANG_NHANVIEN nv = new BANG_NHANVIEN();
             MD5 hash = new MD5();

            nv.idnhanvien = session[0].idnhanvien;

            nv.username = tbx_UserName.Text;
            nv.password = hash.CreateMD5(tbx_Password.Text);
            nv.name = tbx_Name.Text;
            nv.phonenumber = int.Parse(tbx_PhoneNumber.Text);
            nv.idcard = int.Parse(tbx_idcard.Text);
            nv.address = tbx_address.Text;

            nv.idhistorysell = session[0].idhistorysell;
            nv.position = session[0].position.Trim(' ');
            nv.avatar = image;


            
            NHANVIEN_DTO nvUpdate = NHANVIEN_BUL.SuaNhanVien(nv);
            if (nvUpdate != null)
            {
                MessageBox.Show("Chỉnh sửa thành công!", "Thông báo", MessageBoxButtons.OK);

                tbx_Name.Enabled = false;
                tbx_PhoneNumber.Enabled = false;
                tbx_idcard.Enabled = false;
                tbx_address.Enabled = false;
                tbx_UserName.Enabled = false;
                tbx_Password.Enabled = false;
                tbx_ConfirmPassword.Enabled = false;
                btn_UpdateInformation.Enabled = false;
            }
            else
            {
                MessageBox.Show("Chỉnh sửa thất bại", "Thông báo", MessageBoxButtons.OK);
            }
        }


        private void btn_UploadAvatar_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "JPG | *.jpg | PNG | .*PNG | All File | *.*";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                
            }

            if(openFile.FileName.Trim() !="")
            {
                FileStream fileStream = new FileStream(openFile.FileName, FileMode.Open, FileAccess.Read);
                BinaryReader bnr = new BinaryReader(fileStream);
                image = bnr.ReadBytes((int)fileStream.Length);
                pbx_Avatar.Image = ByteToImage(image);
            }
            
        }

        public static Bitmap ByteToImage (byte[] blob)
        {
            MemoryStream mStream = new MemoryStream();
            byte[] pData = blob;
            mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            Bitmap bm = new Bitmap(mStream, false);
            mStream.Dispose();

            return bm;
        }
    }
}
