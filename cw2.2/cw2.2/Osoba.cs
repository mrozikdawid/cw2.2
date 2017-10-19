using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw2._2
{
    class Osoba
    {
        public string imie;
        public string nazwisko;
        public int rokUrodzenia;
        public int waga;
        public int wzrost;
        public bool okulary;
        public string plec;

        public void ObliczWiek()
        {
            Console.WriteLine((DateTime.Now.Year) - rokUrodzenia);
        }

        public void WypiszInfo()
        {
            if (plec == "K")
            {
                Console.WriteLine("Dyrektorem jest Pani {0} {1} ",imie,nazwisko);
            }
            else if (plec == "M")
            {
                Console.WriteLine("Dyrektorem jest Pan {0} {1} ", imie, nazwisko);
            }

        }

    }
}
