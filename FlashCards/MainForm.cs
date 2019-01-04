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
        private TopicJsonData _data;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Start();
        }

        private void Start()
        {
            if (!VerifyDataFile())
                return;

            _data = Data.LoadFile(_dataFilePath);
            lstTopics.Items.Clear();

            foreach (Topic l in _data.topics)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = l.name;
                lvi.SubItems.Add(l.data.Count.ToString());
                lvi.Tag = l.name;
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
            TopicForm topic = new TopicForm(string.Empty, null, Common.FormMode.Add);
            if ( DialogResult.OK == topic.ShowDialog())
            {
                Start();
            }
        }

        private void btnEditTopic_Click(object sender, EventArgs e)
        {
            string topicName = lstTopics.SelectedItems[0].Text;
            TopicForm topic = new TopicForm(topicName, _data, Common.FormMode.Edit);
            if (DialogResult.OK == topic.ShowDialog())
            {
                Start();
            }
        }

        private void btnDeleteTopic_Click(object sender, EventArgs e)
        {

        }
    }
}