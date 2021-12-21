using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class tekerlek2
    {
        public int TekerAdet { get; set; }
        public string TekerCinsi { get; set; }
    }
    class direksiyon2
    {
        public string direksiyonCinsi { get; set; }
    }
    class motor2
    {
        public int MotorBegirGücü { get; set; }
        public int MotorSilindirSayısı { get; set; }
        public string MotorMarkası{ get; set; }
    }
    class sase2
    {
        public string SaseCinsi { get; set; }
    }
    class govde2
    {
        public int GovdeKapiAdedi { get; set; }
        public string GovdeCinsi { get; set; }

    }


    class oto
    {
        tekerlek2[] tekeradet;

    }
}
