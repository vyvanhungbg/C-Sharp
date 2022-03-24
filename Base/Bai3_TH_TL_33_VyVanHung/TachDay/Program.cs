using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TachDay
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int n = nhap("");
            int[] arr = new int[n];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = nhap("");
            }
            xuat(arr, true);
            xuat(arr, false);
            
        }

        static void xuat(int [] a , bool isEven)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if((a[i] %2 == 0) == isEven)
                    Console.Write(a[i]+" ");
            }
            Console.WriteLine();
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
                  
                    string str = Console.ReadLine();
                    n = int.Parse(str);
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
