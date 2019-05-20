using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATA_TRANFER_OBJECT;

namespace DATA_ACCESS_LAYER.DataAccess
{
    public class KHUYENMAI_DAL
    {
        public static QUANLYCUAHANGEntities QuanLyShop;
        //Lấy danh sách khuyến mãi
        public static List<KHUYENMAI_DTO> LayDanhSachKhuyenMai()
        {
            QuanLyShop = new QUANLYCUAHANGEntities();
            var lstKhuyenMai = from km in QuanLyShop.BANG_KHUYENMAI select new KHUYENMAI_DTO { idkhuyenmai=km.idkhuyenmai,giamgia=km.giamgia };
            return lstKhuyenMai.ToList();

        }
        //Thêm khuyến mãi.
        public static KHUYENMAI_DTO ThemMaKhuyenMai(BANG_KHUYENMAI km)
        {
            km = QuanLyShop.BANG_KHUYENMAI.Add(km);
            QuanLyShop.SaveChanges();
            KHUYENMAI_DTO kmDTO = ConvertDTO(km);
            return kmDTO;

        }

        public static KHUYENMAI_DTO ConvertDTO(BANG_KHUYENMAI km)
        {
            km = QuanLyShop.BANG_KHUYENMAI.Add(km);
            QuanLyShop.SaveChanges();
            KHUYENMAI_DTO kmDTO = ConvertDTO(km);
            return kmDTO;
        }

        //Sửa thông tin khuyến mãi
        public static KHUYENMAI_DTO SuaMaKhuyenMai(BANG_KHUYENMAI km)
        {
            //Sau sửa đổi thì mã cũ áp dụng vẫn giữ nguyên.
            BANG_KHUYENMAI kmUpdate = QuanLyShop.BANG_KHUYENMAI.SingleOrDefault(k => k.idkhuyenmai == km.idkhuyenmai);
            if (kmUpdate != null)
            {
                kmUpdate.idkhuyenmai = km.idkhuyenmai;
                kmUpdate.giamgia = km.giamgia;
                QuanLyShop.SaveChanges();
                KHUYENMAI_DTO kmDTO = ConvertDTO(kmUpdate);
                return kmDTO;
            }
            return null;
        }

        //Xóa khuyến mãi
        public static bool XoaMaKhuyenMai(string idKm)
        {
            //Lưu ý sau khi xóa thì mã đã áp dụng thì sẽ không thay đổi.
            BANG_KHUYENMAI dKm = QuanLyShop.BANG_KHUYENMAI.SingleOrDefault(k => k.idkhuyenmai == idKm);
            if (dKm != null)
            {
                QuanLyShop.BANG_KHUYENMAI.Remove(dKm);
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
        //Tìm kiếm khuyến mãi
        public static List<KHUYENMAI_DTO> TimKiemMaKhuyenMai(string info)
        {
            //Tìm kiếm theo tên
            var lstKm = from km in QuanLyShop.BANG_KHUYENMAI
                        where km.giamgia.Contains(info)
                        select new KHUYENMAI_DTO { idkhuyenmai = km.idkhuyenmai, giamgia = km.giamgia };
            return lstKm.ToList();
        }
    }
}
