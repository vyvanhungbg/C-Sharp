using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3_BTVN__QuanLiSinhVien
{
    struct SinhVien
    {
        private int id;
        private string ten;
        private int gioiTinh;
        private int tuoi;
        private double diemToan;
        private double diemLy;
        private double diemHoa;

        public SinhVien(int id, string ten, int gioiTinh, int tuoi, double diemToan, double diemLy, double diemHoa)
        {
            this.id = id;
            this.ten = ten;
            this.gioiTinh = gioiTinh;
            this.tuoi = tuoi;
            this.diemToan = diemToan;
            this.diemLy = diemLy;
            this.diemHoa = diemHoa;
        }

        public  int Id { get => id; set => id = value; }
        public string Ten { get => ten; set => ten = value; }
        public int GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public int Tuoi { get => tuoi; set => tuoi = value; }
        public double DiemToan { get => diemToan; set => diemToan = value; }
        public double DiemLy { get => diemLy; set => diemLy = value; }
        public double DiemHoa { get => diemHoa; set => diemHoa = value; }
        
        public double diemTrungBinh() { return (diemToan + diemLy + diemHoa) / 3; }

        public string hocLuc()
        {
            double diemTB = diemTrungBinh();
            if (diemTB >= 8)
                return "Giỏi";
            else if (diemTB >= 6.5)
                return "Khá";
            else if (diemTB >= 5)
                return "Trung bình";
            else
                return "Yếu";
        }

        public void xuat()
        {
            String formatTable = String.Format("{0,-10} {1,-20} {2,-20} {3, -10} {4, -20:0.0} {5, -20:0.0} {6, -20:0.0} {7, -20:0.0} {8, -20} \n",
                this.id, this.ten, this.gioiTinh == 1 ? "Nam": "Nữ", this.tuoi,this.diemToan, this.diemLy, this.diemHoa, diemTrungBinh(), hocLuc());
               Console.WriteLine(formatTable);
        }

        public string toString()
        {
            String formatTable = String.Format("{0,-10} {1,-20} {2,-20} {3, -10} {4, -20:0.0} {5, -20:0.0} {6, -20:0.0} {7, -20:0.0} {8, -20} \n",
                this.id, this.ten, this.gioiTinh == 1 ? "Nam" : "Nữ", this.tuoi, this.diemToan, this.diemLy, this.diemHoa, diemTrungBinh(), hocLuc());
            return formatTable;
        }

        public void nhap()
        {
            this.id = Program.list.Count+1;  // viết tạm chưa tối ưu theo chương trình thật cần lưu id ngoài 
            this.ten = Program.nhapString("Nhập Tên : ");
            this.gioiTinh = Program.nhapInt("Nhập giới tính { 1 : nam | 0 : nữ} : ",0,1);
            this.tuoi = Program.nhapInt("Nhập tuổi  : ", 0, 250); 
            this.diemToan = Program.nhapDouble("Nhập điểm toán : ", 0, 10); 
            this.diemLy = Program.nhapDouble("Nhập điểm lý : ", 0, 10); ;
            this.diemHoa = Program.nhapDouble("Nhập điểm hóa : ", 0, 10); ;
        }
    }
    class Program
    {
        
        static string path = "quanlisinhvien.txt";
        public static List<SinhVien> list;
        
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            list = getDataFromDB(path);
            //generSinhVien();
            do
            {

                Console.WriteLine("\n1. Thêm sinh viên");
                Console.WriteLine("2. Cập nhật thông tin sinh viên bởi id");
                Console.WriteLine("3. Xóa sinh viên bởi ID");
                Console.WriteLine("4. Tìm kiếm sinh viên theo tên");
                Console.WriteLine("5. Sắp xếp sinh viên theo điểm trung binh.");
                Console.WriteLine("6. Sắp xếp sinh viên theo tên.");
                Console.WriteLine("7. Hiển thị danh sách sinh viên");
                Console.WriteLine("8. Ghi danh sách sinh viên vào file 'student.txt' \n");

                int choose = nhapInt("Nhập lựa chọn [1:8] :\n ", 0, 8);

                switch (choose)
                {
                    case 1: ThemSinhVien(); break;
                    case 2: CapNhatThongTinID();break;
                    case 3: XoaThongTinID();break;
                    case 4: TimKiemSinhVienTheoTen();break;
                    case 5: SapXepSinhVienTheoDiemTB();break;
                    case 6: SapXepSinhVienTheoTen();break;
                    case 7: HienThiThongTinSinhVien(list); break;
                    case 8: GhiDanhSach(list); break;
                    default:
                        break;
                }
            } while (true);

        }

        static void generSinhVien()
        {
            List<SinhVien> sinhViens = new List<SinhVien>();

            sinhViens.Add(new SinhVien(1, "Vy Văn Hùng", 1, 22, 10, 7, 8.5));
            sinhViens.Add(new SinhVien(2, "Nguyễn Văn A", 1, 25, 8, 9, 9));
            sinhViens.Add(new SinhVien(3, "Đào Thị B", 0, 19, 7.0, 8.5, 9));
            sinhViens.Add(new SinhVien(4, "Trần Đức C", 1, 34, 7.8, 7, 6));
            sinhViens.Add(new SinhVien(5, "Vy Văn Hưng", 1, 22, 8.8, 7, 5));
            List<string> listFlat = new List<string>();
            foreach (SinhVien item in sinhViens)
            { 
                string str = ConvertSinhVienToString(item);
                listFlat.Add(str);
            }
            ghiFile(path, listFlat);
        }

        static List<SinhVien> getDataFromDB(string path)
        {
            List<string> myList = docFile(path);
            List<SinhVien> mList = new List<SinhVien>();
            foreach (var item in myList)
            {
                SinhVien sinhVien = ConvertStringToSinhVien(item);
                mList.Add(sinhVien);
               // sinhVien.xuat();
            }
            return mList;
        }

        static void putDataFromDB(List<SinhVien> sinhViens, string path)
        {
            List<string> myList = new List<string>();
            foreach (var item in sinhViens)
            {
                string str = ConvertSinhVienToString(item);
                myList.Add(str);
            }
            ghiFile(path, myList);
        }


        static void TieuDe()
        {
            String formatTable = String.Format("{0,-10} {1,-20} {2,-20} {3, -10} {4, -20} {5, -20} {6, -20} {7, -20} {8, -20} \n",
                 "ID", "Tên", "Giới tính", "Tuổi", "Điểm Toán", "Điểm Lý", "Điểm Hóa", "Trung bình", "Học lực");
            Console.WriteLine(formatTable);
        }

        private static void ThemSinhVien()
        {
            Console.WriteLine("Nhập thông tin sinh viên mới : ");
            SinhVien sinhVien = new SinhVien();
            sinhVien.nhap();
            //Console.WriteLine(ConvertSinhVienToString(sinhVien));
            TieuDe();
            sinhVien.xuat();
            list.Add(sinhVien);
            putDataFromDB(list, path);
            Console.WriteLine("\nThêm Sinh viên thành công");
        }


        static void HienThiThongTinSinhVien(List<SinhVien> mList)
        {
            TieuDe();
            foreach (SinhVien item in mList)
            {
                item.xuat();
            }
        }

        static void CapNhatThongTinID()
        {
            int id = nhapInt("Nhập id sinh viên cần sửa : ", 1, int.MaxValue);
            int index = list.FindIndex(sv => sv.Id == id);

            if (index<0)
            {
                Console.WriteLine("Không tìm thấy sinh viên với mã id "+id);
                return;
            }

            SinhVien sinhVien = list[index];
            Console.WriteLine("Tìm thấy sinh viên :\n");
            TieuDe();
            sinhVien.xuat();
            do
            {
               
                Console.WriteLine("\nChọn các lựa chọn sau ");
                Console.WriteLine("1. Sửa tên");
                Console.WriteLine("2. Sửa giới tính");
                Console.WriteLine("3. Sửa tuổi");
                Console.WriteLine("4. Sửa điểm toán");
                Console.WriteLine("5. Sửa điểm lý");
                Console.WriteLine("6. Sửa điểm hóa");
                Console.WriteLine("7. Lưu ! và Thoát");
                Console.WriteLine("0. Thoát ngay ");
             
                int choose = nhapInt("Nhập lựa chọn [1:7] : ", 0, 7);

                switch (choose)
                {
                    case 1: sinhVien.Ten = nhapString("Nhập tên mới : "); break;
                    case 2: sinhVien.GioiTinh = nhapInt("Nhập giới tính { 1 : nam | 0 : nữ} : ", 0, 1); break;
                    case 3: sinhVien.Tuoi = nhapInt("Nhập tuổi  : ", 0, 250); break;
                    case 4: sinhVien.DiemToan = nhapDouble("Nhập điểm toán : ", 0, 10); break;
                    case 5: sinhVien.DiemLy = nhapDouble("Nhập điểm lý : ", 0, 10); break;
                    case 6: sinhVien.DiemHoa =nhapDouble("Nhập điểm hóa : ", 0, 10); break;
                    case 7:
                        list[index] = sinhVien;
                        putDataFromDB(list, path);
                        Console.WriteLine("Sửa thông tin thành công !");return ; break;
                    case 0: return; break;
                    default:
                        break;
                }
            } while (true);
            
        }

        

        static void XoaThongTinID()
        {
            int id = nhapInt("Nhập id sinh viên cần xóa : ", 1, int.MaxValue);
            int index = list.FindIndex(sv => sv.Id == id);

            if (index < 0)
            {
                Console.WriteLine("Không tìm thấy sinh viên với mã id " + id);
                return;
            }
            SinhVien sinhVien = list[index];
            Console.WriteLine("Tìm thấy sinh viên :\n");
            TieuDe();
            sinhVien.xuat();
            Console.WriteLine("Chắc chắn muốn xóa sinh viên này ? ");
            int choose = nhapInt("Nhập lựa chọn : \n1. Xóa \n0. Hủy \n", 0, 1); 
            if(choose == 1)
            {
                list.RemoveAt(index);
                putDataFromDB(list, path);
                Console.WriteLine("Xóa sinh viên với id = " + id + " thành công !");
            }
            else
            {
                Console.WriteLine("Đã hủy xóa thành công !");
            }
        }

        static void TimKiemSinhVienTheoTen()
        {
            
            string ten = nhapString("Nhập tên sinh viên cần tìm kiếm : ").ToLower();
            //Console.WriteLine("hung");
            List<SinhVien> mList = list.FindAll(sv =>  (ten.Contains(sv.Ten.ToLower()) || sv.Ten.ToLower().Contains(ten)) );
           
            if (mList == null || mList.Count ==0)
            {
                Console.WriteLine("Không tìm thấy sinh viên nào khớp với tên :   " + ten);
                return;
            }
            
            Console.WriteLine("Tìm thấy sinh viên :\n");
           // TieuDe();
            HienThiThongTinSinhVien(mList);
        }

        static void SapXepSinhVienTheoDiemTB()
        {
            Console.WriteLine("Sắp xếp sinh viên theo điểm trung bình ");
            list = list.OrderBy(item => item.diemTrungBinh()).ToList();
            list.Reverse();
            Console.WriteLine("Sắp xếp thành công  !");
        }

        static void SapXepSinhVienTheoTen()
        {
            Console.WriteLine("Sắp xếp sinh viên theo tên ");
            list = list.OrderBy(item => item.Ten).ToList();
            Console.WriteLine("Sắp xếp thành công  !");
        }

        public static void GhiDanhSach(List<SinhVien> sinhViens)
        {
            string myPath = @"student.txt";
            String formatTable = String.Format("{0,-10} {1,-20} {2,-20} {3, -10} {4, -20} {5, -20} {6, -20} {7, -20} {8, -20} \n",
                "ID", "Tên", "Giới tính", "Tuổi", "Điểm Toán", "Điểm Lý", "Điểm Hóa", "Trung bình", "Học lực");

            List<string> myList = new List<string>();
            myList.Add(formatTable);
            foreach (var item in sinhViens)
            {
                myList.Add(item.toString());
            }
            ghiFile(myPath, myList);
        }

        public static int nhapInt(string mess, int from , int to)
        {

            int n = 0;
            bool oke = false;
            do
            {
                try
                {
                    Console.Write(mess);
                    n = int.Parse(Console.ReadLine());
                    oke = true;
                    if (n < from || n > to)
                    {
                        Console.WriteLine("Nhập số trong khoảng ["+from+":"+to+"] : ");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Vui lòng nhập n là một chữ số !");
                }
            } while ((n < from || n > to) || oke == false);

            return n;
        }


        public static string nhapString(string mess)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Console.WriteLine(mess);
            string str = Console.ReadLine();
            return str;
        }


        public static double nhapDouble(string mess, double from, double to)
        {

            double n = 0;
            bool oke = false;
            do
            {
                try
                {
                    Console.Write(mess);
                    n = double.Parse(Console.ReadLine());
                    oke = true;
                    if (n < from || n > to)
                    {
                        Console.WriteLine("Nhập số trong khoảng [" + from + ":" + to + "] : ");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Vui lòng nhập n là một chữ số !");
                }
            } while ((n < from || n > to) || oke == false);

            return n;
        }

        static string ConvertSinhVienToString(SinhVien sinhVien)
        {
           // string[] listString = str.Split('|');
            string res = "";
            res += sinhVien.Id + "|";
            res += sinhVien.Ten + "|";
            res += sinhVien.GioiTinh + "|";
            res += sinhVien.Tuoi + "|";
            res += sinhVien.DiemToan + "|";
            res += sinhVien.DiemLy + "|";
            res += sinhVien.DiemHoa;
            return res;
        }

        static SinhVien ConvertStringToSinhVien(string str)
        {
            string[] listString = str.Split('|');
            SinhVien sinhVien = new SinhVien(
                Convert.ToInt32(listString[0]),
                Convert.ToString(listString[1]),
                Convert.ToInt32(listString[2]),
                Convert.ToInt32(listString[3]),
                Convert.ToDouble(listString[4]),
                Convert.ToDouble(listString[5]),
                Convert.ToDouble(listString[6])
                );
            return sinhVien;
        }

        static List<string> docFile(string path)
        {
            List<string> list = new List<string>();
            StreamReader sr = new StreamReader(path);
            try
            {
                string line ;
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

        static void ghiFile(string path, List<string> list )
        {
            StreamWriter sw = new StreamWriter(path, false);
            try
            {
               // sw.WriteLine(list.Count);
                foreach (var item in list)
                {
                    sw.WriteLine(item);
                }
               
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
