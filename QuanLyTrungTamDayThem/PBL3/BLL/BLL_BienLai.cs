using PBL3.DAL;
using PBL3.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.BLL
{
    class BLL_BienLai
    {
        private static BLL_BienLai _Instance;
        public static BLL_BienLai Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new BLL_BienLai();
                return _Instance;
            }
            private set { }
        }
        public List<CbbItem> GetCbbLopHoc()
        {
            QLTTDayThem db = new QLTTDayThem();
            List<CbbItem> s = new List<CbbItem>();            
            var a = from p in db.LopHocs select new { p.MaLH, p.TenLop };
            foreach (var i in a)
                s.Add(new CbbItem { value = i.MaLH, text = i.TenLop });
            return s;
        }
        public List<bienlai> GetListBienLai(string malop,string tinhtrang,string hoten)
        {
            QLTTDayThem db = new QLTTDayThem();
            List<bienlai> h = new List<bienlai>();
            
                var l = from p in db.BienLais
                        where p.MaLH==malop && p.TinhTrang==tinhtrang&& p.HocVien.HoTen.Contains(hoten)
                        select new { p.MaHV,p.LopHoc.TenLop,p.HocVien.HoTen,p.TinhTrang,p.HocPhi };
                foreach (var i in l)
                    h.Add(new bienlai
                    {
                        MaHV= i.MaHV,
                       TenLH =i.TenLop,
                       HoTen=i.HoTen,
                       TinhTrang=i.TinhTrang,
                       HocPhi=Convert.ToInt32(i.HocPhi)
                    });
            return h;            
        }
        public DataTable GetBienLai(string mahv,int hp)
        {
            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("TenLop",typeof(string)),
                new DataColumn("HoTen",typeof(string)),
                new DataColumn("HocPhi",typeof(int)),
            });
           
            QLTTDayThem db = new QLTTDayThem();
            BienLai bl = db.BienLais.Find(mahv);          
            bl.HocPhi = hp;
                    
            db.SaveChanges();
            // get dữ liệu vào datatable
            DataRow dr = dt.NewRow();
            dr["TenLop"] = bl.LopHoc.TenLop;
            dr["HoTen"] = bl.HocVien.HoTen;
            dr["HocPhi"] = Convert.ToInt32(bl.HocPhi);
            dt.Rows.Add(dr);          
            return dt;
        }
        public void ChangeState(string mahv)
        {
            QLTTDayThem db = new QLTTDayThem();
            BienLai bl = db.BienLais.Find(mahv);
            bl.TinhTrang = "Đã nộp";
            db.SaveChanges();
        }       
        public void AddBienLai(BienLai bl)
        {
            QLTTDayThem db = new QLTTDayThem();
            db.BienLais.Add(bl);
            db.SaveChanges();
        }
    }
}
