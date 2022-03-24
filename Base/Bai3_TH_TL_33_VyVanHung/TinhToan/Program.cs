using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhToan
{
    class Program
    {
        static void Main(string[] args)
        {
            float a = nhap("");
            float b = nhap("");
            string str = Console.ReadLine();
            try
            {
                char myChar = char.Parse(str);
                switch (myChar)
                {
                    case '+':
                        Console.WriteLine(a + " + " + b + " = " + (a + b));
                        break;
                    case '-':
                        Console.WriteLine(a + " - " + b + " = " + (a - b));
                        break;
                    case '/':
                        Console.WriteLine(a + " / " + b + " = " + (a / b));
                        break;
                    case '*':
                        Console.WriteLine(a + " * " + b + " = " + (a * b));
                        break;
                    default:
                        break;

                }
            }
            catch
            {
                return;
            }
            
           

        }

        static float nhap(string mess)
        {

            float n = 0f;
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
            } while (oke == false);

            return n;
        }
    }
}
