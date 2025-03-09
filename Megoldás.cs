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
        private Dictionary<string, int> adosavok = new Dictionary<string, int> {{"A",800},{"B",600},{"C",100}};

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
        public int ado(string adosav, int alapterület)
        {
            int fizetendo_ado= adosavok[adosav]*alapterület;
            return fizetendo_ado>=10000? fizetendo_ado : 0;
        }
        private SortedDictionary<string,(int, int)> adoosszegzes
        {
            get
            {
                SortedDictionary<string, (int darab, int osszeg)> stat = new SortedDictionary<string, (int darab, int osszeg)>();
                foreach (var e in epitmenyadok)
                {
                    int f_ado = ado(e.Adosav, e.AlapT);
                    if (stat.ContainsKey(e.Adosav))
                    {
                        stat[e.Adosav] = (stat[e.Adosav].darab + 1, stat[e.Adosav].osszeg + f_ado);
                    }
                    else stat.Add(e.Adosav, (1, f_ado));
                }
                return stat;
            }
        }
        public string adooszz_kiir
        {
            get 
            {
                string válasz = string.Empty;
                SortedDictionary<string, (int darab,int osszeg)> statisztika=adoosszegzes;
                foreach (var item in statisztika)
                {
                    válasz += $"\n{item.Key} sávba {item.Value.darab} telek esik, az adó {item.Value.osszeg} Ft.";
                }
                return válasz;
            }
        }

        public HashSet<string> fizetendo_adok
        {
            get
            {
                HashSet<string> adatok = new HashSet<string>();
                foreach(var e in epitmenyadok)
                {
                    adatok.Add($"{e.Adoszam} {ado(e.Adosav, e.AlapT)}") ;
                }
                return adatok;
            }
        }

        public void fizetendo_txt(string allomany)
        {
            File.WriteAllLines(allomany, fizetendo_adok);
        }

        public Megoldás(string forrás)
        {
            epitmenyadok = Építményadó.ReadFromJson(forrás);
        }
    }
}

