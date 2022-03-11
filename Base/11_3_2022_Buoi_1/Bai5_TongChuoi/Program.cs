using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5_TongChuoi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("Nhập n : ");
            int n = int.Parse(Console.ReadLine());
            if (n <=0)
                Console.WriteLine("n không hợp lệ !");
            else
            {
                Console.WriteLine("S = 1+2+3+..+n  = " + Sum(n));
                Console.WriteLine("S = 1+1/2+1/3+..+1/n = " + Sum2(n));
            }
        }
        static int Sum(int n)
        {
            if (n == 1)
                return 1;
            else
                return n + Sum(n - 1);
        }

        static float Sum2(int n)
        {
            float mSum = 0;
            for (int i = 1; i <= n; i++)
                mSum += (1 / (1.0f*i));
            return mSum;
        }
    }
}
