using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VyVanHUng_2019601093_proj63
{
    class Student
    {
        private int studentid;
        private string name;
        private string mark;

        public int Studentid { get => studentid; set => studentid = value; }
        public string Name { get => name; set => name = value; }
        public string Mark { get => mark; set => mark = value; }

        public override string ToString()
        {
            String formatTable = String.Format("{0,-15} {1,-15} {2,-15}", Studentid, Name, Mark);
            return formatTable;

        }

        public static void Header()
        {
            String formatTable = String.Format("{0,-15} {1,-15} {2,-15}", "studentid", "name", "mark");
            Console.WriteLine(formatTable);

        }
        public void InputStudent()
        {
            Console.WriteLine("Nhập  student id : ");
            Studentid = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập  student name : ");
            Name = Console.ReadLine();
            Console.WriteLine("Nhập  studnet mark : ");
            Mark = Console.ReadLine();
        }
    }
}
