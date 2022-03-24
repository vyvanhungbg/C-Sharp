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
           
            int n = nhap("Nhập số lượng phần tử của mảng ! : ");
            int[] arr = new int[n];
            int tong = 0;
            for (int i = 0; i < n; i++)
                arr[i] = nhap("");
            for (int i = 0; i < arr.Length; i++)
               if(arr[i] %2 != 0)
                    tong += arr[i];
            Console.WriteLine("Tổng các số lẻ trong mảng là : "+tong);

        }

        static int nhap(string mess)
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

                }
                catch (Exception e)
                {
                    Console.WriteLine("Vui lòng nhập n là một chữ số !");
                }
            } while (oke == false);

            return n;
        }
    }
}
