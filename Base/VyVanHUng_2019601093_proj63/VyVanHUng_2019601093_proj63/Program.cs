using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VyVanHUng_2019601093_proj63
{
    class Program
    {
        static List<Course> courses = new List<Course>();
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            
            do
            {
                Console.WriteLine("1. Thêm một khóa học ");
                Console.WriteLine("2. Hiển thị các khóa học");
                Console.WriteLine("3. Tìm kiếm khóa học ");
                Console.WriteLine("4. Tìm kiếm sinh viên ");
                Console.WriteLine("5. Xóa một khóa học ");
                Console.WriteLine("6. Kết thúc một chương trình ");
                Console.WriteLine("---Nhập lựa chọn của bạn ");
                int choose = int.Parse(Console.ReadLine());
                switch (choose)
                {
                    case 1: ThemMotKhoaHoc();break;  
                    case 2: HienThiCacKhoaHoc();break; 
                    case 3: TimKiemKhoaHoc();break;
                    case 4: TimKiemSinhVien();break;
                    case 5: XoaMotKhoaHoc();break;
                    case 6: return;
                }
            } while (true);
        }

        private static void XoaMotKhoaHoc()
        {

            Console.WriteLine("Nhập mã khóa học cần tìm kiếm");
            string idCourse = Console.ReadLine();
            Course course = courses.Find(item => item.Courseid.Equals(idCourse));
            if (course == null)
            {
                Console.WriteLine("Không tìm thấy khóa học với mã này " + idCourse);
                return;
            }
            courses.Remove(course);
            Console.WriteLine("Xóa thành công khóa học ");
        }

        private static void TimKiemSinhVien()
        {
            bool oke = false;
            Console.WriteLine("Nhập mã sinh viên cần tìm kiếm : ");
            int idStudent = int.Parse(Console.ReadLine());
            foreach (Course item in courses)
            {
                foreach (Student student in item.GetAllStudent())
                {
                    if(student.Studentid == idStudent)
                    {
                        if (oke == false)
                        {
                            Student.Header();
                            Console.WriteLine(student.ToString());
                            Console.WriteLine("---Danh sách các khóa học của sinh viên này là : ");
                            oke = true;
                        }
                        Course.Header();
                        item.Output();

                    }
                }
            }
        }

        private static void TimKiemKhoaHoc()
        {
            Console.WriteLine("Nhập mã khóa học cần tìm kiếm");
            string idCourse = Console.ReadLine();
            Course course = courses.Find(item => item.Courseid.Equals(idCourse));
            if(course == null)
            {
                Console.WriteLine("Không tìm thấy khóa học với mã này " + idCourse);
                return;
            }
            Console.WriteLine("Tìm thấy khóa học với mã  " + idCourse);
            course.DisplayCourseAndStudents();
        }

        private static void HienThiCacKhoaHoc()
        {
            foreach (Course item in courses)
            {
                item.DisplayCourseAndStudents();
            }
        }

        private static void ThemMotKhoaHoc()
        {
            Console.WriteLine("Thêm một khóa học ");
            Course course = new Course();
            course.InputCourse();
            courses.Add(course);
            Console.WriteLine("Thêm thành công ");
        }
    }
}
