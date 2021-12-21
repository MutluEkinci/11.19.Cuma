using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //soru1:ındexleyici kullanarak,boyutu belirlenmiş olan bir depoya o kadar urun objesini atayınız.
            depo2 depo2 = new depo2(10);

            for (int i = 0; i < 10; i++)
                depo2[i] = new urun { urunID = i, UrunAdi = "urun" +" "+ i };

            depo2.EkranaYazdır();




        }
    }
}
