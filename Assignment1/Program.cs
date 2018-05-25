using System;
using System.Collections.Generic;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {            
            List<SinhVien> list = new List<SinhVien>();
            int choice;
            bool c;
            while (true)
            {
                do
                {
                    System.Console.WriteLine("1. Xem danh sach sinh vien");
                    System.Console.WriteLine("2. Them sinh vien");
                    System.Console.WriteLine("3. Tim sinh vien");
                    System.Console.WriteLine("4. Cap nhat thong tin sinh vien");
                    System.Console.WriteLine("5. Thoat");
                    System.Console.Write("Your choice: ");
                    c = int.TryParse(Console.ReadLine(), out choice);
                    if (!c)
                    {
                        System.Console.WriteLine("Choice is a number");
                    } else if (choice < 1 || choice > 5)
                    {
                        System.Console.WriteLine("Choice is from 1 - 5");
                    }
                } while (choice < 1 || choice > 5 || !c);
                switch (choice)
                {
                    case 1:
                        list.XemDanhSachSinhVien();
                        break;

                    case 2:
                        list.ThemSinhVien();
                        break;

                    case 3:
                        list.TimSinhVien();
                        break;

                    case 4:
                        list.ChinhSuaSinhVien();
                        break;

                    case 5:
                        System.Console.WriteLine("Cam on ban da su dung he thong");
                        return;
                }
            }
        }
    }
}
