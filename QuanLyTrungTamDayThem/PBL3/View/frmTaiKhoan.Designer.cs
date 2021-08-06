
namespace PBL3
{
    partial class frmTaiKhoan
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
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.lblDoiMatKhau = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Location = new System.Drawing.Point(71, 50);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(159, 55);
            this.btnDangXuat.TabIndex = 0;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.UseVisualStyleBackColor = true;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // lblDoiMatKhau
            // 
            this.lblDoiMatKhau.AutoSize = true;
            this.lblDoiMatKhau.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblDoiMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoiMatKhau.Location = new System.Drawing.Point(105, 123);
            this.lblDoiMatKhau.Name = "lblDoiMatKhau";
            this.lblDoiMatKhau.Size = new System.Drawing.Size(91, 17);
            this.lblDoiMatKhau.TabIndex = 1;
            this.lblDoiMatKhau.Text = "Đổi mật khẩu";
            this.lblDoiMatKhau.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 191);
            this.Controls.Add(this.lblDoiMatKhau);
            this.Controls.Add(this.btnDangXuat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmTaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTaiKhoan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Label lblDoiMatKhau;
    }
}