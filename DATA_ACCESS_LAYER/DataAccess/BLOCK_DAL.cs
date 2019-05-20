using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATA_TRANFER_OBJECT;

namespace DATA_ACCESS_LAYER.DataAccess
{
    public class BLOCK_DAL
    {
        public static QUANLYCUAHANGEntities QuanLyShop;
        //Lấy danh sách kho hàng
        public static List<BLOCK_DTO> LayDanhSachKhoHang()
        {
            QuanLyShop = new QUANLYCUAHANGEntities();

            var lstBlock = from bl in QuanLyShop.BANG_BLOCK select new BLOCK_DTO { idblock=bl.idblock, name=bl.name,soluong=bl.soluong};
            return lstBlock.ToList();

        }
        //Thêm kho hàng.
        public static BLOCK_DTO ThemKhoHang(BANG_BLOCK bl)
        {
            bl = QuanLyShop.BANG_BLOCK.Add(bl);
            QuanLyShop.SaveChanges();
            BLOCK_DTO blDTO = ConvertDTO(bl);
            return blDTO;

        }

        public static BLOCK_DTO ConvertDTO(BANG_BLOCK bl)
        {
            BLOCK_DTO blDTO = new BLOCK_DTO();
            blDTO.idblock = bl.idblock;
            blDTO.name = bl.name;
            blDTO.soluong = bl.soluong;
            return blDTO;
        }

        //Sửa thông tin kho hàng
        public static BLOCK_DTO SuaKhoHang(BANG_BLOCK bl)
        {
            BANG_BLOCK blUpdate = QuanLyShop.BANG_BLOCK.SingleOrDefault(b => b.idblock == bl.idblock);
            if (blUpdate != null)
            {
                blUpdate.idblock = bl.idblock;
                blUpdate.name = bl.name;
                blUpdate.soluong = bl.soluong;

                QuanLyShop.SaveChanges();
                BLOCK_DTO blDTO = ConvertDTO(blUpdate);
                return blDTO;
            }
            return null;
        }

        //Xóa kho hàng
        public static bool XoaKhoHang(string idBl)
        {
            BANG_BLOCK dBl = QuanLyShop.BANG_BLOCK.SingleOrDefault(b => b.idblock == idBl);
            if (dBl != null)
            {
                QuanLyShop.BANG_BLOCK.Remove(dBl);
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
        //Tìm kiếm kho hàng
        public static List<BLOCK_DTO> TimKiemKhoHang(string info)
        {
            //Tìm kiếm theo tên
            var lstBlock = from bl in QuanLyShop.BANG_BLOCK
                        where bl.name.Contains(info)
                        select new BLOCK_DTO { idblock = bl.idblock, name = bl.name, soluong = bl.soluong };
            return lstBlock.ToList();
        }

        //get name block through key
        public static string GetNameThrKeyBlock(string key)
        {
            QuanLyShop = new QUANLYCUAHANGEntities();
            List<BLOCK_DTO> lstBlock = (from bl in QuanLyShop.BANG_BLOCK where bl.idblock == key select new BLOCK_DTO { name = bl.name }).ToList();
            return lstBlock[0].name;
        }
        //get single block
        public static List<BLOCK_DTO> GetSingleBlock(string idBlock)
        {
            QuanLyShop = new QUANLYCUAHANGEntities();
            return (from bl in QuanLyShop.BANG_BLOCK where bl.idblock == idBlock select new BLOCK_DTO { idblock = bl.idblock, name = bl.name, soluong = bl.soluong }).ToList();
        }
    }
}
