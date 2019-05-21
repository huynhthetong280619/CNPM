using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net;
using System.Net.Mail;
using BUSSINESS_LOGIC_LAYER;
using DATA_ACCESS_LAYER;
using DATA_TRANFER_OBJECT;
using TOOLS;

namespace QuanLyCuaHang
{
    public partial class uct_backuppass : UserControl
    {
        public uct_backuppass()
        {
            InitializeComponent();
        }

        NetworkCredential login;
        SmtpClient client;
        MailMessage msg;

        List<NHANVIEN_DTO> lstNV;
        private void btnSend_Click(object sender, EventArgs e)
        {
            MD5 hash = new MD5();
            bool check=KiemTraSoDienThoaiCoTonTai(tbx_sodienthoai.Text);
            if (!check)
            {
                MessageBox.Show("Số điện thoại này không tồn tại!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            login = new NetworkCredential("harancecastoen", "01662527649");
            client = new SmtpClient("smtp.gmail.com");
            client.Port = Convert.ToInt32("587");
            client.EnableSsl = true;
            client.Credentials = login;
            msg = new MailMessage { From = new MailAddress("harancecastoen" + "smtp.gmail.com".Replace("smtp.", "@"), "Noreply", Encoding.UTF8) };
            msg.To.Add((new MailAddress(tbx_To.Text)));
            if (!string.IsNullOrEmpty(""))
            {
               
            }
            msg.Subject = "Reset password";
            msg.Body = "Mật khẩu của bạn sau khi reset là : azxc2D83mL";
            msg.BodyEncoding = Encoding.UTF8;
            msg.IsBodyHtml = true;
            msg.Priority = MailPriority.Normal;
            msg.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;

            client.SendCompleted += new SendCompletedEventHandler(SendCompletedCallBack);
            string userstate = "Sending...";
            client.SendAsync(msg, userstate);

            
            BANG_NHANVIEN nv = new BANG_NHANVIEN();
            nv.idnhanvien = lstNV[0].idnhanvien;
            nv.username = lstNV[0].username;
            nv.password = hash.CreateMD5("azxc2D83mL");
            nv.name = lstNV[0].name;
            nv.phonenumber = lstNV[0].phonenumber;
            nv.idcard = lstNV[0].idcard;
            nv.address = lstNV[0].address;
            nv.idhistorysell = lstNV[0].idhistorysell;
            nv.position = lstNV[0].position;

            NHANVIEN_BUL.SuaNhanVien(nv);
        }
 
        public bool KiemTraSoDienThoaiCoTonTai(string sdt)
        {

            lstNV = NHANVIEN_BUL.GetNhanVienSoDienThoai(sdt);
            if (lstNV.Count != 0)
            {
                return true;
            }
            return false;
        }

        private void SendCompletedCallBack(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                MessageBox.Show(string.Format("{0} send canceled", e.UserState), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (e.Error != null)
            {
                MessageBox.Show(string.Format("{0} {1} ", e.UserState, e.Error), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Your message has been successfully send!","Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
