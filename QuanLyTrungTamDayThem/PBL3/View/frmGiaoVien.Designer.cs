
namespace PBL3
{
    partial class frmGiaoVien
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
            this.btnThem1GV = new System.Windows.Forms.Button();
            this.pnThongTinGV = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ckbVan = new System.Windows.Forms.CheckBox();
            this.ckbAnh = new System.Windows.Forms.CheckBox();
            this.ckbToan = new System.Windows.Forms.CheckBox();
            this.rbnNu = new System.Windows.Forms.RadioButton();
            this.rbnNam = new System.Windows.Forms.RadioButton();
            this.dtpNgaySinhGV = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHoTenGV = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSDTGV = new System.Windows.Forms.TextBox();
            this.txtDiaChiGV = new System.Windows.Forms.TextBox();
            this.txtTrinhDo = new System.Windows.Forms.TextBox();
            this.btnSuaGV = new System.Windows.Forms.Button();
            this.btnThemMoiGV = new System.Windows.Forms.Button();
            this.btnXoaGV = new System.Windows.Forms.Button();
            this.btnTimKiemGV = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvHienThiThongTinGV = new System.Windows.Forms.DataGridView();
            this.pnChucNang = new System.Windows.Forms.Panel();
            this.cboSapXep = new System.Windows.Forms.ComboBox();
            this.txtTimKiemGV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.pnThongTinGV.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHienThiThongTinGV)).BeginInit();
            this.pnChucNang.SuspendLayout();
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
            this.label1.Size = new System.Drawing.Size(1186, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin Giáo Viên";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1186, 46);
            this.panel2.TabIndex = 0;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(3)))), ((int)(((byte)(62)))));
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnThoat.Location = new System.Drawing.Point(1047, 121);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 40);
            this.btnThoat.TabIndex = 21;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnThem1GV
            // 
            this.btnThem1GV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(3)))), ((int)(((byte)(62)))));
            this.btnThem1GV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem1GV.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnThem1GV.Location = new System.Drawing.Point(944, 121);
            this.btnThem1GV.Name = "btnThem1GV";
            this.btnThem1GV.Size = new System.Drawing.Size(75, 40);
            this.btnThem1GV.TabIndex = 19;
            this.btnThem1GV.Text = "Thêm";
            this.btnThem1GV.UseVisualStyleBackColor = false;
            this.btnThem1GV.Click += new System.EventHandler(this.btnThem1GV_Click);
            // 
            // pnThongTinGV
            // 
            this.pnThongTinGV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(116)))), ((int)(((byte)(163)))));
            this.pnThongTinGV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnThongTinGV.Controls.Add(this.groupBox1);
            this.pnThongTinGV.Controls.Add(this.btnThoat);
            this.pnThongTinGV.Controls.Add(this.btnThem1GV);
            this.pnThongTinGV.Controls.Add(this.rbnNu);
            this.pnThongTinGV.Controls.Add(this.rbnNam);
            this.pnThongTinGV.Controls.Add(this.dtpNgaySinhGV);
            this.pnThongTinGV.Controls.Add(this.label6);
            this.pnThongTinGV.Controls.Add(this.label5);
            this.pnThongTinGV.Controls.Add(this.label4);
            this.pnThongTinGV.Controls.Add(this.txtHoTenGV);
            this.pnThongTinGV.Controls.Add(this.label9);
            this.pnThongTinGV.Controls.Add(this.label8);
            this.pnThongTinGV.Controls.Add(this.label7);
            this.pnThongTinGV.Controls.Add(this.txtSDTGV);
            this.pnThongTinGV.Controls.Add(this.txtDiaChiGV);
            this.pnThongTinGV.Controls.Add(this.txtTrinhDo);
            this.pnThongTinGV.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnThongTinGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnThongTinGV.Location = new System.Drawing.Point(0, 46);
            this.pnThongTinGV.Name = "pnThongTinGV";
            this.pnThongTinGV.Size = new System.Drawing.Size(1186, 200);
            this.pnThongTinGV.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ckbVan);
            this.groupBox1.Controls.Add(this.ckbAnh);
            this.groupBox1.Controls.Add(this.ckbToan);
            this.groupBox1.Location = new System.Drawing.Point(510, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 97);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chuyên Môn";
            // 
            // ckbVan
            // 
            this.ckbVan.AutoSize = true;
            this.ckbVan.Location = new System.Drawing.Point(258, 39);
            this.ckbVan.Name = "ckbVan";
            this.ckbVan.Size = new System.Drawing.Size(60, 24);
            this.ckbVan.TabIndex = 2;
            this.ckbVan.Text = "Văn";
            this.ckbVan.UseVisualStyleBackColor = true;
            // 
            // ckbAnh
            // 
            this.ckbAnh.AutoSize = true;
            this.ckbAnh.Location = new System.Drawing.Point(141, 39);
            this.ckbAnh.Name = "ckbAnh";
            this.ckbAnh.Size = new System.Drawing.Size(60, 24);
            this.ckbAnh.TabIndex = 1;
            this.ckbAnh.Text = "Anh";
            this.ckbAnh.UseVisualStyleBackColor = true;
            // 
            // ckbToan
            // 
            this.ckbToan.AutoSize = true;
            this.ckbToan.Location = new System.Drawing.Point(28, 37);
            this.ckbToan.Name = "ckbToan";
            this.ckbToan.Size = new System.Drawing.Size(68, 24);
            this.ckbToan.TabIndex = 0;
            this.ckbToan.Text = "Toán";
            this.ckbToan.UseVisualStyleBackColor = true;
            // 
            // rbnNu
            // 
            this.rbnNu.AutoSize = true;
            this.rbnNu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnNu.Location = new System.Drawing.Point(434, 62);
            this.rbnNu.Name = "rbnNu";
            this.rbnNu.Size = new System.Drawing.Size(51, 24);
            this.rbnNu.TabIndex = 8;
            this.rbnNu.TabStop = true;
            this.rbnNu.Text = "Nữ";
            this.rbnNu.UseVisualStyleBackColor = true;
            // 
            // rbnNam
            // 
            this.rbnNam.AutoSize = true;
            this.rbnNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnNam.Location = new System.Drawing.Point(368, 62);
            this.rbnNam.Name = "rbnNam";
            this.rbnNam.Size = new System.Drawing.Size(65, 24);
            this.rbnNam.TabIndex = 7;
            this.rbnNam.TabStop = true;
            this.rbnNam.Text = "Nam";
            this.rbnNam.UseVisualStyleBackColor = true;
            // 
            // dtpNgaySinhGV
            // 
            this.dtpNgaySinhGV.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaySinhGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgaySinhGV.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinhGV.Location = new System.Drawing.Point(160, 61);
            this.dtpNgaySinhGV.Name = "dtpNgaySinhGV";
            this.dtpNgaySinhGV.Size = new System.Drawing.Size(110, 26);
            this.dtpNgaySinhGV.TabIndex = 5;
            this.dtpNgaySinhGV.Value = new System.DateTime(2021, 5, 6, 23, 34, 29, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(281, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Giới Tính:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ngày Sinh:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Họ Tên:";
            // 
            // txtHoTenGV
            // 
            this.txtHoTenGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTenGV.Location = new System.Drawing.Point(160, 24);
            this.txtHoTenGV.Name = "txtHoTenGV";
            this.txtHoTenGV.Size = new System.Drawing.Size(320, 26);
            this.txtHoTenGV.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(506, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 20);
            this.label9.TabIndex = 13;
            this.label9.Text = "Trình Độ:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(26, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "Số Điện Thoại:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(26, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Địa Chỉ:";
            // 
            // txtSDTGV
            // 
            this.txtSDTGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDTGV.Location = new System.Drawing.Point(160, 135);
            this.txtSDTGV.MaxLength = 10;
            this.txtSDTGV.Name = "txtSDTGV";
            this.txtSDTGV.Size = new System.Drawing.Size(320, 26);
            this.txtSDTGV.TabIndex = 12;
            // 
            // txtDiaChiGV
            // 
            this.txtDiaChiGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChiGV.Location = new System.Drawing.Point(160, 98);
            this.txtDiaChiGV.Name = "txtDiaChiGV";
            this.txtDiaChiGV.Size = new System.Drawing.Size(320, 26);
            this.txtDiaChiGV.TabIndex = 10;
            // 
            // txtTrinhDo
            // 
            this.txtTrinhDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrinhDo.Location = new System.Drawing.Point(633, 24);
            this.txtTrinhDo.Name = "txtTrinhDo";
            this.txtTrinhDo.Size = new System.Drawing.Size(232, 26);
            this.txtTrinhDo.TabIndex = 1;
            // 
            // btnSuaGV
            // 
            this.btnSuaGV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(3)))), ((int)(((byte)(62)))));
            this.btnSuaGV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaGV.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSuaGV.Location = new System.Drawing.Point(133, 10);
            this.btnSuaGV.Name = "btnSuaGV";
            this.btnSuaGV.Size = new System.Drawing.Size(60, 41);
            this.btnSuaGV.TabIndex = 2;
            this.btnSuaGV.Text = "Sửa";
            this.btnSuaGV.UseVisualStyleBackColor = false;
            this.btnSuaGV.Click += new System.EventHandler(this.btnSuaGV_Click);
            // 
            // btnThemMoiGV
            // 
            this.btnThemMoiGV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(3)))), ((int)(((byte)(62)))));
            this.btnThemMoiGV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemMoiGV.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnThemMoiGV.Location = new System.Drawing.Point(8, 9);
            this.btnThemMoiGV.Name = "btnThemMoiGV";
            this.btnThemMoiGV.Size = new System.Drawing.Size(100, 41);
            this.btnThemMoiGV.TabIndex = 1;
            this.btnThemMoiGV.Text = "Thêm mới";
            this.btnThemMoiGV.UseVisualStyleBackColor = false;
            this.btnThemMoiGV.Click += new System.EventHandler(this.btnThemMoiGV_Click);
            // 
            // btnXoaGV
            // 
            this.btnXoaGV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(3)))), ((int)(((byte)(62)))));
            this.btnXoaGV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaGV.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnXoaGV.Location = new System.Drawing.Point(220, 10);
            this.btnXoaGV.Name = "btnXoaGV";
            this.btnXoaGV.Size = new System.Drawing.Size(60, 41);
            this.btnXoaGV.TabIndex = 3;
            this.btnXoaGV.Text = "Xóa";
            this.btnXoaGV.UseVisualStyleBackColor = false;
            this.btnXoaGV.Click += new System.EventHandler(this.btnXoaGV_Click);
            // 
            // btnTimKiemGV
            // 
            this.btnTimKiemGV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimKiemGV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(3)))), ((int)(((byte)(62)))));
            this.btnTimKiemGV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiemGV.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnTimKiemGV.Location = new System.Drawing.Point(1061, 9);
            this.btnTimKiemGV.Name = "btnTimKiemGV";
            this.btnTimKiemGV.Size = new System.Drawing.Size(91, 41);
            this.btnTimKiemGV.TabIndex = 0;
            this.btnTimKiemGV.Text = "Tìm Kiếm";
            this.btnTimKiemGV.UseVisualStyleBackColor = false;
            this.btnTimKiemGV.Click += new System.EventHandler(this.btnTimKiemGV_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvHienThiThongTinGV);
            this.panel1.Controls.Add(this.pnChucNang);
            this.panel1.Controls.Add(this.pnThongTinGV);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1186, 588);
            this.panel1.TabIndex = 1;
            // 
            // dgvHienThiThongTinGV
            // 
            this.dgvHienThiThongTinGV.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvHienThiThongTinGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHienThiThongTinGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHienThiThongTinGV.Location = new System.Drawing.Point(0, 311);
            this.dgvHienThiThongTinGV.Name = "dgvHienThiThongTinGV";
            this.dgvHienThiThongTinGV.ReadOnly = true;
            this.dgvHienThiThongTinGV.RowHeadersWidth = 51;
            this.dgvHienThiThongTinGV.RowTemplate.Height = 24;
            this.dgvHienThiThongTinGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHienThiThongTinGV.Size = new System.Drawing.Size(1186, 277);
            this.dgvHienThiThongTinGV.TabIndex = 2;
            // 
            // pnChucNang
            // 
            this.pnChucNang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(116)))), ((int)(((byte)(163)))));
            this.pnChucNang.Controls.Add(this.cboSapXep);
            this.pnChucNang.Controls.Add(this.txtTimKiemGV);
            this.pnChucNang.Controls.Add(this.label2);
            this.pnChucNang.Controls.Add(this.btnTimKiemGV);
            this.pnChucNang.Controls.Add(this.btnXoaGV);
            this.pnChucNang.Controls.Add(this.btnSuaGV);
            this.pnChucNang.Controls.Add(this.btnThemMoiGV);
            this.pnChucNang.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnChucNang.Location = new System.Drawing.Point(0, 246);
            this.pnChucNang.Name = "pnChucNang";
            this.pnChucNang.Size = new System.Drawing.Size(1186, 65);
            this.pnChucNang.TabIndex = 0;
            // 
            // cboSapXep
            // 
            this.cboSapXep.FormattingEnabled = true;
            this.cboSapXep.Location = new System.Drawing.Point(331, 34);
            this.cboSapXep.Name = "cboSapXep";
            this.cboSapXep.Size = new System.Drawing.Size(137, 24);
            this.cboSapXep.TabIndex = 5;
            this.cboSapXep.SelectedIndexChanged += new System.EventHandler(this.cboSapXep_SelectedIndexChanged);
            // 
            // txtTimKiemGV
            // 
            this.txtTimKiemGV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimKiemGV.Location = new System.Drawing.Point(843, 18);
            this.txtTimKiemGV.Name = "txtTimKiemGV";
            this.txtTimKiemGV.Size = new System.Drawing.Size(210, 22);
            this.txtTimKiemGV.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(3)))), ((int)(((byte)(62)))));
            this.label2.Location = new System.Drawing.Point(365, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sắp Xếp:";
            // 
            // frmGiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 588);
            this.Controls.Add(this.panel1);
            this.Name = "frmGiaoVien";
            this.Text = "GiaoVien";
            this.panel2.ResumeLayout(false);
            this.pnThongTinGV.ResumeLayout(false);
            this.pnThongTinGV.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHienThiThongTinGV)).EndInit();
            this.pnChucNang.ResumeLayout(false);
            this.pnChucNang.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnThem1GV;
        private System.Windows.Forms.Panel pnThongTinGV;
        private System.Windows.Forms.RadioButton rbnNu;
        private System.Windows.Forms.RadioButton rbnNam;
        private System.Windows.Forms.DateTimePicker dtpNgaySinhGV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHoTenGV;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSDTGV;
        private System.Windows.Forms.TextBox txtDiaChiGV;
        private System.Windows.Forms.Button btnSuaGV;
        private System.Windows.Forms.Button btnThemMoiGV;
        private System.Windows.Forms.Button btnXoaGV;
        private System.Windows.Forms.Button btnTimKiemGV;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvHienThiThongTinGV;
        private System.Windows.Forms.Panel pnChucNang;
        private System.Windows.Forms.ComboBox cboSapXep;
        private System.Windows.Forms.TextBox txtTimKiemGV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTrinhDo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ckbVan;
        private System.Windows.Forms.CheckBox ckbAnh;
        private System.Windows.Forms.CheckBox ckbToan;
    }
}