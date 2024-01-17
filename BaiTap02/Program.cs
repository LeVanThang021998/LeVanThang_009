using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap02
{

    class ChuNhat
    {
        private double rong;
        private double dai;

        public ChuNhat(double dai, double rong)
        {
            this.dai = dai;
            this.rong = rong;
        }
        public double TinhChuVi()
        {
            return 2 * (rong + dai);
        }
        public double TinhDienTich()
        {
            return dai * rong;
        }
        public virtual void Xuat()
        {
            Console.WriteLine("Chieu dai hinh chu nhat:" + dai);
            Console.WriteLine("Chieu rong hinh chu nhat:" + rong);
            Console.WriteLine("Dien Tich hinh chu nhat" + TinhDienTich());
            Console.WriteLine("Chu vi hinh chu nhat" + TinhChuVi());
        }
        class Vuong : ChuNhat
        {
            public Vuong(double canh) : base(canh, canh) { }
            public override void Xuat()
            {
                Console.WriteLine("Canh hinh vuong" + dai);
                Console.WriteLine("Dien tich:" + TinhDienTich());
                Console.WriteLine("Chu Vi:" + TinhChuVi());
            }
            class Program
            {
                static void Main(string[] args)
                {
                    Console.WriteLine("Nhap chieu dai hinh chu nhat:");
                    double daiCN = double.Parse(Console.ReadLine());

                    Console.WriteLine("Nhap chieu rong hinh chu nhat");
                    double rongCN = double.Parse(Console.ReadLine());

                    Console.WriteLine("Nhap canh hinh vuong:");
                    double canhvuong = double.Parse(Console.ReadLine());

                    ChuNhat cn = new ChuNhat(daiCN, rongCN);
                    Vuong vuong = new Vuong(canhvuong);

                    Console.WriteLine("\n Thong tin Hinh Chu Nhat:");
                    cn.Xuat();

                    Console.WriteLine("\n Thong tin hinh vuong:");
                    vuong.Xuat();

                    Console.ReadLine();
                }
            }
        }
    }
}
   