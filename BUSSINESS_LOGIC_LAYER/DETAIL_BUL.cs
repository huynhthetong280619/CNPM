using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATA_ACCESS_LAYER.DataAccess;
using DATA_ACCESS_LAYER;
using DATA_TRANFER_OBJECT;

namespace BUSSINESS_LOGIC_LAYER
{
    public class DETAIL_BUL
    {
        //Lấy danh sách chi tiết sản phẩm
        public static List<DETAIL_DTO> LayDanhSachChiTietSanPham()
        {
            return DETAIL_DAL.LayDanhSachChiTietSanPham();
        }
        //Thêm chi tiết sản phẩm.
        public static DETAIL_DTO ThemChiTietSanPham(BANG_DETAIL dt)
        {
            return DETAIL_DAL.ThemChiTietSanPham(dt);
        }
        //Sửa thông tin chi tiết sản phẩm
        public static DETAIL_DTO SuaChiTietSanPham(BANG_DETAIL dt)
        {
            return DETAIL_DAL.SuaChiTietSanPham(dt);
        }
        
        //Tìm kiếm chi tiết sản phẩm
        public static List<DETAIL_DTO> TimChiTietSanPham(string idDt)
        {
            return DETAIL_DAL.TimChiTietSanPham(idDt);
        }

        public static List<DETAIL_DTO> GetSingleDetail(string id)
        {
            return DETAIL_DAL.GetSingleDetail(id);
        }

        public static List<DETAIL_DTO> GetDetailScreen(string text)
        {
            return DETAIL_DAL.GetDetailScreen(text);
        }

        public static List<DETAIL_DTO> GetDetailCameraF(string text)
        {
            return DETAIL_DAL.GetDetailCameraF(text);
        }

        public static List<DETAIL_DTO> GetDetailCameraB(string text)
        {
            return DETAIL_DAL.GetDetailCameraB(text);
        }

        public static List<DETAIL_DTO> GetDetailOS(string text)
        {
            return DETAIL_DAL.GetDetailOS(text);
        }

        public static List<DETAIL_DTO> GetDetailRam(string text)
        {
            return DETAIL_DAL.GetDetailRam(text);
        }

        public static List<DETAIL_DTO> GetDetailRom(string text)
        {
            return DETAIL_DAL.GetDetailRom(text);
        }

        public static List<DETAIL_DTO> GetDetailPin(string text)
        {
            return DETAIL_DAL.GetDetailPin(text);
        }

        public static List<DETAIL_DTO> GetDetailChip(string text)
        {
            return DETAIL_DAL.GetDetailChip(text);
        }

        public static bool XoaChiTiet(string v)
        {
            return DETAIL_DAL.XoaChiTiet(v);
        }
    }
}
