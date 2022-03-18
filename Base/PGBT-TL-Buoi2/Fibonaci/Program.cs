using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonaci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            nhap();
        }

        static void nhap()
        {
            int n = 0;
            bool oke = false;
            do
            {
                try
                {
                    Console.WriteLine("Nhập n :");
                    n = int.Parse(Console.ReadLine());
                    oke = true;
                    if(n < 1)
                    {
                        Console.WriteLine(" n phải là một số nguyên dương ! ");
                    }
                }catch(Exception e)
                {
                    Console.WriteLine("Vui lòng nhập n là một chữ số !");
                }
            } while (n < 1 || oke == false);
            for(int i = 1; i <= n;i++)
            {
                Console.Write(fibonaci(i) + " ");
            }
        }

        static int fibonaci(int n)
        {
            int soTruoc = 1, soTruocNua = 0, soHienTai = 1;
            if (n == 1)return soTruocNua;
            if (n == 2) return soTruoc;
            if (n == 3) return soHienTai;
            for(int i = 1; i < n-1; i++)
            {
                soHienTai = soTruoc + soTruocNua;
                soTruocNua = soTruoc;
                soTruoc = soHienTai;
            }
            return soHienTai;
        }
    }
}
