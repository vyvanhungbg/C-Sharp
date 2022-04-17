using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VyVanHung_2019601093_proj62
{
    
    class Program
    {
        static List<Vehicles> list = new List<Vehicles>();
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            do
            {
                Console.WriteLine("1.Nhập dữ liệu");
                Console.WriteLine("2.Hiển thị dữ liệu");
                Console.WriteLine("3.Tìm kiếm theo id");
                Console.WriteLine("4.Tìm kiếm theo maker");
                Console.WriteLine("5.Sắp xếp theo price");
                Console.WriteLine("6.Sắp xếp theo year");
                Console.WriteLine("7.Kết thúc");

                int choose = CustomInput.nextInt("--Nhập lựa chọn : ");
                switch (choose)
                {
                    case 1: NhapDuLieu(); break;
                    case 2: HienThiDuLieu(); break;
                    case 3: TimKiemTheoID(); break;
                    case 4: TimKiemTheoMaker();  break; 
                    case 5: SapXepTheoPrice(); break; 
                    case 6: SapXepTheoYear(); break; 
                    case 7: return; break;
                }
            } while (true);
        }

        private static void TimKiemTheoID()
        {
            string id = CustomInput.nextLine("Nhập id cần tìm kiếm : ");
            Vehicles vehicles = list.Find(item => item.Id == id);
            if (vehicles == null)
            {
                Console.WriteLine("Không tìm thấy dữ liệu nào với id = " + id);
                return;
            }
            else if (vehicles is Car)
            {
                Car.Header();
                Car car = (Car)vehicles;
                car.Output();
            }
            else if (vehicles is Trunk)
            {
                Trunk.Header();
                Trunk trunk = (Trunk)vehicles;
                trunk.Output();
            }
                
            
        }

        private static void SapXepTheoYear()
        {
            list.Sort(new SortByYear());
            Console.WriteLine("Đã sắp xếp theo year");
        }

        private static void SapXepTheoPrice()
        {
        
            list.Sort(new SortByPrice());
            Console.WriteLine("Đã sắp xếp theo price");
        }
        
        private class SortByPrice : IComparer<Vehicles>
        { 
            public int Compare(Vehicles x, Vehicles y)
            {
                return x.Price.CompareTo(y.Price);
            }

           /* int IComparer<Vehicles>.Compare(Vehicles x, Vehicles y)
            {
                throw new NotImplementedException();
            }*/
        }

        private class SortByYear : IComparer<Vehicles>
        {
            public int Compare(Vehicles x, Vehicles y)
            {
                return x.Year.CompareTo(y.Year);
            }

            /* int IComparer<Vehicles>.Compare(Vehicles x, Vehicles y)
             {
                 throw new NotImplementedException();
             }*/
        }

        private static void TimKiemTheoMaker()
        {
            bool oke = false;
            string maker = CustomInput.nextLine("Nhập hãng sản xuất cần tìm kiếm ");
            foreach (Vehicles item in list)
            {
                if ((item.Maker).Equals(maker))
                {
                    if (oke == false)
                    {
                        Console.WriteLine("Tìm thấy Car và Trunk với hãng sản xuất : " + maker);
                        oke = true;
                    } 
                    if (item is Car)
                        Car.Header();
                    else if (item is Trunk)
                        Trunk.Header();
                    item.Output();
                }
            }
            if (oke == false) Console.WriteLine("Không tìm thấy Car và Trunk nào với hãng sản  xuất : "+maker);
        }

     

        private static void HienThiDuLieu()
        {
            foreach(Vehicles vehicles in list)
            {
                if (vehicles is Car)
                {
                    Car.Header();
                    Car car = (Car)vehicles;
                    car.Output();
                }
                else if (vehicles is Trunk)
                {
                    Trunk.Header();
                    Trunk trunk = (Trunk)vehicles;
                    trunk.Output();
                }
            }
        }

        private static void NhapDuLieu()
        {
            Console.WriteLine("Nhập 3 xe ô tô : ");
            for (int i = 0; i < 1; i++)
            {
                Car car = new Car();
                car.Input();
                list.Add(car);
            }
            Console.WriteLine("Nhập 3 xe ô tải : ");
            for (int i = 0; i < 1; i++)
            {
                Trunk trunk = new Trunk();
                trunk.Input();
                list.Add(trunk);
            }

        }
    }
}
