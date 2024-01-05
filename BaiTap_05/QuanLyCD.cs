using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap_05
{
    class QuanLyCD
    {
        private CD[] ds;
        private int n;
        public QuanLyCD()
        {
            ds = new CD[100];
            n = 0;
        }
        public QuanLyCD(int sophantu)
        {
            ds = new CD[sophantu];
            n = 0;
        }
        public void themCD(CD cd)
        {
            if (n >= ds.Length)
            {
                Console.WriteLine("Danh sach da day.");
            }
            else
            {
                if (!KiemTraTrungCD(cd.MaCD))
                    ds[n++] = cd;
                else
                {
                    Console.WriteLine("Trung ma CD:");
                }
            }
        }
        private bool KiemTraTrungCD(int Macd)
        {
            for (int i = 0; i < n; i++)
            {
                if(ds[i].MaCD == Macd)
                {
                    return true;
                }
            }
            return false;
        } 
         public double tinhGiaTB()
         {
            int tonggia = 0;
            for(int i = 0; i<n; i++)
            {
                tonggia += ds[i].DonGia;
            }
            return (double)tonggia / n;
         }
        public void Xuat()
        {
            Console.WriteLine("{0,10}", "{1,30}", "{2,30}", "{3,10}", "{4,15}",
                "MaCD", "Tua CD", "Ca si", "So bai hat", "Don thanh");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(ds[i].Tostring()); 
            }
        }
        public void SapXepGiamTheoGiaThanh()
        {
            CD Tam;
            for (int i=0; i< n - 1; i++)
            {
                for( int j= i + 1; j < n; j++)
                {
                    if (ds[i].DonGia < ds[j].DonGia)
                    {
                        Tam = ds[i];
                        ds[j] = ds[j];
                        ds[j] = Tam;                         
                    }                     
                }
            }                      
        }
        public void SapXepGiamTheoTuaCD()
        {
            CD Tam;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (ds[i].TuaCD.CompareTo(ds[j].TuaCD)>0)
                    {
                        Tam = ds[i];
                        ds[j] = ds[j];
                        ds[j] = Tam;
                    }
                }
            }
        }
    }
}
