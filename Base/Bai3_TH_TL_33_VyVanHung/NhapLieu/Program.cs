using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhapLieu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int a = nhap1("Nhập a thuoc [1:100] : ");
            int b = nhap2("Nhập b thuoc [1:100] : ");
            Console.WriteLine("a = "+a);
            Console.WriteLine("b = "+b);
        }

        static int nhap1(string mess)
        {

            int n = 0;
            bool oke = false;
            do
            {
                try
                {
                    Console.Write(mess);
                    n = int.Parse(Console.ReadLine());
                    oke = true;
                    if(n<1 || n > 100)
                    {
                        Console.WriteLine("Nhập số trong khoảng [1:100] : ");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Vui lòng nhập n là một chữ số !");
                }
            } while ( (n < 1 || n > 100)  || oke == false);

            return n;
        }

        static int nhap2(string mess)
        {

            int n = 0;
            bool oke = false;
           
            while (n < 1 || n > 100 || oke == false) 
            {
                try
                {
                    Console.Write(mess);
                    n = int.Parse(Console.ReadLine());
                    oke = true;
                    if (n < 1 || n > 100)
                    {
                        Console.WriteLine("Nhập số trong khoảng [1:100] : ");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Vui lòng nhập n là một chữ số !");
                    oke = false;
                }
            }

            return n;
        }
    }
}
