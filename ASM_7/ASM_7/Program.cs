using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM_7
{
    class Program
    {
        static void Main(string[] args)
        {
            HinhChuNhat hcn = new HinhChuNhat(8, 12);
            hcn.TinhChuViDienTich();
            hcn.XemChuViDienTich();

            HinhTron ht = new HinhTron(3);
            ht.TinhChuViDienTich();
            ht.XemChuViDienTich();

            Console.WriteLine("Su dung tinh da hinh");
            HinhHoc[] hinhList = new HinhHoc[2];
            hinhList[0] = hcn;
            hinhList[1] = ht;
            foreach (var hinh in hinhList)
            {
                hinh.XemChuViDienTich();
            }
        }
    }
}
