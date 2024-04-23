using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DolgozatAutoSzalon
{
    internal class Jarmu
    {
        public string Gyarto { get; set; } 
        public string Modell { get; set; }
        public int Evjarat { get; set; }
        public int AlapAr { get; set; }

        public Jarmu(string gyarto, string modell, int evjarat, int alapAr)
        {
            Gyarto = gyarto;
            Modell = modell;
            Evjarat = evjarat;
            AlapAr = alapAr;
        }
        public void JarmuInfo()
        {
            Console.WriteLine($"Gyartó: {Gyarto}, Modell: {Modell}, Évjárat: {Evjarat}");
        }
        public void ArKalkulacio()
        {
            int aktualisEv = DateTime.Now.Year;
            int kor = aktualisEv - Evjarat;
            int ar = AlapAr;
            if (kor < 5)
            {
                ar = AlapAr;
            }
            else if (kor >= 5 && kor < 10)
            {
                ar = (int)(AlapAr * 0.8);
            }
            else if (kor >= 10 && kor < 15)
            {
                ar = (int)(AlapAr * 0.6);
            }
            else if (kor >= 15 && kor < 20)
            {
                ar = (int)(AlapAr * 0.4);
            }
            else if (kor >= 20)
            {
                ar = (int)(AlapAr * 0.2);
            }
            Console.WriteLine($"Az autó ára: {ar} Ft");
        }   
    }
}
