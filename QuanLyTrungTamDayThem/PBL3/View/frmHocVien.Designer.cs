
namespace PBL3
{
    partial class frmHocVien
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnThem1HV = new System.Windows.Forms.Button();
            this.rbnNu = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnInDS = new System.Windows.Forms.Button();
            this.dgvHienThiThongTinHV = new System.Windows.Forms.DataGridView();
            this.pnChucnang = new System.Windows.Forms.Panel();
            this.btnHienThi = new System.Windows.Forms.Button();
            this.cboHienThiHV = new System.Windows.Forms.ComboBox();
            this.cboSapXep = new System.Windows.Forms.ComboBox();
            this.txtTimKiemHV = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTimKiemHV = new System.Windows.Forms.Button();
            this.btnXoaHV = new System.Windows.Forms.Button();
            this.btnSuaHV = new System.Windows.Forms.Button();
            this.btnThemMoiHV = new System.Windows.Forms.Button();
            this.pnThongTinHV = new System.Windows.Forms.Panel();
            this.cboLopHoc = new System.Windows.Forms.ComboBox();
            this.rbnNam = new System.Windows.Forms.RadioButton();
            this.dtpNgaySinhHV = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTinhTrang = new System.Windows.Forms.TextBox();
            this.txtHoTenHV = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSDTHV = new System.Windows.Forms.TextBox();
            this.txtDiaChiHV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHienThiThongTinHV)).BeginInit();
            this.pnChucnang.SuspendLayout();
            this.pnThongTinHV.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(116)))), ((int)(((byte)(163)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1167, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin Học Viên";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1167, 46);
            this.panel2.TabIndex = 0;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(3)))), ((int)(((byte)(62)))));
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnThoat.Location = new System.Drawing.Point(699, 138);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 40);
            this.btnThoat.TabIndex = 18;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnThem1HV
            // 
            this.btnThem1HV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(3)))), ((int)(((byte)(62)))));
            this.btnThem1HV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem1HV.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnThem1HV.Location = new System.Drawing.Point(594, 138);
            this.btnThem1HV.Name = "btnThem1HV";
            this.btnThem1HV.Size = new System.Drawing.Size(75, 40);
            this.btnThem1HV.TabIndex = 16;
            this.btnThem1HV.Text = "Thêm";
            this.btnThem1HV.UseVisualStyleBackColor = false;
            this.btnThem1HV.Click += new System.EventHandler(this.btnThem1HV_Click);
            // 
            // rbnNu
            // 
            this.rbnNu.AutoSize = true;
            this.rbnNu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnNu.Location = new System.Drawing.Point(415, 64);
            this.rbnNu.Name = "rbnNu";
            this.rbnNu.Size = new System.Drawing.Size(51, 24);
            this.rbnNu.TabIndex = 8;
            this.rbnNu.TabStop = true;
            this.rbnNu.Text = "Nữ";
            this.rbnNu.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnInDS);
            this.panel1.Controls.Add(this.dgvHienThiThongTinHV);
            this.panel1.Controls.Add(this.pnChucnang);
            this.panel1.Controls.Add(this.pnThongTinHV);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1167, 668);
            this.panel1.TabIndex = 1;
            // 
            // btnInDS
            // 
            this.btnInDS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInDS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(3)))), ((int)(((byte)(62)))));
            this.btnInDS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInDS.ForeColor = System.Drawing.Color.White;
            this.btnInDS.Location = new System.Drawing.Point(970, 621);
            this.btnInDS.Name = "btnInDS";
            this.btnInDS.Size = new System.Drawing.Size(163, 35);
            this.btnInDS.TabIndex = 2;
            this.btnInDS.Text = "In Danh Sách";
            this.btnInDS.UseVisualStyleBackColor = false;
            this.btnInDS.Click += new System.EventHandler(this.btnInDS_Click);
            // 
            // dgvHienThiThongTinHV
            // 
            this.dgvHienThiThongTinHV.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvHienThiThongTinHV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHienThiThongTinHV.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvHienThiThongTinHV.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dgvHienThiThongTinHV.Location = new System.Drawing.Point(0, 328);
            this.dgvHienThiThongTinHV.Name = "dgvHienThiThongTinHV";
            this.dgvHienThiThongTinHV.ReadOnly = true;
            this.dgvHienThiThongTinHV.RowHeadersWidth = 51;
            this.dgvHienThiThongTinHV.RowTemplate.Height = 24;
            this.dgvHienThiThongTinHV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHienThiThongTinHV.Size = new System.Drawing.Size(1167, 272);
            this.dgvHienThiThongTinHV.TabIndex = 1;
            // 
            // pnChucnang
            // 
            this.pnChucnang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(116)))), ((int)(((byte)(163)))));
            this.pnChucnang.Controls.Add(this.label3);
            this.pnChucnang.Controls.Add(this.btnHienThi);
            this.pnChucnang.Controls.Add(this.cboHienThiHV);
            this.pnChucnang.Controls.Add(this.cboSapXep);
            this.pnChucnang.Controls.Add(this.txtTimKiemHV);
            this.pnChucnang.Controls.Add(this.label10);
            this.pnChucnang.Controls.Add(this.label2);
            this.pnChucnang.Controls.Add(this.btnTimKiemHV);
            this.pnChucnang.Controls.Add(this.btnXoaHV);
            this.pnChucnang.Controls.Add(this.btnSuaHV);
            this.pnChucnang.Controls.Add(this.btnThemMoiHV);
            this.pnChucnang.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnChucnang.Location = new System.Drawing.Point(0, 240);
            this.pnChucnang.Name = "pnChucnang";
            this.pnChucnang.Size = new System.Drawing.Size(1167, 88);
            this.pnChucnang.TabIndex = 0;
            // 
            // btnHienThi
            // 
            this.btnHienThi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(3)))), ((int)(((byte)(62)))));
            this.btnHienThi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHienThi.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnHienThi.Location = new System.Drawing.Point(595, 22);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(91, 40);
            this.btnHienThi.TabIndex = 17;
            this.btnHienThi.Text = "Hiển thị";
            this.btnHienThi.UseVisualStyleBackColor = false;
            this.btnHienThi.Click += new System.EventHandler(this.btnHienThi_Click);
            // 
            // cboHienThiHV
            // 
            this.cboHienThiHV.FormattingEnabled = true;
            this.cboHienThiHV.Location = new System.Drawing.Point(414, 38);
            this.cboHienThiHV.Name = "cboHienThiHV";
            this.cboHienThiHV.Size = new System.Drawing.Size(167, 24);
            this.cboHienThiHV.TabIndex = 5;
            // 
            // cboSapXep
            // 
            this.cboSapXep.FormattingEnabled = true;
            this.cboSapXep.Location = new System.Drawing.Point(261, 38);
            this.cboSapXep.Name = "cboSapXep";
            this.cboSapXep.Size = new System.Drawing.Size(139, 24);
            this.cboSapXep.TabIndex = 4;
            this.cboSapXep.SelectedIndexChanged += new System.EventHandler(this.cboSapXep_SelectedIndexChanged);
            // 
            // txtTimKiemHV
            // 
            this.txtTimKiemHV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimKiemHV.Location = new System.Drawing.Point(849, 36);
            this.txtTimKiemHV.Name = "txtTimKiemHV";
            this.txtTimKiemHV.Size = new System.Drawing.Size(187, 22);
            this.txtTimKiemHV.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(3)))), ((int)(((byte)(62)))));
            this.label10.Location = new System.Drawing.Point(419, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(152, 20);
            this.label10.TabIndex = 3;
            this.label10.Text = "Hiển Thị Theo Lớp:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(3)))), ((int)(((byte)(62)))));
            this.label2.Location = new System.Drawing.Point(294, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sắp Xếp:";
            // 
            // btnTimKiemHV
            // 
            this.btnTimKiemHV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimKiemHV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(3)))), ((int)(((byte)(62)))));
            this.btnTimKiemHV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiemHV.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnTimKiemHV.Location = new System.Drawing.Point(1042, 17);
            this.btnTimKiemHV.Name = "btnTimKiemHV";
            this.btnTimKiemHV.Size = new System.Drawing.Size(91, 41);
            this.btnTimKiemHV.TabIndex = 7;
            this.btnTimKiemHV.Text = "Tìm Kiếm";
            this.btnTimKiemHV.UseVisualStyleBackColor = false;
            this.btnTimKiemHV.Click += new System.EventHandler(this.btnTimKiemHV_Click);
            // 
            // btnXoaHV
            // 
            this.btnXoaHV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(3)))), ((int)(((byte)(62)))));
            this.btnXoaHV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaHV.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnXoaHV.Location = new System.Drawing.Point(177, 17);
            this.btnXoaHV.Name = "btnXoaHV";
            this.btnXoaHV.Size = new System.Drawing.Size(60, 41);
            this.btnXoaHV.TabIndex = 2;
            this.btnXoaHV.Text = "Xóa";
            this.btnXoaHV.UseVisualStyleBackColor = false;
            this.btnXoaHV.Click += new System.EventHandler(this.btnXoaHV_Click);
            // 
            // btnSuaHV
            // 
            this.btnSuaHV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(3)))), ((int)(((byte)(62)))));
            this.btnSuaHV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaHV.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSuaHV.Location = new System.Drawing.Point(111, 17);
            this.btnSuaHV.Name = "btnSuaHV";
            this.btnSuaHV.Size = new System.Drawing.Size(60, 41);
            this.btnSuaHV.TabIndex = 1;
            this.btnSuaHV.Text = "Sửa";
            this.btnSuaHV.UseVisualStyleBackColor = false;
            this.btnSuaHV.Click += new System.EventHandler(this.btnSuaHV_Click);
            // 
            // btnThemMoiHV
            // 
            this.btnThemMoiHV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(3)))), ((int)(((byte)(62)))));
            this.btnThemMoiHV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemMoiHV.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnThemMoiHV.Location = new System.Drawing.Point(12, 17);
            this.btnThemMoiHV.Name = "btnThemMoiHV";
            this.btnThemMoiHV.Size = new System.Drawing.Size(93, 41);
            this.btnThemMoiHV.TabIndex = 0;
            this.btnThemMoiHV.Text = "Thêm mới";
            this.btnThemMoiHV.UseVisualStyleBackColor = false;
            this.btnThemMoiHV.Click += new System.EventHandler(this.btnThemHV_Click);
            // 
            // pnThongTinHV
            // 
            this.pnThongTinHV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(116)))), ((int)(((byte)(163)))));
            this.pnThongTinHV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnThongTinHV.Controls.Add(this.btnThoat);
            this.pnThongTinHV.Controls.Add(this.btnThem1HV);
            this.pnThongTinHV.Controls.Add(this.cboLopHoc);
            this.pnThongTinHV.Controls.Add(this.rbnNu);
            this.pnThongTinHV.Controls.Add(this.rbnNam);
            this.pnThongTinHV.Controls.Add(this.dtpNgaySinhHV);
            this.pnThongTinHV.Controls.Add(this.label6);
            this.pnThongTinHV.Controls.Add(this.label5);
            this.pnThongTinHV.Controls.Add(this.label4);
            this.pnThongTinHV.Controls.Add(this.label11);
            this.pnThongTinHV.Controls.Add(this.txtTinhTrang);
            this.pnThongTinHV.Controls.Add(this.txtHoTenHV);
            this.pnThongTinHV.Controls.Add(this.label9);
            this.pnThongTinHV.Controls.Add(this.label8);
            this.pnThongTinHV.Controls.Add(this.label7);
            this.pnThongTinHV.Controls.Add(this.txtSDTHV);
            this.pnThongTinHV.Controls.Add(this.txtDiaChiHV);
            this.pnThongTinHV.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnThongTinHV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnThongTinHV.Location = new System.Drawing.Point(0, 46);
            this.pnThongTinHV.Name = "pnThongTinHV";
            this.pnThongTinHV.Size = new System.Drawing.Size(1167, 194);
            this.pnThongTinHV.TabIndex = 1;
            // 
            // cboLopHoc
            // 
            this.cboLopHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLopHoc.FormattingEnabled = true;
            this.cboLopHoc.Location = new System.Drawing.Point(594, 63);
            this.cboLopHoc.Name = "cboLopHoc";
            this.cboLopHoc.Size = new System.Drawing.Size(180, 28);
            this.cboLopHoc.TabIndex = 14;
            // 
            // rbnNam
            // 
            this.rbnNam.AutoSize = true;
            this.rbnNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnNam.Location = new System.Drawing.Point(352, 64);
            this.rbnNam.Name = "rbnNam";
            this.rbnNam.Size = new System.Drawing.Size(65, 24);
            this.rbnNam.TabIndex = 7;
            this.rbnNam.TabStop = true;
            this.rbnNam.Text = "Nam";
            this.rbnNam.UseVisualStyleBackColor = true;
            // 
            // dtpNgaySinhHV
            // 
            this.dtpNgaySinhHV.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaySinhHV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgaySinhHV.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinhHV.Location = new System.Drawing.Point(157, 63);
            this.dtpNgaySinhHV.Name = "dtpNgaySinhHV";
            this.dtpNgaySinhHV.Size = new System.Drawing.Size(110, 26);
            this.dtpNgaySinhHV.TabIndex = 5;
            this.dtpNgaySinhHV.Value = new System.DateTime(2021, 5, 6, 23, 34, 29, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(271, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Giới Tính:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ngày Sinh:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Họ Tên:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(486, 67);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 20);
            this.label11.TabIndex = 13;
            this.label11.Text = "Lớp học:";
            // 
            // txtTinhTrang
            // 
            this.txtTinhTrang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTinhTrang.Location = new System.Drawing.Point(594, 26);
            this.txtTinhTrang.MaxLength = 20;
            this.txtTinhTrang.Name = "txtTinhTrang";
            this.txtTinhTrang.Size = new System.Drawing.Size(180, 26);
            this.txtTinhTrang.TabIndex = 3;
            // 
            // txtHoTenHV
            // 
            this.txtHoTenHV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTenHV.Location = new System.Drawing.Point(157, 26);
            this.txtHoTenHV.MaxLength = 20;
            this.txtHoTenHV.Name = "txtHoTenHV";
            this.txtHoTenHV.Size = new System.Drawing.Size(307, 26);
            this.txtHoTenHV.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(486, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 20);
            this.label9.TabIndex = 13;
            this.label9.Text = "Tình Trạng:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(28, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "Số Điện Thoại:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(28, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Địa Chỉ:";
            // 
            // txtSDTHV
            // 
            this.txtSDTHV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDTHV.Location = new System.Drawing.Point(157, 137);
            this.txtSDTHV.MaxLength = 10;
            this.txtSDTHV.Name = "txtSDTHV";
            this.txtSDTHV.Size = new System.Drawing.Size(307, 26);
            this.txtSDTHV.TabIndex = 12;
            // 
            // txtDiaChiHV
            // 
            this.txtDiaChiHV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChiHV.Location = new System.Drawing.Point(157, 100);
            this.txtDiaChiHV.MaxLength = 50;
            this.txtDiaChiHV.Name = "txtDiaChiHV";
            this.txtDiaChiHV.Size = new System.Drawing.Size(307, 26);
            this.txtDiaChiHV.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(846, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Họ tên:";
            // 
            // frmHocVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(116)))), ((int)(((byte)(163)))));
            this.ClientSize = new System.Drawing.Size(1167, 668);
            this.Controls.Add(this.panel1);
            this.Name = "frmHocVien";
            this.Text = "HocVien";
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHienThiThongTinHV)).EndInit();
            this.pnChucnang.ResumeLayout(false);
            this.pnChucnang.PerformLayout();
            this.pnThongTinHV.ResumeLayout(false);
            this.pnThongTinHV.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnThem1HV;
        private System.Windows.Forms.RadioButton rbnNu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnChucnang;
        private System.Windows.Forms.ComboBox cboSapXep;
        private System.Windows.Forms.TextBox txtTimKiemHV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTimKiemHV;
        private System.Windows.Forms.Button btnXoaHV;
        private System.Windows.Forms.Button btnSuaHV;
        private System.Windows.Forms.Button btnThemMoiHV;
        private System.Windows.Forms.Panel pnThongTinHV;
        private System.Windows.Forms.RadioButton rbnNam;
        private System.Windows.Forms.DateTimePicker dtpNgaySinhHV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHoTenHV;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSDTHV;
        private System.Windows.Forms.TextBox txtDiaChiHV;
        private System.Windows.Forms.DataGridView dgvHienThiThongTinHV;
        private System.Windows.Forms.ComboBox cboHienThiHV;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnHienThi;
        private System.Windows.Forms.ComboBox cboLopHoc;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTinhTrang;
        private System.Windows.Forms.Button btnInDS;
        private System.Windows.Forms.Label label3;
    }
}