using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap_05
{
    class Program
    {
        static void Main(string[] args)
        {
             menu();
        }
        static void menu()
        {
            QuanLyCD quanLyCD = new QuanLyCD();
            int chon = 0;
            do
            {
                Console.WriteLine("******Chuong trinh quan ly CD******");
                Console.WriteLine("1. Them CD:");
                Console.WriteLine("2. Tinh gia trung binh:");
                Console.WriteLine("3. Sap xep CD giam dan theo gia thanh:");
                Console.WriteLine("4. Sap xep CD tang dan theo tua CD:");
                Console.WriteLine("5. Xuat toan bo CD:");
                Console.WriteLine("0. Thoat:");
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("Ban da chon:");
                chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        CD cd = new CD();
                        Console.Write("Nhap ma CD");
                        cd.MaCD = int.Parse(Console.ReadLine());
                        Console.Write("Nhap tua CD");
                        cd.TuaCD = Console.ReadLine();
                        Console.Write("Nhap ca sy");
                        cd.CaSi = Console.ReadLine();
                        Console.Write("Nhap so bai hat");
                        cd.SoBH = int.Parse(Console.ReadLine());
                        Console.Write("Nhap gia thanh");
                        cd.DonGia = int.Parse(Console.ReadLine());
                        quanLyCD.themCD(cd);
                        break;
                    case 2:
                        double kq = quanLyCD.tinhGiaTB();
                        Console.WriteLine("Gia thanh trung binh: {0:#,##0.00}", kq);
                        break;
                    case 3:
                        quanLyCD.SapXepGiamTheoGiaThanh();
                        Console.WriteLine("Da sap xep theo gia thanh giam dan");
                        break;
                    case 4:
                        quanLyCD.SapXepGiamTheoTuaCD();
                        Console.WriteLine("Da sap xep theo tua CD tang dan!");
                        break;
                    case 5:
                        quanLyCD.Xuat();
                        break;
                    case 0:
                        Console.WriteLine("Tam biet. Hen gap lai");
                        Console.ReadLine();
                        break;
                }
            } while (chon != 0);
        }
    }
}
