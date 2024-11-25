using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HoaDon.Models
{
    public class MD_ThongTinHoaDon
    {
        public HoaDon HoaDon { get; set; }
        public DonHang DonHang { get; set; }
        public KhachHang KhachHang { get; set; }
    }
}