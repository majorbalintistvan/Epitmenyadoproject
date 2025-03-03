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
            Console.Write(m);

            Console.Write($"3. feladat. Egy tulajdonos adószáma: ");
            int adószám = int.Parse(Console.ReadLine());
            Console.WriteLine(m.HolTalálható(adószám)); 




            // A - 800, B - 600, C - 100
            Console.ReadKey();
        }
    }
}
