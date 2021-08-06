using PBL3.BLL;
using PBL3.DAL;
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
    public partial class frmLopHocPhan : Form
    {
        public frmLopHocPhan()
        {
            InitializeComponent();
            pnThongTin.Visible = false;
            SetCBB();
        }
        public void SetCBB()
        {
            cboMonHoc.Items.Clear();
            cboChonLop.Items.Clear();
            cboMonHoc.Items.AddRange(new string[]
            {
                "Toán","Anh","Văn"
            });               
            cboChonLop.Items.AddRange(BLL_LopHocPhan.Instance.GetCbbLopHoc().ToArray());
            cboChonLop.SelectedIndex = 0;

            cboBuoi.Items.AddRange(new string[]
            {
                "Buổi sáng","Buổi chiều"
            });
            cboThu.Items.AddRange(new string[]
            {
                "Thứ 2","Thứ 3","Thứ 4","Thứ 5","Thứ 6","Thứ 7"
            });
        }        

        private void cboMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboGiaoVien.Items.Clear();
            cboGiaoVien.Items.AddRange(BLL_LopHocPhan.Instance.GetCbbGiaoVien(cboMonHoc.SelectedItem.ToString()).ToArray());
            cboGiaoVien.SelectedIndex = -1;
        }

        public void ShowDgv(string malh, string mon)
        {
            dgvHienThiKH.DataSource = BLL_LopHocPhan.Instance.GetListLHP( malh, mon);
            dgvHienThiKH.Columns[0].Visible = false;
            dgvHienThiKH.Columns[1].Visible = false;
        }
        private void btnXem_Click(object sender, EventArgs e)
        {
            if (cboChonLop.SelectedIndex == -1)
                MessageBox.Show("Hãy chọn Lớp Học", "Chọn Lớp Học");
            else
            {
                string malh = ((CbbItem)cboChonLop.SelectedItem).value;
                ShowDgv(malh, "");
            }

        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string malh = ((CbbItem)cboChonLop.SelectedItem).value;
            ShowDgv(malh, txtTimKiem.Text);
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            pnThongTin.Visible = false;
            pnChucNang.Visible = true;
            txtTenLop.Text = "";
           
            cboMonHoc.Text = "";
            cboGiaoVien.SelectedIndex = -1;
            cboBuoi.SelectedIndex = -1;
            cboThu.SelectedIndex = -1;
        }
        private void btnThemLop_Click(object sender, EventArgs e)
        {           
            frmLop f = new frmLop();
            // delegate set lại comboBox
            f.d += new frmLop.MyDel(SetCBB);
            f.ShowDialog();
            
        }
        private void btnThemMon_Click(object sender, EventArgs e)
        {
            
            if(cboChonLop.SelectedIndex>0)
            {
                btnThemLHP.Text = "Thêm";
                pnThongTin.Visible = true;
                pnChucNang.Visible = false;
                // ẩn tên lớp( ko cho edit)
                string malh = ((CbbItem)cboChonLop.SelectedItem).value;
                LopHoc lh = BLL_LopHocPhan.Instance.GetLHbyMaLH(malh);
                txtTenLop.Text = lh.TenLop;
                txtTenLop.Enabled = false;
            }
            else
                MessageBox.Show("Chọn 1 Lớp để thêm", "Thêm Lớp Học Phần");


        }
        private void btnSua_Click(object sender, EventArgs e)
        {
                      
            if(dgvHienThiKH.SelectedRows.Count==1)
            {
                btnThemLHP.Text = "Sửa";
                pnThongTin.Visible = true;
                pnChucNang.Visible = false;
                string malh = dgvHienThiKH.SelectedRows[0].Cells["MaLH"].Value.ToString();
                string mamh = dgvHienThiKH.SelectedRows[0].Cells["MaMH"].Value.ToString();
                // set dữ liệu lên form
                LopHoc lh = BLL_LopHocPhan.Instance.GetLHbyMaLH(malh);               
                txtTenLop.Text = lh.TenLop;
                txtTenLop.Enabled = false;

                MonHoc mh = BLL_LopHocPhan.Instance.GetMHbyMaMH(mamh);
                cboMonHoc.Text = mh.TenMon;
                cboGiaoVien.Text = mh.GiaoVien.HoTen;
                string[] s = mh.ThoiGianHoc.Split(',');
                cboBuoi.Text = s[1];
                cboThu.Text = s[0];
                //txtThoiGianHoc.Text = mh.ThoiGianHoc;
                dtpNgayBatDau.Value = mh.NgayBatDau.Value;
                dtpNgayKetThuc.Value = mh.NgayKetThuc.Value;
            }  
            else
                MessageBox.Show("Chọn 1 Lớp học phần để sửa", "Sửa Lớp Học Phần", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
     
   
        private void btnThemLHP_Click(object sender, EventArgs e)
        {
            if(txtTenLop.Text==""||cboThu.SelectedItem == null || cboBuoi.SelectedItem==null||cboGiaoVien.SelectedItem==null
                ||cboMonHoc.SelectedItem==null|| dtpNgayBatDau.Value >= dtpNgayKetThuc.Value)
                MessageBox.Show("Hãy nhập lại thông tin", "Nhập thông tin Lớp Học Phần", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {               

                MonHoc mh = new MonHoc();
                mh.MaGV = ((CbbItem)cboGiaoVien.SelectedItem).value;
                mh.TenMon = cboMonHoc.SelectedItem.ToString();
                mh.ThoiGianHoc = cboThu.SelectedItem.ToString()+","+cboBuoi.SelectedItem.ToString();               
                mh.NgayBatDau = dtpNgayBatDau.Value;
                mh.NgayKetThuc = dtpNgayKetThuc.Value;

                switch (btnThemLHP.Text)
                {                  
                    case "Thêm":
                        {
                            mh.MaLH= ((CbbItem)cboChonLop.SelectedItem).value;
                            mh.MaMH = BLL_LopHocPhan.Instance.XulyMaMH();
                        }
                        break;
                    default:
                        {                           
                            mh.MaMH = dgvHienThiKH.SelectedRows[0].Cells["MaMH"].Value.ToString();
                            mh.MaLH = dgvHienThiKH.SelectedRows[0].Cells["MaLH"].Value.ToString();
                        }
                        break;
                }
                DialogResult dr = MessageBox.Show("Xác nhận thông tin lớp học phần ", "Lớp Học Phần", MessageBoxButtons.OKCancel);
                if (dr == DialogResult.OK)
                {
                    BLL_LopHocPhan.Instance.ExecuteDB(mh);
                    string malh = ((CbbItem)cboChonLop.SelectedItem).value;
                    ShowDgv(malh, "");
                }
                
            }                 
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Xóa lớp học
            if (cboChonLop.SelectedIndex != 0 && dgvHienThiKH.RowCount == 0)
            {
                DialogResult dr = MessageBox.Show("Bạn có muốn  xóa lớp học và học viên thuộc lớp này  không ", "Xóa Lớp Học ", MessageBoxButtons.OKCancel);
                if (dr == DialogResult.OK)
                {
                    string malop = ((CbbItem)cboChonLop.SelectedItem).value;
                    BLL_LopHocPhan.Instance.XoaLop(malop);

                    SetCBB();
                }
            }
            // Xóa môn hoc( Lớp học phần)
            else
            {
                if (dgvHienThiKH.SelectedRows.Count > 0)
                {
                    List<string> mamh = new List<string>();
                    for (int i = 0; i < dgvHienThiKH.SelectedRows.Count; i++)
                    {
                        mamh.Add(dgvHienThiKH.SelectedRows[i].Cells["MaMH"].Value.ToString());
                    }


                    DialogResult dr = MessageBox.Show("Xác nhận xóa lớp học phần ", "Xóa Lop Học Phần", MessageBoxButtons.OKCancel);
                    if (dr == DialogResult.OK)
                    {
                        BLL_LopHocPhan.Instance.XoaListMonHoc(mamh);

                        string malh = ((CbbItem)cboChonLop.SelectedItem).value;
                        ShowDgv(malh, "");
                    }

                }
                else
                    MessageBox.Show("Chọn 1 Lớp học phần để xóa", "Xóa Lớp Học Phần", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(cboGiaoVien.SelectedIndex>=0)
            {
                string malh = ((CbbItem)cboChonLop.SelectedItem).value;
                string mamh = ((CbbItem)cboGiaoVien.SelectedItem).value;
                frmLichHoc frm = new frmLichHoc(malh, mamh);
                frm.ShowDialog();
            }  
            else
                MessageBox.Show("Hãy chọn giáo viên");

        }
    }
}
