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
            Megoldás m = new Megoldás(forras);
            Console.WriteLine($"2.feladat. A mintában {m.TelkekSzáma} telek szerepel.");
            Console.Write($"3. feladat. Egy tulajdonos adószáma:");
            int adoszam = int.Parse(Console.ReadLine());
            Console.Write(m.LakcímKeresés(adoszam));
            Console.WriteLine($"\n5. feladat. {m.adooszz_kiir}");
            Console.WriteLine("6. feladat: A több sávba sorolt utcák:");
            foreach (var utca in m.utcakTobbAdosavval)
            {
                Console.WriteLine(utca);
            }
            Console.WriteLine("7. feladat: Fizetendõ adók tulajonként (json)");
            m.fizetendo_json("fizetendo.json");
            Console.ReadKey();
        }
    }
}
