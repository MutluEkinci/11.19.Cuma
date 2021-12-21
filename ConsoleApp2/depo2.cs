using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class depo2
    {
        urun[] urunler;
        public depo2(int kapasite)
        {
            urunler = new urun[kapasite];
        }
        public urun this[int index]
        {
            get { return urunler[index]; }
            set { urunler[index] = value; }
        }
        public void EkranaYazdır()
        {
            foreach (urun urun in urunler)
                Console.WriteLine(urun.urunID +" " + urun.UrunAdi);
        }
    }
}
