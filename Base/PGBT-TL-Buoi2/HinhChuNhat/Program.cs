using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HinhChuNhat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            HCN();
        }
        static void HCN()
        {
             double dai= 0, rong=0;
            nhapCanh(ref dai, ref rong);
            Console.WriteLine("Chu vi hình chữ nhật là : "+ ((dai+rong)*2));
            Console.WriteLine("Diện tích hình chữ nhật là : "+ (dai*rong));
        }
         static void nhapCanh(ref double dai, ref double rong)
        {
            bool oke = false;
            do
            {

                try
                {
                    Console.WriteLine("Nhập chiều dài hình chữ nhật : ");
                    dai = Double.Parse(Console.ReadLine());
                    Console.WriteLine("Nhập chiều rộng hình chữ nhật : ");
                    rong = Double.Parse(Console.ReadLine());
                    if (dai < rong)
                    {
                        Console.WriteLine("Chiều dài phải lớn hơn chiều rộng ! Nhập lại");

                    }
                    else
                    {
                        oke = true;
                    }
                    
                }
                catch(Exception e)
                {
                    Console.WriteLine("Vui lòng nhập chiều dài , rộng của hình chữ nhật là các chữ số !");

                }
            } while (dai < rong || oke == false);
        }
    }
}
