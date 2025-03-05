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
        public int Adoszam { get; set; }
        public string UtcaNev { get;set; }
        public string Hazszam { get; set; }
        public string Adosav { get; set; }
        public int Alapterulet { get; set; }

        public static List<Építményadó> ReadFromJson(string forrás)
        {
            string jsonString = File.ReadAllText(forrás);
            return JsonSerializer.Deserialize<List<Építményadó>>(jsonString);
        }

    }
}
