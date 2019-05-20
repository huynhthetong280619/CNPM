using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA_TRANFER_OBJECT
{
    public class SANPHAM_DTO
    {
        public string idsanpham { get; set; }
        public string idcategory { get; set; }
        public string name { get; set; }
        public Nullable<int> price { get; set; }
        public string idblock { get; set; }
        public string iddetail { get; set; }
        public string datesell { get; set; }
        public byte[] image { get; set; }
        public Nullable<int> soluong { get; set; }

        //customize
        public string tenkho { get; set; }
        public string category { get; set; }
        public string thongtinchitiet { get; set; }

    }
}
