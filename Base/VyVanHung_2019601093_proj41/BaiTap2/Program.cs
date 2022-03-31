using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Cricle cricle = new Cricle(5);
           
            Console.WriteLine("Diện tích hình tròn bán kính = "+cricle.Radius+" là :"+cricle.Area().ToString("0.##"));
            Console.WriteLine("Chu vi    hình tròn bán kính = "+cricle.Radius+" là :"+cricle.Perimeter().ToString("0.##"));
        }
    }
}
