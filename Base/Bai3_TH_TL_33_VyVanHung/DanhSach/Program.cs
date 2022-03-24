using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanhSach
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            List<float> list = new List<float>();
            for (int i = 0; i < 5; i++)
            {
                list.Add(nhap("Nhập phần tử thứ "+(i+1)+" : "));
            }
            list.Sort();
            xuat(list);
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] < 0)
                    list.RemoveAt(i--);
            }
            xuat(list);
            float x = nhap("\nNhập x : ");
            for (int i = 0; i < list.Count; i++)
            {
                if(list[i] > x)
                {
                    list.Insert(i, x);
                    break;
                }
            }

            xuat(list);

        }

        static void xuat(List<float> list)
        {
            Console.WriteLine();
            foreach (var item in list)
            {
                Console.Write(item +" ");
            }
        }

        static float nhap(string mess)
        {

            float n = 0;
            bool oke = false;
            do
            {
                try
                {
                    Console.Write(mess);
                    n = float.Parse(Console.ReadLine());
                    oke = true;
                    
                }
                catch (Exception e)
                {
                    Console.WriteLine("Vui lòng nhập n là một chữ số !");
                }
            } while ( oke == false);

            return n;
        }
    }
}
