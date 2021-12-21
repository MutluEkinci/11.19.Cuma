using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Koleksiyonlar(collections): IEnumareble arayüzünü uygulamış olan sınıflara collections denir.Boyutları runtimeda değişir.4 farklı çalışma prensibi-mekanizması vardır.Genelde iki farklı şekilde çalışma mekanizması karşımıza çıkar.

            //Normal collections ve Generic collections(daha sonra görücez ve bunu kullannamız tavsiye ediliyor.).

            //NORMAL COLLECTIONS                Generic collections  *****
            //1-ArrayList                       List<T>
            //2-Stack(LIFO)                     Stack<T>
            //3-Queue(FIFO)                     Queue<T>
            //4-Hashtable       (key,value)     Dictionery<T,U>
            //5-Sortedlist      (key,value)     Sortedlist<T,U>

            //ARRAYLİST


            ArrayList list = new ArrayList();
            //for (int i = 0; i < 25; i++)
            //list.Add(12);   Teker teker atmak için add;toplu yani dizi şeklinde eklemek için addrange.
            int[] sayilar = { 1, 2, 3, 4,5,6,7,8};
            list.AddRange(sayilar);
            list.Contains(12);
            //list.Remove(1);
            //list.RemoveAt(1); //indisini verip sildiriyoruz.
            //list.Reverse();
            //list.Sort();  //sıralama yapar.
            list.Add("ankara");
            Console.WriteLine($"Kapasite={list.Capacity} Adet={list.Count}");

            list.InsertRange(5, sayilar);

            list[0] = "istanbul";
            Console.WriteLine(list[0]);
            Console.WriteLine("------");

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }


        }
    }
}
