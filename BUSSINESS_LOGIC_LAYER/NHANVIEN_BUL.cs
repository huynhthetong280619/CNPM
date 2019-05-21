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
    public class NHANVIEN_BUL
    {
        //Lấy danh sách nhân viên
        public static List<NHANVIEN_DTO> LayDanhSachNhanVien(string flag)
        {
            return NHANVIEN_DAL.LayDanhSachNhanVien(flag);
        }
        //Thêm nhân viên.
        public static NHANVIEN_DTO ThemNhanVien(BANG_NHANVIEN nv)
        {
            return NHANVIEN_DAL.ThemNhanVien(nv);
        }
        //Sửa thông tin nhân viên
        public static NHANVIEN_DTO SuaNhanVien(BANG_NHANVIEN nv)
        {
            return NHANVIEN_DAL.SuaNhanVien(nv);
        }
        //Xóa nhân viên
        public static bool XoaNhanVien(string idNv)
        {
            return NHANVIEN_DAL.XoaNhanVien(idNv);
        }

        public static List<NHANVIEN_DTO> TimKiemNhanVien(string idNv)
        {
            return NHANVIEN_DAL.TimKiemNhanVien(idNv);
        }

        //Kiểm tra login
        public static List<NHANVIEN_DTO> PhanQuyen(string username,string password)
        {
            return NHANVIEN_DAL.PhanQuyen(username, password);
        }
        //Get single employee
        public static List<NHANVIEN_DTO> GetSingleEmployee(string idNv)
        {
            return NHANVIEN_DAL.GetSingleEmployee(idNv);
        }
        //Check exist
        public static bool CheckExist(string idNv)
        {
            return NHANVIEN_DAL.CheckExist(idNv);
        }

        public static List<NHANVIEN_DTO> GetNhanVienSoDienThoai(string sdt)
        {
            return NHANVIEN_DAL.GetNhanVienSoDienThoai(sdt);
        }
    }
}
