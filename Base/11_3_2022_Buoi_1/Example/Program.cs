using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;


namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            GhiFile("vidu.txt");
            DocFile("vidu.txt");
        }

        static void GhiFile(string fileName)
        {
            System.IO.StreamWriter sw = new System.IO.StreamWriter(fileName, true);// true là đè lên cái cũ ,
            sw.WriteLine("Vy Văn Hùng");
            sw.Close();
           
        }

        static void DocFile(string fileName)
        {
            System.IO.StreamReader sr = new System.IO.StreamReader(fileName);
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                Console.WriteLine(line);
            }
            sr.Close();
        }
    }
}
