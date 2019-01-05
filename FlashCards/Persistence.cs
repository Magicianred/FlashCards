/* Author       :   Mahasri Kalavala
 * Date         :   1/5/2019
 * Description  :   This application is written to help memorize many things
 *                  including languages, alphabets, words, formulas and more!
 */
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

    public class TopicComparer : IEqualityComparer<Topic>
    {
        public bool Equals(Topic x, Topic y)
        {
            return (x.name == y.name) ? true : false;
        }

        public int GetHashCode(Topic obj)
        {
            return base.GetHashCode();
        }
    }

    public class TopicJsonData
    {
        public List<Topic> topics;
    }

    public class Persistence
    {
        public static TopicJsonData LoadFile(string filePath)
        {
            if (!File.Exists(filePath))
                return null;

            string json = File.ReadAllText(filePath);
            TopicJsonData retVal = null;

            try
            {
                retVal = JsonConvert.DeserializeObject<TopicJsonData>(json);
                return retVal;
            }
            catch
            {
                return null;
            }
        }

        public static void SaveFile(TopicJsonData data, string filePath)
        {
            string json = JsonConvert.SerializeObject(data, Formatting.Indented);
            File.WriteAllText(filePath, json);
        }

        public static bool FileExists(string filePath)
        {
            return File.Exists(filePath);
        }
    }
}