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
    public partial class MainForm : Form
    {
        private Button currentBtn;
        private Panel panelleftmenu;
        private Form currentFormCon;
        public Adminn ad { get; set; }
        public MainForm(Adminn s)
        {
            InitializeComponent();
            ad = s;
            setQuyen(ad.ChucVu);
            panelleftmenu = new Panel();
            panelleftmenu.Size = new Size(5, 49);
            //panelleftmenu.BackColor = Color.Green;
            pnMenu.Controls.Add(panelleftmenu);        
        }
        public void setQuyen(string s)
        {
            lblNameActor.Text = s;
            if (s=="Nhân viên quản lý")
            {
                btnBienLai.Visible = false;
                btnNhanVien.Visible = false;
            }  
            if(s=="Nhân viên kế toán")
            {               
                btnGiaoVien.Visible = false;
                btnHocVien.Visible = false;
                btnLopHoc.Visible = false;
                btnNhanVien.Visible = false;
            }    
        }
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(10,100, 100);
            public static Color color2 = Color.FromArgb(240, 86, 5);
            public static Color color3 = Color.FromArgb(240, 239, 41);
            public static Color color4 = Color.FromArgb(100, 233, 112);
            public static Color color5 = Color.FromArgb(131, 29, 240);
            public static Color color6 = Color.FromArgb(58, 240, 231);
            public static Color color7 = Color.FromArgb(212, 212, 212);
        }

        private void TaoMoiBtn(object senderBtn, Color color)
        {
            LenhBtn();
            if(senderBtn!=null)
            {
                currentBtn = senderBtn as Button;
                currentBtn.BackColor = Color.FromArgb(150, 167, 50);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.ImageList = imageList1;
                currentBtn.ImageIndex = currentBtn.ImageIndex;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                panelleftmenu.BackColor = color;
                panelleftmenu.Location = new Point(0, currentBtn.Location.Y);
                panelleftmenu.Visible = true;
                panelleftmenu.BringToFront();

                lblTieuDe.ImageIndex = currentBtn.ImageIndex;
                lblTieuDe.Text = currentBtn.Text;
            }
        }
        private void LenhBtn()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(46, 3, 62);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.ImageList = imageList1;
                currentBtn.ImageIndex = currentBtn.ImageIndex;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void MoForm(Form FormCon)
        {
            if(currentFormCon!=null)
            {
                currentFormCon.Close();
            }
            currentFormCon = FormCon;
            FormCon.TopLevel = false;
            FormCon.FormBorderStyle = FormBorderStyle.None;
            FormCon.Dock = DockStyle.Fill;
            pnHienThi.Controls.Add(FormCon);
            pnHienThi.Tag = FormCon;
            FormCon.BringToFront();
            FormCon.Show();
        }
        
        private void ptbHome_Click(object sender, EventArgs e)
        {
            lblTieuDe.Text = "Home";
            lblTieuDe.ImageIndex = 4;
            if(currentFormCon!=null)
            currentFormCon.Close();
            Resest();
        }

        private void Resest()
        {
            LenhBtn();
            panelleftmenu.Visible = false;
        }

        private void btnGiaoVien_Click(object sender, EventArgs e)
        {
            TaoMoiBtn(sender, RGBColors.color1);
            MoForm(new frmGiaoVien());
        }

        private void btnHocVien_Click(object sender, EventArgs e)
        {
            TaoMoiBtn(sender, RGBColors.color2);
            MoForm(new frmHocVien());
        }
        private void btnLopHoc_Click(object sender, EventArgs e)
        {
            TaoMoiBtn(sender, RGBColors.color3);
            MoForm(new frmLopHocPhan());
        }

        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            TaoMoiBtn(sender, RGBColors.color5);
        }

        private void btnBienLai_Click(object sender, EventArgs e)
        {
            TaoMoiBtn(sender, RGBColors.color7);
            MoForm(new frmBienLai());
        }

        
        
        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            TaoMoiBtn(sender, RGBColors.color4);
            MoForm(new frmNhanVien());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void ptbTaiKhoan_Click(object sender, EventArgs e)
        {
            frmTaiKhoan tk = new frmTaiKhoan(ad);
            tk.ShowDialog();
           
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn thoát không", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
                //Application.Exit();
                Application.ExitThread();
            else
                e.Cancel = true;
        }
    }
}
