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
    
    public partial class LopHoc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LopHoc()
        {
            this.BienLais = new HashSet<BienLai>();
            this.HocViens = new HashSet<HocVien>();
            this.MonHocs = new HashSet<MonHoc>();
        }
    
        public string MaLH { get; set; }
        public string TenLop { get; set; }
        public Nullable<int> SiSo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BienLai> BienLais { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HocVien> HocViens { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MonHoc> MonHocs { get; set; }

        //lophoc
        public static string TangMaLH(string mahv)
        {
            string[] x = mahv.Split('H');
            string a = Convert.ToString(Convert.ToInt32(x[1]) + 1);
            int b = a.Length;
            if (b < 3)
                for (int i = 0; i < 3 - b; i++)
                    a = "0" + a;
            return "LH" + a;
        }
        public int GetSiSo()
        {
            return HocViens.Count;
        }
    }
}
