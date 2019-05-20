using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATA_TRANFER_OBJECT;

namespace DATA_ACCESS_LAYER.DataAccess
{
    public class DETAIL_DAL
    {
        public static QUANLYCUAHANGEntities QuanLyShop;
        //Lấy danh sách chi tiết sản phẩm
        public static List<DETAIL_DTO> LayDanhSachChiTietSanPham()
        {
            QuanLyShop = new QUANLYCUAHANGEntities();
            var lstChiTiet = from ct in QuanLyShop.BANG_DETAIL select new DETAIL_DTO { iddetail = ct.iddetail, manhinh = ct.manhinh, cameratruoc=ct.cameratruoc, camerasau=ct.camerasau,os=ct.os,ram=ct.ram, rom=ct.rom,dungluongpin=ct.dungluongpin,chip=ct.chip };
            return lstChiTiet.ToList();

        }
        //Thêm chi tiết sản phẩm.
        public static DETAIL_DTO ThemChiTietSanPham(BANG_DETAIL dt)
        {
            QuanLyShop = new QUANLYCUAHANGEntities();
            dt = QuanLyShop.BANG_DETAIL.Add(dt);
            QuanLyShop.SaveChanges();
            DETAIL_DTO dtDTO = ConvertDTO(dt);
            return dtDTO;

        }

        public static DETAIL_DTO ConvertDTO(BANG_DETAIL dt)
        {
            DETAIL_DTO dtDTO = new DETAIL_DTO();
            dtDTO.iddetail = dt.iddetail;
            dtDTO.manhinh = dt.manhinh;
            dtDTO.cameratruoc = dt.cameratruoc;
            dtDTO.camerasau = dt.camerasau;
            dtDTO.os = dt.os;
            dtDTO.ram = dt.ram;
            dtDTO.rom = dt.rom;
            dtDTO.dungluongpin = dt.dungluongpin;
            dtDTO.chip = dt.chip;

            return dtDTO;
        }

        public static List<DETAIL_DTO> GetDetailCameraF(string text)
        {
            QuanLyShop = new QUANLYCUAHANGEntities();
            return (from ct in QuanLyShop.BANG_DETAIL where ct.cameratruoc.Contains(text) select new DETAIL_DTO { iddetail = ct.iddetail, manhinh = ct.manhinh, cameratruoc = ct.cameratruoc, camerasau = ct.camerasau, os = ct.os, ram = ct.ram, rom = ct.rom, dungluongpin = ct.dungluongpin, chip = ct.chip }).ToList();
        }

        public static List<DETAIL_DTO> GetDetailCameraB(string text)
        {
            QuanLyShop = new QUANLYCUAHANGEntities();
            return (from ct in QuanLyShop.BANG_DETAIL where ct.camerasau.Contains(text) select new DETAIL_DTO { iddetail = ct.iddetail, manhinh = ct.manhinh, cameratruoc = ct.cameratruoc, camerasau = ct.camerasau, os = ct.os, ram = ct.ram, rom = ct.rom, dungluongpin = ct.dungluongpin, chip = ct.chip }).ToList();
        }

        public static bool XoaChiTiet(string v)
        {
            QuanLyShop = new QUANLYCUAHANGEntities();
            BANG_DETAIL dHd = QuanLyShop.BANG_DETAIL.SingleOrDefault(h => h.iddetail == v);
            if (dHd != null)
            {
                QuanLyShop.BANG_DETAIL.Remove(dHd);
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

        public static List<DETAIL_DTO> GetDetailScreen(string text)
        {
            QuanLyShop = new QUANLYCUAHANGEntities();
            return (from ct in QuanLyShop.BANG_DETAIL where ct.manhinh.Contains(text) select new DETAIL_DTO { iddetail = ct.iddetail, manhinh = ct.manhinh, cameratruoc = ct.cameratruoc, camerasau = ct.camerasau, os = ct.os, ram = ct.ram, rom = ct.rom, dungluongpin = ct.dungluongpin, chip = ct.chip }).ToList();
        }

        public static List<DETAIL_DTO> GetDetailOS(string text)
        {
            QuanLyShop = new QUANLYCUAHANGEntities();
            return (from ct in QuanLyShop.BANG_DETAIL where ct.os.Contains(text) select new DETAIL_DTO { iddetail = ct.iddetail, manhinh = ct.manhinh, cameratruoc = ct.cameratruoc, camerasau = ct.camerasau, os = ct.os, ram = ct.ram, rom = ct.rom, dungluongpin = ct.dungluongpin, chip = ct.chip }).ToList();
        }

        //Sửa thông tin chi tiết sản phẩm
        public static DETAIL_DTO SuaChiTietSanPham(BANG_DETAIL dt)
        {
            QuanLyShop = new QUANLYCUAHANGEntities();
            BANG_DETAIL dtUpdate = QuanLyShop.BANG_DETAIL.SingleOrDefault(d => d.iddetail == dt.iddetail);
            if (dtUpdate != null)
            {
                dtUpdate.iddetail = dt.iddetail;
                dtUpdate.manhinh = dt.manhinh;
                dtUpdate.cameratruoc = dt.cameratruoc;
                dtUpdate.camerasau = dt.camerasau;
                dtUpdate.os = dt.os;
                dtUpdate.ram = dt.ram;
                dtUpdate.rom = dt.rom;
                dtUpdate.dungluongpin = dt.dungluongpin;
                dtUpdate.chip = dt.chip;

                QuanLyShop.SaveChanges();
                DETAIL_DTO dtDTO = ConvertDTO(dtUpdate);
                return dtDTO;
            }
            return null;
        }

        public static List<DETAIL_DTO> GetDetailRam(string text)
        {
            QuanLyShop = new QUANLYCUAHANGEntities();
            return (from ct in QuanLyShop.BANG_DETAIL where ct.ram.Contains(text) select new DETAIL_DTO { iddetail = ct.iddetail, manhinh = ct.manhinh, cameratruoc = ct.cameratruoc, camerasau = ct.camerasau, os = ct.os, ram = ct.ram, rom = ct.rom, dungluongpin = ct.dungluongpin, chip = ct.chip }).ToList();
        }

        public static List<DETAIL_DTO> GetDetailRom(string text)
        {
            QuanLyShop = new QUANLYCUAHANGEntities();
            return (from ct in QuanLyShop.BANG_DETAIL where ct.rom.Contains(text) select new DETAIL_DTO { iddetail = ct.iddetail, manhinh = ct.manhinh, cameratruoc = ct.cameratruoc, camerasau = ct.camerasau, os = ct.os, ram = ct.ram, rom = ct.rom, dungluongpin = ct.dungluongpin, chip = ct.chip }).ToList();
        }

        public static List<DETAIL_DTO> GetDetailPin(string text)
        {
            QuanLyShop = new QUANLYCUAHANGEntities();
            return (from ct in QuanLyShop.BANG_DETAIL where ct.dungluongpin.Contains(text) select new DETAIL_DTO { iddetail = ct.iddetail, manhinh = ct.manhinh, cameratruoc = ct.cameratruoc, camerasau = ct.camerasau, os = ct.os, ram = ct.ram, rom = ct.rom, dungluongpin = ct.dungluongpin, chip = ct.chip }).ToList();
        }

        public static List<DETAIL_DTO> GetDetailChip(string text)
        {
            QuanLyShop = new QUANLYCUAHANGEntities();
            return (from ct in QuanLyShop.BANG_DETAIL where ct.chip.Contains(text) select new DETAIL_DTO { iddetail = ct.iddetail, manhinh = ct.manhinh, cameratruoc = ct.cameratruoc, camerasau = ct.camerasau, os = ct.os, ram = ct.ram, rom = ct.rom, dungluongpin = ct.dungluongpin, chip = ct.chip }).ToList();
        }


        //Tìm kiếm chi tiết sản phẩm
        public static List<DETAIL_DTO> TimChiTietSanPham(string idDt)
        {
            return null;
        }

        //get single detail
        public static List<DETAIL_DTO> GetSingleDetail(string id)
        {
            QuanLyShop = new QUANLYCUAHANGEntities();
            return (from ct in QuanLyShop.BANG_DETAIL where ct.iddetail == id select new DETAIL_DTO { iddetail = ct.iddetail, manhinh = ct.manhinh, cameratruoc = ct.cameratruoc, camerasau = ct.camerasau, os = ct.os, ram = ct.ram, rom = ct.rom, dungluongpin = ct.dungluongpin, chip = ct.chip }).ToList();
        }
    }
}
