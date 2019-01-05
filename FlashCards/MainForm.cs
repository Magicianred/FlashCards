/* Author       :   Mahasri Kalavala
 * Date         :   1/5/2019
 * Description  :   This application is written to help memorize many things
 *                  including languages, alphabets, words, formulas and more!
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace FlashCards
{
    public partial class MainForm : Form
    {
        private List<Topic> _data;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void RefreshData()
        {
            _data = Data.TheData.Topics();
            lstTopics.Items.Clear();

            if (_data != null)
            {
                foreach (Topic topic in _data)
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = topic.name;
                    lvi.SubItems.Add(topic.data.Count.ToString());
                    lvi.Tag = topic.name;
                    lstTopics.Items.Add(lvi);
                }
            }

            btnOpenFlashCards.Visible = lstTopics.SelectedItems.Count > 0;
            btnEditTopic.Visible = lstTopics.SelectedItems.Count > 0;
            btnDeleteTopic.Visible = lstTopics.SelectedItems.Count > 0;
            chkRandom.Visible = lstTopics.SelectedItems.Count > 0;
        }

        private void lstTopics_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnOpenFlashCards.Visible = lstTopics.SelectedItems.Count > 0;
            btnEditTopic.Visible = lstTopics.SelectedItems.Count > 0;
            btnDeleteTopic.Visible = lstTopics.SelectedItems.Count > 0;
            chkRandom.Visible = lstTopics.SelectedItems.Count > 0;
        }

        private void btnOpenFlashCards_Click(object sender, EventArgs e)
        {
            ShowFlashCardDialog();
        }

        private void lstTopics_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ShowFlashCardDialog();
        }

        private void ShowFlashCardDialog()
        {
            if (lstTopics.SelectedItems.Count == 0)
                return;

            this.Visible = false;
            FlashCardForm frm = new FlashCardForm(_data, 
                                    lstTopics.SelectedItems[0].Text, 
                                    chkRandom.Checked);
            frm.ShowDialog();
            this.Visible = true;
        }

        private void btnAddTopic_Click(object sender, EventArgs e)
        {
            TopicForm topic = new TopicForm(string.Empty, Common.FormMode.Add);
            DialogResult dr = topic.ShowDialog();
            if ( dr == DialogResult.OK)
            {
                bool retVal = Data.TheData.AddTopicByName(topic.TopicName, 
                                            topic.TopicUrl, 
                                            topic.TopicEntries);
                if (false == retVal)
                {
                    if ( _data == null)
                    {
                        new MyMessageBox(Constants.TITLE_ATTENTION,
                                     string.Format(Constants.TOPIC_ADD_FAILED, topic.TopicName),
                                     MessageBoxButtons.OK).ShowDialog();
                    }
                    else
                    {
                        new MyMessageBox(Constants.TITLE_ATTENTION,
                                     string.Format(Constants.TOPIC_EXISTS, topic.TopicName),
                                     MessageBoxButtons.OK).ShowDialog();
                    }
                }
            }
            RefreshData();
        }

        private void btnEditTopic_Click(object sender, EventArgs e)
        {
            string topicName = lstTopics.SelectedItems[0].Text;
            TopicForm tf = new TopicForm(topicName, Common.FormMode.Edit);
            DialogResult dr = tf.ShowDialog();
            if ( dr == DialogResult.OK)
            {
                Topic newTopic = new Topic();
                newTopic.data = tf.TopicEntries;
                newTopic.name = tf.TopicName;
                newTopic.url = tf.TopicUrl;

                Data.TheData.UpdateTopic(newTopic);
            }
            RefreshData();
        }

        private void btnDeleteTopic_Click(object sender, EventArgs e)
        {
            if (lstTopics.SelectedItems.Count == 0)
                return;

            string name = lstTopics.SelectedItems[0].Text;
            string msg = string.Format(Constants.MSG_CONFIRM_DELETE, name);
            DialogResult dr = new MyMessageBox(Constants.TITLE_CONFIRM_DELETE, 
                                               msg, 
                                               MessageBoxButtons.YesNo).ShowDialog();
            if ( dr == DialogResult.Yes)
            {
                Data.TheData.RemoveTopicByName(name);
                RefreshData();
            }
        }
    }
}