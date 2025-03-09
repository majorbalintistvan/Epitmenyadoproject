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
            string forrás = "utca.json";
            Megoldás m = new Megoldás(forrás);
          
            Console.WriteLine($"2.feladat. A mintában {m.TelkekSzáma} telek szerepel.");

            Console.Write($"3. feladat. Egy tulajdonos adószáma:");
            int adoszam = int.Parse(Console.ReadLine());
            Console.Write(m.LakcímKeresés(adoszam));

            Console.WriteLine($"\n5. feladat. {m.adooszz_kiir}");
            Console.WriteLine("6. feladat: A t�bb s�vba sorolt utc�k:");
            foreach (var utca in m.utcakTobbAdosavval)
            {
                Console.WriteLine(utca);
            }
            Console.WriteLine("7. feladat: Fizetendő adó tulajonként (txt)");
            m.fizetendo_txt("fizetendo.txt");

            // A - 800, B - 600, C - 100

            Console.ReadKey();
        }
    }
}
