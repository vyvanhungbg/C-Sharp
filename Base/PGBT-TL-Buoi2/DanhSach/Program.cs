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
            int n = 5;
            List<int> chan = new List<int>();
            List<int> le = new List<int>();
            List<int> snt = new List<int>();
            for(int i = 0; i < n; i++)
            {
                int tmp = int.Parse(Console.ReadLine());
                if (tmp % 2 == 0)
                    chan.Add(tmp);
                else
                    le.Add(tmp);
                if (SNT(tmp))
                    snt.Add(tmp);
            }
            Console.Write(" Số chẵn là : ");
            xuat(chan);
            Console.Write(" Số lẻ là   : ");
            xuat(le);
            Console.Write(" Số nt là   : ");
            xuat(le);
        }

        static void xuat(List<int> list)
        {
            foreach(int item in list)
                Console.Write(item + " ");
            Console.WriteLine();
        }

        static bool SNT(int n)
        {
            for (int i = 2; i * i <= n; i++)
                if (n % i == 0)
                    return false;
            return n > 1;
        }
    }
}
