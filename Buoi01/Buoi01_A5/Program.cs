
/*
* Bài: Buoi01_A5 - Từ lưu đồ đến code: chu vi, diện tích hình chữ nhật
* Sinh viên: Lê Trần Bảo Nghi - MSSV: 31251024972
* Ngày: 21/10/2026
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi01_A5
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Console.OutputEncoding = System.Text.Encoding.UTF8;
           
            // NHẬP (tạm gán sẵn)
            double a = 3, b = 5;
            // XỬ LÝ
            double cv = 2 * (a + b);
            double dt = a * b;
            double d = Math.Sqrt(a * a + b * b);
            // XUẤT
            Console.WriteLine("Chiều dài = " + a);
            Console.WriteLine("Chiều rộng = " + b);
            Console.WriteLine("Chu vi = " + cv);
            Console.WriteLine("Diện tích = " + dt);
            Console.WriteLine("Đường chéo = " + d);

        }
    }
}
