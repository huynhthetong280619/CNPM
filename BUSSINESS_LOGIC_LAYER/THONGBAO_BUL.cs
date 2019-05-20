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
    public class THONGBAO_BUL
    {
        //Lấy danh sách thông báo.
        public static List<THONGBAO_DTO> LayDanhSachThongBao()
        {
            return THONGBAO_DAL.LayDanhSachThongBao();
        }
        //Thêm thông báo..
        public static THONGBAO_DTO ThemThongBao(BANG_THONGBAO tb)
        {
            return THONGBAO_DAL.ThemThongBao(tb);
        }
        //Sửa thông tin thông báo.
        public static THONGBAO_DTO SuaThongBao(BANG_THONGBAO tb)
        {
            return THONGBAO_DAL.SuaThongBao(tb);
        }
        //Xóa thông báo.
        public static bool XoaThongBao(string idTb)
        {
            return THONGBAO_DAL.XoaThongBao(idTb);
        }
        //Tìm kiếm thông báo.
        public static List<THONGBAO_DTO> TimKiemThongBao(string idTb)
        {
            return THONGBAO_DAL.TimKiemThongBao(idTb);
        }
    }
}
