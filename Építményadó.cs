using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Newtonsoft.Json;
using System.IO;


namespace Epitmenyadoproject
{
    internal class Építményadó
    {
        public int Adószám { get; private set; }
        public string UtcaNév { get; private set; }
        public int Házszám { get; private set; }
        public string Adósáv { get; private set; }
        public int Alapterület { get; private set; }

        
        
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
        




    }
}
