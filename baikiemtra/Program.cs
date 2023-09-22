using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baikiemtra
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so luong phan tu cua mang : ");
            int n = int.Parse(Console.ReadLine());

            // Khởi tạo mảng có kích thước n
            int[] arr = new int[n];

            // Nhập giá trị cho từng phần tử và thêm vào mảng
            for (int i = 0; i < n; i++)
            {
                Console.Write($"nhap gia tri cho phan tu thu {i + 1}: ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            // Khởi tạo giá trị lớn nhất và vị trí của nó ban đầu
            int max_value = arr[0];
            int vi_tri_max = 0;

            // Duyệt qua mảng để tìm giá trị lớn nhất và vị trí của nó
            for (int i = 1; i < n; i++)
            {
                if (arr[i] > max_value)
                {
                    max_value = arr[i];
                    vi_tri_max = i;
                }
            }

            // In kết quả ra màn hình
            Console.WriteLine($"phan tu lon nhat trong mang la {max_value} nam o vi tri {vi_tri_max + 1}.");
        }
    }
}
