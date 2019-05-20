using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA_TRANFER_OBJECT
{
    public class NHANVIEN_DTO
    {
        public string idnhanvien { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string name { get; set; }
        public Nullable<int> phonenumber { get; set; }
        public Nullable<int> idcard { get; set; }
        public string address { get; set; }
        public string idhistorysell { get; set; }
        public string position { get; set; }
        public byte[] avatar { get; set; }
        public Boolean gender { get; set; }

    }
}
