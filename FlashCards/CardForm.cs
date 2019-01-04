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
    public partial class CardForm : Form
    {
        private string _key;
        private string _value;
        private Common.FormMode _mode;
        public CardForm(Common.FormMode mode, string key, string value)
        {
            this._mode = mode;
            this._key = key;
            this._value = value;
            InitializeComponent();
        }

        private void DataForm_Load(object sender, EventArgs e)
        {
            if (_mode == Common.FormMode.Add)
            {
                txtKey.Text = "";
                txtValue.Text = "";
            }
            if ( _mode == Common.FormMode.Edit)
            {
                txtKey.Text = this._key;
                txtValue.Text = this._value;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
