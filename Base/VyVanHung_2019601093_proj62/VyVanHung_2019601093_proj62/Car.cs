using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VyVanHung_2019601093_proj62
{
    class Car : Vehicles
    {
        private string color;

        public Car():base()
        {
        }

        public Car(string id, string maker, string model, int year, double price,string color) : base(id, maker, model, year, price)
        {
            this.Color = color;
        }

        public string Color { get => color; set => color = value; }

        public override void Input()
        {
            base.Input();
            Color = CustomInput.nextLine("Nhập màu sắc của ô tô : ");

        }

        public override void Output()
        {
            base.Output();
            String formatTable = String.Format("{0,-15} \n", Color);
            Console.WriteLine(formatTable);
        }

        public static void Header()
        {
            Vehicles.Header();
            String formatTable = String.Format("{0,-15} \n", "Color");
            Console.WriteLine(formatTable );
        }
    }
}
