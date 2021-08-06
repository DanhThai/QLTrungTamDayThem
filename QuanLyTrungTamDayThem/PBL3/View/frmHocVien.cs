using PBL3.BLL;
using PBL3.DAL;
using PBL3.DTO;
using PBL3.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3
{
    public partial class frmHocVien : Form
    {
        public frmHocVien()
        {
            InitializeComponent();
            pnThongTinHV.Visible = false;
            SetCBB();
        }
        public void SetCBB()
        {
            cboHienThiHV.Items.Add(new CbbItem { value = "0", text = "Tất cả" });
            cboHienThiHV.Items.AddRange(BLL_HocVien.Instance.SetCbbLopHoc().ToArray());
            cboHienThiHV.SelectedIndex = 0;
            cboLopHoc.Items.AddRange(BLL_HocVien.Instance.SetCbbLopHoc().ToArray());
            cboSapXep.Items.Add("Họ Tên");
            cboSapXep.Items.Add("Tình Trạng");
        }
        public void ShowDgv(string malop, string hoten)
        {
            dgvHienThiThongTinHV.DataSource = BLL_HocVien.Instance.GetListHocVien(malop, hoten);
            // ẩn column MaHV
            dgvHienThiThongTinHV.Columns[0].Visible = false;
        }
        private void btnThemHV_Click(object sender, EventArgs e)
        {
            btnThem1HV.Text = "Thêm";
            pnThongTinHV.Visible = true;
            pnChucnang.Visible = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
           
            pnThongTinHV.Visible = false;
            pnChucnang.Visible = true;
            // reset lai form
            txtHoTenHV.Text = "";
            txtDiaChiHV.Text = "";
            txtSDTHV.Text = "";
            txtTinhTrang.Text = "";
            dtpNgaySinhHV.Value = DateTime.Now;
            rbnNam.Checked = false;
            rbnNu.Checked = false;
        }   

        private void btnSuaHV_Click(object sender, EventArgs e)
        {
           
            if (dgvHienThiThongTinHV.SelectedRows.Count == 1)
            {
                btnThem1HV.Text = "Sửa";
                pnThongTinHV.Visible = true;
                pnChucnang.Visible = false;

                string mahv = dgvHienThiThongTinHV.SelectedRows[0].Cells["MaHV"].Value.ToString();
                HocVien h = BLL_HocVien.Instance.GetHVbyMaHV(mahv);
                // set dữ liệu lên view
                txtHoTenHV.Text = h.HoTen;
                txtDiaChiHV.Text = h.DiaChi;
                txtSDTHV.Text = h.SDT;
                txtTinhTrang.Text = h.TinhTrang;
                dtpNgaySinhHV.Value = h.NamSinh.Value;
                if (h.GioiTinh == true) rbnNam.Checked = true;
                else rbnNu.Checked = true;
                cboLopHoc.Text = h.LopHoc.TenLop;
            }
            else
                MessageBox.Show("Chọn 1 Học viên để sửa", "Sửa Học Viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void btnThem1HV_Click(object sender, EventArgs e)
        {
            // check điều kiện
            if (txtHoTenHV.Text == "" || txtDiaChiHV.Text == "" || txtSDTHV.Text == "" || txtTinhTrang.Text == ""||HocVien.CheckSDT(txtSDTHV.Text)==false)
                MessageBox.Show("Hãy nhập lại thông tin", "Nhập thông tin Học Viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                HocVien hv = new HocVien();
                hv.MaLH = ((CbbItem)cboLopHoc.SelectedItem).value;
                hv.HoTen = txtHoTenHV.Text;
                hv.DiaChi = txtDiaChiHV.Text;
                hv.SDT = txtSDTHV.Text; 
                hv.TinhTrang = txtTinhTrang.Text;
                hv.NamSinh = dtpNgaySinhHV.Value;
                if (rbnNam.Checked == true)
                    hv.GioiTinh = true;
                else hv.GioiTinh = false;
                // thêm học viên
                if (btnThem1HV.Text == "Thêm")
                {
                    hv.MaHV = BLL_HocVien.Instance.XulyMaHV();
                }
                // sửa thông tin
                else
                {
                    string mahv = dgvHienThiThongTinHV.SelectedRows[0].Cells["MaHV"].Value.ToString();
                    hv.MaHV = mahv;
                }
                // xử lý thêm/sửa

                DialogResult dr = MessageBox.Show("Xác nhận thông tin học viên ", " Học Viên", MessageBoxButtons.OKCancel);
                if (dr == DialogResult.OK)
                {
                    BLL_HocVien.Instance.ExecuteDB(hv);
                    ShowDgv(hv.MaLH, "");
                }
                
            }    
           
        }
        private void btnHienThi_Click(object sender, EventArgs e)
        {
            string malop = ((CbbItem)cboHienThiHV.SelectedItem).value.ToString();
            ShowDgv(malop, "");
            
        }

        private void btnTimKiemHV_Click(object sender, EventArgs e)
        {
            string malop = ((CbbItem)cboHienThiHV.SelectedItem).value.ToString();
            ShowDgv(malop, txtTimKiemHV.Text);            
        }

        private void btnXoaHV_Click(object sender, EventArgs e)
        {
            if (dgvHienThiThongTinHV.SelectedRows.Count > 0)
            {
                List<string> mahv = new List<string>();
                for (int i = 0; i < dgvHienThiThongTinHV.SelectedRows.Count; i++)
                {
                    mahv.Add(dgvHienThiThongTinHV.SelectedRows[i].Cells["MaHV"].Value.ToString());                  
                }


                DialogResult dr= MessageBox.Show("Xác nhận xóa học viên ", "Xóa Học Viên", MessageBoxButtons.OKCancel);
                if (dr == DialogResult.OK)
                {
                    BLL_HocVien.Instance.XoaListHV(mahv);
                    string malop = ((CbbItem)cboHienThiHV.SelectedItem).value.ToString();
                    ShowDgv(malop, "");
                }
            } 
            else
                MessageBox.Show("Chọn 1 hoặc nhiều học viên để xóa","Xóa Học Viên",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        private void cboSapXep_SelectedIndexChanged(object sender, EventArgs e)
        {
            string malop = ((CbbItem)cboHienThiHV.SelectedItem).value.ToString();           
            dgvHienThiThongTinHV.DataSource = BLL_HocVien.Instance.SortHV(malop, cboSapXep.SelectedItem.ToString());
        }

        private void btnInDS_Click(object sender, EventArgs e)
        {
            if(cboHienThiHV.SelectedIndex>0)
            {
                DataTable dt = new DataTable();
                dt.Columns.AddRange(new DataColumn[]
                {
                new DataColumn("TenLop",typeof(string)),
                new DataColumn("SiSo",typeof(int)),
                new DataColumn("HoTenHV",typeof(string)),
                new DataColumn("NgaySinh",typeof(string)),
                new DataColumn("GioiTinh",typeof(string)),
                new DataColumn("DiaChi",typeof(string)),
                new DataColumn("SDT",typeof(string)),
                });
                string malop = ((CbbItem)cboHienThiHV.SelectedItem).value.ToString();
                ShowDgv(malop, "");
                foreach (hocvien i in BLL_HocVien.Instance.GetListHocVien(malop, ""))
                {
                    
                    DataRow dr = dt.NewRow();
                    dr["TenLop"] = i.TenLop; dr["SiSo"] = i.SiSo;
                    dr["HoTenHV"] = i.HoTen; dr["NgaySinh"] = i.NamSinh;
                    dr["GioiTinh"] = i.GioiTinh;
                    dr["DiaChi"] = i.DiaChi; dr["SDT"] = i.SDT;
                    dt.Rows.Add(dr);
                }
                
                // get dữ liệu table lên rpt
                rptDSHocVien rptDS = new rptDSHocVien();
                rptDS.SetDataSource(dt);
                //get rpt vào from in
                frmInDSLop f = new frmInDSLop();
                f.crystalReportViewer1.ReportSource = rptDS;
                f.ShowDialog();
            }    
            
        }
    }
}
