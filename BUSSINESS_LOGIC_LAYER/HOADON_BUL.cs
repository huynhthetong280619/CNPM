using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATA_ACCESS_LAYER;
using DATA_ACCESS_LAYER.DataAccess;
using DATA_TRANFER_OBJECT;

namespace BUSSINESS_LOGIC_LAYER
{
    public class HOADON_BUL
    {
        //Lấy danh sách hóa đơn
        public static List<HOADON_DTO> LayDanhSachHoaDon()
        {
            return HOADON_DAL.LayDanhSachHoaDon();
        }
        //Thêm hóa đơn.
        public static HOADON_DTO ThemHoaDon(BANG_HOADON hd)
        {
            return HOADON_DAL.ThemHoaDon(hd);
        }
        //Sửa thông tin hóa đơn
        public static HOADON_DTO SuaHoaDon(BANG_HOADON hd)
        {
            return HOADON_DAL.SuaHoaDon(hd);
        }
        //Xóa hóa đơn
        public static bool XoaHoaDon(string idHd)
        {
            return HOADON_DAL.XoaHoaDon(idHd);
        }
        //Tìm kiếm hóa đơn
        public static List<HOADON_DTO> TimHoaDon(string idHd)
        {
            return HOADON_DAL.TimHoaDon(idHd);
        }

        public static double DoanhThu(string month)
        {
            return HOADON_DAL.DoanhThu(month);
        }
    }
}
