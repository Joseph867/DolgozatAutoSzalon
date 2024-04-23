using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DolgozatAutoSzalon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SzemelyAuto auto1 = new SzemelyAuto("Toyota", "Corolla", 2021, 8000000, 5, 6.5);
            Terepjaro auto2 = new Terepjaro("Land Rover", "Defender", 2020, 15000000, "4WD", true);

            Autosalon autosalon = new Autosalon();
            autosalon.JarmuvekHozzaadasa(auto1);
            autosalon.JarmuvekHozzaadasa(auto2);

            Console.WriteLine("Szalonban lévő autók:");
            autosalon.JarmuvekListazasa();
        }
    }
}
