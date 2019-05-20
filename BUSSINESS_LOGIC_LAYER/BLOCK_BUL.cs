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
    public class BLOCK_BUL
    {
        //Lấy danh sách kho hàng
        public static List<BLOCK_DTO> LayDanhSachKhoHang()
        {
            return BLOCK_DAL.LayDanhSachKhoHang();
        }
        //Thêm kho hàng.
        public static BLOCK_DTO ThemKhoHang(BANG_BLOCK bl)
        {
            return BLOCK_DAL.ThemKhoHang(bl);
        }
        //Sửa thông tin kho hàng
        public static BLOCK_DTO SuaKhoHang(BANG_BLOCK bl)
        {
            return BLOCK_DAL.SuaKhoHang(bl);
        }
        //Xóa kho hàng
        public static bool XoaKhoHang(string idBl)
        {
            return BLOCK_DAL.XoaKhoHang(idBl);
        }
        //Tìm kiếm kho hàng
        public static List<BLOCK_DTO> TimKiemKhoHang(string idBl)
        {
            return BLOCK_DAL.TimKiemKhoHang(idBl);
        }

        //get name through key block
        public static string GetNameThrKeyBlock(string key)
        {
            return BLOCK_DAL.GetNameThrKeyBlock(key);
        }
        //get single block
        public static List<BLOCK_DTO> GetSingleBlock(string idBlock)
        {
            return BLOCK_DAL.GetSingleBlock(idBlock);
        }
    }
}
