using System;
using huongdoituong;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace huongdoituong
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            ThuVien thuVien = new ThuVien();

            // Thêm sách vào thư viện
            thuVien.ThemSach(1, "Sách 1", "Tác giả Tùng");
            thuVien.ThemSach(2, "Sách 2", "Tác giả Tuấn");
            thuVien.ThemSach(3, "Sách 3", "Tác giả Long ");

            // Hiển thị thông tin sách trong thư viện
            thuVien.HienThiThongTinSach();

            // Xóa sách khỏi thư viện
            Console.WriteLine(" Xoá danh sách 2 khỏi thư viện nhấn phím bất kì để hiện thị danh sách còn lại");
            thuVien.XoaSach(2); Console.ReadLine();

            // Hiển thị lại thông tin sách sau khi xóa
            thuVien.HienThiThongTinSach(); Console.ReadLine();
        }


    }
}