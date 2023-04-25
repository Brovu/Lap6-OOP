using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lap6._1_HuynhLeAnhVu
{
    public class Phone: IComparable<Phone>
    {
       public String ID;
       public String brand;
       public int giaNhap;
       public String pic;

        public Phone() { }
        public Phone(string ID, string brand, int giaNhap, string pic)
        {
            this.ID = ID;
            this.brand = brand;
            this.giaNhap = giaNhap;
            this.pic = pic;
        }

        public double calculatePrice()
        {
            double giaBan;
           
            if(brand == "Iphone")
            {
                giaBan = 1.5 * giaNhap;
            } else {
                giaBan = 1.3 * giaNhap;
            }

            return giaBan;

        }

        public int CompareTo(Phone p)
        {
            return giaNhap.CompareTo(p.giaNhap) * -1;
        }

       
    }
}
