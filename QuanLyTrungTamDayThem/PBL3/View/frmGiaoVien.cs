using PBL3.BLL;
using PBL3.DAL;
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
    public partial class frmGiaoVien : Form
    {
        public frmGiaoVien()
        {
            InitializeComponent();
            pnThongTinGV.Visible = false;
            SetCBB();
            ShowDgv("");
        }
        public void SetCBB()
        {          
            cboSapXep.Items.Add("Họ Tên");
            cboSapXep.Items.Add("Trình Độ");
            cboSapXep.Items.Add("Chuyên Môn");
        }
        public void ShowDgv( string hoten)
        {
            dgvHienThiThongTinGV.DataSource = BLL_GiaoVien.Instance.GetListGiaoVien(hoten);
            // ẩn column MaGV
            dgvHienThiThongTinGV.Columns[0].Visible = false;
        }
        private void btnThemMoiGV_Click(object sender, EventArgs e)
        {
            btnThem1GV.Text = "Thêm";
            pnThongTinGV.Visible = true;
            pnChucNang.Visible = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            pnThongTinGV.Visible = false;
            pnChucNang.Visible = true;

            // reset lại form
            txtHoTenGV.Text = "";
            txtDiaChiGV.Text = "";
            txtSDTGV.Text = "";
            ckbAnh.Checked = false;
            ckbToan.Checked = false;
            ckbVan.Checked = false;
            txtTrinhDo.Text = "";
            dtpNgaySinhGV.Value = DateTime.Now;
            rbnNam.Checked = false;
            rbnNu.Checked = false;
        }

        private void btnSuaGV_Click(object sender, EventArgs e)
        {
                       
            if (dgvHienThiThongTinGV.SelectedRows.Count == 1)
            {
                btnThem1GV.Text = "Sửa";
                pnThongTinGV.Visible = true;
                pnChucNang.Visible = false;

                string magv = dgvHienThiThongTinGV.SelectedRows[0].Cells["MaGV"].Value.ToString();
                GiaoVien gv = BLL_GiaoVien.Instance.GetGVbyMaGV(magv);
                // set dữ liệu lên view
                txtHoTenGV.Text = gv.HoTen;
                txtDiaChiGV.Text = gv.DiaChi;
                txtSDTGV.Text = gv.SDT;           
                if (gv.ChuyenMon.Contains("Toán")) ckbToan.Checked = true;
                if (gv.ChuyenMon.Contains("Anh")) ckbAnh.Checked = true;
                if (gv.ChuyenMon.Contains("Văn")) ckbVan.Checked = true;

                txtTrinhDo.Text = gv.TrinhDo;
                dtpNgaySinhGV.Value = gv.NamSinh.Value;
                if (gv.GioiTinh == true) rbnNam.Checked = true;
                else rbnNu.Checked = true;
                
            }
            else
                MessageBox.Show("Chọn 1 Giáo viên để sửa", "Sửa Giáo Viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnTimKiemGV_Click(object sender, EventArgs e)
        {
            ShowDgv(txtTimKiemGV.Text);
        }

        private void btnThem1GV_Click(object sender, EventArgs e)
        {
            // check điều kiện
            if (txtHoTenGV.Text == "" || txtDiaChiGV.Text == "" || txtSDTGV.Text == "" ||  txtTrinhDo.Text == "" 
                || HocVien.CheckSDT(txtSDTGV.Text) == false||(ckbAnh.Checked==false&& ckbToan.Checked==false&&ckbVan.Checked==false))

                MessageBox.Show("Hãy nhập lại đầy đủ thông tin", "Nhập thông tin Giáo Viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                GiaoVien gv = new GiaoVien();
                gv.HoTen = txtHoTenGV.Text;
                gv.NamSinh = dtpNgaySinhGV.Value;
                gv.DiaChi = txtDiaChiGV.Text;
                gv.SDT = txtSDTGV.Text;
                //gv.ChuyenMon = cboChuyenMon.SelectedItem.ToString();
                gv.TrinhDo = txtTrinhDo.Text;
                if (ckbToan.Checked == true) gv.ChuyenMon += ckbToan.Text+",";
                if (ckbAnh.Checked == true) gv.ChuyenMon += ckbAnh.Text + ",";
                if (ckbVan.Checked == true) gv.ChuyenMon += ckbVan.Text;
                if (rbnNam.Checked == true)
                    gv.GioiTinh = true;
                else gv.GioiTinh = false;
                // thêm giáo viên
                if (btnThem1GV.Text == "Thêm")
                {
                    gv.MaGV = BLL_GiaoVien.Instance.XulyMaGV();
                }
                // sửa thông tin
                else
                {
                    string magv = dgvHienThiThongTinGV.SelectedRows[0].Cells["MaGV"].Value.ToString();
                    gv.MaGV = magv;
                }
                // xử lý thêm/sửa

                DialogResult dr = MessageBox.Show("Xác nhận thông tin giáo viên ", " Giáo Viên", MessageBoxButtons.OKCancel);
                if (dr == DialogResult.OK)
                {
                    BLL_GiaoVien.Instance.ExecuteDB(gv);
                    ShowDgv("");
                }
            }
        }

        private void btnXoaGV_Click(object sender, EventArgs e)
        {
            if (dgvHienThiThongTinGV.SelectedRows.Count > 0)
            {
                List<string> magv = new List<string>();
                for (int i = 0; i < dgvHienThiThongTinGV.SelectedRows.Count; i++)
                {
                    magv.Add(dgvHienThiThongTinGV.SelectedRows[i].Cells["MaGV"].Value.ToString());
                }


                DialogResult dr = MessageBox.Show("Xác nhận xóa giáo viên ", "Xóa Giáo Viên", MessageBoxButtons.OKCancel);
                if (dr == DialogResult.OK)
                {
                    BLL_GiaoVien.Instance.XoaGV(magv);                   
                    ShowDgv("");
                }
            }
            else
                MessageBox.Show("Chọn 1 hoặc nhiều giáo viên để xóa", "Xóa Giáo Viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void cboSapXep_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvHienThiThongTinGV.DataSource = BLL_GiaoVien.Instance.SortGV(cboSapXep.SelectedItem.ToString());
        }     
    }
}
