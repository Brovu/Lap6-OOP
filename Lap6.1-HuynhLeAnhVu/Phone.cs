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
       public String branch;
       public int giaNhap;
       public String pic;

        public Phone() { }
        public Phone(string ID, string branch, int giaNhap, string pic)
        {
            this.ID = ID;
            this.branch = branch;
            this.giaNhap = giaNhap;
            this.pic = pic;
        }

        public double calculatePrice()
        {
            double giaBan;
           
            if(branch == "Iphone")
            {
                giaBan = 1.5 * giaNhap;
            } else {
                giaBan = 1.3 * giaNhap;
            }

            return giaBan;

        }

        public int CompareTo(Phone p)
        {
            return calculatePrice().CompareTo(p.calculatePrice()) * -1;
        }

       
    }
}
