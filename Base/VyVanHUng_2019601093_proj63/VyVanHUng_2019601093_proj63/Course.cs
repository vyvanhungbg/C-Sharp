using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VyVanHUng_2019601093_proj63
{
    class Course
    {
        private string courseid;
        private string courseName;
        private int fee;
        private List<Student> students = new List<Student>();

        public Course(List<Student> students)
        {
            this.students = new List<Student>();
        }

        public Course()
        {
        }

        public string Courseid { get => courseid; set => courseid = value; }
        public string CourseName { get => courseName; set => courseName = value; }
        public int Fee { get => fee; set => fee = value; }

        public void InputCourse()
        {
            Console.WriteLine("Nhập course id :");
            Courseid = Console.ReadLine();
            Console.WriteLine("Nhập course Name : ");
            CourseName = Console.ReadLine();
            Console.WriteLine("Nhập course fee : ");
            Fee = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập số lượng học sinh : ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Student student = new Student();
                student.InputStudent();
                students.Add(student);
            }

          
        }

        public void DisplayCourseAndStudents()
        {
            Console.WriteLine("Course Id   : " + courseid);
            Console.WriteLine("Course Name : " + courseName);
            Console.WriteLine("Course Fee  : " + fee);
            Console.WriteLine("---List Student----");
            Student.Header();
            foreach (Student item in students)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine();

        }

        public void Output()
        {
           
            string formatTable = String.Format("{0,-15} {1,-15} {2,-15}", courseid, courseName, fee);
            Console.WriteLine(formatTable);
        }

        public static void Header()
        {

            string formatTable = String.Format("{0,-15} {1,-15} {2,-15}", "courseid", "courseName", "fee");
            Console.WriteLine(formatTable);
        }

        public List<Student> GetAllStudent()
        {
            return students;
        }
    }
}
