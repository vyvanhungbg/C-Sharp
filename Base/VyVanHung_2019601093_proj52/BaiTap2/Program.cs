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
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            GiaiPhuongTrinhBac2 ptb2 = new GiaiPhuongTrinhBac2(2,3,-5);
            ptb2.Xuat();
        }
    }
}
