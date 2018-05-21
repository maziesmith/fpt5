using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM_7
{
    class HinhChuNhat : HinhHoc
    {
        protected float mChieuDai;
        protected float mChieuRong;

        public HinhChuNhat()
        {
            mChieuDai = 4;
            mChieuRong = 2;
        }

        public HinhChuNhat(float chieuDai, float chieuRong)
        {
            mChieuDai = chieuDai;
            mChieuRong = chieuRong;
        }

        public void TinhChuViDienTich ()
        {
            mChuVi = (mChieuDai + mChieuRong) * 2;
            mDienTich = mChieuDai * mChieuRong;
        }

        public override void XemChuViDienTich()
        {
            Console.WriteLine("Thong tin hinh chu nhat");
            base.XemChuViDienTich();
        }
    }
}
