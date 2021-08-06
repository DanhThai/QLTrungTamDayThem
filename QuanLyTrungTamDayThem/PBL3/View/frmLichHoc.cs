using PBL3.BLL;
using PBL3.DAL;
using PBL3.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3.View
{
    public partial class frmLichHoc : Form
    {

        private List<TKB> tkb1;
        private List<TKB> tkb2;

        public frmLichHoc(string malh, string magv)
        {
            InitializeComponent();
            SetLichHoc(malh);
            SetLichGV(magv);
        }
        public void SetLichHoc(string malh)
        {

            //label1.Text="Lịch học của lớp: "+
            tkb1 = new List<TKB>();           

            tkb1.Add(new TKB("Buổi sáng"));
            tkb1.Add(new TKB("Buổi chiều"));

            List<lophocphan> lh = BLL_LopHocPhan.Instance.GetListLHP(malh, "");
            //List<MonHoc> ldgv = BLL_LopHocPhan.Instance.GetListLichDay(magv);

            // lịch học của lớp
            foreach (lophocphan i in lh)
            {
                SetLichHocBan(i.ThoiGianHoc);
            }
            dgvLichHoc.DataSource = tkb1;

            // Lịch dạy
           
            //foreach (MonHoc j in ldgv)
            //{
            //    SetLichBan(j.ThoiGianHoc);
            //}
            //dataGridView2.DataSource = tkb;
        }
        public void SetLichGV( string magv)
        {

            //label1.Text="Lịch học của lớp: "+
            tkb2 = new List<TKB>();
            tkb2.Add(new TKB("Buổi sáng"));
            tkb2.Add(new TKB("Buổi chiều"));     
            List<MonHoc> ldgv = BLL_LopHocPhan.Instance.GetListLichDay(magv);
         
            // Lịch dạy

            foreach (MonHoc j in ldgv)
            {
                SetLichGVBan(j.ThoiGianHoc);
            }
            dgvLichDay.DataSource = tkb2;
        }
        public void SetLichHocBan(string tgh)
        {
            int buoi;
            string[] s = tgh.Split(',');
            // get buổi                
            if (s[1] == "Buổi sáng")
                buoi = 0;
            else buoi = 1;
            // set tình trạng của thứ
            switch (s[0])
            {
                case "Thứ 2":
                    tkb1[buoi].Monday = "Bận";
                    break;
                case "Thứ 3":
                    tkb1[buoi].Tuesday = "Bận";
                    break;
                case "Thứ 4":
                    tkb1[buoi].Webnesday = "Bận";
                    break;
                case "Thứ 5":
                    tkb1[buoi].Thursday = "Bận";
                    break;
                case "Thứ 6":
                    tkb1[buoi].Friday = "Bận";
                    break;
                case "Thứ 7":
                    tkb1[buoi].Saturday = "Bận";
                    break;              
            }
        }
        public void SetLichGVBan(string tgh)
        {
            int buoi;
            string[] s = tgh.Split(',');
            // get buổi                
            if (s[1] == "Buổi sáng")
                buoi = 0;
            else buoi = 1;
            // set tình trạng của thứ
            switch (s[0])
            {
                case "Thứ 2":
                    tkb2[buoi].Monday = "Bận";
                    break;
                case "Thứ 3":
                    tkb2[buoi].Tuesday = "Bận";
                    break;
                case "Thứ 4":
                    tkb2[buoi].Webnesday = "Bận";
                    break;
                case "Thứ 5":
                    tkb2[buoi].Thursday = "Bận";
                    break;
                case "Thứ 6":
                    tkb2[buoi].Friday = "Bận";
                    break;
                case "Thứ 7":
                    tkb2[buoi].Saturday = "Bận";
                    break;
               
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if(e.Value!=null)
            {
                if (e.Value.ToString() == "Buổi sáng" || e.Value.ToString() == "Buổi chiều")
                    e.CellStyle.BackColor = Color.AliceBlue;
                if (e.Value.ToString() == "Bận")
                    e.CellStyle.BackColor = Color.Red;
            }    
        }
    }
}
