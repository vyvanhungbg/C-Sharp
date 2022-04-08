using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap2
{
    class GiaiPhuongTrinhBac2
    {
        private int a;
        private int b;
        private int c;

        public GiaiPhuongTrinhBac2(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public GiaiPhuongTrinhBac2()
        {
        }


        public int A { get => a; set => a = value; }
        public int B { get => b; set => b = value; }
        public int C { get => c; set => c = value; }

        public double delta()
        {
            return b*b-4*a*c;
        }

        public double result_1()
        {
            if (delta() >= 0)
            {
                return (-b + Math.Sqrt(delta())) / (2 * a);
            }
            throw new Exception("Phương trình vô nghiệm");
        }

        public double result_2()
        {
            if (delta() >= 0)
            {
                return (-b - Math.Sqrt(delta())) / (2 * a);
            }
            throw new Exception("Phương trình vô nghiệm");
        }
        public void Input()
        {
            A = int.Parse(nextLine("Nhập a : "));
            B = int.Parse(nextLine("Nhập b : "));
            C = int.Parse(nextLine("Nhập c : "));
        }

        public void Xuat()
        {
            Console.WriteLine("Phương trình "+a+"x^2 + ("+b+")x + ("+c+") = 0");
            try
            {
                Console.WriteLine("Có nghiệm thứ nhất l là : " + result_1());
                Console.WriteLine("Có nghiệm thứ nhất 2 là : " + result_2());
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public string nextLine(string mess)
        {
            Console.WriteLine(mess);
            return Console.ReadLine();
        }
    }

}
