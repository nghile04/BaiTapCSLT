
/*
* Bài: Buoi01_B3 - Sửa lỗi chương trình cho sẵn
* Sinh viên: Lê Trần Bảo Nghi - MSSV: 31251024972
* Ngày: 21/10/2026
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi01_B3
{
    internal class program
    {
        static void Main(string[] args) //sửa: viết hoa chữ Main
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; //sửa: thêm dấu ; cuối chuỗi
            Console.WriteLine("Chương trình có lỗi"); //sửa: thêm dấu " sau chữ lỗi và viết hoa Console                                 
            Console.WriteLine(@"Đường dẫn: C:\Temp\new"); //sửa: viết hoa chữ Line và thêm kí tự @ để sửa lỗi biên dịch \T và lỗi sai kết quả \n          
            Console.WriteLine("Kết thúc");//sửa: đổi từ '' sang ""
        }
    }
} //thêm dấu } cho khớp với ba dấu { ở trên

