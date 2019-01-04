using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashCards
{
    public class Language
    {
        public string name;
        public Dictionary<string, string> alphabets;
    }

    class LanguageJsonData
    {
        public List<Language> languages;
    }

    class Data
    {
        public static LanguageJsonData LoadFile(string filePath)
        {
            if (!File.Exists(filePath)) return null;
            string json = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<LanguageJsonData>(json);
        }
    }
}