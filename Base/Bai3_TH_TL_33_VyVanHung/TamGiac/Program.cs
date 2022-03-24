using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TamGiac
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int a=0, b=0, c=0;
            nhap(ref a, ref b, ref c);
            Console.WriteLine("Chu vi tam giác là : " + ChuViTamGiac(a, b, c));
            Console.WriteLine("Diện tích tam giác là : " + DienTichTamGiac(a, b, c));
        }

        static bool TamGiac(int a, int b, int c)
        {
            if (a + b <= c || a + c <= b || b + c <= a || a < 0 || b < 0 || c < 0)
                return false;
            return true;
        }

        static void nhap(ref int a, ref int b, ref int c)
        {

            
            bool oke = false;
            do
            {
                try
                {
                    Console.Write("Nhập a = ");
                    a = int.Parse(Console.ReadLine());
                    Console.Write("Nhập b = ");
                    b = int.Parse(Console.ReadLine());
                    Console.Write("Nhập c = ");
                    c = int.Parse(Console.ReadLine());
                    oke = true;
                    if (!TamGiac(a,b,c))
                    {
                        Console.WriteLine("Vui lòng nhập 3 cạnh của một tam giác : ");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Vui lòng nhập n là một chữ số !");
                }
            } while ( oke == false || !TamGiac(a,b,c));

           
        }

        static float ChuViTamGiac(float a, float b, float c)
        {
            return a + b + c;
        }
        static float DienTichTamGiac(float a, float b, float c)
        {
            float nuaChuVi = ChuViTamGiac(a, b, c) / 2;
            return (float)Math.Sqrt(nuaChuVi * (nuaChuVi - a) * (nuaChuVi - b) * (nuaChuVi - c));
        }
    }
}
