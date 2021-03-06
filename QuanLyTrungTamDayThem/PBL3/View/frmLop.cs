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
    public partial class frmLop : Form
    {
        // delegate set lại cbb
        public delegate void MyDel();
        public MyDel d;
        public frmLop()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTenLop.Text == "" || BLL_LopHocPhan.Instance.CheckTenLop(txtTenLop.Text) == false)
                //MessageBox.Show("Hãy nhập lại tên lớp", "Thêm Lớp");
                MessageBox.Show("Trùng tên lớp", "Thêm Lớp");
            else
            {
                DialogResult dr= MessageBox.Show("Bạn muốn thêm lớp không", "Lớp Học", MessageBoxButtons.OKCancel);
                if (dr == DialogResult.OK)
                {
                    BLL_LopHocPhan.Instance.ThemLop(txtTenLop.Text);
                    MessageBox.Show("Thêm lớp thành công", "Lớp Học");
                }    
                    
            }    
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            d();
            this.Close();
        }
    }
}
