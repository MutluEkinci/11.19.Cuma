using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //soru2:bir otomobili genel parçalarını düşünerek modelleyiniz(class olarak).
            otomobil otomobil = new otomobil(2);

            motor m = new motor() { BegirGucu = 600, SilindirSayisi = 8 };

            otomobil oto2 = new otomobil(m, 2);



        }
    }
}
