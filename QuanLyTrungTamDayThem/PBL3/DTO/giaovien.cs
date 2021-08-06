using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DTO
{
    class giaovien
    {
        public string MaGV { get; set; }
        public string HoTen { get; set; }
        public DateTime NamSinh { get; set; }
        public bool GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public string ChuyenMon { get; set; }
        public string TrinhDo { get; set; }
        public string SDT { get; set; }
        public static int SortByHoTen(object o1, object o2)
        {
            string[] hv1 = ((giaovien)o1).HoTen.Split(' ');
            string[] hv2 = ((giaovien)o2).HoTen.Split(' ');

            if (string.Compare(hv1.Last(), hv2.Last()) > 0)
                return 1;
            else
            {
                if (string.Compare(hv1.Last(), hv2.Last()) == 0)
                    return 0;
                else return -1;
            }
        }
        public static int SortByTrinhDo(object o1, object o2)
        {

            string[] hv1 = ((giaovien)o1).TrinhDo.Split(' ');
            string[] hv2 = ((giaovien)o2).TrinhDo.Split(' ');
            if (string.Compare(hv1.Last(), hv2.Last()) > 0)
                return 1;
            else
            {
                if (string.Compare(hv1.Last(), hv2.Last()) == 0)
                    return 0;
                else return -1;
            }
        }
        public static int SortByChuyenMon(object o1, object o2)
        {

            string[] hv1 = ((giaovien)o1).ChuyenMon.Split(' ');
            string[] hv2 = ((giaovien)o2).ChuyenMon.Split(' ');
            if (string.Compare(hv1.Last(), hv2.Last()) > 0)
                return 1;
            else
            {
                if (string.Compare(hv1.Last(), hv2.Last()) == 0)
                    return 0;
                else return -1;
            }
        }
        ///////////////
        
    }
}
