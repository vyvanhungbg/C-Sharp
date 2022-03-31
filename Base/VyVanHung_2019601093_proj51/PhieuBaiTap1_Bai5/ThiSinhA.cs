using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhieuBaiTap1_Bai5
{
    class ThiSinhA
    {
        private int soBaoDanh;
        private string hoTen;
        private string diaChi;
        private double toan;
        private double ly;
        private double hoaHoc;
        private double diemUuTien;
       

        public int SoBaoDanh { get => soBaoDanh; set => soBaoDanh = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public double Toan { get => toan; set => toan = value; }
        public double Ly { get => ly; set => ly = value; }
        public double HoaHoc { get => hoaHoc; set => hoaHoc = value; }
        public double DiemUuTien { get => diemUuTien; set => diemUuTien = value; }
       
        public double TongDiem() { return toan + ly + hoaHoc + diemUuTien; }
       

        public ThiSinhA(int soBaoDanh, string hoTen, string diaChi, double toan, double ly, double hoaHoc, double diemUuTien)
        {
            SoBaoDanh = soBaoDanh;
            HoTen = hoTen;
            DiaChi = diaChi;
            Toan = toan;
            Ly = ly;
            HoaHoc = hoaHoc;
            DiemUuTien = diemUuTien;
           
        }

        public ThiSinhA()
        {
        }

        public static void Header()
        {
            string formatTable = String.Format("{0,-12} {1,-12} {2,-12} {3,-12:0.0} {4,-12:0.0}{5,-12:0.0} {6,-12:0.0} {7,-12:0.0}\n"
                , "SoBaoDanh"," HoTen", "DiaChi", "Toan", "Ly", "HoaHoc", "DiemUuTien", "TongDiem");
            Console.WriteLine(formatTable);
        }
        public void xuat()
        {
            string formatTable = String.Format("{0,-12} {1,-12} {2,-12} {3,-12:0.0} {4,-12:0.0}{5,-12:0.0} {6,-12:0.0} {7,-12:0.0}\n"
                , SoBaoDanh,HoTen,DiaChi,Toan,Ly, HoaHoc,DiemUuTien,TongDiem());
            Console.WriteLine(formatTable);
        }
    }
}
