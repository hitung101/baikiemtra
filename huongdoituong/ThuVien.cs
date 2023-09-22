using System;
using huongdoituong;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace huongdoituong
{

    class ThuVien
    {

        private List<Sach> danhSachSach = new List<Sach>();

        // Thêm sách vào thư viện
        public void ThemSach(int maSach, string tenSach, string tacGia)
        {
            Sach sachMoi = new Sach(maSach, tenSach, tacGia);
            danhSachSach.Add(sachMoi);
        }

        // Xóa sách khỏi thư viện
        public void XoaSach(int maSach)
        {
            Sach sachCanXoa = danhSachSach.Find(s => s.MaSach == maSach);
            if (sachCanXoa != null)
            {
                danhSachSach.Remove(sachCanXoa);
            }
            else
            {
                Console.WriteLine("Không tìm thấy sách có mã sách {0} trong thư viện.", maSach);
            }
        }

        // Hiển thị thông tin sách trong thư viện
        public void HienThiThongTinSach()
        {
            Console.WriteLine("Danh sách sách trong thư viện:");
            foreach (Sach sach in danhSachSach)
            {
                Console.WriteLine("Mã sách: {0}", sach.MaSach);
                Console.WriteLine("Tên sách: {0}", sach.TenSach);
                Console.WriteLine("Tác giả: {0}", sach.TacGia);
                Console.WriteLine();
            }
        }

    }
}