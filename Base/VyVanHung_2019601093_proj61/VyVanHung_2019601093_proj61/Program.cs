using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VyVanHung_2019601093_proj61
{
    class Program
    {
        static List<Student> list = new List<Student>();
        static void Main(string[] args)
        {

            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            do
            {
                Console.WriteLine("\n1. Thêm sinh viên");
                Console.WriteLine("2. Hiển thị danh sách các sinh viên");
                Console.WriteLine("3. Tìm kiếm sinh viên theo ID");
                Console.WriteLine("4. Tìm kiếm sinh viên theo address");
                Console.WriteLine("5. Xóa một sinh viên theo ID");
                
                Console.WriteLine("6. Thoát.");
                int choose = CustomInput.nextInt("Nhập lựa chọn : [1:6] ");

                switch (choose)
                {
                    case 1: ThemSinhVien();break;
                    case 2: HienThiDanhSach();break;
                    case 3: TimKiemSinhVienTheoID();break;
                    case 4: TimKiemSinhVienTheoDiaChi();break;
                    case 5: XoaSinhVienTheoID();break;
                    case 6: return;break;
                     
                }

            } while (true);
        }

        private static void XoaSinhVienTheoID()
        {
            int id = CustomInput.nextInt("Nhập id sinh viên cần xóa : ");
            foreach (Student item in list)
            {
                if (item.Id == id)
                {
                    list.Remove(item);
                    Console.WriteLine("\nXóa thành công sinh viên có mã id =  " + id);
                    return;
                }
            }
            Console.WriteLine("\n Không tìm thấy sinh viên nào với mã id =" + id);
        }

        private static void TimKiemSinhVienTheoDiaChi()
        {
            string address = CustomInput.nextLine("Nhập địa chỉ sinh viên cần tìm kiếm : ");

            Console.WriteLine("\nDanh sách  sinh viên với địa chỉ tại  " +address + " là : ");
            Student.Header();
            foreach (Student item in list)
            {
                if (item.Address.Contains(address))
                {
                    item.Output();                 
                }
            }
            
        }

        private static void TimKiemSinhVienTheoID()
        {
            int id = CustomInput.nextInt("Nhập id sinh viên cần tìm kiếm : ");
            foreach (Student item in list)
            {
                if(item.Id == id)
                {
                    Console.WriteLine("\nTìm thấy sinh viên với mã id = "+id);
                    Student.Header();
                    item.Output();
                    return;
                }
            }
            Console.WriteLine("\n Không tìm thấy sinh viên nào với mã id ="+id);
            
        }

        private static void HienThiDanhSach()
        {
            Student.Header();
            foreach (Student item in list)
            {
                item.Output();
            }
        }

        private static void ThemSinhVien()
        {
            Console.WriteLine("Nhập sinh viên mới : ");
            Student student = new Student();
            student.Input();
            list.Add(student);
            Console.WriteLine("\n Thêm sinh viên mới thành công \n !");
        }
    }
}
