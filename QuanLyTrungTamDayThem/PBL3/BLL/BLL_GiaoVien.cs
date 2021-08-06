using PBL3.DAL;
using PBL3.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.BLL
{
    class BLL_GiaoVien
    {
        private static BLL_GiaoVien _Instance;
        public static BLL_GiaoVien Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new BLL_GiaoVien();
                return _Instance;
            }
            private set { }
        }
        public List<giaovien> GetListGiaoVien(string hoten)
        {
            QLTTDayThem db = new QLTTDayThem();
            List<giaovien> gv = new List<giaovien>();

            var l = from p in db.GiaoViens
                    where p.HoTen.Contains(hoten)
                    select new { p.MaGV, p.HoTen, p.NamSinh, p.GioiTinh, p.DiaChi, p.SDT, p.ChuyenMon, p.TrinhDo };
            foreach (var i in l)
                gv.Add(new giaovien
                {
                    MaGV = i.MaGV,
                    HoTen = i.HoTen,
                    NamSinh = Convert.ToDateTime(i.NamSinh),
                    GioiTinh = Convert.ToBoolean(i.GioiTinh),
                    DiaChi = i.DiaChi,
                    SDT = i.SDT,
                    TrinhDo = i.TrinhDo,
                    ChuyenMon = i.ChuyenMon
                });
            return gv;
        }
        public GiaoVien GetGVbyMaGV(string magv)
        {
            QLTTDayThem db = new QLTTDayThem();
            return db.GiaoViens.Find(magv);
        }
        // tăng MaHV lên 1 đơn vị
        public string XulyMaGV()
        {
            QLTTDayThem db = new QLTTDayThem();
            // tìm gv cuối cùng của danh sách
            GiaoVien gv = db.GiaoViens.OrderByDescending(x => x.MaGV).Take(1).Single();

            return GiaoVien.TangMaGV(gv.MaGV);
        }
        public void ExecuteDB(GiaoVien g)
        {
            QLTTDayThem db = new QLTTDayThem();
            GiaoVien gv = db.GiaoViens.Find(g.MaGV);
            if (gv != null)
            {
                gv.HoTen = g.HoTen;
                gv.NamSinh = g.NamSinh;
                gv.GioiTinh = g.GioiTinh;
                gv.DiaChi = g.DiaChi;
                gv.TrinhDo = g.TrinhDo;
                gv.ChuyenMon = g.ChuyenMon;
                gv.SDT = g.SDT;
                db.SaveChanges();
            }
            else
            {
                db.GiaoViens.Add(g);
                db.SaveChanges();
            }
        }
        public void XoaGV(List<string> magv)
        {
            QLTTDayThem db = new QLTTDayThem();
            for (int i = 0; i < magv.Count; i++)
            {
                GiaoVien gv = db.GiaoViens.Find(magv[i]);
                db.GiaoViens.Remove(gv);
                db.SaveChanges();
            }
        }
        public List<giaovien> SortGV(string item)
        {
            List<giaovien> l = GetListGiaoVien("");
            if (item == "Họ Tên")
                l.Sort(giaovien.SortByHoTen);
            if (item == "Trình Độ")
                l.Sort(giaovien.SortByTrinhDo);
            if (item == "Chuyên Môn")
                l.Sort(giaovien.SortByChuyenMon);
            return l;
        }
    }
}
