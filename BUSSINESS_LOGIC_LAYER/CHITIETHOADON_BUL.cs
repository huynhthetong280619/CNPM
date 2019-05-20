using DATA_ACCESS_LAYER;
using DATA_TRANFER_OBJECT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUSSINESS_LOGIC_LAYER
{
    public class CHITIETHOADON_BUL
    {
        public static CHITIETHOADON_DTO ThemChiTietHoaDon(BANG_CHITIETHOADON bcthd)
        {
            return CHITIETHOADON_DAL.ThemChiTietHoaDon(bcthd);
        }
    }
}
