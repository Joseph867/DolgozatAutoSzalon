using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DolgozatAutoSzalon
{
    internal class Terepjaro : Jarmu
    {
        public string Hajtas { get; set; }
        public bool OffRoadKepesseg { get; set; }

        public Terepjaro(string gyarto, string modell, int evjarat, int alapAr, string hajtas, bool offRoadKepesseg) : base(gyarto, modell, evjarat, alapAr)
        {
            Hajtas = hajtas;
            OffRoadKepesseg = offRoadKepesseg;
        }
        public void OffRoadCsomagFelszerel() 
        {            
            if (OffRoadKepesseg == false)
            {
                OffRoadKepesseg = true;
                AlapAr += 500000;
                Console.WriteLine("Off-road csomag felszerelve!");
            }
            else
            {
                Console.WriteLine("Az off-road csomag már felszerelve van!");
            }
        }
    }
}
