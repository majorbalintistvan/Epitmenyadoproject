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

        public int Adoszam { get; private set; }
        public string UtcaNev { get; private set; }
        public int Hazszam { get; private set; }
        public string Adosav { get; private set; }
        public int Alapterulet { get; private set; }

            public static List<Építményadó> ReadFromJson(string forrás)
            {
                try
                {
                    string jsonString = File.ReadAllText(forrás);
                    return JsonConvert.DeserializeObject<List<Építményadó>>(jsonString);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error reading JSON file: {ex.Message}");
                    return new List<Építményadó>();
                }
            }

        public static List<Építményadó> ReadFromJson(string forrás)
        {
            string jsonString = File.ReadAllText(forrás);
            return JsonSerializer.Deserialize<List<Építményadó>>(jsonString);
        }

    }
}
