using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuoi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập chuỗi : ");
            string str = Console.ReadLine();

            for (int i = 0; i < str.Length; i++)
            {
                Console.WriteLine(str[i]);
            }

            Console.WriteLine("Phần 2\n");
            string[] myStr = str.Split(' ');
            for (int i = 0; i < myStr.Length; i++)
            {
                Console.WriteLine(myStr[i]);
            }
            Console.WriteLine("Phần 3\n");
            countCharacter(str);
        }

        static void countCharacter(string str)
        {
            int[] count = new int[256];
            for (int i = 0; i < str.Length; i++)
                count[(int)str[i]]++;
            for (int i = 0; i < count.Length; i++)
            {
                if (count[i]>0)
                    Console.WriteLine((char) i + " - "+count[i]);
            }
        }
    }
}
