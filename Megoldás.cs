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

        public List<IGrouping<string, Építményadó>> teszt => epitmenyadok.GroupBy(x => x.UtcaNev).ToList();

        public List<string> utcakTobbAdosavval => epitmenyadok
       .GroupBy(x => x.UtcaNev)
       .Where(g => g.Select(x => x.Adosav).Distinct().Count() > 1)
       .Select(g => g.Key)
       .ToList();


        public string LakcímKeresés(int adoszam)
        {
            string lakcím = "";
            foreach (var e in epitmenyadok) // conflict resolve-ban írtam át a kisbetűs listára
            {
                if (e.Adoszam == adoszam)
                {
                    lakcím += $"{e.UtcaNev} utca {e.Hazszam}\n";
                }
                
            }
            if(lakcím == "")
            {
                lakcím = "Nem szerepel az adatállományban.";
            }
            return lakcím;
        }



        


        public Megoldás(string forrás)
        {
            epitmenyadok = Építményadó.ReadFromJson(forrás);
        }
    }
}

