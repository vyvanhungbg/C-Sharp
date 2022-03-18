using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap4
{
    class Program
    {
        static void Main(string[] args)
        {
            nhap();
        }

        static void nhap()
        {
            Console.OutputEncoding = Encoding.UTF8;
            int n = 0;
            bool oke = false;
            do
            {
                try
                {
                    Console.WriteLine("Nhập n :");
                    n = int.Parse(Console.ReadLine());
                    oke = true;
                    if (n < 1)
                    {
                        Console.WriteLine(" n phải là một số nguyên dương ! ");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Vui lòng nhập n là một chữ số !");
                }
            } while (n < 1 || oke == false);
            Console.WriteLine(" Day fibo là : ");
            for (int i = 1; i <= n; i++)
            {
                Console.Write(fibonaci(i) + " ");
            }
            Console.WriteLine();
            Console.WriteLine(n+" ! = "+GiaiThua(n));
        }

        static int fibonaci(int n)
        {
            if (n == 1 ) return 0;
            if (n == 2) return 1;
            return fibonaci(n - 1) + fibonaci(n - 2);
        }

        static int  GiaiThua(int n)
        {
            if (n == 0 || n == 1) return 1;
            return n * GiaiThua(n - 1);
        }
    }
}
