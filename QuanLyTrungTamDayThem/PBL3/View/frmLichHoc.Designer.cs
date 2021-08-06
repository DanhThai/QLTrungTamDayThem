
namespace PBL3.View
{
    partial class frmLichHoc
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
            this.dgvLichHoc = new System.Windows.Forms.DataGridView();
            this.dgvLichDay = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichDay)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(291, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lịch học của lớp: ";
            // 
            // dgvLichHoc
            // 
            this.dgvLichHoc.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvLichHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLichHoc.Location = new System.Drawing.Point(22, 57);
            this.dgvLichHoc.Name = "dgvLichHoc";
            this.dgvLichHoc.ReadOnly = true;
            this.dgvLichHoc.RowHeadersWidth = 51;
            this.dgvLichHoc.RowTemplate.Height = 24;
            this.dgvLichHoc.Size = new System.Drawing.Size(766, 150);
            this.dgvLichHoc.TabIndex = 1;
            this.dgvLichHoc.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // dgvLichDay
            // 
            this.dgvLichDay.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvLichDay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLichDay.Location = new System.Drawing.Point(22, 288);
            this.dgvLichDay.Name = "dgvLichDay";
            this.dgvLichDay.RowHeadersWidth = 51;
            this.dgvLichDay.RowTemplate.Height = 24;
            this.dgvLichDay.Size = new System.Drawing.Size(766, 150);
            this.dgvLichDay.TabIndex = 2;
            this.dgvLichDay.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(291, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lịch dạy của giáo viên";
            // 
            // frmLichHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvLichDay);
            this.Controls.Add(this.dgvLichHoc);
            this.Controls.Add(this.label1);
            this.Name = "frmLichHoc";
            this.Text = "frmLichHoc";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichDay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvLichHoc;
        private System.Windows.Forms.DataGridView dgvLichDay;
        private System.Windows.Forms.Label label2;
    }
}