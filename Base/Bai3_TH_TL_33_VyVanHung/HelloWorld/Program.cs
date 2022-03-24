using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Hãy nhập vào 2 số");
            int a = nhap("a = ");
            int b = nhap("b = ");
            Console.WriteLine(a + " + " + b +" = "+(a+b));
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
            } while ( oke == false);

            return n;
        }
    }
}
