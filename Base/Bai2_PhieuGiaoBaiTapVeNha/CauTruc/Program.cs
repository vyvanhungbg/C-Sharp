using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CauTruc
{
    struct HocSinh{
        public string hoTen;
        public int tuoi;
        public bool gioiTinh;

        public HocSinh(string hoTen, int tuoi, bool gioiTinh)
        {
            this.hoTen = hoTen;
            this.tuoi = tuoi;
            this.gioiTinh = gioiTinh;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            HocSinh[] arrays = new HocSinh[5];
            arrays[0] = new HocSinh("Hung", 32, true);
            arrays[1] = new HocSinh("Hà", 32, false);
            arrays[2] = new HocSinh("Hải", 32, true);
            arrays[3] = new HocSinh("Long", 32, true);
            arrays[4] = new HocSinh("Thủy", 32, false);


            int tong = 0;
            for (int i = 0; i < arrays.Length; i++)
            {
                tong += arrays[i].tuoi;
            }

            Console.WriteLine("tổng số tuổi : "+tong);
        }
    }
}
