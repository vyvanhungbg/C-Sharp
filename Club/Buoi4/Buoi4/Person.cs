using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi4
{
    class Person
    {
        private string name;
        private int age;


        // tạo setter getter // Bấm ctrl + R+E 
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }


        // bôi đen các thuộc tính bấm ctr + .
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public override string ToString()
        {
            return base.ToString();
        }




        //ctor +  tab
        public Person()
        {

        }

    }
}
