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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void butSignin_Click(object sender, EventArgs e)
        {
            if (BLL_Admin.Instance.CheckTK(txtUsername.Text,txtPassword.Text) != null)
            {
                MainForm mf = new MainForm(BLL_Admin.Instance.CheckTK(txtUsername.Text, txtPassword.Text));                                          
                mf.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác", "Đăng Nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
       
    }
}
