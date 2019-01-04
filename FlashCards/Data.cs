using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashCards
{
    public class Topic
    {
        public string name;
        public string url;
        public Dictionary<string, string> data;
    }

    public class TopicJsonData
    {
        public List<Topic> topics;
    }

    class Data
    {
        public static TopicJsonData LoadFile(string filePath)
        {
            if (!File.Exists(filePath)) return null;
            string json = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<TopicJsonData>(json);
        }
    }
}