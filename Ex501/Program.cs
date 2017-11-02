using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex501
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Temperatura> temperatury = new List<Temperatura>();
            temperatury.Add(new Temperatura(45.2));
            temperatury.Add(new Temperatura(-12.3));
            temperatury.Add(new Temperatura(0));
            temperatury.Sort();
        }
    }
}
