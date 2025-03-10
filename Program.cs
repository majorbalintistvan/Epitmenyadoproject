using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epitmenyadoproject
{
    internal class Program
    {
        static void Main()
        {
            string forras = "utca.json";
            Megold�s m = new Megold�s(forras);
          
            Console.WriteLine($"2.feladat. A mint�ban {m.TelkekSz�ma} telek szerepel.");

            Console.Write($"3. feladat. Egy tulajdonos ad�sz�ma:");
            int adoszam = int.Parse(Console.ReadLine());
            Console.Write(m.Lakc�mKeres�s(adoszam));

            Console.WriteLine($"\n5. feladat. {m.adooszz_kiir}");
            Console.WriteLine("6. feladat: A t�bb s�vba sorolt utc�k:");
            foreach (var utca in m.utcakTobbAdosavval)
            {
                Console.WriteLine(utca);
            }
            Console.WriteLine("7. feladat: Fizetend� ad�k tulajonk�nt (txt)");
            m.fizetendo_txt("fizetendo.txt");

            // A - 800, B - 600, C - 100

            Console.ReadKey();
        }
    }
}
