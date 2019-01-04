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
        private TopicJsonData _data = null;
        private string _topicName = string.Empty;
        private Common.FormMode _mode;

        public TopicForm(string topic, TopicJsonData data, Common.FormMode mode)
        {
            this._data = data;
            this._topicName = topic;
            this._mode = mode;
            InitializeComponent();
        }

        private void TopicForm_Load(object sender, EventArgs e)
        {
            if ( _mode == Common.FormMode.Add)
            {
                txtName.Text = "";
                txtUrl.Text = "";
            }
            if (_mode == Common.FormMode.Edit)
            {
                foreach (Topic t in _data.topics)
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            
            CardForm df = new CardForm(Common.FormMode.Edit, lstData.SelectedItems[0].Text,
                                                     (string)lstData.SelectedItems[0].Tag);
            df.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CardForm df = new CardForm(Common.FormMode.Add, string.Empty, string.Empty);
            df.ShowDialog();
        }

        private void lstData_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lstData.SelectedItems.Count == 0)
                return;

            CardForm df = new CardForm(Common.FormMode.Edit, lstData.SelectedItems[0].Text,
                                                     (string)lstData.SelectedItems[0].Tag);
            df.ShowDialog();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
