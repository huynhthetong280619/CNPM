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
using DATA_TRANFER_OBJECT;
using DATA_ACCESS_LAYER;
using BUSSINESS_LOGIC_LAYER;


namespace QuanLyCuaHang
{
    public partial class frm_AddProduct : Form
    {
        public frm_AddProduct()
        {
            InitializeComponent();
        }
        byte[] image = null;
        ConvertImage cvImg;
       
        //Danh các data cần load.
        List<CATEGORY_DTO> lstCate = new List<CATEGORY_DTO>();
        List<DETAIL_DTO> lstDetail = new List<DETAIL_DTO>();
        List<BLOCK_DTO> lstBlock = new List<BLOCK_DTO>();
        private void frm_AddProduct_Load(object sender, EventArgs e)
        {
            lstCate = CATEGORY_BUL.LayDanhSachTheLoai();
            lstBlock = BLOCK_BUL.LayDanhSachKhoHang();
            lstDetail = DETAIL_BUL.LayDanhSachChiTietSanPham();
            cmbox_block.DataSource = lstBlock;
            cmbox_block.DisplayMember = "name";
            cmbox_block.ValueMember = "idblock";

            cmbox_cate.DataSource = lstCate;
            cmbox_cate.DisplayMember = "name";
            cmbox_cate.ValueMember = "idcategory";
            
            
            cmbox_detail.DataSource = lstDetail;
            cmbox_detail.DisplayMember = "iddetail";
            cmbox_detail.ValueMember = "iddetail";
            

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
                cvImg = new ConvertImage();
                FileStream fileStream = new FileStream(openFile.FileName, FileMode.Open, FileAccess.Read);
                BinaryReader bnr = new BinaryReader(fileStream);
                image = bnr.ReadBytes((int)fileStream.Length);
                ptb_Img.Image = cvImg.ByteToImage(image);
            }
        }

        private void ptb_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        Random rd;
        private void btn_addProduct_Click(object sender, EventArgs e)
        {
            BANG_SANPHAM sp = new BANG_SANPHAM();
            CreateID crID = new CreateID();
            rd = new Random();
            MD5 hash = new MD5();
            string nameProduct = tbx_name.Text;
            bool Exist=SANPHAM_BUL.CheckExist(nameProduct.ToLower(),tbx_CodeID.Text.ToLower());

            sp.idsanpham = tbx_CodeID.Text;
            sp.soluong = Int32.Parse(nudown.Value.ToString());
            sp.idcategory = cmbox_cate.SelectedValue.ToString();
            sp.iddetail = cmbox_detail.SelectedValue.ToString();
            sp.idblock = cmbox_block.SelectedValue.ToString();
            sp.price = int.Parse(tbx_price.Text);
            sp.image = image;
            sp.name = tbx_name.Text;
            sp.datesell = null;

            SANPHAM_DTO result;
            if (Exist)
            {
                 result=SANPHAM_BUL.SuaSanPham(sp);
            }
            else
            {
                result=SANPHAM_BUL.ThemSanPham(sp);

            }

          
            if (result != null)
            {
                MessageBox.Show("Thao tác thành công !", "Notice", MessageBoxButtons.OK);
                UpdateCate(sp.idcategory,cmbox_cate.Text);

                BANG_HISTORY ls = new BANG_HISTORY();
                string ct = "LƯU KHO\n" + "Thời gian: " + DateTime.Now.Date + "\n Mã nhân viên: " + frm_Login.idLogin + "\nThêm vào kho sản phẩm gồm:\n" + tbx_name.Text + " Số lượng : " + nudown.Value.ToString() + "\nĐơn giá :" + tbx_price.Text + "\nTổng giá trị: " + double.Parse(tbx_price.Text) * double.Parse(nudown.Value.ToString()) + "\n";
                CreateID idR = new CreateID();
                rd = new Random();
                string idhs = "HS0" + idR.ID(rd.Next(100, 100).ToString());
                ls.idhistory =idhs;
                ls.idkhachhang = null;
                ls.idnhanvien = frm_Login.idLogin;
                ls.ngayban = null;
                ls.ngayluukho = DateTime.Now.Date;
                ls.chitiet =ct;

                HISTORY_BUL.ThemLichSu(ls);
            }
            else
            {
                MessageBox.Show("Xảy ra lỗi !", "Error", MessageBoxButtons.OK);
            }

        }


        private void UpdateCate(string idCate,string nameCate)
        {
            int quanity = SANPHAM_BUL.Quanity(idCate);

            BANG_CATEGORY cate = new BANG_CATEGORY();
            cate.idcategory = idCate;
            cate.name = nameCate;
            cate.quanity = quanity;

            CATEGORY_DTO result= CATEGORY_BUL.SuaTheLoai(cate);
            if (result != null)
            {
                MessageBox.Show("Complete!");
            }
            else
            {
                MessageBox.Show("Error!");
            }


        }

        private void tbx_name_KeyUp(object sender, KeyEventArgs e)
        {
            string key = tbx_name.Text;
            List<SANPHAM_DTO> lstProductLike = SANPHAM_BUL.GetProductLike(key);
            if (lstProductLike != null)
            {
                cmbox_Goiy.DataSource = lstProductLike;
                cmbox_Goiy.DisplayMember = "name";
                cmbox_Goiy.ValueMember = "name";
            }
        }


        private void cmbox_Goiy_SelectionChangeCommitted(object sender, EventArgs e)
        {
            tbx_name.Text = cmbox_Goiy.Text;

            List<SANPHAM_DTO> Single = SANPHAM_BUL.GetSingleProductName(cmbox_Goiy.SelectedValue.ToString());

            if (Single != null)
            {
                tbx_CodeID.Text = Single[0].idsanpham;
                cmbox_detail.SelectedValue = Single[0].iddetail;
                cmbox_block.SelectedValue = Single[0].idblock;
                cmbox_cate.SelectedValue = Single[0].idcategory;
                tbx_price.Text = Single[0].price.ToString();

                if (Single[0].soluong == null)
                {
                    nudown.Minimum = 0;
                    nudown.Value = 0;
                }
                else
                {
                    nudown.Minimum = Int32.Parse(Single[0].soluong.ToString());
                    nudown.Value= Int32.Parse(Single[0].soluong.ToString());
                } 
            }
        }

        private void circleButton3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
