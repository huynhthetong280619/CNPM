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
    public class KHUYENMAI_BUL
    {
        //Lấy danh sách khuyến mãi
        public static List<KHUYENMAI_DTO> LayDanhSachKhuyenMai()
        {
            return KHUYENMAI_DAL.LayDanhSachKhuyenMai();
        }
        //Thêm khuyến mãi.
        public static KHUYENMAI_DTO ThemMaKhuyenMai(BANG_KHUYENMAI km)
        {
            return KHUYENMAI_DAL.ThemMaKhuyenMai(km);
        }
        //Sửa thông tin khuyến mãi
        public static KHUYENMAI_DTO SuaMaKhuyenMai(BANG_KHUYENMAI km)
        {
            return KHUYENMAI_DAL.SuaMaKhuyenMai(km);
        }
        //Xóa khuyến mãi
        public static bool XoaMaKhuyenMai(string idKm)
        {
            return KHUYENMAI_DAL.XoaMaKhuyenMai(idKm);
        }

        public static List<KHUYENMAI_DTO> TimKiemMaKhuyenMai(string idKm)
        {
            return KHUYENMAI_DAL.TimKiemMaKhuyenMai(idKm);
        }
    }
}
