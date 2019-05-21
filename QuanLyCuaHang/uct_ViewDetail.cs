using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DATA_TRANFER_OBJECT;
using BUSSINESS_LOGIC_LAYER;
using TOOLS;

namespace QuanLyCuaHang
{
    public partial class uct_ViewDetail : UserControl
    {
        List<SANPHAM_DTO> lstSP;
        List<DETAIL_DTO> lstDetail;
        ConvertImage convert = new ConvertImage();
        public uct_ViewDetail()
        {
            InitializeComponent();
            lstSP = SANPHAM_BUL.LayDanhSachSanPham("");
            foreach (SANPHAM_DTO item in lstSP)
            {
                lstDetail = DETAIL_BUL.GetSingleDetail(item.iddetail);
                LayoutSanPham layoutSanPham = new LayoutSanPham();
                Image image;
                if (item.image != null)
                    image = convert.ByteToImage(item.image);
                else
                    image = Properties.Resources.avatar;
                layoutSanPham.SetValue(image, item.name, (int)item.price);
                layoutSanPham.SetDetail(lstDetail[0].manhinh, lstDetail[0].cameratruoc, lstDetail[0].camerasau, lstDetail[0].os, lstDetail[0].ram, lstDetail[0].rom, lstDetail[0].dungluongpin, lstDetail[0].chip);
                gradient1.Controls.Add(layoutSanPham);
            }
        }
    }
}
