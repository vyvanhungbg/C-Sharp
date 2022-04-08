using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap3
{
    class TimUSCLN
    {
        private int sothu1;
        private int sothu2;

        public TimUSCLN()
        {
        }

        public TimUSCLN(int sothu1, int sothu2)
        {
            this.sothu1 = sothu1;
            this.sothu2 = sothu2;
        }

        public int Sothu1 { get => sothu1; set => sothu1 = value; }
        public int Sothu2 { get => sothu2; set => sothu2 = value; }

        /*public int UCLN(int sothu1, int sothu2)
        {
            if (sothu2 == 0) return sothu1;
            if (sothu1 % sothu2 ==0) return sothu2;
            return UCLN(sothu2, sothu1 % sothu2);
        }*/

        public int UCLN()
        {
         
            while(sothu2 != 0)
            {
                int tmp = sothu1 % sothu2;
                sothu1 = sothu2;
                sothu2 = tmp;
            }
            return sothu1;
        }

        public string nextLine(string mess)
        {
            Console.WriteLine(mess);
            return Console.ReadLine();
        }

        public void Input()
        {
            Sothu1 = int.Parse(nextLine("Nhập số thứ 1 :"));
            Sothu2 = int.Parse(nextLine("Nhập số thứ 2 :"));
        }

        public void Output()
        {
            string formatTable = String.Format("{0,-20} {1,-20} {2,-20}",Sothu1,Sothu2,UCLN());
            Console.WriteLine(formatTable);
        }

        public static void Header()
        {
            string formatTable = String.Format("{0,-20} {1,-20} {2,-20}", "Số thứ 1", "Số thứ 2", " UCLN");
            Console.WriteLine(formatTable);
        }
    }
}
