using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap2
{
    class Cricle
    {
        private double radius;

        public double Radius { get => radius; set => radius = value; }

        public Cricle(double radius)
        {
            this.Radius = radius;
        }

        public Cricle()
        {
        }

        public double Area()
        {
            return (this.Radius) * (this.Radius) * Math.PI;
        }

        public double Perimeter() { return 2 * Math.PI * this.Radius; }
    }
}
