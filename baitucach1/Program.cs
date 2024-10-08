using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitucach1
{
    internal class Program
    {
        //bai1 thuc hien tinh tong day sau S= 9 + 99 + 999 + 9999 +9....n
        //voi n nhap tu ban phim
        static void Tongdayso(int n)
        {
            
                int i, t = 9, sum = 0;
                n = int.Parse(Console.ReadLine());
                for (i = 0; i < n; i++)
                {
                    sum += t;
                    t = t * 10 + 9;
                }
                Console.WriteLine("\nTong day so tren la: {0}", sum);
          }
     //Bai2: Viet chuong trinh chuyen doi 1 so he nhi phan sang he thap phan. Sau khi chuyen doi sang he thap phan h*ay kiem tra xem so do co
     //phai so nguyen to hay khong? Co phai la so hoan hao hay khong?
        static bool sohoanhao(int n)
        {
            int s = 0;
            for (int i = 0; i <= n / 2; i++) 
            if (n % i == 0)
                {
                    s += i;
                }
            return n == s;
        }
        static bool songuyento(int n)
        {
            for (int i = 2; i <= n / 2; i++)
                if (n % i == 0) return false;
            return true;
        }
        static void Main()
        {
            int n, s = 0, t = 1;
            Console.Write("Nhap so n o he nhi phan: ");
            n=int.Parse(Console.ReadLine());   
            while(n>0)
            {
                int i = n % 10;
                s = s + t * i;
                t *= 2;
                n/= 10;
            }
            if (sohoanhao(s))
                Console.WriteLine(s + "la so hoan hao");
            else Console.WriteLine(s + "khong phai la so hoan hao");
            if (songuyento(s))
                Console.WriteLine(s + "la so nguyen to");
            else Console.WriteLine(s+"khong phai la so nguyen to");
        }




        //Bai3:Nhap vao 1 mang gom n so
        //a. in mang  vua nhap
        static void Nhap(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("a[" + i + "]=");
                a[i] = int.Parse(Console.ReadLine());

            }
        }
        static void Xuat(int[] a, int n)
        {

            for (int i = 0; i < n; i++)
                Console.Write(a[i] + " ");

        }

        //b. tim so phan tu giong nhau trong mang
        static void Ktra(int[] a, int n)
        {
            int d = 0;
            Console.Write("So phan tu giong nhau trong mang la: ");
            for (int i = 0; i < n; i++)
            {
                int dem = 0;
                for (int j = 0; j < i; j++)
                {
                    if (a[i] == a[j]) dem++;
                }
                if (dem != 0) d++;
            }
            Console.WriteLine(d);
        }


        //c. tinh tong mang theo cong thuc sau...
        static void Tong(int[] a, int n)
        {
            int t, s;
            for (int i = 0; i < n; i++)
            {
                t *= i + 1;
                s += (float)a[i] / t;

            }
            Console.WriteLine(s);
        }

        //Bai4: Nhap vao 2 mang 2 chieu. Tinh tong 2 ma tran do
        static void Main(string[] args)
        {
            int n;
            n= int.Parse(Console.ReadLine()); int[]a= new int[n];
            Nhap(a, n);
            Xuat(a, n);
            Console.ReadKey(); 
        }
    }
}
