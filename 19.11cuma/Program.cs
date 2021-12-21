using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19._11cuma
{
    class kitap
    {
        private int id;
        public kitap()
        {

        }
        public kitap(int id)
        {
            // id = id;
            this.id = id;
            //sııfı id isimli uyesi...
        }
        public int KitapID
        {
            get { return id; }
            set { id = value; }
        }
        public string KitapAdi { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //this 2. kullanmı

        }
    }
}
