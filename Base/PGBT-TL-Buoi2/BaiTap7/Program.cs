using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string oldDirectory = @"C:\source\";
            string oldPath = oldDirectory+ @"vidu.txt";
            string newPath = @"D:\target\vidu.txt";

            // Cách 1
            if (SinhFileTest(oldPath, newPath))  // tự sinh file cần thiết để test){
            {
                ChuyenFile(oldPath, newPath);
                // chuyển file bằng thư viện File
            }
            else
            {
                Console.WriteLine("Tạo các thư mục cần thiết thành công ! \n-- Chạy lại chương trình !");
            }

            //Cách 2

            /*if (SinhFileTest(oldPath, newPath))  // tự sinh file cần thiết để test){
            {
                List<string> list = DocFile(oldPath);
                if (list != null)
                {
                    GhiFile(newPath, list,oldPath);
                }

                // chuyển file bằng thư viện File
            }
            else
            {
                Console.WriteLine("Tạo các thư mục cần thiết thành công ! \n-- Chạy lại chương trình !");
            }*/

        }

        static void TaoThuMuc(string pathDirectory)
        {
            if(!Directory.Exists(pathDirectory))
            {
                try
                {
                    Console.WriteLine("Thư mục tại đường dẫn " + pathDirectory + " không tồn tại !");
                    Directory.CreateDirectory(pathDirectory);
                    Console.WriteLine("Đã tạo thư mục tại đường dẫn " + pathDirectory + " thành công !");
                }
                catch(Exception e)
                {
                    Console.WriteLine("Có lỗi trong quá trình tạo thư mục tại đường dẫn "+ pathDirectory);
                    Console.WriteLine(e.Message);
                }
            }
            else
            {
                Console.WriteLine("Thư mục "+pathDirectory+" đã tồn tại !");
            }
           
        }

        static void TaoFile(string path)
        {
            if (!File.Exists(path))
            {
                try
                {
                    Console.WriteLine("File  tại đường dẫn " + path + " không tồn tại !");
                    File.Create(path);
                    Console.WriteLine("Đã tạo file tại đường dẫn " + path + " thành công !");
                }
                catch(Exception e)
                {
                    Console.WriteLine("Có lỗi trong quá trình tạo file tại đường dẫn " + path);
                    Console.WriteLine(e.Message);
                }
            }
            else
            {
                Console.WriteLine("File "+path+" đã tồn tại !");
            }
           
        }
        static bool SinhFileTest( string oldPath , string newPath)
        {
            bool oldFileOke = false;
            bool newFileOke = false;
            if(!File.Exists(oldPath))
            {
                Console.WriteLine("Đường dẫn file ban đầu không hợp lệ !");
                Console.WriteLine("Tự động sinh file  !");
                try
                {
                    TaoThuMuc(Directory.GetParent(oldPath).FullName);
                    TaoFile(oldPath);
                   
                }
                catch(Exception e)
                {
                    Console.WriteLine("Lỗi trong quá trình tự động sinh file  " + oldPath +"\n Dừng chương trình !");
                    Console.WriteLine(e.Message);
                    return false;
                }
                oldFileOke = false;

            }
            else
            {
                oldFileOke = true;
            }
            Console.WriteLine("\n");
            if (newPath == null || !Directory.Exists(Directory.GetParent(newPath).FullName))
            {
                Console.WriteLine("Đường dẫn thư mục muốn chuyển đến không hợp lệ !");
                Console.WriteLine("Tự động sinh thư mục  !");
                try
                {
                    TaoThuMuc(Directory.GetParent(newPath).FullName);
                   
                }
                catch (Exception e)
                {
                    Console.WriteLine("Lỗi trong quá trình tự động sinh thư mục  " + newPath + "\n Dừng chương trình !");
                    Console.WriteLine(e.Message);
                    return false;
                }
                newFileOke = false;
            }
            else
            {
                newFileOke = true;
            }

            if (newFileOke && oldFileOke)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void ChuyenFile(string oldPath, string newPath)
        {
            try
            {
                File.Move(oldPath, newPath);
                Console.WriteLine("Chuyển file thành công !");
            }
            catch (Exception e)
            {
                Console.WriteLine(" Lỗi chuyển đổi vị trí file !");
                Console.WriteLine(e.ToString());
            }
        }

        static void GhiFile(string path, List<string> list, string oldPath)
        {
            if (!File.Exists(path))
            {
                Console.WriteLine("Đường dẫn file ban đầu không hợp lệ !");
                Console.WriteLine("Tự động sinh file  !");
                try
                {
                    TaoThuMuc(Directory.GetParent(path).FullName);
                    TaoFile(path);

                }
                catch (Exception e)
                {
                    Console.WriteLine("Lỗi trong quá trình tự động sinh file  " + path + "\n Dừng chương trình !");
                    Console.WriteLine(e.Message);
                   
                }
                Console.WriteLine("Tạo file "+path+" thành công \n Chạy lại chương trình ");

            }
            else
            {
                StreamWriter sw = new StreamWriter(path, true);
                try
                {

                    foreach (string item in list)
                    {
                        sw.WriteLine(item);
                    }

                    Console.WriteLine("Ghi file tại " + path + " thành công !");
                    File.Delete(oldPath);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Lỗi ghi file !");
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    sw.Close();
                }
            }
            
        }

        static List<string> DocFile(string path)
        {
            StreamReader sr = new StreamReader(path);
            List<string> list = new List<string>();
            try
            {

                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    list.Add(line);
                    Console.WriteLine(line);
                }
                Console.WriteLine("Đọc file thành công !");
                return list;
            }
            catch (Exception e)
            {
                Console.WriteLine("Lỗi ghi file !");
                Console.WriteLine(e.Message);
                return null;
            }
            finally
            {
                sr.Close();
                
            }
            Console.WriteLine();
        }
    }
}
