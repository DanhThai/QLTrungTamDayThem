using PBL3.DAL;
using PBL3.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.BLL
{
    class BLL_HocVien
    {
        private static BLL_HocVien _Instance;
        public static BLL_HocVien Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new BLL_HocVien();
                return _Instance;
            }
            private set { }
        }
        public List<CbbItem> SetCbbLopHoc()
        {
            QLTTDayThem db = new QLTTDayThem();
            List<CbbItem> s = new List<CbbItem>();
           

            var a = from p in db.LopHocs select new { p.MaLH, p.TenLop };
            foreach (var i in a)
                s.Add(new CbbItem { value = i.MaLH, text = i.TenLop });
            return s;
        }
        public List<hocvien> GetListHocVien(string malop, string hoten)
        {
            QLTTDayThem db = new QLTTDayThem();
            List<hocvien> h = new List<hocvien>();
            if (malop == "0")
            {
                var l = from p in db.HocViens
                        where p.HoTen.Contains(hoten)
                        select new { p.MaHV, p.LopHoc.TenLop,p.LopHoc.SiSo, p.HoTen, p.NamSinh, p.GioiTinh, p.DiaChi, p.SDT, p.TinhTrang };
                foreach (var i in l)
                    h.Add(new hocvien
                    {
                        MaHV = i.MaHV,
                        TenLop = i.TenLop,
                        SiSo=Convert.ToInt32(i.SiSo),
                        HoTen = i.HoTen,
                        NamSinh = Convert.ToDateTime(i.NamSinh),
                        GioiTinh = Convert.ToBoolean(i.GioiTinh),
                        DiaChi = i.DiaChi,
                        SDT = i.SDT,
                        TinhTrang = i.TinhTrang
                    });
            }
            ///
            else
            {
                var l = from p in db.HocViens
                        where p.MaLH == malop && p.HoTen.Contains(hoten)
                        select new { p.MaHV, p.LopHoc.TenLop, p.LopHoc.SiSo, p.HoTen, p.NamSinh, p.GioiTinh, p.DiaChi, p.SDT, p.TinhTrang };
                foreach (var i in l)
                    h.Add(new hocvien
                    {
                        MaHV = i.MaHV,
                        TenLop = i.TenLop,
                        SiSo = Convert.ToInt32(i.SiSo),
                        HoTen = i.HoTen,
                        NamSinh = Convert.ToDateTime(i.NamSinh),
                        GioiTinh = Convert.ToBoolean(i.GioiTinh),
                        DiaChi = i.DiaChi,
                        SDT = i.SDT,
                        TinhTrang = i.TinhTrang
                    });
            }

            return h;
        }
        // tăng MaHV lên 1 đơn vị
        public string XulyMaHV()
        {
            QLTTDayThem db = new QLTTDayThem();
            // tìm hv cuối cùng của danh sách
            HocVien hv = db.HocViens.OrderByDescending(x => x.MaHV).Take(1).Single();

            return HocVien.TangMaHV(hv.MaHV);
        }
        public HocVien GetHVbyMaHV(string mahv)
        {
            QLTTDayThem db = new QLTTDayThem();
            return db.HocViens.Find(mahv);
        }
        public void ExecuteDB(HocVien h)
        {
            QLTTDayThem db = new QLTTDayThem();
            HocVien hv = db.HocViens.Find(h.MaHV);
            
            if (hv != null)
            {
                string malh = hv.MaLH;
                // set lại dữ liệu
                hv.HoTen = h.HoTen;                 
                hv.MaLH = h.MaLH;
                hv.NamSinh = h.NamSinh;
                hv.GioiTinh = h.GioiTinh;
                hv.DiaChi = h.DiaChi;
                hv.SDT = h.SDT;
                hv.TinhTrang = h.TinhTrang;               
                db.SaveChanges();
                // set lại sĩ số
                if (malh != h.MaLH)
                {
                    LopHoc lh1 = db.LopHocs.Find(h.MaLH);
                    lh1.SiSo = lh1.GetSiSo();
                    LopHoc lh2 = db.LopHocs.Find(malh);
                    lh2.SiSo = lh2.GetSiSo();
                    db.SaveChanges();
                }
                

            }
            else
            {
                db.HocViens.Add(h);
                LopHoc lh = db.LopHocs.Find(h.MaLH);
                lh.SiSo = lh.GetSiSo();
                db.SaveChanges();
                // add biên lai
                BienLai bl = new BienLai()
                {
                    MaHV = h.MaHV,
                    MaLH=h.MaLH,
                    TinhTrang="Chưa nộp",
                    HocPhi=0
                };
                BLL_BienLai.Instance.AddBienLai(bl);
            }
        }
        public void XoaListHV(List<string> mahv)
        {
            QLTTDayThem db = new QLTTDayThem();
            for (int i = 0; i < mahv.Count; i++)
            {
                HocVien hv = db.HocViens.Find(mahv[i]);
                LopHoc lh = db.LopHocs.Find(hv.MaLH);
                lh.SiSo = lh.GetSiSo()-1;
                db.HocViens.Remove(hv);               
                db.SaveChanges();
            }
        }
        public void XoaAllHVbyLop(string malop)
        {                     
            List<string> s = new List<string>();
            QLTTDayThem db = new QLTTDayThem();
            var l = from p in db.HocViens
                    where p.MaLH == malop
                    select p;
            // get list MaHV
            foreach (var i in l)
            {
                s.Add(i.MaHV);
            }
            // Xóa học viên
            for (int i = 0; i < s.Count; i++)
            {
                HocVien hv = db.HocViens.Find(s[i]);
                LopHoc lh = db.LopHocs.Find(hv.MaLH);
                lh.SiSo = lh.GetSiSo() - 1;
                db.HocViens.Remove(hv);
                db.SaveChanges();
            }
        }
        public List<hocvien> SortHV(string malop, string item)
        {
            List<hocvien> l = GetListHocVien(malop, "");
            if (item == "Họ Tên")
                l.Sort(hocvien.SortByHoTen);
            if (item == "Tình Trạng")
                l.Sort(hocvien.SortByTinhTrang);
            return l;
        }
    }
}
