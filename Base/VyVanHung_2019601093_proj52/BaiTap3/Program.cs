using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap3
{
    class Program
    {
        static List<TimUSCLN> list = new List<TimUSCLN>();
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            
            
            Input();
            Output();


            
        }

        public static void Input()
        {
            Console.WriteLine("Nhập số lượng mảng");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                TimUSCLN timUSCLN = new TimUSCLN();
                timUSCLN.Input();
                list.Add(timUSCLN);
            }
        }

        public static void Output()
        {
            TimUSCLN.Header();
            foreach (TimUSCLN item in list)
            {
                item.Output();
            }
        }

       
    }
}
