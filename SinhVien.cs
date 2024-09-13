using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nguyenVanTan_Buoi3
{
    internal class SinhVien
    {
        public string MaSinhVien { get; set; }
        public string TenSinhVien { get; set; }
        public DateTime NgaySinh { get; set; }
        public int Sodienthoai { get; set; }
        public string DiaChi { get; set; }
        public SinhVien(string maSinhVien, string tenSinhVien, DateTime ngaySinh, string diaChi)
        {
            MaSinhVien = maSinhVien;
            TenSinhVien = tenSinhVien;
            NgaySinh = ngaySinh;
            DiaChi = diaChi;
        }
        public override string ToString()
        {
            return $"Mã Sinh Viên: {MaSinhVien}, Tên: {TenSinhVien}, Ngày Sinh: {NgaySinh.ToShortDateString()}, Số điện thoại : {Sodienthoai}, Địa Chỉ: {DiaChi}";
        }
    }
}
