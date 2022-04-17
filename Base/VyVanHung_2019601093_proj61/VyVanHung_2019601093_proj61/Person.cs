using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VyVanHung_2019601093_proj61
{
    class Person
    {
        private int id;
        private string name;
        private string address;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }

        public Person()
        {
        }

        public Person(int id, string name, string address)
        {
            this.Id = id;
            this.Name = name;
            this.Address = address;
        }



        public virtual void Input()
        {
            Id = CustomInput.nextInt("Nhập ID : ");
            Name = CustomInput.nextLine("Nhập tên : ");
            Address = CustomInput.nextLine("Nhập địa chỉ : ");

        }
        public virtual void Output()
        {
            string formatTable = String.Format("{0,-15} {1,-15} {2,-15}",Id,Name,Address);
            Console.Write(formatTable);
        }

        public static void Header()
        {
            string formatTable = String.Format("{0,-15} {1,-15} {2,-15}", "Id", " Name", "Address");
            Console.Write(formatTable);
        }
    }
}
