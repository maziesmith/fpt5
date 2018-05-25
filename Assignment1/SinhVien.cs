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
            System.Console.WriteLine($"{"Ma SV", -10}{"Ho Ten", -30}{"Ngay Sinh", -25}{"Dia Chi", -20}{"Dien Thoai", -15}");
        }

        public void XemThongTin() {
            System.Console.WriteLine($"{MaSV, -10}{HoTen, -30}{NgaySinh.ToString("dd/MM/yyyy"), -25}{DiaChi, -20}{DienThoai, -15}");
        }
    }
}