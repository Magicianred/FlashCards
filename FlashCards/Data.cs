/* Author       :   Mahasri Kalavala
 * Date         :   1/5/2019
 * Description  :   This application is written to help memorize many things
 *                  including languages, alphabets, words, formulas and more!
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace FlashCards
{
    public sealed class Data
    {

        private static TopicJsonData _data = null;
        private static string _flashcardFile = string.Empty;

        public static readonly Data TheData = new Data();

        private Data()
        {
            if (null == _data)
                LoadTopics();
        }

        private void LoadTopics()
        {
            _flashcardFile = Common.DataFilePath;

            if (Persistence.FileExists(_flashcardFile))
            {
                _data = Persistence.LoadFile(_flashcardFile);
                if (_data == null)
                {
                    new MyMessageBox(Constants.TITLE_ATTENTION,
                                     string.Format(Constants.ERROR_LOADING_DATA, _flashcardFile),
                                     System.Windows.Forms.MessageBoxButtons.OK).ShowDialog();
                }
            }
            else
            {
                _data = new TopicJsonData();
                SaveTopics();
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

        public Topic GetTopicByName(string name)
        {
            if (_data == null || _data.topics == null)
                return null;

            Topic retVal = _data.topics.Find(delegate (Topic dto) {
                return dto.name == name;
            });
            return retVal;
        }

        public bool AddTopicByName(string name, string url, Dictionary<string, string> items)
        {
            if (_data == null)
                return false;

            Topic retVal = GetTopicByName(name);
            if (null == retVal)
            {
                Topic newTopic = new Topic();
                newTopic.name = name;
                newTopic.url = url;
                newTopic.data = items;
                if (_data.topics == null)
                    _data.topics = new List<Topic>(4);
                _data.topics.Add(newTopic);

                SaveTopics();
                return true;
            }
            return false;
        }

        public bool UpdateTopic(Topic topic)
        {
            if (_data == null || _data.topics == null)
                return false;

            if (null != topic)
            {
                Topic t = GetTopicByName(topic.name);
                if ( null != t)
                    _data.topics.Remove(t);
            }

            Topic newTopic = new Topic();
            newTopic.name = topic.name;
            newTopic.url = topic.url;
            newTopic.data = topic.data;

            _data.topics.Add(newTopic);
            SaveTopics();
            return true;
        }
    }
}