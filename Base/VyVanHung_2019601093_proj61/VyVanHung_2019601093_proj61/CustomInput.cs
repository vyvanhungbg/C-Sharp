using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VyVanHung_2019601093_proj61
{
    class CustomInput
    {

        public static string nextLine(string mess)
        {
            Console.WriteLine(mess);
            return Console.ReadLine();
        }

        public static byte  nextByte(string mess)
        {
            Console.WriteLine(mess);
            return byte.Parse(Console.ReadLine());
        }

        public static int nextInt(string mess)
        {
            Console.WriteLine(mess);
            return int.Parse(Console.ReadLine());
        }
    }
}
