using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Epitmenyadoproject
{
    internal class Megoldás
    {

       public List<Építményadó> Epitmenyadok { get; private set; } // később törölhető, ha nem kell
       public List<Építményadó> epitmenyadok = new List<Építményadó>();
        
       public int TelkekSzáma => epitmenyadok.Count;

       public string GetAddressByAdoszam(int adoszam)
        {
            foreach (var e in epitmenyadok) // conflict resolve-ban írtam át a kisbetűs listára
            {
                if (e.Adoszam == adoszam)
                {
                    return $"Utca: {e.UtcaNev}, Házszám: {e.Hazszam}";
                }
            }
            return "Nem szerepel az adatállományban.";
        }


        public Megoldás(string forrás)
        {
            epitmenyadok = Építményadó.ReadFromJson(forrás);
        }
    }
}

