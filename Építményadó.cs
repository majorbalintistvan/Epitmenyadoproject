using System.Collections.Generic;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;


namespace Epitmenyadoproject
{
    internal class Építményadó
    {

        public int Adoszam { get; private set; }
        public string UtcaNev { get; private set; }
        public int Hazszam { get; private set; }
        public string Adosav { get; private set; }
        public int Alapterulet { get; private set; }

           

        public static List<Építményadó> ReadFromJson(string forrás)
        {
            string jsonString = File.ReadAllText(forrás);
            return JsonSerializer.Deserialize<List<Építményadó>>(jsonString);
        }

    }
}
