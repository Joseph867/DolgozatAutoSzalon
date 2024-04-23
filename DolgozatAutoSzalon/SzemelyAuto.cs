using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DolgozatAutoSzalon
{
    internal class SzemelyAuto : Jarmu
    {
        public int UlesekSzama { get; set; }
        public double Fogyasztas { get; set; }

        public SzemelyAuto(string gyarto, string modell, int evjarat, int alapAr, int ulesekSzama, double fogyasztas) : base(gyarto, modell, evjarat, alapAr)
        {
            UlesekSzama = ulesekSzama;
            Fogyasztas = fogyasztas;
        }
        public void KenyelmiExtraBeszerzese()
        {
            AlapAr += 300000;
            Console.WriteLine("Kényelmi extrák beszerelve!");
        }

    }
}
