using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATA_ACCESS_LAYER.DataAccess;
using DATA_TRANFER_OBJECT;
using DATA_ACCESS_LAYER;

namespace BUSSINESS_LOGIC_LAYER
{
    public class KHACHHANG_BUL
    {
        //Lấy danh sách khách hàng
        public static List<KHACHHANG_DTO> LayDanhSachKhachHang()
        {
            return KHACHHANG_DAL.LayDanhSachKhachHang();
        }
        //Thêm khách hàng.
        public static KHACHHANG_DTO ThemKhachHang(BANG_KHACHHANG kh)
        {
            return KHACHHANG_DAL.ThemKhachHang(kh);
        }
        //Sửa thông tin khách hàng
        public static KHACHHANG_DTO SuaKhachHang(BANG_KHACHHANG kh)
        {
            return KHACHHANG_DAL.SuaKhachHang(kh);
        }
        //Xóa khách hàng
        public static bool XoaKhachHang(string idKh)
        {
            return KHACHHANG_DAL.XoaKhachHang(idKh);
        }
        //Tìm kiếm khách hàng
        public static List<KHACHHANG_DTO> TimKiemKhachHang(string idKh)
        {
            return KHACHHANG_DAL.TimKiemKhachHang(idKh);
        }

        public static List<KHACHHANG_DTO> SellGroceries(string phone)
        {
            return KHACHHANG_DAL.SellGroceries(phone);
        }

        public static List<KHACHHANG_DTO> GetSingleCustomer(string idkh)
        {
            return KHACHHANG_DAL.GetSingleCustomer(idkh);
        }
    }
}
