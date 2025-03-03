using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;


namespace Epitmenyadoproject
{
    internal class Megoldás
    {
        public List<Építményadó> Epitmenyadok { get; private set; }

        

        public string GetAddressByAdoszam(int adoszam)
        {
            foreach (var e in Epitmenyadok)
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
            Epitmenyadok = Építményadó.ReadFromJson(forrás);
        }
    }
}

