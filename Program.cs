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

            // A - 800, B - 600, C - 100
            Console.ReadKey();
        }
    }
}
