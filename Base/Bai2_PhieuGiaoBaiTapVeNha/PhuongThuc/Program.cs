using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhuongThuc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int n = 10;
            int[] arr = new int[n];
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                arr[i] = random.Next(100);
            }
            Console.Write("\n Số nguyên tố có trong mảng là : ");
            for (int i = 0; i < n; i++)
            {
                if(SNT(arr[i]))
                    Console.Write(arr[i] + " ");
            }
            
        }

        static bool SNT(int n)
        {
            for (int i = 2; i*i <=n; i++)
                if (n % i == 0) return false;
            return n > 2;
        }
    }
}
