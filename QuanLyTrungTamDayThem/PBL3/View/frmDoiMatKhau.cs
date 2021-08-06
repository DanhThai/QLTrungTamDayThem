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
    public partial class frmDoiMatKhau : Form
    {
        public Adminn ad { get; set; }
        public frmDoiMatKhau(Adminn s)
        {
            InitializeComponent();
            ad = s;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if(txtMatKhauMoi.Text==txtXacNhanMatKhau.Text && txtMatKhauCu.Text==ad.MatKhau)
                BLL_Admin.Instance.DoiMatKhau(ad.TaiKhoan, txtMatKhauMoi.Text);
            else
                MessageBox.Show(" Mật khẩu không chính xác", "Đổi Mật Khẩu", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
