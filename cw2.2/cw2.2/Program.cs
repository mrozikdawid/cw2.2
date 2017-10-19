using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Osoba dyrektor = new Osoba();
            dyrektor.imie = "janusz";
            dyrektor.nazwisko = "KOwalski";
            dyrektor.rokUrodzenia = 1964;
            dyrektor.plec = "M";
            dyrektor.ObliczWiek();
            dyrektor.WypiszInfo();

            Console.ReadKey();
        }
    }
}
