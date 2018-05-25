using System;
using System.Collections.Generic;

namespace Assignment1
{
    public static class ListSinhVienExtension {
        public static SinhVien TimSinhVien(this List<SinhVien> list, Func<SinhVien, bool> check) {
            foreach (var sv in list)
            {
                if (check(sv))
                {
                    return sv;
                }
            }
            return null;
        }

        public static void XemDanhSachSinhVien(this List<SinhVien> list) {
            if (list.Count == 0)
            {
                System.Console.WriteLine("Khong co sinh vien nao ca. Bam so 2 de them sinh vien");
            } else {
                SinhVien.InTieuDe();
                foreach (var sv in list)
                {
                    sv.XemThongTin();
                }
            }
        }

        private static string readString(string msg) {
            System.Console.Write(msg);
            return Console.ReadLine();
        }

        private static DateTime readDateTime(string msg) {
            bool c = false;
            DateTime datetime = default(DateTime);
            do
            {
                try
                {
                    datetime = DateTime.ParseExact(readString(msg), "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                    c = true;
                }
                catch (System.FormatException)
                {
                    System.Console.WriteLine("Ngay sinh khong dung, vui long nhap lai");
                }
            } while (!c);
            return datetime;
        }

        public static void ThemSinhVien(this List<SinhVien> list) {
            bool c;
            string maSV;
            do
            {
                maSV = readString("Ma sinh vien: ");
                c = list.TimSinhVien(sv => sv.MaSV == maSV) == null;
                if (!c)
                {
                    System.Console.WriteLine("Ma sinh vien trung, nhap ma sinh vien khac");
                }
            } while (!c);
            string hoTen = readString("Ho ten: ");
            DateTime ngaySinh = readDateTime("Ngay sinh (dd/MM/yyyy): ");
            string diaChi = readString("Dia chi: ");
            string dienThoai = readString("So dien thoai: ");
            list.Add(new SinhVien(maSV, hoTen, ngaySinh, diaChi, dienThoai));
        }

        public static void TimSinhVien(this List<SinhVien> list) {
            string maSV = readString("Nhap ma sinh vien can tim: ");
            SinhVien sv = list.TimSinhVien((x) => x.MaSV == maSV);
            if (sv == null)
            {
                System.Console.WriteLine($"Khong tim thay sinh vien voi ma {maSV}!");
            } else {
                SinhVien.InTieuDe();
                sv.XemThongTin();
            }
        }
        public static void ChinhSuaSinhVien(this List<SinhVien> list) {
            SinhVien sv;
            string maSV = readString("Nhap ma sinh vien can chinh sua thong tin: ");
            sv = list.TimSinhVien(x => x.MaSV == maSV);
            if (sv == null)
            {
                System.Console.WriteLine($"Khong tim thay sinh vien {maSV} trong he thong!");
            } else {
                sv.HoTen = readString("Ho ten: ");
                sv.NgaySinh = readDateTime("Ngay sinh (dd/MM/yyyy): ");
                sv.DiaChi = readString("Dia chi: ");
                sv.DienThoai = readString("So dien thoai: ");
                System.Console.WriteLine("Cap nhat thanh cong");
            }
        }
    }
}