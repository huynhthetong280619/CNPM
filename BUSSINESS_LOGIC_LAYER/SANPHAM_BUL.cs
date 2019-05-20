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
    public class SANPHAM_BUL
    {
        //Lấy danh sách sản phẩm
        public static List<SANPHAM_DTO> LayDanhSachSanPham(string flag)
        {
            return SANPHAM_DAL.LayDanhSachSanPham(flag);
        }
        //Thêm sản phẩm.
        public static SANPHAM_DTO ThemSanPham(BANG_SANPHAM sp)
        {
            return SANPHAM_DAL.ThemSanPham(sp);
        }
        //Sửa thông tin sản phẩm
        public static SANPHAM_DTO SuaSanPham(BANG_SANPHAM sp)
        {
            return SANPHAM_DAL.SuaSanPham(sp);
        }
        //Xóa sản phẩm
        public static bool XoaSanPham(string idSp)
        {
            return SANPHAM_DAL.XoaSanPham(idSp);
        }

        public static List<SANPHAM_DTO> TimKiemSanPham(string idSp)
        {
            return SANPHAM_DAL.TimKiemSanPham(idSp);
        }

        public static List<SANPHAM_DTO> GetSingleProduct(string idSp)
        {
            return SANPHAM_DAL.GetSingleProduct(idSp);
        }

        public static List<SANPHAM_DTO> GetSingleProductName(string nameSp)
        {
            return SANPHAM_DAL.GetSingleProductName(nameSp);
        }

        public static bool CheckExist(string nameSp,string codeId)
        {
            return SANPHAM_DAL.CheckExist(nameSp, codeId);
        }

        public static List<SANPHAM_DTO> GetProductLike(string key)
        {
            return SANPHAM_DAL.GetProductKey(key);
        }

        //quantity product fol category
        public static int Quanity(string idCate)
        {
            return SANPHAM_DAL.Quanity(idCate);
        }
        //quanity pro fol block
        public static int QuantityFlBlock(string idBlock)
        {
            return SANPHAM_DAL.QuantityFlBlock(idBlock);
        }
        //get product fl block
        public static List<SANPHAM_DTO> GetProductFlBlock(string idBlock)
        {
            return SANPHAM_DAL.GetProductFlBlock(idBlock);
        }
    }
}
