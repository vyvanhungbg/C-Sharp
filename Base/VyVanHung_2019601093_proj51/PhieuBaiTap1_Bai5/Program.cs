using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhieuBaiTap1_Bai5
{
    class Program
    {
        static List<ThiSinhA> list = new List<ThiSinhA>();
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
          
            do
            {

                Console.WriteLine("\n1. Thêm sinh viên");
                Console.WriteLine("2. Hiển thị danh sách các sinh viên");
                Console.WriteLine("3. Hiển thị các sinh viên theo tổng điểm");
                Console.WriteLine("4. Hiển thị các sinh viên theo địa chỉ");
                Console.WriteLine("5. Tìm kiếm sinh viên theo SBD");
                Console.WriteLine("6. Thoát.");
               

                Console.WriteLine("Nhập lựa chọn [1:6] :\n ");
                int choose = int.Parse(Console.ReadLine());

                switch (choose)
                {
                    case 1: ThemSinhVien(); break;
                    case 2: HienThi();break;
                    case 3: HienThiTheoTongDiem();break;
                    case 4: HienThiSinhVienTheoDiaChi();break;
                    case 5: TimKiemTheoSoBaoDanh();break;
                    case 6: Console.WriteLine("Đã thoát !"); return;
                  
                    default:
                        Console.WriteLine("Nhập sai ! Nhập lại ");
                        break;
                }
            } while (true);
        }

        private static void TimKiemTheoSoBaoDanh()
        {
            Console.WriteLine("Nhập số báo danh sinh viên cần tìm kiếm : ");
            int soBaoDanh = int.Parse(Console.ReadLine());
            foreach (ThiSinhA item in list)
            {
                if(item.SoBaoDanh == soBaoDanh)
                {
                    Console.WriteLine("Tìm thấy sinh viên với SBD "+soBaoDanh);
                    ThiSinhA.Header();
                    item.xuat();
                    return;
                }
            }
            Console.WriteLine("Không tìm thấy sinh viên nào có SBD "+soBaoDanh);
        }

        private static void HienThiSinhVienTheoDiaChi()
        {
            Console.WriteLine("Nhập địa chỉ :");
            string diaChi = Console.ReadLine();
            Console.WriteLine("Danh sách sinh viên có địa chỉ tại " + diaChi + " là :");
            ThiSinhA.Header();
            foreach (ThiSinhA item in list)
            {
                if (item.DiaChi.Equals(diaChi))
                {
                    item.xuat();
                }
            }
        }

        private static void HienThiTheoTongDiem()
        {
            Console.WriteLine("Nhập tổng điểm :");
            double tongDiem = double.Parse(Console.ReadLine());
            Console.WriteLine("Danh sách sinh viên có tổng điểm >= "+tongDiem+" là :");
            ThiSinhA.Header();
            foreach (ThiSinhA item in list)
            {
                if (item.TongDiem() >= tongDiem)
                {
                    item.xuat();
                }
            }
        }

        private static void HienThi()
        {
            Console.WriteLine("Danh sách sinh viên là : ");
            ThiSinhA.Header();
            foreach (ThiSinhA item in list)
            {
                item.xuat();
            }
        }

        private static void ThemSinhVien()
        {
            ThiSinhA thiSinhA = new ThiSinhA();
            Console.WriteLine("Nhập số báo danh : ");
            thiSinhA.SoBaoDanh = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập họ tên : ");
            thiSinhA.HoTen = Console.ReadLine();
            Console.WriteLine("Nhập địa chỉ : ");
            thiSinhA.DiaChi = Console.ReadLine();
            Console.WriteLine("Nhập điểm toán : ");
            thiSinhA.Toan = Double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập điểm lý : ");
            thiSinhA.Ly = Double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập điểm hóa học : ");
            thiSinhA.HoaHoc = Double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập điểm ưu tiên : ");
            thiSinhA.DiemUuTien = Double.Parse(Console.ReadLine());
            list.Add(thiSinhA);
            Console.WriteLine("Thêm thành công !");
        }
    }
}
