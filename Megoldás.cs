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

       
       public List<Építményadó> epitmenyadok = new List<Építményadó>();
        
       public int TelkekSzáma => epitmenyadok.Count;

       public string GetAddressByAdoszam(int adoszam)
        {
            string result = "";
            foreach (var e in epitmenyadok) // conflict resolve-ban írtam át a kisbetűs listára
            {
                if (e.Adoszam == adoszam)
                {
                    result += $"Utca: {e.UtcaNev}, Házszám: {e.Hazszam}";
                }
            }
            return result;
        }


        public Építményadó Teszt
        {
            get
            {
                return epitmenyadok[1];
            }
        }


        public Megoldás(string forrás)
        {
            epitmenyadok = Építményadó.ReadFromJson(forrás);
        }
    }
}

