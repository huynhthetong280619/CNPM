using BUSSINESS_LOGIC_LAYER;
using DATA_ACCESS_LAYER;
using DATA_TRANFER_OBJECT;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TOOLS;

namespace QuanLyCuaHang
{
    public partial class frm_repairProduct : Form
    {
        List<SANPHAM_DTO> lstSanPham = new List<SANPHAM_DTO>();
        List<BLOCK_DTO> lstBlock = new List<BLOCK_DTO>();
        byte[] image = null;
        int quanityRepair = 0;
        ConvertImage cvImage;

        public frm_repairProduct(string idSp,int soLuongCanSua)
        {
            InitializeComponent();
            lstSanPham = SANPHAM_BUL.GetSingleProduct(idSp);
            lstBlock = BLOCK_BUL.LayDanhSachKhoHang();
            quanityRepair = soLuongCanSua;
        }

        private void frm_repairProduct_Load(object sender, EventArgs e)
        {
            tbx_name.Text = lstSanPham[0].name;
            tbx_CodeID.Text = lstSanPham[0].idsanpham;
            tbx_price.Text = lstSanPham[0].price.ToString();

            cmbox_block.DataSource = lstBlock;
            cmbox_block.DisplayMember = "name";
            cmbox_block.ValueMember = "idblock";

            nudown.Minimum = quanityRepair;
            nudown.Enabled = false;
            nudown.Value = quanityRepair;

            cvImage = new ConvertImage();
            if (lstSanPham[0].image != null)
            {
                ptb_Img.Image = cvImage.ByteToImage(lstSanPham[0].image);
            }
            else
            {
                ptb_Img.Image = null;
            }
        }

        private void ptb_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ptb_Img_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "JPG | *.jpg | PNG | .*PNG | All File | *.*";
            if (openFile.ShowDialog() == DialogResult.OK)
            {

            }

            if (openFile.FileName.Trim() != "")
            {
                FileStream fileStream = new FileStream(openFile.FileName, FileMode.Open, FileAccess.Read);
                BinaryReader bnr = new BinaryReader(fileStream);
                image = bnr.ReadBytes((int)fileStream.Length);
                ptb_Img.Image = cvImage.ByteToImage(image);
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            BANG_SANPHAM sp = new BANG_SANPHAM();
            MD5 hash = new MD5();

            sp.idblock = cmbox_block.SelectedValue.ToString();
            sp.idsanpham = tbx_CodeID.Text;
            sp.idcategory = lstSanPham[0].idcategory;
            sp.iddetail = lstSanPham[0].iddetail;
            sp.price = int.Parse(tbx_price.Text);
            sp.soluong = int.Parse(nudown.Value.ToString());
            sp.image = image;
            sp.name = tbx_name.Text;
            sp.datesell = null;

            if((cmbox_block.SelectedValue.ToString() != lstSanPham[0].idblock || lstSanPham[0].price != int.Parse(tbx_price.Text)) && quanityRepair < lstSanPham[0].soluong)
            {
                sp.idsanpham = tbx_CodeID.Text.Trim(' ').Substring(tbx_CodeID.Text.Length-2) + cmbox_block.Text;
                SANPHAM_DTO result=SANPHAM_BUL.ThemSanPham(sp);
                if (result != null)
                {
                    MessageBox.Show("Chỉnh sửa thành công!", "Notice", MessageBoxButtons.OK);
                    CapNhatSanPhamCu();
                    string idBlockOld = lstSanPham[0].idblock;
                    string idBlockNew = cmbox_block.SelectedValue.ToString();
                    CapNhatBlock(idBlockOld, idBlockNew);
                }
            }
            else
            {
                SANPHAM_BUL.SuaSanPham(sp);
                MessageBox.Show("Cập nhật avatar thành công !", "Notice", MessageBoxButtons.OK);
            }

        }

        private void CapNhatSanPhamCu()
        {
            BANG_SANPHAM sp = new BANG_SANPHAM();
            sp.idblock = lstSanPham[0].idblock;
            sp.idsanpham = lstSanPham[0].idsanpham;
            sp.idcategory = lstSanPham[0].idcategory;
            sp.iddetail = lstSanPham[0].iddetail;
            sp.price = lstSanPham[0].price;
            sp.soluong = lstSanPham[0].soluong-quanityRepair;
            sp.image = lstSanPham[0].image;
            sp.name = lstSanPham[0].name;
            sp.datesell = null;

            SANPHAM_BUL.SuaSanPham(sp);

        }

        private void CapNhatBlock(string idBlockOld,string idBlockNew)
        {
            int quanityOld = SANPHAM_BUL.QuantityFlBlock(idBlockOld);
            int quanityNew = SANPHAM_BUL.QuantityFlBlock(idBlockNew);

            SuaKho(quanityOld, idBlockOld);
            SuaKho(quanityNew, idBlockNew);
        }

        private void SuaKho(int quantity,string idBlock)
        {
            BANG_BLOCK bl = new BANG_BLOCK();
            bl.idblock = idBlock;
            bl.name = BLOCK_BUL.GetNameThrKeyBlock(idBlock);
            bl.soluong = quantity;
            BLOCK_BUL.SuaKhoHang(bl);
        }

        private void circleButton3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
