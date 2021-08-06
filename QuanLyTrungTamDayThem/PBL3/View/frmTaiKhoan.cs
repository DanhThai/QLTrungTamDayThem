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
    public partial class frmTaiKhoan : Form
    {
        public Adminn ad { get; set; } 
        public frmTaiKhoan(Adminn s)
        {
            InitializeComponent();
            ad = s;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau doi = new frmDoiMatKhau(ad);
            doi.ShowDialog();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn đăng xuất không", "Đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                //Application.ExitThread();
                Application.Restart();
            }


        }
    }
}
