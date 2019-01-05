using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace FlashCards
{
    public sealed class FlashCardDataManager
    {

        private static TopicJsonData _data = null;
        private static string _flashcardFile = string.Empty;

        public static readonly FlashCardDataManager TheFlashCardDataManager = new FlashCardDataManager();

        private FlashCardDataManager()
        {
            if (null == _data)
                LoadTopics();
        }

        private void LoadTopics()
        {
            try
            {
                _flashcardFile = ConfigurationManager.AppSettings["topicFilePath"];

                if (Persistence.FileExists(_flashcardFile))
                {
                    _data = Persistence.LoadFile(_flashcardFile);
                }
                else
                {
                    _data = new TopicJsonData();
                    SaveTopics();
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error loading file!", e);
            }
        }

        public void SaveTopics()
        {
            Persistence.SaveFile(_data, _flashcardFile);
        }

        public List<Topic> Topics()
        {
            if (_data == null)
                return null;
            return _data.topics;
        }

        public void RemoveTopicByName(string name)
        {
            if (_data == null)
                return;

            Topic topic = GetTopicByName(name);
            if (null != topic)
            {
                _data.topics.Remove(topic);
                SaveTopics();
            }
        }

        public void RemoveTopicDataByName(string topic, string name)
        {
            if (_data == null)
                return;

            Topic t = GetTopicByName(topic);
            if (null != t)
            {
                t.data.Remove(name);
                SaveTopics();
            }
        }

        public void UpdateTopicDataByName(string topic, string key, string value)
        {
            if (_data == null)
                return;

            Topic t = GetTopicByName(topic);
            if (null != t)
            {
                t.data.Remove(key);
                t.data.Add(key, value);
                SaveTopics();
            }
        }

        public bool AddTopicDataByName(string topic, string key, string value)
        {
            if (_data == null)
                return false;

            Topic t = GetTopicByName(topic);
            if (null != t)
            {
                if (!t.data.ContainsKey(key))
                {
                    t.data.Add(key, value);
                    SaveTopics();
                    return true;
                }

                return false;
            }
            return false;
        }

        public Topic GetTopicByName(string name)
        {
            if (_data == null)
                return null;

            Topic retVal = _data.topics.Find(delegate (Topic dto) {
                return dto.name == name;
            });
            return retVal;
        }

        public void AddTopicByName(string name, string url, Dictionary<string, string> items)
        {
            if (_data == null)
                return;

            Topic retVal = GetTopicByName(name);
            if (null == retVal)
            {
                Topic newTopic = new Topic();
                newTopic.name = name;
                newTopic.url = url;
                newTopic.data = items;
                _data.topics.Add(newTopic);

                SaveTopics();
            }
            return;
        }

        public void UpdateTopic(Topic topic)
        {
            if (null != topic)
            {
                Topic t = GetTopicByName(topic.name);
                _data.topics.Remove(t);
            }

            Topic newTopic = new Topic();
            newTopic.name = topic.name;
            newTopic.url = topic.url;
            newTopic.data = topic.data;

            _data.topics.Add(newTopic);
            SaveTopics();
        }
    }
}