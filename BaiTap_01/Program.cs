using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap_01
{
    class NhanVien
    {
        private string HoTen;
        private double SoNgayCong;
        private double SoNgayLamThem;
        private string XepLoai;
        private string BoPhan;
        public NhanVien()
        { }
        public NhanVien(string hoten, double songaycong, double songaylamthem, string xeploai, string bophan)
        {
            this.hoten = hoten;
            this.SoNgayCong = songaycong;
            this.SoNgayLamThem = songaylamthem;
            this.XepLoai = xeploai;
            this.BoPhan = bophan;
        }
        public string hoten
        {
            set { HoTen = value; }
            get { return hoten; }
        }
        public double songaycong
        {
            set { songaycong = value; }
            get { return songaycong; }
        }
        public double songaylamthem
        {
            set { songaylamthem = value; }
            get { return songaylamthem; }
        }
        public string xeploai
        {
            set { xeploai = value; }
            get { return xeploai; }
        }
        public string bophan
        {
            set { bophan = value; }
            get { return bophan; }
        }
        public double TinhLuong()
        {
            double phanTramTang = (bophan == "truc tiep") ? 3.0 : 2.0;
            double luongMotNgay = 100000;
            return (songaycong + songaylamthem * (phanTramTang / 100)) * luongMotNgay;
        }
        public double TinhThuNhap()
        {
            switch (XepLoai)
            {
                case "A":
                    return 1.5 * TinhLuong();
                case "B":
                    return 1.2 * TinhLuong();
                case "C":
                    return TinhLuong();
                default: return 0;

            }
        }
        public void InThongTin()
        {
            Console.WriteLine("Ho Ten: 0", HoTen);
            Console.WriteLine("Bo Phan: 0", bophan);
            Console.WriteLine("Thu Nhap: 0", TinhThuNhap());
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
              NhanVien nhanVien1 = new NhanVien();
            Console.Write("Nhap Ho Ten: ");
            nhanVien1.hoten = Console.ReadLine();
            Console.Write("Nhap So Ngay Cong: ");
            nhanVien1.songaycong = int.Parse(Console.ReadLine());
            Console.Write("Nhap So Ngay Lam Them: ");
            nhanVien1.songaylamthem = int.Parse(Console.ReadLine());
            Console.Write("Nhap Xep Loai (A/B/C/D): ");
            nhanVien1.xeploai = Console.ReadLine();
            Console.Write("Nhap So Bo Phan (TrucTiep/GianTiep): ");
            nhanVien1.bophan = Console.ReadLine();
            nhanVien1.InThongTin();
            NhanVien nhanVien2 = new NhanVien(" Nguyen Van B", 25, 5, "B", " GianTiep");
            nhanVien2.InThongTin();
            Console.ReadLine();

        }
    }
}
