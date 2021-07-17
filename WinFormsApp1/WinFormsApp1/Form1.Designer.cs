
namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.timKiem = new System.Windows.Forms.Button();
            this.maSinhVien = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.thuocTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ketQua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // timKiem
            // 
            this.timKiem.Location = new System.Drawing.Point(303, 25);
            this.timKiem.Name = "timKiem";
            this.timKiem.Size = new System.Drawing.Size(94, 29);
            this.timKiem.TabIndex = 0;
            this.timKiem.Text = "Tìm Kiếm";
            this.timKiem.UseVisualStyleBackColor = true;
            this.timKiem.Click += new System.EventHandler(this.timKiem_Click);
            // 
            // maSinhVien
            // 
            this.maSinhVien.Location = new System.Drawing.Point(108, 25);
            this.maSinhVien.Name = "maSinhVien";
            this.maSinhVien.Size = new System.Drawing.Size(172, 27);
            this.maSinhVien.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.thuocTinh,
            this.ketQua});
            this.dataGridView1.Location = new System.Drawing.Point(-1, 147);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(789, 303);
            this.dataGridView1.TabIndex = 2;
            // 
            // thuocTinh
            // 
            this.thuocTinh.HeaderText = "";
            this.thuocTinh.MinimumWidth = 6;
            this.thuocTinh.Name = "thuocTinh";
            this.thuocTinh.ReadOnly = true;
            this.thuocTinh.Width = 200;
            // 
            // ketQua
            // 
            this.ketQua.HeaderText = "";
            this.ketQua.MinimumWidth = 6;
            this.ketQua.Name = "ketQua";
            this.ketQua.ReadOnly = true;
            this.ketQua.Width = 700;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã SV";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.maSinhVien);
            this.Controls.Add(this.timKiem);
            this.Name = "Form1";
            this.Text = "Tra Cứu thông tin sinh viên UTC2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button timKiem;
        private System.Windows.Forms.TextBox maSinhVien;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn thuocTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ketQua;
        private System.Windows.Forms.Label label1;
    }
}

