using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM_7
{
    class HinhTron : HinhHoc
    {
        private float mBanKinh;

        public HinhTron()
        {
            mBanKinh = 0;
        }

        public HinhTron(float banKinh)
        {
            mBanKinh = banKinh;
        }

        public void TinhChuViDienTich()
        {
            mChuVi = (float)(Math.PI * 2 * mBanKinh);
            mDienTich = (float)(Math.PI * mBanKinh * mBanKinh);
        }

        public override void XemChuViDienTich()
        {
            Console.WriteLine("Thong tin hinh tron");
            base.XemChuViDienTich();
        }
    }
}
