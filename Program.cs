using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace vernyomasnaplo
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Zádor Tamás része
            Console.Title = "Vérnyomásnapló projektmunka";
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine();
            Console.WriteLine("\t\t\tA projektmunkát készítette: | Zádor Tamás | Fehér Tamás | Bolgár Milán |");
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("A kezdéshez nyomj Entert");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("A kilépéshez nyomj X-et");
            Console.ReadLine();
            Console.Clear();

            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine();
            Console.WriteLine("\t\t\t\t\t\tVérnyomásnapló projektmunka");
            Console.WriteLine();
            Console.WriteLine(@"                                        |________|___________________|_
                                        |        | | | | | | | | | | | |________________
                                        |________|___________________|_|                ,
                                        |        |                   |                  ,");
            Console.WriteLine();

            //Input mezők megvalósítása
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Kérem adja meg a nevét");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            string nev = Console.ReadLine();
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Kérem adja meg az aktuális dátumot (ÉV.HÓNAP.NAP formátumban)");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            DateTime datum = DateTime.Parse(Console.ReadLine() + " " + DateTime.Now.ToString("HH:mm:ss"));
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Kérem adja meg a napszakot (reggel, dél, este)");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            string napszak = Console.ReadLine();
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Kérem adja meg a szisztolés vérnyomás értékét");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            int szisztoles = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Kérem adja meg a diasztolés vérnyomás értékét");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            int diasztoles = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Kérem adja meg a pulzusszám értékét:");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            int pulzusszam = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Adatok ELMENTVE!");
            Console.ResetColor();
            Console.WriteLine();

            //Listák létrehozása
            List<int> vAdatok = new List<int>();
            vAdatok.Add(szisztoles);
            List<int> vAdatok2 = new List<int>();
            vAdatok2.Add(diasztoles);
            List<int> vAdatok3 = new List<int>();
            vAdatok3.Add(pulzusszam);

            //Kiíratás a fájlba
            FileStream fajl = new FileStream("Összesítés.txt", FileMode.Create);
            StreamWriter kiiratas = new StreamWriter(fajl);
            kiiratas.WriteLine("MEGADOTT ADATOK:");
            kiiratas.WriteLine();
            kiiratas.WriteLine("| Név: {0} | Dátum: {1} | Napszak: {2} | Szisztolés: {3} | Diasztolés: {4} | Pulzusszám: {5} |", nev, datum, napszak, szisztoles, diasztoles, pulzusszam);
            kiiratas.Close();
            #endregion


            #region Fehér Tamás része

            #endregion
            int osszeg2 = 0;
            int osszeg3 = 0;
            int osszeg = 0;
            for (int i = 0; i < vAdatok.Count; i++)
            {
                osszeg += vAdatok[i];
                osszeg2 += vAdatok2[i];
                osszeg3 += vAdatok3[i];
            }
            int atlag = osszeg / vAdatok.Count;
            int atlag2 = osszeg2 / vAdatok.Count;
            int atlag3 = osszeg3 / vAdatok.Count;
            Console.WriteLine("Átlag vérnyomás:\t{0}\t{1}\t{2}", atlag, atlag2, atlag3);

            #region Bolgár Milán része

            #endregion

            Console.ReadLine();
        }
    }
}
