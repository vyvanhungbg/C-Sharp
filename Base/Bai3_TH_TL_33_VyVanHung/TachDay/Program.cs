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
           
            int[] arr = nhap();
          
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

        static int[] nhap()
        {
            List<int> myList = new List<int>();
            bool oke = false;
            do
            {
                try
                {
                    Console.WriteLine("Nhập mảng :");
                    string[] str = Console.ReadLine().Split();
                    for (int i = 0; i < str.Length; i++)
                    {
                        myList.Add(int.Parse(str[i]));
                    }
                    oke = true;


                }
                catch (Exception e)
                {
                    Console.WriteLine("Vui lòng nhập n là một chữ số !"+e.Message);
                }
            } while (oke == false);

            return myList.ToArray();
        }
    }
}
