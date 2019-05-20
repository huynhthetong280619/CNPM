using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATA_TRANFER_OBJECT;

namespace DATA_ACCESS_LAYER.DataAccess
{
    public class CATEGORY_DAL
    {
        public static QUANLYCUAHANGEntities QuanLyShop;
        //Lấy danh sách thể loại
        public static List<CATEGORY_DTO> LayDanhSachTheLoai()
        {
            QuanLyShop = new QUANLYCUAHANGEntities();

            var lstCate = from cate in QuanLyShop.BANG_CATEGORY select new CATEGORY_DTO { idcategory=cate.idcategory, name=cate.name, quanity=cate.quanity };
            return lstCate.ToList();

        }
        //Thêm thể loại.
        public static CATEGORY_DTO ThemTheLoai(BANG_CATEGORY sp)
        {
            return null;

        }

        public static CATEGORY_DTO ConvertDTO(BANG_CATEGORY cate)
        {
            CATEGORY_DTO cateDTO = new CATEGORY_DTO();
            cateDTO.idcategory = cate.idcategory;
            cateDTO.name = cate.name;
            cate.quanity = cate.quanity;

            return cateDTO;
        }

        //Sửa thông tin thể loại
        public static CATEGORY_DTO SuaTheLoai(BANG_CATEGORY cate)
        {
            BANG_CATEGORY cateUpdate = QuanLyShop.BANG_CATEGORY.SingleOrDefault(ct => ct.idcategory == cate.idcategory);
            if (cateUpdate != null)
            {

                cateUpdate.idcategory = cate.idcategory;
                cateUpdate.name = cate.name;
                cateUpdate.quanity = cate.quanity;
                QuanLyShop.SaveChanges();
                CATEGORY_DTO cateDTO = ConvertDTO(cateUpdate);
                return cateDTO;
            }
            return null;
        }

        //Xóa thể loại
        public static bool XoaTheLoai(string idSp)
        {

            return false;
        }
        //Tìm kiếm thể loại
        public static List<CATEGORY_DTO> TimKiemTheLoai(string idSp)
        {
            return null;
        }

        //get name cate
        public static string GetNameCate(string key)
        {
            QuanLyShop = new QUANLYCUAHANGEntities();
            List<CATEGORY_DTO> lstCate=(from cate in QuanLyShop.BANG_CATEGORY where cate.idcategory == key select new CATEGORY_DTO { name=cate.name}).ToList();
            return lstCate[0].name;
        }
    }
}
