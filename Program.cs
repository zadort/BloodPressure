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
            Console.Title = "Vérnyomásnapló";

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(@"                                |________|___________________|_
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
            Console.ForegroundColor = ConsoleColor.Cyan;
            int szisztoles = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Kérem adja meg a diasztolés vérnyomás értékét");
            Console.ForegroundColor = ConsoleColor.Cyan;
            int diasztoles = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Kérem adja meg a pulzusszám értékét:");
            Console.ForegroundColor = ConsoleColor.Cyan;
            int pulzusszam = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Adatok ELMENTVE!");
            Console.ResetColor();

            //Listák létrehozása
            List<int> vAdatok = new List<int>();
            vAdatok.Add(szisztoles);
            vAdatok.Add(diasztoles);
            vAdatok.Add(pulzusszam);

            //Kiíratás a fájlba
            FileStream fajl = new FileStream("Összesítés.txt", FileMode.Create);
            StreamWriter kiiratas = new StreamWriter(fajl);
            kiiratas.WriteLine("MEGADOTT ADATOK:");
            kiiratas.WriteLine();
            kiiratas.WriteLine("Név: {0} | Dátum: {1} | Napszak: {2} | Szisztolés: {3} | Diasztolés: {4} | Pulzusszám: {5}", nev, datum, napszak, szisztoles, diasztoles, pulzusszam);
            kiiratas.Close();
            #endregion


            #region Fehér Tamás része

            #endregion


            #region Bolgár Milán része

            #endregion

            Console.ReadLine();
        }
    }
}