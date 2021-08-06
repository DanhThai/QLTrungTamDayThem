using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DTO
{
    class TKB
    {
        public string BuoiHoc { get; set; }
        public string Monday { get; set; }
        public string Tuesday { get; set; }
        public string Webnesday { get; set; }
        public string Thursday { get; set; }
        public string Friday { get; set; }
        public string Saturday { get; set; }
        public TKB(string buoihoc)
        {
            BuoiHoc = buoihoc;
            Monday = "Rảnh"; Tuesday = "Rảnh"; Webnesday = "Rảnh";
            Thursday = "Rảnh"; Friday = "Rảnh"; Saturday = "Rảnh"; 
        }
    }
}
