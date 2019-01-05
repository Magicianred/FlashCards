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

namespace FlashCards
{
    public partial class TopicForm : Form
    {
        private List<Topic> _data = null;
        private string _topicName = string.Empty;
        private Common.FormMode _mode;

        public string TopicName { get; set; }
        public string TopicUrl { get; set; }
        public Dictionary<string, string> TopicEntries { get; set; }
        public TopicForm(string topic, Common.FormMode mode)
        {
            this._topicName = topic;
            this._mode = mode;
            TopicEntries = new Dictionary<string, string>(0);
            InitializeComponent();
        }

        private void TopicForm_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void RefreshData()
        {
            _data = _data = Data.TheData.Topics();
            if (_mode == Common.FormMode.Edit)
            {
                lstData.Items.Clear();
                foreach (Topic t in _data)
                {
                    if (t.name == _topicName)
                    {
                        txtName.Text = t.name;
                        txtUrl.Text = t.url;
                        
                        foreach (var x in t.data)
                        {
                            ListViewItem lvi = new ListViewItem();
                            lvi.Text = x.Key;
                            lvi.SubItems.Add(x.Value);
                            lvi.Tag = x.Value;
                            lstData.Items.Add(lvi);
                        }
                    }
                }
            }

            btnEdit.Visible = lstData.SelectedItems.Count > 0;
            btnDelete.Visible = lstData.SelectedItems.Count > 0;
        }

        private void lstData_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnEdit.Visible = lstData.SelectedItems.Count > 0;
            btnDelete.Visible = lstData.SelectedItems.Count > 0;
        }

        private void lstData_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lstData.SelectedItems.Count == 0)
                return;

            CardForm df = new CardForm(Common.FormMode.Edit, 
                                       lstData.SelectedItems[0].Text,
                                       (string)lstData.SelectedItems[0].Tag);
            df.ShowDialog();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if ( txtName.Text == string.Empty || txtUrl.Text == string.Empty)
            {
                new MyMessageBox(Constants.TITLE_MISSINGDATA,
                                 Constants.MSG_REQUIRED_DATA, 
                                 MessageBoxButtons.OK);
                return;
            }

            this.TopicName = txtName.Text;
            this.TopicUrl = txtUrl.Text;

            foreach (ListViewItem lvi in lstData.Items)
            {
                if (!this.TopicEntries.ContainsKey(lvi.Text))
                {
                    this.TopicEntries.Add(lvi.Text, (string)lvi.Tag);
                }
            }

            if (lstData.Items.Count == 0)
            {
                // add an empty dictionary item
                this.TopicEntries = new Dictionary<string, string>(0);
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lstData.SelectedItems.Count == 0)
                return;

            CardForm cf = new CardForm(Common.FormMode.Edit, 
                                       lstData.SelectedItems[0].Text,
                                       (string)lstData.SelectedItems[0].Tag);
            DialogResult dr = cf.ShowDialog();
            if (dr == DialogResult.OK)
            {
                Data.TheData.UpdateTopicDataByName(_topicName, cf.Key, cf.Value);
                RefreshData();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CardForm cf = new CardForm(Common.FormMode.Add, 
                                       string.Empty, 
                                       string.Empty);
            DialogResult dr = cf.ShowDialog();
            if (dr == DialogResult.OK)
            {
                TopicEntries.Add(cf.Key, cf.Value);
                ListViewItem lvi = new ListViewItem();
                lvi.Text = cf.Key;
                lvi.SubItems.Add(cf.Value);
                lvi.Tag = cf.Value;
                lstData.Items.Add(lvi);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstData.SelectedItems.Count == 0)
                return;

            string itemKey = lstData.SelectedItems[0].Text;
            DialogResult dr = new MyMessageBox(Constants.TITLE_CONFIRM_DELETE,
                                               string.Format(Constants.MSG_CONFIRM_DELETE, itemKey), 
                                               MessageBoxButtons.YesNo).ShowDialog();
            if (dr == DialogResult.Yes)
            {
                Data.TheData.RemoveTopicDataByName(_topicName, itemKey);
                RefreshData();
            }
        }
    }
}