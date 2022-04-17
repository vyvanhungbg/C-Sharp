using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VyVanHung_2019601093_proj62
{
    class Vehicles : IVehicle
    {
        protected string id;
        protected string maker;
        protected string model;
        protected int year;
        protected double price;

        public Vehicles() 
        {
        }

        public Vehicles(string id, string maker, string model, int year, double price)
        {
            this.Id = id;
            this.Maker = maker;
            this.Model = model;
            this.Year = year;
            this.Price = price;
        }

        public string Id { get => id; set => id = value; }
        public string Maker { get => maker; set => maker = value; }
        public string Model { get => model; set => model = value; }
        public int Year { get => year; set => year = value; }
        public double Price { get => price; set => price = value; }

        public virtual void Input()
        {
            Id = CustomInput.nextLine("Nhập ID : ");
            Maker = CustomInput.nextLine("Nhập hãng sản xuất : ");
            Model = CustomInput.nextLine("Nhập tên xe : ");
            Year = CustomInput.nextInt("Nhập năm sx : ");
            Price = CustomInput.nextDouble("Nhập giá tiền : ");
        }

         public virtual void Output()
        {
            String formatTable = String.Format("{0,-10} {1,-20} {2,-20} {3, -10} {4, -20:0.0} ",
               Id,Maker,Model,Year,Price);
            Console.Write(formatTable);
        }

        public static void Header()
        {
            String formatTable = String.Format("{0,-10} {1,-20} {2,-20} {3, -10} {4, -20:0.0} ",
               "Id", "Maker", "Model", "Year", "Price");
            Console.Write(formatTable);
        }
        // override object.Equals
        public override bool Equals(object obj)
        {
            Vehicles myObj = (Vehicles)obj;
            if (this.Id.Equals(myObj.Id))
            {
                return true;
            }
            return false;
           
        }

        public override string ToString()
        {
            return  String.Format("{0,-10} {1,-20} {2,-20} {3, -10} {4, -20:0.0} \n",
               "Id", "Maker", "Model", "Year", "Price"); ;
        }

        
    }
}
