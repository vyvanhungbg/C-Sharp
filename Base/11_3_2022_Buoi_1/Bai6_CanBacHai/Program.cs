using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai6_CanBacHai
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("nhập số a :");
           
            double myNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập epsilon , thường là 0.0000001:");
            double epsilon = double.Parse(Console.ReadLine());
            if (myNumber < 0 || epsilon<0)
                Console.WriteLine("số a, epsilon không hợp lệ , a,epsilon >=0");
            else
                Console.WriteLine(mySqrt(myNumber, epsilon));
        }

        static double mySqrt(double a,double epsilon)
        {
            if (a == 0)
                return 0;
            double x_0 = 1;
            double xN = (a / x_0 + x_0) / 2;
            do
            {
                xN = (a / xN + xN) / 2;
            } while (Math.Abs(( (a / xN + xN) / 2) - xN) > epsilon );
            return xN;
        }

    }
}
