using PBL3.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.BLL
{
    class BLL_Admin
    {
        private static BLL_Admin _Instance;
        public static BLL_Admin Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new BLL_Admin();
                return _Instance;
            }
            private set { }
        }
        public Adminn CheckTK(string tk,string pw)
        {
            QLTTDayThem db = new QLTTDayThem();
            Adminn a = db.Adminns.Find(tk);
            if (a != null && a.MatKhau == pw)
                return a;
            else return null;
        }        
        public void DoiMatKhau(string tk,string mkmoi)
        {
            QLTTDayThem db = new QLTTDayThem();
            Adminn a = db.Adminns.Find(tk);
            a.MatKhau = mkmoi;
            db.SaveChanges();
        }
        
        public List<Adminn> GetListAdmin(string cv)
        {
            QLTTDayThem db = new QLTTDayThem();
            if (cv == "All")
            {
                var l = from p in db.Adminns select p;
                return l.ToList();
            }
            else
            {
                var l = from p in db.Adminns where p.ChucVu == cv select p;
                return l.ToList();
            }
        }
        public Adminn GetADbyTK(string tk)
        {
            QLTTDayThem db = new QLTTDayThem();
            return db.Adminns.Find(tk);
        }
        public void ExecuteDB(Adminn a)
        {
            QLTTDayThem db = new QLTTDayThem();
            Adminn ad = db.Adminns.Find(a.TaiKhoan);
            if (ad != null)
            {
                ad.MatKhau = a.MatKhau;
                ad.ChucVu = a.ChucVu;
                db.SaveChanges();
            }
            else
            {
                db.Adminns.Add(a);
                db.SaveChanges();
            }
        }
        public bool CheckTK(string tk)
        {
            QLTTDayThem db = new QLTTDayThem();
            Adminn ad = db.Adminns.Find(tk);
            if (ad != null) return true;
            else return false;
        }
        public void XoaTK(List<string> tk)
        {
            QLTTDayThem db = new QLTTDayThem();
            for (int i = 0; i < tk.Count; i++)
            {
                Adminn ad = db.Adminns.Find(tk[i]);
                db.Adminns.Remove(ad);
                db.SaveChanges();
            }
        }

    }
}
