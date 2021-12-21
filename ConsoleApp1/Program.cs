using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Asker
    {
        int[] silahlar;
        public Asker(int adet)
        {
            silahlar = new int[adet];
        }
        //indexers(indeksleyiciler) herhangi bir sınıfın sanki bir diziymiş gibi kullanımıdır.this aslında bulunduğu classtan bahseder.
        public int this[int indis]
        {
            get { return silahlar[indis]; }
            set { silahlar[indis] = value; }
        }
        public int this[string indis]
        {
            get { return silahlar[0]; }
            set { silahlar[0] = value; }
        }
    }

    class deneme
    {
        int[,] dizi = new int[3, 3];
        int[] dizi2 = new int[9];
        public int this[int i]
        {
            get { return dizi2[i]; }
            set { dizi2[i] = value; }
        }
        public int this[int i, int j]
        {
            get { return dizi[i, j]; }
            set { dizi[i, j] = value; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //this 3. kullanımı
            Asker a = new Asker(10);

            a[0] = 1;
            a[1] = 2;

            deneme d = new deneme();

            d[0, 0] = 111;

            deneme d2 = new deneme();
            d2[0] = 12;




        }
    }
}
