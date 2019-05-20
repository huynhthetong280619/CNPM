using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA_TRANFER_OBJECT
{
    public class HOADON_DTO
    {
        public string idhoadon { get; set; }
        public string idnhanvien { get; set; }
        public string idkhachhang { get; set; }
        public Nullable<int> tongtien { get; set; }
        public string idkhuyenmai { get; set; }
        public Nullable<System.DateTime> ngayban { get; set; }
        public Nullable<int> tongtiencuoi { get; set; }
        public Nullable<int> soluong { get; set; }

        //customize
        public string khachhang { get; set; }
        public string khuyenmai { get; set; }
        public string nhanvien { get; set; }
    }
}
