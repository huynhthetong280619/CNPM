using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA_TRANFER_OBJECT
{
    public class HISTORY_DTO
    {
        public string idhistory { get; set; }
        public string idnhanvien { get; set; }
        public string idkhachhang { get; set; }
        public Nullable<System.DateTime> ngayban { get; set; }
        public Nullable<System.DateTime> ngayluukho { get; set; }
        public string chitiet { get; set; }


        //customize
        public string nhanvien { get; set; }
        public string khachhang { get; set; }
    }
}
