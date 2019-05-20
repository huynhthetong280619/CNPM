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
    public class HISTORY_BUL
    {
        //Lấy danh sách lịch sử
        public static List<HISTORY_DTO> LayDanhSachLichSu()
        {
            return HISTORY_DAL.LayDanhSachLichSu();
        }
        //Thêm lịch sử.
        public static HISTORY_DTO ThemLichSu(BANG_HISTORY ht)
        {
            return HISTORY_DAL.ThemLichSu(ht);
        }
        //Sửa thông tin lịch sử
        public static HISTORY_DTO SuaLichSu(BANG_HISTORY ht)
        {
            return HISTORY_DAL.SuaLichSu(ht);
        }
     
        //Tìm kiếm lịch sử
        public static List<HISTORY_DTO> TimLichSu(string idHt)
        {
            return HISTORY_DAL.TimLichSu(idHt);
        }

        public static bool XoaLichSu(string v)
        {
            return HISTORY_DAL.XoaLichSu(v);
        }
    }
}
