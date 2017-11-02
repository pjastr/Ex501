using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex501
{
    class Temperatura:IComparable<Temperatura>
    {
        private double wartosc;

        public Temperatura(double wart)
        {
            this.wartosc = wart;
        }

        public int CompareTo(Temperatura other)
        {
            if (other.wartosc > this.wartosc)
            {
                return 1;
            }
            else if (other.wartosc == this.wartosc)
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }
    }
}
