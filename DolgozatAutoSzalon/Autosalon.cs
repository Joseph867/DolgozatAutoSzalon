using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DolgozatAutoSzalon
{
    internal class Autosalon
    {
        private List<Jarmu> jarmuvek = new List<Jarmu>();

        public void JarmuvekHozzaadasa(Jarmu jarmu)
        {
            jarmuvek.Add(jarmu);
        }

        public void JarmuvekListazasa()
        {
            foreach (var jarmu in jarmuvek)
            {
                jarmu.JarmuInfo();
            }
        }

        public void JarmuvekArKalkulacio()
        {
            foreach (var jarmu in jarmuvek)
            {
                jarmu.ArKalkulacio();
            }
        }
        public void JarmuEladasa(string gyarto, string modell)
        {
            Jarmu jarmu = jarmuvek.Find(x => x.Gyarto == gyarto && x.Modell == modell);
            if (jarmu != null)
            {
                jarmuvek.Remove(jarmu);
                Console.WriteLine("Az autó eladva!");
            }
            else
            {
                Console.WriteLine("Nincs ilyen autó az adatbázisban!");
            }
        }
    }
}
