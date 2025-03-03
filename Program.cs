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
            Console.WriteLine(m);
            Console.WriteLine($"2.feladat: A mintában {m.TelkekSzáma} telek szerepel.");

            // A - 800, B - 600, C - 100
            Console.ReadKey();
        }
    }
}
