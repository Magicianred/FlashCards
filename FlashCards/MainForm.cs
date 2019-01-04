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
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            string path = ConfigurationManager.AppSettings["topicFilePath"];
            TopicJsonData jap = Data.LoadFile(path);
            lstTopics.Items.Clear();

            foreach (Topic l in jap.topics)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = l.name;
                lvi.SubItems.Add(l.data.Count.ToString());
                lvi.Tag = l.name;
                lstTopics.Items.Add(lvi);
            }
            btnOpenFlashCards.Visible = false;
        }

        private void lstTopics_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnOpenFlashCards.Visible = lstTopics.SelectedItems.Count > 0;
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
            FlashCardForm frm = new FlashCardForm(lstTopics.SelectedItems[0].Text, chkRandom.Checked);
            frm.ShowDialog();
            this.Visible = true;
        }
    }
}