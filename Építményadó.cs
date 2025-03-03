using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

using System.IO;
using System.Text.Json;


namespace Epitmenyadoproject
{
    internal class Építményadó
    {
        public int Adoszam { get; set; }
        public string UtcaNev { get; set; }
        public string Hazszam { get; set; }
        public string Adosav { get; set; }
        public int AlapT { get; set; }
        
        public static List<Építményadó> ReadFromJson(string forrás)
        {
            string jsonString = File.ReadAllText(forrás);
            return JsonSerializer.Deserialize<List<Építményadó>>(jsonString);
        }

    }
}
