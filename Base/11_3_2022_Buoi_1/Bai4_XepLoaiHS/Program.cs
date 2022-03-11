using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4_XepLoaiHS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            String name;
            float score;
            Console.WriteLine("Nhập tên :");
            name = Console.ReadLine();
            Console.WriteLine( "Nhập điểm : ");
            score = Int32.Parse(Console.ReadLine());
            output(name, score);

        }
        static void output(String name, float score)
        {
            String mName = name.ToUpper();
            String rank = "Yếu";
            if(score >10 || score < 0)
            {
                Console.WriteLine("Điểm không hợp lệ !");
                return;
            }
            if (score >= 8)
                rank = "Giỏi";
            else if (score >= 6.5)
                rank = "Khá";
            else if (score >= 5)
                rank = "Trung bình";
            Console.WriteLine("Tên : "+mName);
            Console.WriteLine("XL  : "+rank);
        }
    }
}
