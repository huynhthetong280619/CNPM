using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATA_TRANFER_OBJECT;

namespace DATA_ACCESS_LAYER.DataAccess
{
    public class SANPHAM_DAL
    {
        public static QUANLYCUAHANGEntities QuanLyShop;
        //Lấy danh sách sản phẩm
        public static List<SANPHAM_DTO> LayDanhSachSanPham(string flag)
        {
            QuanLyShop = new QUANLYCUAHANGEntities();
            if (flag == "")
            {
                var lstSanPham = from sp in QuanLyShop.BANG_SANPHAM select new SANPHAM_DTO { idsanpham = sp.idsanpham, idcategory = sp.idcategory, soluong = sp.soluong, name = sp.name, price = sp.price, idblock = sp.idblock, iddetail = sp.iddetail, datesell = sp.datesell, tenkho = sp.BANG_BLOCK.name, category = sp.BANG_CATEGORY.name, thongtinchitiet = "Màn hình: "+sp.BANG_DETAIL.manhinh+"\n"+"Camera sau: " + sp.BANG_DETAIL.camerasau + "\n" + "Camera trước: " + sp.BANG_DETAIL.cameratruoc + "\n" + "OS: " + sp.BANG_DETAIL.os + "\n" + "RAM: " + sp.BANG_DETAIL.ram + "\n" + "ROM: " + sp.BANG_DETAIL.rom + "\n" + "Dung lượng pin: " + sp.BANG_DETAIL.dungluongpin + "\n" + "Dòng chip: " + sp.BANG_DETAIL.chip + "\n" ,image=sp.image};
                return lstSanPham.ToList();
            }
            if (flag.Contains("L"))
            {
                var lstSanPham = from sp in QuanLyShop.BANG_SANPHAM where sp.idcategory=="CATE1" select new SANPHAM_DTO { idsanpham = sp.idsanpham, soluong = sp.soluong, idcategory = sp.idcategory, name = sp.name, price = sp.price, idblock = sp.idblock, iddetail = sp.iddetail, datesell = sp.datesell, tenkho = sp.BANG_BLOCK.name, category = sp.BANG_CATEGORY.name, thongtinchitiet = "Màn hình: "+sp.BANG_DETAIL.manhinh+"\n"+"Camera sau: " + sp.BANG_DETAIL.camerasau + "\n" + "Camera trước: " + sp.BANG_DETAIL.cameratruoc + "\n" + "OS: " + sp.BANG_DETAIL.os + "\n" + "RAM: " + sp.BANG_DETAIL.ram + "\n" + "ROM: " + sp.BANG_DETAIL.rom + "\n" + "Dung lượng pin: " + sp.BANG_DETAIL.dungluongpin + "\n" + "Dòng chip: " + sp.BANG_DETAIL.chip + "\n", image = sp.image };
                return lstSanPham.ToList();
            }
            else if (flag.Contains("S"))
            {
                var lstSanPham = from sp in QuanLyShop.BANG_SANPHAM where sp.idcategory == "CATE2" select new SANPHAM_DTO { idsanpham = sp.idsanpham, soluong = sp.soluong, idcategory = sp.idcategory, name = sp.name, price = sp.price, idblock = sp.idblock, iddetail = sp.iddetail, datesell = sp.datesell, tenkho = sp.BANG_BLOCK.name, category = sp.BANG_CATEGORY.name, thongtinchitiet = "Màn hình: "+sp.BANG_DETAIL.manhinh+"\n"+"Camera sau: " + sp.BANG_DETAIL.camerasau + "\n" + "Camera trước: " + sp.BANG_DETAIL.cameratruoc + "\n" + "OS: " + sp.BANG_DETAIL.os + "\n" + "RAM: " + sp.BANG_DETAIL.ram + "\n" + "ROM: " + sp.BANG_DETAIL.rom + "\n" + "Dung lượng pin: " + sp.BANG_DETAIL.dungluongpin + "\n" + "Dòng chip: " + sp.BANG_DETAIL.chip + "\n", image = sp.image };
                return lstSanPham.ToList();
            }
            else if (flag.Contains("E"))
            {
                var lstSanPham = from sp in QuanLyShop.BANG_SANPHAM where sp.idcategory == "CATE3" select new SANPHAM_DTO { idsanpham = sp.idsanpham, soluong = sp.soluong, idcategory = sp.idcategory, name = sp.name, price = sp.price, idblock = sp.idblock, iddetail = sp.iddetail, datesell = sp.datesell, tenkho = sp.BANG_BLOCK.name, category = sp.BANG_CATEGORY.name, thongtinchitiet = "Màn hình: "+sp.BANG_DETAIL.manhinh+"\n"+"Camera sau: " + sp.BANG_DETAIL.camerasau + "\n" + "Camera trước: " + sp.BANG_DETAIL.cameratruoc + "\n" + "OS: " + sp.BANG_DETAIL.os + "\n" + "RAM: " + sp.BANG_DETAIL.ram + "\n" + "ROM: " + sp.BANG_DETAIL.rom + "\n" + "Dung lượng pin: " + sp.BANG_DETAIL.dungluongpin + "\n" + "Dòng chip: " + sp.BANG_DETAIL.chip + "\n", image = sp.image };
                return lstSanPham.ToList();
            }

            return null;

        }
        //Thêm sản phẩm.
        public static SANPHAM_DTO ThemSanPham(BANG_SANPHAM sp)
        {
            sp = QuanLyShop.BANG_SANPHAM.Add(sp);
            QuanLyShop.SaveChanges();
            SANPHAM_DTO spDTO = ConvertDTO(sp);
            return spDTO;

        }

        public static SANPHAM_DTO ConvertDTO(BANG_SANPHAM Sp)
        {
            SANPHAM_DTO spDTO = new SANPHAM_DTO();
            spDTO.idsanpham = Sp.idsanpham;
            spDTO.idcategory = Sp.idcategory;
            spDTO.name = Sp.name;
            spDTO.price = Sp.price;
            spDTO.idblock = Sp.idblock;
            spDTO.iddetail = Sp.iddetail;
            spDTO.datesell = Sp.datesell;
            spDTO.soluong = Sp.soluong;
            spDTO.image = Sp.image;

            return spDTO;
        }

        //Sửa thông tin sản phẩm
        public static SANPHAM_DTO SuaSanPham(BANG_SANPHAM Sp)
        {
            BANG_SANPHAM spUpdate = QuanLyShop.BANG_SANPHAM.SingleOrDefault(sp => sp.idsanpham == Sp.idsanpham);
            if (spUpdate != null)
            {
                spUpdate.idsanpham = Sp.idsanpham;
                spUpdate.idcategory = Sp.idcategory;
                spUpdate.name = Sp.name;
                spUpdate.price = Sp.price;
                spUpdate.idblock = Sp.idblock;
                spUpdate.iddetail = Sp.iddetail;
                spUpdate.datesell = Sp.datesell;
                spUpdate.soluong = Sp.soluong;
                spUpdate.image = Sp.image;

                QuanLyShop.SaveChanges();
                SANPHAM_DTO spDTO = ConvertDTO(spUpdate);
                return spDTO;
            }
            return null;
        }

        //Xóa sản phẩm
        public static bool XoaSanPham(string idSp)
        {
            BANG_SANPHAM dSp = QuanLyShop.BANG_SANPHAM.SingleOrDefault(sp => sp.idsanpham == idSp);
            if (dSp != null)
            {
                QuanLyShop.BANG_SANPHAM.Remove(dSp);
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
        //Tìm kiếm sản phẩm
        public static List<SANPHAM_DTO> TimKiemSanPham(string info)
        {
            QuanLyShop = new QUANLYCUAHANGEntities();
            //Tìm kiếm theo tên
            var lstSanPham = from sp in QuanLyShop.BANG_SANPHAM
                                   where sp.name.Contains(info)
                                   select new SANPHAM_DTO { idsanpham = sp.idsanpham, soluong=sp.soluong, idcategory = sp.idcategory, name = sp.name, price = sp.price, idblock = sp.idblock, iddetail = sp.iddetail, datesell = sp.datesell, tenkho = sp.BANG_BLOCK.name, category = sp.BANG_CATEGORY.name, thongtinchitiet = "Màn hình: "+sp.BANG_DETAIL.manhinh+"\n"+"Camera sau: " + sp.BANG_DETAIL.camerasau + "\n" + "Camera trước: " + sp.BANG_DETAIL.cameratruoc + "\n" + "OS: " + sp.BANG_DETAIL.os + "\n" + "RAM: " + sp.BANG_DETAIL.ram + "\n" + "ROM: " + sp.BANG_DETAIL.rom + "\n" + "Dung lượng pin: " + sp.BANG_DETAIL.dungluongpin + "\n" + "Dòng chip: " + sp.BANG_DETAIL.chip + "\n", image = sp.image };
            return lstSanPham.ToList();
        }

        public static List<SANPHAM_DTO> GetSingleProduct(string idSp)
        {
            QuanLyShop = new QUANLYCUAHANGEntities();
            return (from sp in QuanLyShop.BANG_SANPHAM where sp.idsanpham == idSp select new SANPHAM_DTO { idsanpham = sp.idsanpham, soluong = sp.soluong, idcategory = sp.idcategory, name = sp.name, price = sp.price, idblock = sp.idblock, iddetail = sp.iddetail, datesell = sp.datesell, tenkho = sp.BANG_BLOCK.name, category = sp.BANG_CATEGORY.name, thongtinchitiet = "Màn hình: "+sp.BANG_DETAIL.manhinh+"\n"+"Camera sau: " + sp.BANG_DETAIL.camerasau + "\n" + "Camera trước: " + sp.BANG_DETAIL.cameratruoc + "\n" + "OS: " + sp.BANG_DETAIL.os + "\n" + "RAM: " + sp.BANG_DETAIL.ram + "\n" + "ROM: " + sp.BANG_DETAIL.rom + "\n" + "Dung lượng pin: " + sp.BANG_DETAIL.dungluongpin + "\n" + "Dòng chip: " + sp.BANG_DETAIL.chip + "\n", image = sp.image }).ToList();
        }

        public static List<SANPHAM_DTO> GetSingleProductName(string nameSp)
        {
            QuanLyShop = new QUANLYCUAHANGEntities();
            return (from sp in QuanLyShop.BANG_SANPHAM where sp.name == nameSp select new SANPHAM_DTO { idsanpham = sp.idsanpham, soluong = sp.soluong, idcategory = sp.idcategory, name = sp.name, price = sp.price, idblock = sp.idblock, iddetail = sp.iddetail, datesell = sp.datesell, tenkho = sp.BANG_BLOCK.name, category = sp.BANG_CATEGORY.name, thongtinchitiet = "Màn hình: "+sp.BANG_DETAIL.manhinh+"\n"+"Camera sau: " + sp.BANG_DETAIL.camerasau + "\n" + "Camera trước: " + sp.BANG_DETAIL.cameratruoc + "\n" + "OS: " + sp.BANG_DETAIL.os + "\n" + "RAM: " + sp.BANG_DETAIL.ram + "\n" + "ROM: " + sp.BANG_DETAIL.rom + "\n" + "Dung lượng pin: " + sp.BANG_DETAIL.dungluongpin + "\n" + "Dòng chip: " + sp.BANG_DETAIL.chip + "\n", image = sp.image }).ToList();
        }

        public static bool CheckExist(string nameSP,string codeId)
        {
            QuanLyShop = new QUANLYCUAHANGEntities();
            var result = from sp in QuanLyShop.BANG_SANPHAM where sp.name.ToLower() == nameSP && sp.idsanpham.ToLower() == codeId select sp.idsanpham;
            if (result != null)
            {
                return true;
            }
            return false;
        }

        public static List<SANPHAM_DTO> GetProductKey(string key)
        {
            QuanLyShop = new QUANLYCUAHANGEntities();
            var result = from sp in QuanLyShop.BANG_SANPHAM where sp.name.ToLower().Contains(key.ToLower()) select new SANPHAM_DTO { idsanpham = sp.idsanpham, soluong = sp.soluong, idcategory = sp.idcategory, name = sp.name, price = sp.price, idblock = sp.idblock, iddetail = sp.iddetail, datesell = sp.datesell, tenkho = sp.BANG_BLOCK.name, category = sp.BANG_CATEGORY.name, thongtinchitiet = "Màn hình: "+sp.BANG_DETAIL.manhinh+"\n"+"Camera sau: " + sp.BANG_DETAIL.camerasau + "\n" + "Camera trước: " + sp.BANG_DETAIL.cameratruoc + "\n" + "OS: " + sp.BANG_DETAIL.os + "\n" + "RAM: " + sp.BANG_DETAIL.ram + "\n" + "ROM: " + sp.BANG_DETAIL.rom + "\n" + "Dung lượng pin: " + sp.BANG_DETAIL.dungluongpin + "\n" + "Dòng chip: " + sp.BANG_DETAIL.chip + "\n", image = sp.image };
            if (result != null)
            {
                return result.ToList();
            }
            return null;
        }
        //quntity product fol cate
        public static int Quanity(string idCate)
        {
            QuanLyShop = new QUANLYCUAHANGEntities();

            var result = from sp in QuanLyShop.BANG_SANPHAM where sp.idcategory == idCate select new SANPHAM_DTO { soluong =sp.soluong};
            int quanity = int.Parse(result.Sum(e => e.soluong).ToString());

            return quanity;
        }
        //quantity product fol block
        public static int QuantityFlBlock(string idBlock)
        {
            QuanLyShop = new QUANLYCUAHANGEntities();
            var result = from sp in QuanLyShop.BANG_SANPHAM where sp.idblock == idBlock select new SANPHAM_DTO { soluong = sp.soluong };
            int quantity = int.Parse(result.ToList().Sum(e => e.soluong).ToString());
            return quantity;
        }

        //get product fl block
        public static List<SANPHAM_DTO> GetProductFlBlock(string idBlock)
        {
            QuanLyShop = new QUANLYCUAHANGEntities();
            return (from sp in QuanLyShop.BANG_SANPHAM where sp.idblock == idBlock select new SANPHAM_DTO { idsanpham = sp.idsanpham, soluong = sp.soluong, idcategory = sp.idcategory, name = sp.name, price = sp.price, idblock = sp.idblock, iddetail = sp.iddetail, datesell = sp.datesell, tenkho = sp.BANG_BLOCK.name, category = sp.BANG_CATEGORY.name, thongtinchitiet = "Màn hình: "+sp.BANG_DETAIL.manhinh+"\n"+"Camera sau: " + sp.BANG_DETAIL.camerasau + "\n" + "Camera trước: " + sp.BANG_DETAIL.cameratruoc + "\n" + "OS: " + sp.BANG_DETAIL.os + "\n" + "RAM: " + sp.BANG_DETAIL.ram + "\n" + "ROM: " + sp.BANG_DETAIL.rom + "\n" + "Dung lượng pin: " + sp.BANG_DETAIL.dungluongpin + "\n" + "Dòng chip: " + sp.BANG_DETAIL.chip + "\n", image = sp.image }).ToList();
        }

    }
}
