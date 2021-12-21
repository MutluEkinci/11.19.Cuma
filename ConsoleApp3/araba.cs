using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class motor
    {
        public short BegirGucu { get; set; }
        public byte SilindirSayisi { get; set; }
    }
    class Sase
    {
        public string SaseNo { get; set; }
    }
    class koltuk
    {
        public string Renk { get; set; }
        public string Materyal { get; set; }
    }
    class lastik
    {
        public string Tipi { get; set; }
    }
    class direksiyon
    {
        public string Tipi { get; set; }
    }
    class otomobil
    {
        public otomobil(int koltuksayisi)
        {
            koltuklar = new koltuk[koltuksayisi];
            lastikler = new lastik[5];
            InitializeDefault();
        }
        public otomobil(motor motor,int koltuksayisi)
        {
            motor = motor;
            koltuklar = new koltuk[koltuksayisi];
            lastikler = new lastik[5];
            InitializeDefault();
        }

        public motor motor { get; set; }
        public direksiyon direksiyon { get; set; }
        public Sase sase { get; set; }
        public koltuk[] koltuklar { get; set; }
        public lastik[] lastikler { get; set; }
        private void InitializeDefault()
        {
            motor = new motor() { BegirGucu = 450, SilindirSayisi = 6 };
            direksiyon = new direksiyon() { Tipi = "mekanik" };
            sase = new Sase() { SaseNo = "asdf8asd86fs" };
            int adet = koltuklar.Length;
            for (int i = 0; i < adet; i++)
                koltuklar[i] = new koltuk() { Renk = "siyah", Materyal = "deri" };
            for (int i = 0; i < lastikler.Length; i++)
                lastikler[i] = new lastik() { Tipi="yaz" };
        }
    }
}
