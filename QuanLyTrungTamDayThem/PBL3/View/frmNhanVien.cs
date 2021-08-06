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
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
            pnThongTin.Visible = false;
            SetCbb();
        }
        public void SetCbb()
        {
            cboCongViec.Items.AddRange(new string[]
            {
               "Admin","Nhân viên", "Kế toán"
            });
            cboHienThiTheo.Items.AddRange(new string[]
            {
                "Tất cả","Admin","Nhân viên", "Kế toán"
            });
            cboHienThiTheo.SelectedIndex = 0;

        }
        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            btnThem1NV.Text = "Thêm";
            pnThongTin.Visible = true;
            pnChucNang.Visible = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            pnThongTin.Visible = false;
            pnChucNang.Visible = true;
            // reset lại form
            txtTaiKhoanNV.Text = "";
            txtTaiKhoanNV.Enabled = true;
            txtMatKhauNV.Text = "";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnThem1NV.Text = "Sửa";
            pnThongTin.Visible = true;
            pnChucNang.Visible = false;
            
            if (dgvHienThiThongTinNV.SelectedRows.Count == 1)
            {
                string tk = dgvHienThiThongTinNV.SelectedRows[0].Cells["TaiKhoan"].Value.ToString();
                Adminn ad = BLL_Admin.Instance.GetADbyTK(tk);
                txtTaiKhoanNV.Text = ad.TaiKhoan;
                txtTaiKhoanNV.Enabled = false;
                txtMatKhauNV.Text = ad.MatKhau;
                cboCongViec.Text = ad.ChucVu;
            }
            else
                MessageBox.Show("Chọn 1 Nhân viên để sửa", "Sửa Tài Khoản", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            ShowDgv(cboHienThiTheo.SelectedItem.ToString());
        }
        public void ShowDgv(string cv)
        {
            dgvHienThiThongTinNV.DataSource = BLL_Admin.Instance.GetListAdmin(cboHienThiTheo.SelectedItem.ToString());
        }

        private void btnThem1NV_Click(object sender, EventArgs e)
        {
            // check điều kiện
            if (txtMatKhauNV.Text==""|| txtTaiKhoanNV.Text=="")
                MessageBox.Show("Hãy nhập lại thông tin", "Nhập thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                Adminn ad = new Adminn();
                ad.MatKhau = txtMatKhauNV.Text;
                ad.ChucVu = cboCongViec.SelectedItem.ToString();
                // thêm tk
                if (btnThem1NV.Text == "Thêm")
                {
                    ad.TaiKhoan = txtTaiKhoanNV.Text;
                }
                // sửa thông tin
                else
                {
                    string tk = dgvHienThiThongTinNV.SelectedRows[0].Cells["TaiKhoan"].Value.ToString();
                    ad.TaiKhoan = tk;
                }
                // xử lý thêm/sửa

                DialogResult dr = MessageBox.Show("Xác nhận thông tin ", " Tài Khoản", MessageBoxButtons.OKCancel);
                if (dr == DialogResult.OK)
                {
                    BLL_Admin.Instance.ExecuteDB(ad);
                    ShowDgv(cboHienThiTheo.SelectedItem.ToString());
                }

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvHienThiThongTinNV.SelectedRows.Count > 0)
            {
                List<string> tk = new List<string>();
                for (int i = 0; i < dgvHienThiThongTinNV.SelectedRows.Count; i++)
                {
                    tk.Add(dgvHienThiThongTinNV.SelectedRows[i].Cells["TaiKhoan"].Value.ToString());
                }
                DialogResult dr = MessageBox.Show("Xác nhận xóa tài khoản", "Xóa Tài Khoản", MessageBoxButtons.OKCancel);
                if (dr == DialogResult.OK)
                {
                    BLL_Admin.Instance.XoaTK(tk);
                    ShowDgv(cboHienThiTheo.SelectedItem.ToString());
                }
            }
            else
                MessageBox.Show("Chọn 1 Nhân viên để xóa", "Xóa Học Viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
