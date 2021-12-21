using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            //HASHTABLE

            Hashtable hash = new Hashtable();

            hash.Add(1, "Adana");
            hash.Add(34, "Istanbul");

            Console.WriteLine(hash[1]);
            Console.WriteLine(hash[34]);
            


        }
    }
}
