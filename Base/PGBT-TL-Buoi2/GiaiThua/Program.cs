using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiaiThua
{
    class Program
    {
        static void Main(string[] args)
        {
            nhap();
        }

        static int GiaiThua(int n)
        {
            int res = 1;
            if (n == 0 || n == 1) return 1;
            for (int i = 1; i <= n; i++)
                res *= i;
            return res;
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
            Console.WriteLine(n+ "! : = "+ GiaiThua(n));
        }

    }
}
