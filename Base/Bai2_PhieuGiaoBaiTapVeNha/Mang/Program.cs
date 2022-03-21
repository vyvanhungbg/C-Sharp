using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mang
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập số lượng phần tử của mảng !");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            for(int i = 0; i < n; i++)
            {
                arr[i]= int.Parse(Console.ReadLine());
            }

           
            int max = arr[0], min = arr[0];
            
            for (int i = 0; i < n; i++)
            {
                if (arr[i] < min) min = arr[i];
                if (arr[i] > max) max = arr[i];
            }
            Console.WriteLine("Số lớn nhất là : "+max);
            Console.WriteLine("Số bé nhất là : "+min);
        }
    }
}
