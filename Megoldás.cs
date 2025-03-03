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

        public string HolTalálható(int adószám)
        {
            string hely = "";
            bool van = false;
            foreach(var e in Epitmenyadok)
            {
                if (e.Adószám == adószám)
                {
                    hely += $"{e.UtcaNév} {e.Házszám}\t";
                    van = true ;
                }
                if (!van)
                {
                    hely = "Nem szerepel az adatállományban.";
                }
            }
            return hely;
        }



        public Megoldás(string forrás)
        {
            Epitmenyadok = Építményadó.ReadFromJson(forrás);
        }
    }
}

