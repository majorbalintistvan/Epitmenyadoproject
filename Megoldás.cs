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



        public Megoldás(string forrás)
        {
            Epitmenyadok = Építményadó.ReadFromJson(forrás);
        }
    }
}

