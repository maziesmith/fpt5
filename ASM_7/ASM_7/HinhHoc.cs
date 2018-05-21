using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM_7
{
    class HinhHoc
    {
        protected float mChuVi;
        protected float mDienTich;

        public virtual void XemChuViDienTich()
        {
            Console.WriteLine("Chu vi = {0}, Dien tich = {1}", mChuVi, mDienTich);
        }
    }
}
