using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA_TRANFER_OBJECT
{
    public class KHACHHANG_DTO
    {
        public string idkhachhang { get; set; }
        public string name { get; set; }
        public string phonenumber { get; set; }
        public string address { get; set; }
        public string idkhuyenmai { get; set; }
        public Nullable<bool> gender { get; set; }
        public Nullable<int> Old { get; set; }
        public Nullable<System.DateTime> createdate { get; set; }
        public string Chitiet { get; set; }

        //customize
        public string makhuyenmai { get; set; }
    }
}
