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
    public partial class CardForm : Form
    {
        public string Key { get; set; }
        public string Value { get; set; }

        private Common.FormMode _mode;

        public CardForm(Common.FormMode mode, string key, string value)
        {
            this._mode = mode;
            this.Key = key;
            this.Value = value;
            InitializeComponent();
        }

        private void DataForm_Load(object sender, EventArgs e)
        {
            if (_mode == Common.FormMode.Add)
            {
                txtKey.Text = string.Empty;
                txtValue.Text = string.Empty;
            }
            if ( _mode == Common.FormMode.Edit)
            {
                txtKey.Text = this.Key;
                txtValue.Text = this.Value;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtKey.Text == string.Empty || txtValue.Text == string.Empty)
            {
                MyMessageBox mb = new MyMessageBox(Constants.TITLE_MISSINGDATA, 
                                                   Constants.MSG_REQUIRED_DATA, 
                                                   MessageBoxButtons.OK);
                mb.ShowDialog();
                return;
            }

            this.Key = txtKey.Text;
            this.Value = txtValue.Text;

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