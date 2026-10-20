//cap nhat mo ta
/*
* Bài: Buoi01_B1 - Thời khóa biểu canh cột
* Sinh viên: Lê Trần Bảo Nghi - MSSV: 31251024972
* Ngày: 21/10/2026
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi01_B1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding= System.Text.Encoding.UTF8;
            //Cách 1
            Console.WriteLine("THỜI KHÓA BIỂU TUẦN 1");
            Console.WriteLine("Thứ\tSáng\t\tChiều"); 
            Console.WriteLine("Hai\tCSLT\t\tToán CC");
            Console.WriteLine("Ba\tTiếng Anh\t(trống)");
            Console.WriteLine();
            //Cách 2
            Console.WriteLine("THỜI KHÓA BIỂU TUẦN 1\nThứ\tSáng\t\tChiều\nHai\tCSLT\t\tToán CC\nBa\tTiếng Anh\t(trống)");

        }
    }
}
