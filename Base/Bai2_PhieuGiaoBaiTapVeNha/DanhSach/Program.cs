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
            Console.OutputEncoding = Encoding.UTF8;
            List<string> list = new List<string>();
            list.Add("Hà Nội ");
            list.Add("Hải Phòng");
            list.Add("Đà Nẵng ");
            list.Add("TPHCM");
            list.Add("Cần thơ");
            xuat(list);

            list = list.OrderBy(item => item).ToList();
            xuat(list);

            list.Remove("Bắc Giang");
            list.Add("Bắc Kạn ");
            list.Add("Hà Tĩnh");
            list.Add("Kiên Giang ");
            list.Add("Huế");
            xuat(list);
        }

        static void xuat(List<string> list)
        {
            Console.WriteLine("Xuất mảng : \n");
            foreach (var item in list) 
            {
                Console.WriteLine(item);
            }
        }
    }
}
