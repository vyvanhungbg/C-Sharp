using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap3
{
    class Student
    {
        private string id;
        private string name;
        private int mark;
        private int scholarship;

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Mark 
        {   get => mark;
            set  { mark = value;CheckScholarship();}
           
        }

        public void CheckScholarship()
        {
            if (this.Mark > 8)
                scholarship = 500;
            else if (this.Mark >= 7)
                scholarship = 300;
            else
                scholarship = 0;
        }
        public int Scholarship
        { 
            get => scholarship;
            set => CheckScholarship();

        }

        public Student(string id, string name, int mark, int scholarship)
        {
            this.Id = id;
            this.Name = name;
            this.Mark = mark;
            this.Scholarship = scholarship;
        }

        public Student(string id, string name, int mark)
        {
            this.Id = id;
            this.Name = name;
            this.Mark = mark;
           
        }

        public Student()
        {
        }

        public Student(string id)
        {
            this.id = id;
        }

        public override string ToString()
        {
            return String.Format("{0,-10} {1,-20} {2,-20} {3,-20} ", Id, Name, Mark, Scholarship);
        }
    }
}
