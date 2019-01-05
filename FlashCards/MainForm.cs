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
        private string _dataFilePath;
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
            if (!VerifyDataFile())
                return;

            _data = FlashCardDataManager.TheFlashCardDataManager.Topics();
            lstTopics.Items.Clear();

            if (_data == null)
            {
                MessageBox.Show("Unable to load the data file. Invalid or corrupted json file.\n\nApplication cannot proceed until the problem is fixed.", "Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.DialogResult = DialogResult.Abort;
                this.Close();
            }

            foreach (Topic topic in _data)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = topic.name;
                lvi.SubItems.Add(topic.data.Count.ToString());
                lvi.Tag = topic.name;
                lstTopics.Items.Add(lvi);
            }

            btnOpenFlashCards.Visible = lstTopics.SelectedItems.Count > 0;
            btnEditTopic.Visible = lstTopics.SelectedItems.Count > 0;
            btnDeleteTopic.Visible = lstTopics.SelectedItems.Count > 0;
        }

        private bool VerifyDataFile()
        {
            _dataFilePath = ConfigurationManager.AppSettings["topicFilePath"];
            if (null == _dataFilePath)
            {
                string msg = "The data file is required to run this application. Please make sure the file path is specified correctly in the FlashCards.exe.config file.";
                MessageBox.Show(msg, "Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return false;
            }

            if (!System.IO.File.Exists(_dataFilePath))
            {
                MessageBox.Show("File '" + _dataFilePath + "' does not exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
    
            return true;
        }

        private void lstTopics_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnOpenFlashCards.Visible = lstTopics.SelectedItems.Count > 0;
            btnEditTopic.Visible = lstTopics.SelectedItems.Count > 0;
            btnDeleteTopic.Visible = lstTopics.SelectedItems.Count > 0;
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
            FlashCardForm frm = new FlashCardForm(_data, lstTopics.SelectedItems[0].Text, chkRandom.Checked);
            frm.ShowDialog();
            this.Visible = true;
        }

        private void btnAddTopic_Click(object sender, EventArgs e)
        {
            TopicForm topic = new TopicForm(string.Empty, Common.FormMode.Add);
            DialogResult dr = topic.ShowDialog();
            if ( dr == DialogResult.OK)
            {
                FlashCardDataManager.TheFlashCardDataManager.AddTopicByName(topic.TopicName, topic.TopicUrl, topic.TopicEntries);
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

                FlashCardDataManager.TheFlashCardDataManager.UpdateTopic(newTopic);
            }
            RefreshData();
        }

        private void btnDeleteTopic_Click(object sender, EventArgs e)
        {
            if (lstTopics.SelectedItems.Count == 0)
                return;

            string name = lstTopics.SelectedItems[0].Text;
            string msg = string.Format("Are you sure, you want to delete the topic '{0}'?", name);
            DialogResult dr = MessageBox.Show(msg, "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if ( dr == DialogResult.Yes)
            {
                FlashCardDataManager.TheFlashCardDataManager.RemoveTopicByName(name);
                RefreshData();
            }
        }
    }
}