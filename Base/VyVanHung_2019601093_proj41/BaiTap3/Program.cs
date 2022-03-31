using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap3
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("1", "Hùng", 8);
            Console.WriteLine(student.ToString());
         
        }


        class SortByMark : IComparer<Student>
        {
            public int Compare(Student x, Student y)
            {
                return x.Mark.CompareTo(y.Mark);
            }
        }
    }
}
