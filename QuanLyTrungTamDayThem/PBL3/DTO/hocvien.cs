using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DTO
{
    class hocvien
    {
        public string MaHV { get; set; }
      
        public string TenLop { get; set; }
        public int SiSo { get; set; }
        public string HoTen { get; set; }
        public DateTime NamSinh { get; set; }
        public bool GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public string SDT { get; set; }
        public string TinhTrang { get; set; }
        public static int SortByHoTen(object o1,object o2)
        {
            string[] hv1 = ((hocvien)o1).HoTen.Split(' ');
            string[] hv2 = ((hocvien)o2).HoTen.Split(' ');
            
            if (string.Compare(hv1.Last(), hv2.Last()) > 0)
                return 1;
            else
            {
                if (string.Compare(hv1.Last(), hv2.Last()) == 0)
                    return 0;
                else return -1;
            }           
        }
        public static int SortByTinhTrang(object o1, object o2)
        {

            string[] hv1 = ((hocvien)o1).TinhTrang.Split(' ');
            string[] hv2 = ((hocvien)o2).TinhTrang.Split(' ');
            if (string.Compare(hv1.Last(), hv2.Last()) > 0)
                return 1;
            else
            {
                if (string.Compare(hv1.Last(), hv2.Last()) == 0)
                    return 0;
                else return -1;
            }
        }
        
    }
}
