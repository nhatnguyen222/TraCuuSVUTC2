using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timKiem_Click(object sender, EventArgs e)
        {
            SinhVien sinhvien = new SinhVien();
            sinhvien.maSinhVien = maSinhVien.Text.ToString();
            if (sinhvien.kiemTraThongTin())
            {
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();
                dataGridView1.Rows.Add(new string[] { "Số CMND", sinhvien.CMND });
                dataGridView1.Rows.Add(new string[] { "Họ Tên", sinhvien.HODEM + " " + sinhvien.TEN });
                dataGridView1.Rows.Add(new string[] { "Ngày sinh", sinhvien.NGAY_SINH });
                dataGridView1.Rows.Add(new string[] { "SĐT Cá Nhân", sinhvien.DIEN_THOAI_DD });
                dataGridView1.Rows.Add(new string[] { "Địa Chỉ", sinhvien.PHUONG_XA });
                dataGridView1.Rows.Add(new string[] { "Tên Phụ Huynh", sinhvien.KHICAN_BANTINCHO_AI });
                dataGridView1.Rows.Add(new string[] { "SĐT Phụ Huynh", sinhvien.DIEN_THOAI_GDINH });
                dataGridView1.Rows.Add(new string[] { "Địa Chỉ Phụ Huynh", sinhvien.KHICAN_BANTINCHO_AI_DIACHI });
                dataGridView1.Rows.Add(new string[] { "Email", sinhvien.EMAIL });
                dataGridView1.Rows.Add(new string[] { "Số TK Ngân Hàng", sinhvien.SO_TAIKHOAN });


            }
            else MessageBox.Show("Ma sinh vien khong ton tai"); 
        }
    }
}
