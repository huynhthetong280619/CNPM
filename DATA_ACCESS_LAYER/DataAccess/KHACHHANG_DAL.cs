using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATA_TRANFER_OBJECT;

namespace DATA_ACCESS_LAYER.DataAccess
{
    public class KHACHHANG_DAL
    {
        public static QUANLYCUAHANGEntities QuanLyShop;
        //Lấy danh sách khách hàng
        public static List<KHACHHANG_DTO> LayDanhSachKhachHang()
        {
            QuanLyShop = new QUANLYCUAHANGEntities();
            var lstKhachHang = from kh in QuanLyShop.BANG_KHACHHANG select new KHACHHANG_DTO { idkhachhang = kh.idkhachhang, name = kh.name, phonenumber = kh.phonenumber, address = kh.address, idkhuyenmai = kh.idkhuyenmai, makhuyenmai = kh.BANG_KHUYENMAI.giamgia, createdate = kh.createdate, Chitiet = kh.Chitiet, Old = kh.Old, gender = kh.gender,  };
            return lstKhachHang.ToList();

        }
        //Thêm khách hàng.
        public static KHACHHANG_DTO ThemKhachHang(BANG_KHACHHANG kh)
        {
            QuanLyShop = new QUANLYCUAHANGEntities();
            kh = QuanLyShop.BANG_KHACHHANG.Add(kh);
            QuanLyShop.SaveChanges();
            KHACHHANG_DTO khDTO = ConvertDTO(kh);
            return khDTO;

        }

        public static KHACHHANG_DTO ConvertDTO(BANG_KHACHHANG kh)
        {
            KHACHHANG_DTO khDTO = new KHACHHANG_DTO();
            khDTO.idkhachhang = kh.idkhachhang;
            khDTO.name = kh.name;
            khDTO.phonenumber = kh.phonenumber;
            khDTO.address = kh.address;
            khDTO.idkhuyenmai = kh.idkhuyenmai;
            khDTO.gender = kh.gender;
            khDTO.Old = kh.Old;
            khDTO.Chitiet = kh.Chitiet;
            khDTO.createdate = kh.createdate;

            return khDTO;
        }

        //Sửa thông tin khách hàng.
        public static KHACHHANG_DTO SuaKhachHang(BANG_KHACHHANG Kh)
        {
            BANG_KHACHHANG khUpdate = QuanLyShop.BANG_KHACHHANG.SingleOrDefault(k => k.idkhachhang == Kh.idkhachhang);
            if (khUpdate != null)
            {
                khUpdate.idkhachhang = Kh.idkhachhang;
                khUpdate.name = Kh.name;
                khUpdate.phonenumber = Kh.phonenumber;
                khUpdate.address = Kh.address;
                khUpdate.idkhuyenmai = Kh.idkhuyenmai;
                khUpdate.gender = Kh.gender;
                khUpdate.Old = Kh.Old;
                khUpdate.createdate = Kh.createdate;
                khUpdate.Chitiet = khUpdate.Chitiet + "\n"+ Kh.Chitiet;

                QuanLyShop.SaveChanges();
                KHACHHANG_DTO khDTO = ConvertDTO(khUpdate);
                return khDTO;
            }
            return null;
        }

        //Xóa khách hàng
        public static bool XoaKhachHang(string idKh)
        {

            BANG_KHACHHANG dKh = QuanLyShop.BANG_KHACHHANG.SingleOrDefault(k => k.idkhachhang == idKh);
            if (dKh != null)
            {
                QuanLyShop.BANG_KHACHHANG.Remove(dKh);
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
        //Tìm kiếm khách hàng
        public static List<KHACHHANG_DTO> TimKiemKhachHang(string info)
        {
            QuanLyShop = new QUANLYCUAHANGEntities();
            //Tìm kiếm theo tên
            var lstKh = from kh in QuanLyShop.BANG_KHACHHANG
                        where kh.name.Contains(info)
                        select new KHACHHANG_DTO { idkhachhang = kh.idkhachhang, name = kh.name, phonenumber = kh.phonenumber, address = kh.address, idkhuyenmai = kh.idkhuyenmai, makhuyenmai = kh.BANG_KHUYENMAI.giamgia, createdate = kh.createdate, Chitiet = kh.Chitiet, Old = kh.Old, gender = kh.gender };
            return lstKh.ToList();
        }

        public static List<KHACHHANG_DTO> SellGroceries(string phone)
        {
            QuanLyShop = new QUANLYCUAHANGEntities();
            var lstKh = from kh in QuanLyShop.BANG_KHACHHANG
                        where kh.phonenumber.Contains(phone)
                        select new KHACHHANG_DTO { idkhachhang = kh.idkhachhang, name = kh.name, phonenumber = kh.phonenumber, address = kh.address, idkhuyenmai = kh.idkhuyenmai, makhuyenmai = kh.BANG_KHUYENMAI.giamgia, createdate = kh.createdate, Chitiet = kh.Chitiet, Old = kh.Old, gender = kh.gender };
            return lstKh.ToList();
        }

        public static List<KHACHHANG_DTO> GetSingleCustomer(string idkh)
        {
            QuanLyShop = new QUANLYCUAHANGEntities();
            return (from kh in QuanLyShop.BANG_KHACHHANG where kh.idkhachhang == idkh select new KHACHHANG_DTO { idkhachhang = kh.idkhachhang, name = kh.name, phonenumber = kh.phonenumber, address = kh.address, idkhuyenmai = kh.idkhuyenmai, makhuyenmai = kh.BANG_KHUYENMAI.giamgia ,createdate=kh.createdate, Chitiet=kh.Chitiet,Old=kh.Old, gender=kh.gender}).ToList();
        }
    }
}
