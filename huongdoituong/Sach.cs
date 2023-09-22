using System;
using System.Collections.Generic;
using huongdoituong;


class Sach
{ 
    public int MaSach { get; set; }
    public string TenSach { get; set; }
    public string TacGia { get; set; }

    public Sach(int maSach, string tenSach, string tacGia)
    {
        MaSach = maSach;
        TenSach = tenSach;
        TacGia = tacGia;
    }
}