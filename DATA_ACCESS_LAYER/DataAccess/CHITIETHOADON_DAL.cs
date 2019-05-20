using DATA_TRANFER_OBJECT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA_ACCESS_LAYER
{
    public class CHITIETHOADON_DAL
    {
        public static QUANLYCUAHANGEntities QuanLyShop;
        public static CHITIETHOADON_DTO ThemChiTietHoaDon(BANG_CHITIETHOADON bcthd)
        {
            QuanLyShop = new QUANLYCUAHANGEntities();
            bcthd = QuanLyShop.BANG_CHITIETHOADON.Add(bcthd);
            QuanLyShop.SaveChanges();
            CHITIETHOADON_DTO cthdDTO = ConvertDTO(bcthd);
            return cthdDTO;
        }

        public static CHITIETHOADON_DTO ConvertDTO(BANG_CHITIETHOADON cthd)
        {
            CHITIETHOADON_DTO cthdDTO = new CHITIETHOADON_DTO();
            cthdDTO.idhoadon = cthd.idhoadon;
            cthdDTO.idsanpham = cthd.idsanpham;
            cthdDTO.dongia = cthd.dongia;

            return cthdDTO;
        }
    }
}
