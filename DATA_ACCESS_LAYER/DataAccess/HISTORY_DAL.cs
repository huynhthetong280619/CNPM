using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATA_TRANFER_OBJECT;

namespace DATA_ACCESS_LAYER.DataAccess
{
    public class HISTORY_DAL
    {
        public static QUANLYCUAHANGEntities QuanLyShop;
        //Lấy danh sách lịch sử
        public static List<HISTORY_DTO> LayDanhSachLichSu()
        {
            QuanLyShop = new QUANLYCUAHANGEntities();
            var lstLichSu = from ls in QuanLyShop.BANG_HISTORY select new HISTORY_DTO { idhistory=ls.idhistory,idnhanvien=ls.idnhanvien,idkhachhang=ls.idkhachhang,ngayban=ls.ngayban,ngayluukho=ls.ngayluukho,chitiet=ls.chitiet, nhanvien=ls.BANG_NHANVIEN.name,khachhang=ls.BANG_KHACHHANG.name };
            return lstLichSu.ToList();

        }
        //Thêm lịch sử.
        public static HISTORY_DTO ThemLichSu(BANG_HISTORY ls)
        {
            QuanLyShop = new QUANLYCUAHANGEntities();
            ls = QuanLyShop.BANG_HISTORY.Add(ls);
            QuanLyShop.SaveChanges();
            HISTORY_DTO lsDTO = ConvertDTO(ls);
            return lsDTO;

        }

        public static bool XoaLichSu(string v)
        {
            QuanLyShop = new QUANLYCUAHANGEntities();
            BANG_HISTORY dHd = QuanLyShop.BANG_HISTORY.SingleOrDefault(h => h.idhistory == v);
            if (dHd != null)
            {
                QuanLyShop.BANG_HISTORY.Remove(dHd);
                try
                {
                    QuanLyShop.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
            return false;
        }

        public static HISTORY_DTO ConvertDTO(BANG_HISTORY ls)
        {
            HISTORY_DTO lsDTO = new HISTORY_DTO();
            lsDTO.idhistory = ls.idhistory;
            lsDTO.idnhanvien = ls.idnhanvien;
            lsDTO.idkhachhang = ls.idkhachhang;
            lsDTO.ngayban = ls.ngayban;
            lsDTO.ngayluukho = ls.ngayluukho;
            lsDTO.chitiet = ls.chitiet;


            return lsDTO;
        }

        //Sửa thông tin lịch sử
        public static HISTORY_DTO SuaLichSu(BANG_HISTORY ls)
        {
            return null;
        }

       
        //Tìm kiếm lịch sử
        public static List<HISTORY_DTO> TimLichSu(string idLs)
        {
            return null;
        }
    }
}
