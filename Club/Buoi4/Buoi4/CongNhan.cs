using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi4
{
    class CongNhan : Person
    {
        private double luong;

        public CongNhan()
        {
        }

        public CongNhan(string name, int age, double luong) : base(name, age)
        {
            this.luong = luong;
        }

        public override string ToString()
        {
            return Name + " "+ Age+ +"";
        }

        public double Luong { get => luong; set => luong = value; }

        
    }
}
