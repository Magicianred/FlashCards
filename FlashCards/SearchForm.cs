using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlashCards
{
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text.Trim() == string.Empty)
                return;

            lstSearchResults.Items.Clear();
            foreach (Topic topic in Data.TheData.Topics())
            {
                List<string> keys = null;
                if ( chkIgnoreCase.Checked)
                    keys = topic.data.Where(kvp => kvp.Value.ToLower().Contains(txtSearch.Text.ToLower())).Select(kvp => kvp.Key).ToList();
                else
                    keys = topic.data.Where(kvp => kvp.Value.Contains(txtSearch.Text)).Select(kvp => kvp.Key).ToList();

                if (keys.Count > 0)
                {
                    foreach ( string key in keys )
                    {
                        ListViewItem lvi = new ListViewItem();
                        lvi.Text = topic.name;
                        lvi.SubItems.Add(key);
                        lvi.SubItems.Add(topic.data[key]);
                        lstSearchResults.Items.Add(lvi);
                        lvi.Tag = key + "|" + topic.data[key];
                    }
                }
            }
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            txtSearch.Focus();
        }

        private void lstSearchResults_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (lstSearchResults.FocusedItem.Bounds.Contains(e.Location))
                {
                    contextMenuStrip1.Show(Cursor.Position);
                }
            }
        }

        private void mnuOpenTopic_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            string topicName = lstSearchResults.SelectedItems[0].Text;
            TopicForm tf = new TopicForm(topicName, Common.FormMode.Edit);
            DialogResult dr = tf.ShowDialog();
            if (dr == DialogResult.OK)
            {
                Topic newTopic = new Topic();
                newTopic.data = tf.TopicEntries;
                newTopic.name = tf.TopicName;
                newTopic.url = tf.TopicUrl;

                Data.TheData.UpdateTopic(newTopic);
            }
            this.Visible = true;
        }

        private void mnuCopyKey_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(lstSearchResults.SelectedItems[0].Tag.ToString().Split('|')[0]);
        }

        private void mnuCopyValue_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(lstSearchResults.SelectedItems[0].Tag.ToString().Split('|')[1]);
        }

        private void mnuCopyRow_Click(object sender, EventArgs e)
        {
            string topic = lstSearchResults.SelectedItems[0].Text;
            string key = lstSearchResults.SelectedItems[0].Tag.ToString().Split('|')[0];
            string value = lstSearchResults.SelectedItems[0].Tag.ToString().Split('|')[1];
            string text = string.Format("{0} - {1} - {2} ", topic, key, value);
            Clipboard.SetText(text);
        }
    }
}