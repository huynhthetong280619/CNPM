using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATA_TRANFER_OBJECT;

namespace DATA_ACCESS_LAYER.DataAccess
{
    public class HOADON_DAL
    {
        public static QUANLYCUAHANGEntities QuanLyShop;
        //Lấy danh sách hóa đơn
        public static List<HOADON_DTO> LayDanhSachHoaDon()
        {
            QuanLyShop = new QUANLYCUAHANGEntities();
            var lstHoaDon = from hd in QuanLyShop.BANG_HOADON select new HOADON_DTO { idhoadon=hd.idhoadon, idnhanvien=hd.idnhanvien, idkhachhang=hd.idkhachhang, tongtien=hd.tongtien, ngayban=hd.ngayban, tongtiencuoi=hd.tongtiencuoi, soluong=hd.soluong, khachhang=hd.BANG_KHACHHANG.name, nhanvien=hd.BANG_NHANVIEN.name };
            return lstHoaDon.ToList();

        }
        //Thêm hóa đơn.
        public static HOADON_DTO ThemHoaDon(BANG_HOADON hd)
        {
            QuanLyShop = new QUANLYCUAHANGEntities();
            hd = QuanLyShop.BANG_HOADON.Add(hd);
            QuanLyShop.SaveChanges();
            HOADON_DTO hdDTO = ConvertDTO(hd);
            return hdDTO;

        }

        public static double DoanhThu(string month)
        {
            QuanLyShop = new QUANLYCUAHANGEntities();
            var result = from hd in QuanLyShop.BANG_HOADON where hd.ngayban.Value.Month.ToString() == month select new HOADON_DTO { tongtiencuoi = hd.tongtiencuoi };
            double r = double.Parse(result.ToList().Sum(e => e.tongtiencuoi).ToString());
            return r;
        }

        public static HOADON_DTO ConvertDTO(BANG_HOADON hd)
        {
            HOADON_DTO hdDTO = new HOADON_DTO();
            hdDTO.idhoadon = hd.idhoadon;
            hdDTO.idnhanvien = hd.idnhanvien;
            hdDTO.idkhachhang = hd.idkhachhang;
            hdDTO.tongtien = hd.tongtien;
            hdDTO.ngayban = hd.ngayban;
            hdDTO.tongtiencuoi = hd.tongtiencuoi;
            hdDTO.soluong = hd.soluong;


            return hdDTO;
        }

        //Sửa thông tin hóa đơn
        public static HOADON_DTO SuaHoaDon(BANG_HOADON hd)
        {
            BANG_HOADON hdUpdate = QuanLyShop.BANG_HOADON.SingleOrDefault(h => h.idhoadon == hd.idhoadon);
            if (hdUpdate != null)
            {
                hdUpdate.idhoadon = hd.idhoadon;
                hdUpdate.idnhanvien = hd.idnhanvien;
                hdUpdate.idkhachhang = hd.idkhachhang;
                hdUpdate.tongtien = hd.tongtien;
                hdUpdate.ngayban = hd.ngayban;
                hdUpdate.tongtiencuoi = hd.tongtiencuoi;
                hdUpdate.soluong = hd.soluong;

                QuanLyShop.SaveChanges();
                HOADON_DTO hdDTO = ConvertDTO(hdUpdate);
                return hdDTO;
            }
            return null;
        }

        //Xóa hóa đơn
        public static bool XoaHoaDon(string idHd)
        {
            QuanLyShop = new QUANLYCUAHANGEntities();
            BANG_HOADON dHd = QuanLyShop.BANG_HOADON.SingleOrDefault(h => h.idhoadon == idHd);
            if (dHd != null)
            {
                QuanLyShop.BANG_HOADON.Remove(dHd);
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
        //Tìm kiếm hóa đơn
        public static List<HOADON_DTO> TimHoaDon(string idHd)
        {
            return null;
        }
    }
}
