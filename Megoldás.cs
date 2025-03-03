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
        public List<Építményadó> epitmenyadok = new List<Építményadó>();
        
        public int TelkekSzáma => epitmenyadok.Count;

        public Megoldás(string forrás)
        {
            epitmenyadok = Építményadó.ReadFromJson(forrás);
        }
    }
}

