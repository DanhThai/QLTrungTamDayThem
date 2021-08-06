//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PBL3.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class MonHoc
    {
        public string MaMH { get; set; }
        public string TenMon { get; set; }
        public string MaGV { get; set; }
        public string MaLH { get; set; }
        public string ThoiGianHoc { get; set; }
        public Nullable<System.DateTime> NgayBatDau { get; set; }
        public Nullable<System.DateTime> NgayKetThuc { get; set; }
    
        public virtual GiaoVien GiaoVien { get; set; }
        public virtual LopHoc LopHoc { get; set; }
        public static string TangMaMH(string mahv)
        {
            string[] x = mahv.Split('H');
            string a = Convert.ToString(Convert.ToInt32(x[1]) + 1);
            int b = a.Length;
            if (b < 3)
                for (int i = 0; i < 3 - b; i++)
                    a = "0" + a;
            return "MH" + a;
        }
    }
}
