using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VyVanHung_2019601093_proj62
{
    class Trunk :  Vehicles
    {
        private int trunkLoad;

        public Trunk(int trunkLoad)
        {
            this.trunkLoad = trunkLoad;
        }

        public Trunk(string id, string maker, string model, int year, double price, int trunkLoad) : base(id, maker, model, year, price)
        {
            this.trunkLoad = trunkLoad;
        }

        public int TrunkLoad { get => trunkLoad; set => trunkLoad = value; }

        public override void Input()
        {
            base.Input();
            TrunkLoad = CustomInput.nextInt("Nhập số trọng tải");
        }

        public  Trunk():base()
        {

        }

        public override void Output()
        {
            base.Output();
            String formatTable = String.Format("{0, -15} \n", TrunkLoad);
            Console.WriteLine(formatTable);
        }

        public  static void Header()
        {
            Vehicles.Header();
            String formatTable = String.Format("{0, -15} \n", "TrunkLoad");
            Console.WriteLine(formatTable);
        }
    }
}
