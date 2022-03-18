using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeCoSo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Convert10ToB(15, 8);
            Console.WriteLine();
            ConvertBTo10(17,8);
            Console.WriteLine();
        }

        /// <summary>
        ///  Hàm chuyển đổi từ số N cơ số 10 sang hệ cơ số b khuyến kích b <16
        /// </summary>
        /// <param name="n">Số N</param>
        /// <param name="b">Hệ cơ số</param>
        static void Convert10ToB(int n,int b)  /// Doi sang he nhi phan so nguyen duong n
        {
            if (n ==0) return;
            else
            {
                Convert10ToB(n / b,b);
                Console.Write(ConvertIntToString(n % b));
            }
        }

        static String ConvertIntToString(int n)
        {
            if (n == 10) return "A";
            else
            if (n == 11) return "B";
            else
            if (n == 12) return "C";
            else
            if (n == 13) return "D";
            else
            if (n == 14) return "E";
            else
            if (n == 15) return "F";
            else
                return n.ToString();
        }

        static int ConvertStringToInt(String n)
        {
            if (n == "A") return 10;
            else
            if (n == "B") return 11;
            else
            if (n == "C") return 12;
            else
            if (n == "D") return 13;
            else
            if (n == "E") return 14;
            else
            if (n == "F") return 15;
            else
                return int.Parse(n);
        }

        static bool checkInput(int n, int b)
        {
            while (n != 0)
            {
                if(n %10 >= b)
                {
                    return false;
                }
                n /= 10;
            }
            return true;
        }

        static void ConvertBTo10(int n,int b)
        {
            if (!checkInput(n,b))
            {
                Console.WriteLine("Số "+n+ "  không phù hợp với cơ số "+b+" nên không thể chuyển đổi !");
                return;
            }
            List<int> list = new List<int>();
            String myString = n.ToString();
            for(int i = 0; i < myString.Length; i++)
            {
                list.Insert(0,ConvertStringToInt( myString[i].ToString() ));
            }
            /* foreach(int item in list)
                 Console.Write(item + " ");*/
            int res = 0;
           for(int i = 0; i < list.Count; i++)
            {
                res += (int)Math.Pow(b, i)*list.ElementAt(i);
            }
            Console.WriteLine(res);
        }
    }

   
}
