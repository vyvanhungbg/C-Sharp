using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VyVanHung_2019601093_proj61
{
    class Student : Person
    {
        private byte maths;
        private byte physics;

        public Student():base()
        {
        }

        public Student(int id, string name, string address, byte maths, byte physics) : base(id, name, address)
        {
            this.maths = maths;
            this.physics = physics;
        }

        public byte Maths { get => maths; set => maths = value; }
        public byte Physics { get => physics; set => physics = value; }

        public override void Input()
        {
            base.Input();
            Maths = CustomInput.nextByte("Nhập điểm toán : ");
            Physics = CustomInput.nextByte("Nhập điểm lý : ");

        }

        public override void Output()
        {
            base.Output();
            string formatTable = String.Format("{0,-15} {1,-15} {2,-15}", Maths, Physics,Total());
            Console.WriteLine(formatTable);
        }

        public  static void Header()
        {
            Person.Header();
            string formatTable = String.Format("{0,-15} {1,-15}  {2,-15}", "Maths", "Physics","Total");
            Console.WriteLine(formatTable);
        }

        public double Total()
        {
            return Maths + Physics;
        }





    }
}
