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
    public class CATEGORY_BUL
    {
        //Lấy danh sách category
        public static List<CATEGORY_DTO> LayDanhSachTheLoai()
        {
            return CATEGORY_DAL.LayDanhSachTheLoai();
        }
        //Thêm category.
        public static CATEGORY_DTO ThemTheLoai(BANG_CATEGORY tl)
        {
            return CATEGORY_DAL.ThemTheLoai(tl);
        }
        //Sửa thông tin category
        public static CATEGORY_DTO SuaTheLoai(BANG_CATEGORY tl)
        {
            return CATEGORY_DAL.SuaTheLoai(tl);
        }
        //Xóa category
        public static bool XoaTheLoai(string idTl)
        {
            return CATEGORY_DAL.XoaTheLoai(idTl);
        }
        //Tìm kiếm category
        public static List<CATEGORY_DTO> TimKiemTheLoai(string idTl)
        {
            return CATEGORY_DAL.TimKiemTheLoai(idTl);
        }

        //get name cate
        public static string GetNameCate(string key)
        {
            return CATEGORY_DAL.GetNameCate(key);
        }
    }
}
