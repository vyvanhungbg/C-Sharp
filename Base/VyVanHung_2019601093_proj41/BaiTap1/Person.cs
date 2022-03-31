using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap1
{
    class Person
    {
        private string id;
        private string name;
        private int age;
        private string email;
        private string address;

        public Person()
        {
        }

        public Person(string id, string name, int age, string email, string address)
        {
            this.Id = id;
            this.Name = name;
            this.Age = age;
            this.Email = email;
            this.Address = address;
        }

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public string Email { get => email; set => email = value; }
        public string Address { get => address; set => address = value; }

        public void CheckAge() { Console.WriteLine(this.age >= 18 ? "Bạn đủ tuổi bầu cử" : "Bạn còn nhỏ"); }
    
        public void Input()
        {
            Console.WriteLine("Nhập id : ");
            this.Id = Console.ReadLine();
            Console.WriteLine("Nhập tên : ");
            this.Name = Console.ReadLine();
            Console.WriteLine("Nhập tuổi : ");
            this.Age = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập email : ");
            this.Email = Console.ReadLine();
            Console.WriteLine("Nhập địa chỉ : ");
            this.Address = Console.ReadLine();
        }

        public static void Header()
        {
            string formatTable = String.Format("{0,-10} {1,-20} {2,-20} {3,-20} {4,-20} \n",
                "id", "tên", "tuổi", "email", "địa chỉ" );
            Console.WriteLine(formatTable);
        }

        public void Output()
        {
            string formatTable = String.Format("{0,-10} {1,-20} {2,-20} {3,-20} {4,-20} \n",
                this.id, this.name, this.age, this.email, this.address);
            Console.WriteLine(formatTable);
        }
       
    }
}
