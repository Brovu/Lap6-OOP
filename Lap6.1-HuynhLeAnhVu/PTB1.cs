using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lap6._1_HuynhLeAnhVu
{
    public class PTB1
    {
        public double a, b;

        public PTB1(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public double GiaiPT()
        {
            if (a == 0)
            {
                throw new InvalidOperationException("Không phải phương trình bậc 1");
            }
            return -b / a;
        }
    }
}
