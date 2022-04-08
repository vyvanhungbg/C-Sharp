using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap1
{
    class Employee
    {
        private string id;
        private string name;
        private int age;
        private int workingdays;
        private static int PRICE = 50;

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public int Workingdays { get => workingdays; set => workingdays = value; }
        public double Salary(){return Workingdays * PRICE;}

        public void Input()
        {
            Id = nextLine("Nhập Id : ");
            Name = nextLine("Nhập họ tên : ");
            Age = int.Parse(nextLine("Nhập tuổi : "));
            Workingdays = int.Parse(nextLine("Nhập số ngày công : "));
        }

        public string nextLine(string mess)
        {
            Console.WriteLine(mess);
            return Console.ReadLine();
        }

        public void Output()
        {
            string formatTable = String.Format("{0,-12} {1,-12} {2,-12} {3,-18} {4,-12:0.00}",
                Id,Name,Age,Workingdays,Salary());
            Console.WriteLine(formatTable);
        }

        public static void Header()
        {
            string formatTable = String.Format("{0,-12} {1,-12} {2,-12} {3,-18} {4,-12}",
                "Id", "Name", "Age", " Workingdays", "Salary");
            Console.WriteLine(formatTable);
        }
    }
}
