
namespace PBL3
{
    partial class frmNhanVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.pnThongTin = new System.Windows.Forms.Panel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnThem1NV = new System.Windows.Forms.Button();
            this.cboCongViec = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMatKhauNV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTaiKhoanNV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnChucNang = new System.Windows.Forms.Panel();
            this.btnHienThi = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.cboHienThiTheo = new System.Windows.Forms.ComboBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.dgvHienThiThongTinNV = new System.Windows.Forms.DataGridView();
            this.pnThongTin.SuspendLayout();
            this.pnChucNang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHienThiThongTinNV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(116)))), ((int)(((byte)(163)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1193, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin nhân viên";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnThongTin
            // 
            this.pnThongTin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(116)))), ((int)(((byte)(163)))));
            this.pnThongTin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnThongTin.Controls.Add(this.btnThoat);
            this.pnThongTin.Controls.Add(this.btnThem1NV);
            this.pnThongTin.Controls.Add(this.cboCongViec);
            this.pnThongTin.Controls.Add(this.label8);
            this.pnThongTin.Controls.Add(this.txtMatKhauNV);
            this.pnThongTin.Controls.Add(this.label3);
            this.pnThongTin.Controls.Add(this.txtTaiKhoanNV);
            this.pnThongTin.Controls.Add(this.label2);
            this.pnThongTin.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnThongTin.Location = new System.Drawing.Point(0, 56);
            this.pnThongTin.Name = "pnThongTin";
            this.pnThongTin.Size = new System.Drawing.Size(1193, 141);
            this.pnThongTin.TabIndex = 2;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(3)))), ((int)(((byte)(62)))));
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnThoat.Location = new System.Drawing.Point(144, 69);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 40);
            this.btnThoat.TabIndex = 24;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnThem1NV
            // 
            this.btnThem1NV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(3)))), ((int)(((byte)(62)))));
            this.btnThem1NV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem1NV.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnThem1NV.Location = new System.Drawing.Point(28, 69);
            this.btnThem1NV.Name = "btnThem1NV";
            this.btnThem1NV.Size = new System.Drawing.Size(75, 40);
            this.btnThem1NV.TabIndex = 22;
            this.btnThem1NV.Text = "Thêm";
            this.btnThem1NV.UseVisualStyleBackColor = false;
            this.btnThem1NV.Click += new System.EventHandler(this.btnThem1NV_Click);
            // 
            // cboCongViec
            // 
            this.cboCongViec.FormattingEnabled = true;
            this.cboCongViec.Location = new System.Drawing.Point(629, 13);
            this.cboCongViec.Name = "cboCongViec";
            this.cboCongViec.Size = new System.Drawing.Size(191, 28);
            this.cboCongViec.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(540, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Công việc:";
            // 
            // txtMatKhauNV
            // 
            this.txtMatKhauNV.Location = new System.Drawing.Point(383, 14);
            this.txtMatKhauNV.Name = "txtMatKhauNV";
            this.txtMatKhauNV.Size = new System.Drawing.Size(141, 26);
            this.txtMatKhauNV.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(289, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật Khẩu:";
            // 
            // txtTaiKhoanNV
            // 
            this.txtTaiKhoanNV.Location = new System.Drawing.Point(111, 14);
            this.txtTaiKhoanNV.Name = "txtTaiKhoanNV";
            this.txtTaiKhoanNV.Size = new System.Drawing.Size(153, 26);
            this.txtTaiKhoanNV.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tài Khoản:";
            // 
            // pnChucNang
            // 
            this.pnChucNang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(116)))), ((int)(((byte)(163)))));
            this.pnChucNang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnChucNang.Controls.Add(this.btnHienThi);
            this.pnChucNang.Controls.Add(this.label9);
            this.pnChucNang.Controls.Add(this.cboHienThiTheo);
            this.pnChucNang.Controls.Add(this.btnXoa);
            this.pnChucNang.Controls.Add(this.btnSua);
            this.pnChucNang.Controls.Add(this.btnThemMoi);
            this.pnChucNang.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnChucNang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnChucNang.Location = new System.Drawing.Point(0, 197);
            this.pnChucNang.Name = "pnChucNang";
            this.pnChucNang.Size = new System.Drawing.Size(1193, 68);
            this.pnChucNang.TabIndex = 1;
            // 
            // btnHienThi
            // 
            this.btnHienThi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(3)))), ((int)(((byte)(62)))));
            this.btnHienThi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHienThi.ForeColor = System.Drawing.Color.White;
            this.btnHienThi.Location = new System.Drawing.Point(559, 13);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(101, 36);
            this.btnHienThi.TabIndex = 5;
            this.btnHienThi.Text = "Hiển thị";
            this.btnHienThi.UseVisualStyleBackColor = false;
            this.btnHienThi.Click += new System.EventHandler(this.btnHienThi_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(308, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 20);
            this.label9.TabIndex = 3;
            this.label9.Text = "Công việc";
            // 
            // cboHienThiTheo
            // 
            this.cboHienThiTheo.FormattingEnabled = true;
            this.cboHienThiTheo.Location = new System.Drawing.Point(397, 18);
            this.cboHienThiTheo.Name = "cboHienThiTheo";
            this.cboHienThiTheo.Size = new System.Drawing.Size(145, 28);
            this.cboHienThiTheo.TabIndex = 4;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(3)))), ((int)(((byte)(62)))));
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(218, 13);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(68, 36);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(3)))), ((int)(((byte)(62)))));
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(144, 13);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(68, 36);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa ";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(3)))), ((int)(((byte)(62)))));
            this.btnThemMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemMoi.ForeColor = System.Drawing.Color.White;
            this.btnThemMoi.Location = new System.Drawing.Point(24, 13);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(114, 36);
            this.btnThemMoi.TabIndex = 0;
            this.btnThemMoi.Text = "Thêm mới";
            this.btnThemMoi.UseVisualStyleBackColor = false;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // dgvHienThiThongTinNV
            // 
            this.dgvHienThiThongTinNV.BackgroundColor = System.Drawing.Color.White;
            this.dgvHienThiThongTinNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHienThiThongTinNV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHienThiThongTinNV.Location = new System.Drawing.Point(0, 265);
            this.dgvHienThiThongTinNV.Name = "dgvHienThiThongTinNV";
            this.dgvHienThiThongTinNV.ReadOnly = true;
            this.dgvHienThiThongTinNV.RowHeadersWidth = 51;
            this.dgvHienThiThongTinNV.RowTemplate.Height = 24;
            this.dgvHienThiThongTinNV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHienThiThongTinNV.Size = new System.Drawing.Size(1193, 336);
            this.dgvHienThiThongTinNV.TabIndex = 3;
            // 
            // frmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 601);
            this.Controls.Add(this.dgvHienThiThongTinNV);
            this.Controls.Add(this.pnChucNang);
            this.Controls.Add(this.pnThongTin);
            this.Controls.Add(this.label1);
            this.Name = "frmNhanVien";
            this.Text = "frmNhanVien";
            this.pnThongTin.ResumeLayout(false);
            this.pnThongTin.PerformLayout();
            this.pnChucNang.ResumeLayout(false);
            this.pnChucNang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHienThiThongTinNV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnThongTin;
        private System.Windows.Forms.Panel pnChucNang;
        private System.Windows.Forms.DataGridView dgvHienThiThongTinNV;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboHienThiTheo;
        private System.Windows.Forms.ComboBox cboCongViec;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMatKhauNV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTaiKhoanNV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnHienThi;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnThem1NV;
    }
}