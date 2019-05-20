using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATA_TRANFER_OBJECT;

namespace DATA_ACCESS_LAYER.DataAccess
{
    public class THONGBAO_DAL
    {
        public static QUANLYCUAHANGEntities QuanLyShop;
        //Lấy danh sách thông báo
        public static List<THONGBAO_DTO> LayDanhSachThongBao()
        {
            QuanLyShop = new QUANLYCUAHANGEntities();

            var lstThongBao = from tb in QuanLyShop.BANG_THONGBAO select new THONGBAO_DTO { idthongbao = tb.idthongbao, tieude = tb.tieude, createdate = tb.createdate, noidung=tb.noidung};
            return lstThongBao.ToList();


        }
        //Thêm thông báo.
        public static THONGBAO_DTO ThemThongBao(BANG_THONGBAO tb)
        {
            QuanLyShop = new QUANLYCUAHANGEntities();
            tb = QuanLyShop.BANG_THONGBAO.Add(tb);
            QuanLyShop.SaveChanges();
            THONGBAO_DTO tbDTO = ConvertDTO(tb);
            return tbDTO;

        }

        public static THONGBAO_DTO ConvertDTO(BANG_THONGBAO tb)
        {
            THONGBAO_DTO tbDTO = new THONGBAO_DTO();
            tbDTO.idthongbao = tb.idthongbao;
            tbDTO.tieude = tb.tieude;
            tbDTO.createdate = tb.createdate;
            tbDTO.noidung = tb.noidung;

            return tbDTO;
        }

        //Sửa thông tin thông báo
        public static THONGBAO_DTO SuaThongBao(BANG_THONGBAO tb)
        {
            QuanLyShop = new QUANLYCUAHANGEntities();
            BANG_THONGBAO tbUpdate = QuanLyShop.BANG_THONGBAO.SingleOrDefault(t => t.idthongbao == tb.idthongbao);
            if (tbUpdate != null)
            {
                tbUpdate.idthongbao = tb.idthongbao;
                tbUpdate.tieude = tb.tieude;
                tbUpdate.createdate = tb.createdate;
                tbUpdate.noidung = tb.noidung;

                QuanLyShop.SaveChanges();
                THONGBAO_DTO tbDTO = ConvertDTO(tbUpdate);
                return tbDTO;
            }
            return null;
        }

        //Xóa thông báo
        public static bool XoaThongBao(string idTb)
        {
            QuanLyShop = new QUANLYCUAHANGEntities();
            BANG_THONGBAO dTb = QuanLyShop.BANG_THONGBAO.SingleOrDefault(t => t.idthongbao == idTb);
            if (dTb != null)
            {
                QuanLyShop.BANG_THONGBAO.Remove(dTb);
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
        //Tìm kiếm thông báo
        public static List<THONGBAO_DTO> TimKiemThongBao(string info)
        {
            QuanLyShop = new QUANLYCUAHANGEntities();
            //Tìm kiếm theo id
            var lstTb = from tb in QuanLyShop.BANG_THONGBAO
                        where tb.idthongbao.Contains(info)
                        select new THONGBAO_DTO { idthongbao = tb.idthongbao, tieude = tb.tieude, createdate = tb.createdate, noidung = tb.noidung };
            return lstTb.ToList();
        }
    }
}
