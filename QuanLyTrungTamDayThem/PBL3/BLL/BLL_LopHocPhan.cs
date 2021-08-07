using PBL3.DAL;
using PBL3.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.BLL
{
    class BLL_LopHocPhan
    {
        private static BLL_LopHocPhan _Instance;
        public static BLL_LopHocPhan Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new BLL_LopHocPhan();
                return _Instance;
            }
            private set { }
        }
        // Get all các comboBox
        
        public List<CbbItem> GetCbbLopHoc()
        {
            QLTTDayThem db = new QLTTDayThem();
            List<CbbItem> s = new List<CbbItem>();
            s.Add(new CbbItem { value = "0", text = "All" });
            var a = from p in db.LopHocs  select new { p.MaLH, p.TenLop };
            foreach (var i in a)
                s.Add(new CbbItem { value = i.MaLH, text = i.TenLop });
            return s;
        }
        public List<CbbItem> GetCbbGiaoVien(string monhoc)
        {
            QLTTDayThem db = new QLTTDayThem();
            List<CbbItem> s = new List<CbbItem>();

            var a = from p in db.GiaoViens where p.ChuyenMon.Contains(monhoc) select new { p.MaGV, p.HoTen };
            foreach (var i in a)
                s.Add(new CbbItem { value = i.MaGV, text = i.HoTen });
            return s;
        }
        // Lấy danh sách lớp học phần
        public List<lophocphan> GetListLHP( string malh, string mon)
        {
            List<lophocphan> l = new List<lophocphan>();
            QLTTDayThem db = new QLTTDayThem();
            // get all lop học
            if (malh == "0")
            {
                var a = from p in db.MonHocs
                        where  p.TenMon.Contains(mon) 
                        select new
                        {
                            p.MaLH,
                            p.MaMH,                          
                            p.LopHoc.TenLop,
                            p.LopHoc.SiSo,
                            p.TenMon,
                            p.GiaoVien.HoTen,
                            p.ThoiGianHoc,
                            p.NgayBatDau,
                            p.NgayKetThuc
                        };
                foreach (var i in a)
                {
                    l.Add(new lophocphan
                    {
                        MaLH = i.MaLH,
                        MaMH = i.MaMH,                      
                        TenLop = i.TenLop,
                        SiSo=Convert.ToInt32(i.SiSo),
                        TenMon = i.TenMon,
                        HoTenGV = i.HoTen,
                        ThoiGianHoc = i.ThoiGianHoc,
                        NgayBatDau = Convert.ToDateTime(i.NgayBatDau),
                        NgayKetThuc = Convert.ToDateTime(i.NgayKetThuc)
                    });
                }
            }
            ////
            else
            {
                var a = from p in db.MonHocs
                        where  p.MaLH == malh && p.TenMon.Contains(mon) 
                        select new
                        {
                            p.MaLH,
                            p.MaMH,                        
                            p.LopHoc.TenLop,
                            p.LopHoc.SiSo,
                            p.TenMon,
                            p.GiaoVien.HoTen,
                            p.ThoiGianHoc,
                            p.NgayBatDau,
                            p.NgayKetThuc
                        };
                foreach (var i in a)
                {
                    l.Add(new lophocphan
                    {
                        MaLH = i.MaLH,
                        MaMH = i.MaMH,                       
                        TenLop = i.TenLop,
                        SiSo = Convert.ToInt32(i.SiSo),
                        TenMon = i.TenMon,
                        HoTenGV = i.HoTen,
                        ThoiGianHoc = i.ThoiGianHoc,
                        NgayBatDau = Convert.ToDateTime(i.NgayBatDau),
                        NgayKetThuc = Convert.ToDateTime(i.NgayKetThuc)
                    });
                }
            }

            return l;
        }

        public MonHoc GetMHbyMaMH(string mamh)
        {
            QLTTDayThem db = new QLTTDayThem();
            return db.MonHocs.Find(mamh);
        }
        public LopHoc GetLHbyMaLH(string malh)
        {
            QLTTDayThem db = new QLTTDayThem();
            return db.LopHocs.Find(malh);
        }
        public string XulyMaMH()
        {
            QLTTDayThem db = new QLTTDayThem();
            // tìm mh cuối cùng của danh sách
            MonHoc mh = db.MonHocs.OrderByDescending(x => x.MaMH).Take(1).Single();
            return MonHoc.TangMaMH(mh.MaMH);
        }
        public string XulyMaLH()
        {
            QLTTDayThem db = new QLTTDayThem();
            // tìm mh cuối cùng của danh sách
            LopHoc lh = db.LopHocs.OrderByDescending(x => x.MaLH).Take(1).Single();
            return LopHoc.TangMaLH(lh.MaLH);
        }

        public void ExecuteDB(MonHoc mh)
        {
            QLTTDayThem db = new QLTTDayThem();
            MonHoc m = db.MonHocs.Find(mh.MaMH);
           
            if (m != null )
            {
                m.MaLH = mh.MaLH;
                m.TenMon = mh.TenMon;
                m.MaGV = mh.MaGV;
                m.ThoiGianHoc = mh.ThoiGianHoc;
                m.NgayBatDau = mh.NgayBatDau;
                m.NgayKetThuc = mh.NgayKetThuc;
                
                db.SaveChanges();
            }
            else
            {               
                db.MonHocs.Add(mh);
                db.SaveChanges();
            }
        }
        public void XoaListMonHoc(List<string> mamh)
        {
            QLTTDayThem db = new QLTTDayThem();
            for (int i = 0; i < mamh.Count; i++)
            {
                MonHoc mh = db.MonHocs.Find(mamh[i]);
                db.MonHocs.Remove(mh);
                db.SaveChanges();
            }
        }
        public bool CheckTen(string tenlop)
        {
            QLTTDayThem db = new QLTTDayThem();
            var a = from p in db.LopHocs where p.TenLop==tenlop select p;
            if (a == null)
                return true;
            else
                return false;
            
        }
        public void ThemLop(string tenlop)
        {
            QLTTDayThem db = new QLTTDayThem();
            LopHoc lh = db.LopHocs.OrderByDescending(x => x.MaLH).Take(1).Single();
            LopHoc l = new LopHoc
            {
                MaLH=LopHoc.TangMaLH(lh.MaLH),
                TenLop = tenlop,
                SiSo=0
            };
            db.LopHocs.Add(l);
            db.SaveChanges();
        }
        public void XoaLop(string malop)
        {
            QLTTDayThem db = new QLTTDayThem();
            // xóa all học viên thuộc lớp
            BLL_HocVien.Instance.XoaAllHVbyLop(malop);            
            
            LopHoc lh = db.LopHocs.Find(malop);
            db.LopHocs.Remove(lh);
            db.SaveChanges();            
        }
        public List<MonHoc> GetListLichDay(string magv)
        {
            List<MonHoc> l = new List<MonHoc>();
            QLTTDayThem db = new QLTTDayThem();
            var a= from p in db.MonHocs
                   where p.GiaoVien.MaGV==magv
                   select p;
            return a.ToList();
        }

    }
}
