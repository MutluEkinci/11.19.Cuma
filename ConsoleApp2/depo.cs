using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class depo //% 70 doğru
    {
        int boyut = 5;
        public depo(int obje = 5)
        {
            boyut = obje;
        }
        public int this[int indis]
        {
            get { return boyut = 5; }
            set { boyut = value; }
        }

    }
}
