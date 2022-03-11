using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3_TamGiac
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            float a, b, c;
            Console.Write("Nhập a = ");
            a = float.Parse(Console.ReadLine());
            Console.Write("Nhập b = ");
            b = float.Parse(Console.ReadLine());
            Console.Write("Nhập c = ");
            c = float.Parse(Console.ReadLine());
            if (TamGiac(a,b,c))
            {
                Console.WriteLine("Chu vi tam giác là : " + ChuViTamGiac(a, b, c));
                Console.WriteLine("Diện tích tam giác là : " + DienTichTamGiac(a, b, c));
            }
            else
            {
                Console.WriteLine("3 cạnh không phải là tam giác !");
            }
            Console.ReadKey();
        }

        static bool TamGiac(float a, float b, float c)
        {
            if (a + b <= c || a + c <= b || b + c <= a || a < 0 || b < 0 || c < 0)
                return false;
            return true;
        }

        static float ChuViTamGiac(float a, float b, float c)
        {
            return a + b + c;
        }
        static float DienTichTamGiac(float a, float b , float c)
        {
            float  nuaChuVi= ChuViTamGiac(a,b,c)/2;
            return (float)Math.Sqrt(nuaChuVi * (nuaChuVi - a) * (nuaChuVi - b) * (nuaChuVi - c));
        }
    }
}
