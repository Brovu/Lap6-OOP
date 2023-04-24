using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lap6._1_HuynhLeAnhVu
{
    public class PTB2 : PTB1
    {
        public double c;

        public PTB2(double a, double b, double c) : base(a, b)
        {
            this.c = c;
        }

        public new Tuple<double, double> GiaiPT()
        {
            if (a == 0)
            {
                throw new InvalidOperationException("Không phải phương trình bậc 2");
            }

            double delta = b * b - 4 * a * c;

            if (delta < 0)
            {
                throw new InvalidOperationException("Vo nghiem");
            }
            else if (delta == 0)
            {
                double x = -b / (2 * a);
                return Tuple.Create(x, x);
            }
            else
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                return Tuple.Create(x1, x2);
            }
        }
    }
}
