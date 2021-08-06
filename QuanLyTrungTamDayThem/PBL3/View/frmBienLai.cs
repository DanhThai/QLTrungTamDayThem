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
    public partial class frmBienLai : Form
    {
        public frmBienLai()
        {
            InitializeComponent();
            SetCBB();
        }
        public void SetCBB()
        {
            cboChonLop.Items.AddRange(BLL_BienLai.Instance.GetCbbLopHoc().ToArray());
            cboHienThiDS.Items.AddRange(new string[]
            {
                "Chưa nộp","Đã nộp"
            });
        }
        private void btnInBienLai_Click(object sender, EventArgs e)
        {
            if(dgvDanhSachHocVien.SelectedRows.Count==1 )
            {               
                if(txtHocPhi.Text != "")
                {
                    int hp;
                    string mahv = dgvDanhSachHocVien.SelectedRows[0].Cells["MaHV"].Value.ToString();
                    try
                    {
                        // check định dạng convet học phí
                        hp = Convert.ToInt32(txtHocPhi.Text);

                        DataTable bl = BLL_BienLai.Instance.GetBienLai(mahv, hp);
                        // get dữ liệu table lên rpt
                        rptBienlai rptBL = new rptBienlai();
                        rptBL.SetDataSource(bl);
                        //get rpt vào from in
                        frmInBienLai f = new frmInBienLai();
                        f.crystalReportViewer1.ReportSource = rptBL;
                        f.ShowDialog();
                        // Thay đổi tình trạng nộp
                        BLL_BienLai.Instance.ChangeState(mahv);
                        string malop = ((CbbItem)cboChonLop.SelectedItem).value;
                        ShowDgv(malop, cboHienThiDS.SelectedItem.ToString(), txtHoTen.Text);
                    }
                    catch(FormatException ex)
                    {
                        MessageBox.Show("Nhập sai định dạng học phí", "In Biên Lai", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }                                      
                }
                else
                    MessageBox.Show("Nhập học phí", "In Biên Lai", MessageBoxButtons.OK, MessageBoxIcon.Error);               
            }    
            else
                MessageBox.Show("Chọn 1 học viên để in", "In Biên Lai", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
       

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if(cboChonLop.SelectedIndex>-1 && cboHienThiDS.SelectedIndex>-1)
            {
                string malop = ((CbbItem)cboChonLop.SelectedItem).value;
                ShowDgv(malop, cboHienThiDS.SelectedItem.ToString(), txtHoTen.Text);
            }    
            
        }
        public void ShowDgv(string malop, string tinhtrang, string hoten)
        {
            dgvDanhSachHocVien.DataSource = BLL_BienLai.Instance.GetListBienLai(malop, tinhtrang, hoten);
            dgvDanhSachHocVien.Columns[0].Visible = false;
        }
    }
}
