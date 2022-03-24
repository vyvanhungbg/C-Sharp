using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TapTin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string pathInput = @"myfile.txt";
            string pathOutPut = @"Ouput.txt";

            List<string> list = docFile(pathInput);
            xuat(list);

            list = list.ConvertAll(item => item.ToUpper());
            Console.WriteLine(" Viết hoa : ");
            xuat(list);

            int numberWord = countWord(list);
            Console.WriteLine("Số từ đếm được : "+ numberWord);
            ghiFile(pathOutPut, list, numberWord);
        }

        static void xuat(List<string> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        static int countWord(List<string> list)
        {
            int count = 0;
            foreach (var item in list)
            {
                string [] listString = Convert.ToString(item).Split();
                foreach (var subItem in listString.ToList())
                {
                    if (Convert.ToString(subItem).Length > 1)
                        count++;
                }
            }
            return count;
        }

        static List<string> docFile(string path)
        {
            List<string> list = new List<string>();
            StreamReader sr = new StreamReader(path);
            try
            {
                string line;
                while (!sr.EndOfStream)
                {
                    line = sr.ReadLine();
                    list.Add(line);
                   
                }
                Console.WriteLine("đọc file thành công !");
                return list;
            }
            catch (Exception e)
            {
                Console.WriteLine("Có lỗi trong quá trình đọc file " + e.Message);

            }
            finally
            {
                sr.Close();
            }
            return list;

        }


        static void ghiFile(string path, List<string> list ,int numberWord)
        {
            StreamWriter sw = new StreamWriter(path, false);
            try
            {

                foreach (var item in list)
                {
                    sw.WriteLine(item);
                }
                sw.WriteLine(numberWord);
                Console.WriteLine("ghi file thành công !");
            }
            catch (Exception e)
            {
                Console.WriteLine("Có lỗi trong quá trình ghi file " + e.Message);
            }
            finally
            {
                sw.Close();
            }
        }
    }
}
