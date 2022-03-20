using System;
using System.Collections;
using System.Collections.Generic
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi4
{
    class Program
    {
        static void Main(string[] args)
        {
            CongNhan congNhan = new CongNhan();
            congNhan.Age = 32;
            Console.WriteLine(congNhan.Age);

            ArrayList name = new ArrayList();
            List<int> MyList = new List<int>();
            MyList.Add

            name.Add("Hung");
            name.Add(32);
            name.Add(new CongNhan("hung", 32, 500000));


            foreach (var item in name)
            {
               if(item is Person)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
