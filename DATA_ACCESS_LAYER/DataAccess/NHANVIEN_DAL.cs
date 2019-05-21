using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATA_TRANFER_OBJECT;

namespace DATA_ACCESS_LAYER.DataAccess
{
    public class NHANVIEN_DAL
    {
        public static QUANLYCUAHANGEntities QuanLyShop;
        //Lấy danh sách nhân viên
        public static List<NHANVIEN_DTO> LayDanhSachNhanVien(string flag)
        {
            QuanLyShop = new QUANLYCUAHANGEntities();
            if (flag == "")
            {
                var lstNhanVien = from nv in QuanLyShop.BANG_NHANVIEN select new NHANVIEN_DTO { idnhanvien = nv.idnhanvien, username=nv.username,password = nv.password, name = nv.name, phonenumber = nv.phonenumber, idcard = nv.idcard, address = nv.address, idhistorysell = nv.idhistorysell, position = nv.position };
                return lstNhanVien.ToList();
            }
            if (flag.Contains("S"))
            {
                var lstNhanVien = from nv in QuanLyShop.BANG_NHANVIEN where nv.position=="SALE" select new NHANVIEN_DTO { idnhanvien = nv.idnhanvien, username = nv.username, password = nv.password, name = nv.name, phonenumber = nv.phonenumber, idcard = nv.idcard, address = nv.address, idhistorysell = nv.idhistorysell, position = nv.position };
                return lstNhanVien.ToList();
            }
            if (flag.Contains("W"))
            {
                var lstNhanVien = from nv in QuanLyShop.BANG_NHANVIEN where nv.position=="WAREHOUSE" select new NHANVIEN_DTO { idnhanvien = nv.idnhanvien, username = nv.username, password = nv.password, name = nv.name, phonenumber = nv.phonenumber, idcard = nv.idcard, address = nv.address, idhistorysell = nv.idhistorysell, position = nv.position };
                return lstNhanVien.ToList();
            }
            return null;
           
        }

        public static List<NHANVIEN_DTO> GetNhanVienSoDienThoai(string sdt)
        {
            QuanLyShop = new QUANLYCUAHANGEntities();
            var result = from nv in QuanLyShop.BANG_NHANVIEN where nv.phonenumber.ToString().Trim() == sdt.Trim() select new NHANVIEN_DTO { idnhanvien = nv.idnhanvien, username = nv.username, password = nv.password, name = nv.name, phonenumber = nv.phonenumber, idcard = nv.idcard, address = nv.address, idhistorysell = nv.idhistorysell, position = nv.position };
            return result.ToList();
        }

        //Thêm nhân viên.
        public static NHANVIEN_DTO ThemNhanVien(BANG_NHANVIEN nv)
        {
            nv = QuanLyShop.BANG_NHANVIEN.Add(nv);
            QuanLyShop.SaveChanges();
            NHANVIEN_DTO nvDTO = ConvertDTO(nv);
            return nvDTO;

        }

        public static NHANVIEN_DTO ConvertDTO(BANG_NHANVIEN nv)
        {
            NHANVIEN_DTO nvDTO = new NHANVIEN_DTO();
            nvDTO.idnhanvien = nv.idnhanvien;
            nvDTO.username = nv.username;
            nvDTO.password = nv.password;
            nvDTO.name = nv.name;
            nvDTO.phonenumber = nv.phonenumber;
            nvDTO.idcard = nv.idcard;
            nvDTO.address = nv.address;
            nvDTO.idhistorysell = nv.idhistorysell;
            nvDTO.position = nv.position;

            return nvDTO;
        }

        //Sửa thông tin nhân viên
        public static NHANVIEN_DTO SuaNhanVien(BANG_NHANVIEN nv)
        {
            BANG_NHANVIEN nvUpdate = QuanLyShop.BANG_NHANVIEN.SingleOrDefault(n => n.idnhanvien == nv.idnhanvien);
            if (nvUpdate != null)
            {
                nvUpdate.idnhanvien = nvUpdate.idnhanvien;
                nvUpdate.username = nv.username;
                nvUpdate.password = nv.password;
                nvUpdate.name = nv.name;
                nvUpdate.phonenumber = nv.phonenumber;
                nvUpdate.idcard = nv.idcard;
                nvUpdate.address = nv.address;
                nvUpdate.idhistorysell = nv.idhistorysell;
                nvUpdate.position = nv.position;
                nvUpdate.avatar = nv.avatar;

                QuanLyShop.SaveChanges();
                NHANVIEN_DTO nvDTO = ConvertDTO(nvUpdate);
                return nvDTO;
            }
            return null;
        }

        //Xóa nhân viên
        public static bool XoaNhanVien(string idNv)
        {
            BANG_NHANVIEN dNv = QuanLyShop.BANG_NHANVIEN.SingleOrDefault(n => n.idnhanvien == idNv);
            if (dNv != null)
            {
                QuanLyShop.BANG_NHANVIEN.Remove(dNv);
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
        //Tìm kiếm nhân viên
        public static List<NHANVIEN_DTO> TimKiemNhanVien(string info)
        {
            //Tìm kiếm theo tên
            var lstNv = from nv in QuanLyShop.BANG_NHANVIEN
                             where nv.name.Contains(info)
                             select new NHANVIEN_DTO { idnhanvien = nv.idnhanvien, username=nv.username, password = nv.password, name = nv.name, phonenumber = nv.phonenumber, idcard = nv.idcard, address = nv.address, idhistorysell = nv.idhistorysell, position = nv.position };
            return lstNv.ToList();
        }

        //Kiểm tra đăng nhập
        public static List<NHANVIEN_DTO> PhanQuyen(string username  , string password)
        {
            QuanLyShop = new QUANLYCUAHANGEntities();
            var result = from nv in QuanLyShop.BANG_NHANVIEN where nv.username == username && nv.password == password select new NHANVIEN_DTO { idnhanvien = nv.idnhanvien, username =nv.username, password = nv.password, name = nv.name, phonenumber = nv.phonenumber, idcard = nv.idcard, address = nv.address, idhistorysell = nv.idhistorysell, position = nv.position , avatar=nv.avatar};

            return result.ToList();
        }

        //Get single employee
        public static List<NHANVIEN_DTO> GetSingleEmployee(string idNv)
        {
            QuanLyShop = new QUANLYCUAHANGEntities();
            return (from nv in QuanLyShop.BANG_NHANVIEN where nv.idnhanvien == idNv select new NHANVIEN_DTO { idnhanvien = nv.idnhanvien, username = nv.username, password = nv.password, name = nv.name, phonenumber = nv.phonenumber, idcard = nv.idcard, address = nv.address, idhistorysell = nv.idhistorysell, position = nv.position, avatar = nv.avatar }).ToList();
        }
        //Check exist
        public static bool CheckExist(string idNv)
        {
            QuanLyShop = new QUANLYCUAHANGEntities();
            var result = from nv in QuanLyShop.BANG_NHANVIEN where nv.idnhanvien == idNv select nv.idnhanvien;
            if (result!=null)
            {
                return false;
            }
            return true;
        }
    }
}
