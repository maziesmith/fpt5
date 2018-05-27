using System;
using System.Collections.Generic;

namespace Assignment1
{
    public class SinhVien {
        private string mMaSV;
        public string MaSV
        {
            get { return mMaSV;}
            set { mMaSV = value;}
        }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public string DienThoai { get; set; }

        public SinhVien() {}

        public SinhVien(string maSV, string hoTen, DateTime ngaySinh, string diaChi, string dienThoai)
        {
            MaSV = maSV;
            HoTen = hoTen;
            NgaySinh = ngaySinh;
            DiaChi = diaChi;
            DienThoai = dienThoai;
        }

        public static void InTieuDe() {
            System.Console.WriteLine($"{"Ma SV", -10}{"Ho Ten", -20}{"Ngay Sinh", -15}{"Dia Chi", -10}{"Dien Thoai", -15}");
        }

        public void XemThongTin() {
            System.Console.WriteLine($"{MaSV, -10}{HoTen, -20}{NgaySinh.ToString("dd/MM/yyyy"), -15}{DiaChi, -10}{DienThoai, -15}");
        }
    }
}