
namespace PBL3
{
    partial class frmLopHocPhan

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
            this.button1 = new System.Windows.Forms.Button();
            this.cboMonHoc = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenLop = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnThemLHP = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpNgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.cboGiaoVien = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pnChucNang = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThemMon = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnXem = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cboChonLop = new System.Windows.Forms.ComboBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThemLop = new System.Windows.Forms.Button();
            this.dgvHienThiKH = new System.Windows.Forms.DataGridView();
            this.cboThu = new System.Windows.Forms.ComboBox();
            this.cboBuoi = new System.Windows.Forms.ComboBox();
            this.pnThongTin.SuspendLayout();
            this.pnChucNang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHienThiKH)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(116)))), ((int)(((byte)(163)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1202, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông Tin Lớp Học Phần";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnThongTin
            // 
            this.pnThongTin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(116)))), ((int)(((byte)(163)))));
            this.pnThongTin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnThongTin.Controls.Add(this.cboBuoi);
            this.pnThongTin.Controls.Add(this.cboThu);
            this.pnThongTin.Controls.Add(this.button1);
            this.pnThongTin.Controls.Add(this.cboMonHoc);
            this.pnThongTin.Controls.Add(this.label4);
            this.pnThongTin.Controls.Add(this.txtTenLop);
            this.pnThongTin.Controls.Add(this.label3);
            this.pnThongTin.Controls.Add(this.btnThoat);
            this.pnThongTin.Controls.Add(this.btnThemLHP);
            this.pnThongTin.Controls.Add(this.label5);
            this.pnThongTin.Controls.Add(this.dtpNgayKetThuc);
            this.pnThongTin.Controls.Add(this.dtpNgayBatDau);
            this.pnThongTin.Controls.Add(this.cboGiaoVien);
            this.pnThongTin.Controls.Add(this.label7);
            this.pnThongTin.Controls.Add(this.label10);
            this.pnThongTin.Controls.Add(this.label6);
            this.pnThongTin.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnThongTin.Location = new System.Drawing.Point(0, 58);
            this.pnThongTin.Name = "pnThongTin";
            this.pnThongTin.Size = new System.Drawing.Size(1202, 221);
            this.pnThongTin.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(948, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 33);
            this.button1.TabIndex = 25;
            this.button1.Text = "Lịch Bận";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cboMonHoc
            // 
            this.cboMonHoc.FormattingEnabled = true;
            this.cboMonHoc.Location = new System.Drawing.Point(152, 74);
            this.cboMonHoc.Name = "cboMonHoc";
            this.cboMonHoc.Size = new System.Drawing.Size(162, 28);
            this.cboMonHoc.TabIndex = 23;
            this.cboMonHoc.SelectedIndexChanged += new System.EventHandler(this.cboMonHoc_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Môn học:";
            // 
            // txtTenLop
            // 
            this.txtTenLop.Location = new System.Drawing.Point(152, 19);
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Size = new System.Drawing.Size(162, 26);
            this.txtTenLop.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Tên lớp:";
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(3)))), ((int)(((byte)(62)))));
            this.btnThoat.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnThoat.Location = new System.Drawing.Point(859, 155);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 40);
            this.btnThoat.TabIndex = 20;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnThemLHP
            // 
            this.btnThemLHP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(3)))), ((int)(((byte)(62)))));
            this.btnThemLHP.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnThemLHP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemLHP.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnThemLHP.Location = new System.Drawing.Point(723, 154);
            this.btnThemLHP.Name = "btnThemLHP";
            this.btnThemLHP.Size = new System.Drawing.Size(116, 40);
            this.btnThemLHP.TabIndex = 18;
            this.btnThemLHP.Text = "Thêm ";
            this.btnThemLHP.UseVisualStyleBackColor = false;
            this.btnThemLHP.Click += new System.EventHandler(this.btnThemLHP_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(395, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Thời gian học:";
            // 
            // dtpNgayKetThuc
            // 
            this.dtpNgayKetThuc.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayKetThuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayKetThuc.Location = new System.Drawing.Point(522, 160);
            this.dtpNgayKetThuc.Name = "dtpNgayKetThuc";
            this.dtpNgayKetThuc.Size = new System.Drawing.Size(162, 27);
            this.dtpNgayKetThuc.TabIndex = 7;
            this.dtpNgayKetThuc.Value = new System.DateTime(2021, 5, 11, 21, 44, 29, 0);
            // 
            // dtpNgayBatDau
            // 
            this.dtpNgayBatDau.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayBatDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayBatDau.Location = new System.Drawing.Point(522, 87);
            this.dtpNgayBatDau.Name = "dtpNgayBatDau";
            this.dtpNgayBatDau.Size = new System.Drawing.Size(162, 27);
            this.dtpNgayBatDau.TabIndex = 5;
            this.dtpNgayBatDau.Value = new System.DateTime(2021, 5, 11, 21, 44, 29, 0);
            // 
            // cboGiaoVien
            // 
            this.cboGiaoVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboGiaoVien.FormattingEnabled = true;
            this.cboGiaoVien.Location = new System.Drawing.Point(152, 122);
            this.cboGiaoVien.Name = "cboGiaoVien";
            this.cboGiaoVien.Size = new System.Drawing.Size(162, 28);
            this.cboGiaoVien.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(397, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Ngày kết thúc:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(27, 125);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Giáo viên:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(397, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Ngày bắt đầu:";
            // 
            // pnChucNang
            // 
            this.pnChucNang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(116)))), ((int)(((byte)(163)))));
            this.pnChucNang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnChucNang.Controls.Add(this.label2);
            this.pnChucNang.Controls.Add(this.btnThemMon);
            this.pnChucNang.Controls.Add(this.txtTimKiem);
            this.pnChucNang.Controls.Add(this.btnTimKiem);
            this.pnChucNang.Controls.Add(this.btnXem);
            this.pnChucNang.Controls.Add(this.label8);
            this.pnChucNang.Controls.Add(this.cboChonLop);
            this.pnChucNang.Controls.Add(this.btnXoa);
            this.pnChucNang.Controls.Add(this.btnSua);
            this.pnChucNang.Controls.Add(this.btnThemLop);
            this.pnChucNang.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnChucNang.Location = new System.Drawing.Point(0, 279);
            this.pnChucNang.Name = "pnChucNang";
            this.pnChucNang.Size = new System.Drawing.Size(1202, 101);
            this.pnChucNang.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(902, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Môn học:";
            // 
            // btnThemMon
            // 
            this.btnThemMon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(3)))), ((int)(((byte)(62)))));
            this.btnThemMon.Cursor = System.Windows.Forms.Cursors.Help;
            this.btnThemMon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemMon.ForeColor = System.Drawing.Color.White;
            this.btnThemMon.Location = new System.Drawing.Point(152, 29);
            this.btnThemMon.Name = "btnThemMon";
            this.btnThemMon.Size = new System.Drawing.Size(116, 46);
            this.btnThemMon.TabIndex = 10;
            this.btnThemMon.Text = "Thêm LHP";
            this.btnThemMon.UseVisualStyleBackColor = false;
            this.btnThemMon.Click += new System.EventHandler(this.btnThemMon_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtTimKiem.Location = new System.Drawing.Point(905, 42);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(159, 22);
            this.txtTimKiem.TabIndex = 8;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(3)))), ((int)(((byte)(62)))));
            this.btnTimKiem.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Location = new System.Drawing.Point(1083, 29);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(69, 46);
            this.btnTimKiem.TabIndex = 9;
            this.btnTimKiem.Text = "Tìm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnXem
            // 
            this.btnXem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(3)))), ((int)(((byte)(62)))));
            this.btnXem.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnXem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXem.ForeColor = System.Drawing.Color.White;
            this.btnXem.Location = new System.Drawing.Point(610, 27);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(101, 46);
            this.btnXem.TabIndex = 7;
            this.btnXem.Text = "Hiển thị";
            this.btnXem.UseVisualStyleBackColor = false;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(479, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "Chọn lớp:";
            // 
            // cboChonLop
            // 
            this.cboChonLop.FormattingEnabled = true;
            this.cboChonLop.Location = new System.Drawing.Point(483, 47);
            this.cboChonLop.Name = "cboChonLop";
            this.cboChonLop.Size = new System.Drawing.Size(114, 24);
            this.cboChonLop.TabIndex = 3;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(3)))), ((int)(((byte)(62)))));
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(374, 29);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(60, 46);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(3)))), ((int)(((byte)(62)))));
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(286, 29);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(66, 46);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa ";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThemLop
            // 
            this.btnThemLop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(3)))), ((int)(((byte)(62)))));
            this.btnThemLop.Cursor = System.Windows.Forms.Cursors.Help;
            this.btnThemLop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemLop.ForeColor = System.Drawing.Color.White;
            this.btnThemLop.Location = new System.Drawing.Point(11, 27);
            this.btnThemLop.Name = "btnThemLop";
            this.btnThemLop.Size = new System.Drawing.Size(119, 46);
            this.btnThemLop.TabIndex = 0;
            this.btnThemLop.Text = "Thêm lớp";
            this.btnThemLop.UseVisualStyleBackColor = false;
            this.btnThemLop.Click += new System.EventHandler(this.btnThemLop_Click);
            // 
            // dgvHienThiKH
            // 
            this.dgvHienThiKH.BackgroundColor = System.Drawing.Color.White;
            this.dgvHienThiKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHienThiKH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHienThiKH.Location = new System.Drawing.Point(0, 380);
            this.dgvHienThiKH.Name = "dgvHienThiKH";
            this.dgvHienThiKH.ReadOnly = true;
            this.dgvHienThiKH.RowHeadersWidth = 51;
            this.dgvHienThiKH.RowTemplate.Height = 24;
            this.dgvHienThiKH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHienThiKH.Size = new System.Drawing.Size(1202, 269);
            this.dgvHienThiKH.TabIndex = 3;
            // 
            // cboThu
            // 
            this.cboThu.FormattingEnabled = true;
            this.cboThu.Location = new System.Drawing.Point(516, 28);
            this.cboThu.Name = "cboThu";
            this.cboThu.Size = new System.Drawing.Size(168, 28);
            this.cboThu.TabIndex = 26;
            // 
            // cboBuoi
            // 
            this.cboBuoi.FormattingEnabled = true;
            this.cboBuoi.Location = new System.Drawing.Point(723, 28);
            this.cboBuoi.Name = "cboBuoi";
            this.cboBuoi.Size = new System.Drawing.Size(168, 28);
            this.cboBuoi.TabIndex = 27;
            // 
            // frmLopHocPhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 649);
            this.Controls.Add(this.dgvHienThiKH);
            this.Controls.Add(this.pnChucNang);
            this.Controls.Add(this.pnThongTin);
            this.Controls.Add(this.label1);
            this.Name = "frmLopHocPhan";
            this.Text = "frmLopMonHoc";
            this.pnThongTin.ResumeLayout(false);
            this.pnThongTin.PerformLayout();
            this.pnChucNang.ResumeLayout(false);
            this.pnChucNang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHienThiKH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnThongTin;
        private System.Windows.Forms.Panel pnChucNang;
        private System.Windows.Forms.DataGridView dgvHienThiKH;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThemLop;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.DateTimePicker dtpNgayBatDau;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpNgayKetThuc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnThemLHP;
        private System.Windows.Forms.ComboBox cboGiaoVien;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTenLop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboChonLop;
        private System.Windows.Forms.ComboBox cboMonHoc;
        private System.Windows.Forms.Button btnThemMon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cboBuoi;
        private System.Windows.Forms.ComboBox cboThu;
    }
}