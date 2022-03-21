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
            int m = 0, n = 0;
            int[,] matrix ;

            string path = @"myfile.txt";
            matrix =  docFile( ref m, ref n, path);
            ghiFile(matrix, m, n, path);
        }

        static int[,]  docFile(ref int m,ref int n, string path)
        {
            StreamReader sr = new StreamReader(path);
            try
            {
                
                m = int.Parse(sr.ReadLine());
                n = int.Parse(sr.ReadLine());
                int[,] matrix = new int[m, n];
                for (int i = 0; i < m; i++)
                {
                   
                    string[] line = sr.ReadLine().Split();
                    
                    for (int j = 0; j < n; j++)
                    {
                        matrix[i,j] = int.Parse(line[j]);
                    }

                }
                Console.WriteLine("đọc file thành công !");
                return matrix;
            }
            catch(Exception e)
            {
                Console.WriteLine("Có lỗi trong quá trình đọc file "+ e.Message);

            }
            finally
            {
                sr.Close();
            }
            return new int[0,0];
            
        }


        static void ghiFile(int[,] matrix,  int m,  int n, string path)
        {
            StreamWriter sw = new StreamWriter(path, true);
            try
            {
                
                /* sw.WriteLine(m);
                 sw.WriteLine(n);*/
                int sum = 0;
                for (int i = 0; i < m; i++)
                {
                    
                    for (int j = 0; j < n; j++)
                    {
                        // sw.Write(matrix[i,j] + " ");
                        sum += matrix[i, j];
                    }
                    //sw.WriteLine();

                }
                
                sw.WriteLine(sum);
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
