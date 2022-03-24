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
            string str = Console.ReadLine();
            string reStr = new string(str.Reverse().ToArray());
            Console.WriteLine(str.Equals(reStr) && str.Length>0 ? "Đối xứng " : "Không đối xứng");
        }

    }
}
