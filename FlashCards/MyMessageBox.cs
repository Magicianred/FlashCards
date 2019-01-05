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
    public partial class MyMessageBox : Form
    {
        private string _message = string.Empty;
        private string _title = string.Empty;
        private MessageBoxButtons _buttons;
        public MyMessageBox(string title, 
                            string message, 
                            MessageBoxButtons buttons)
        {
            this._message = message;
            this._title = title;
            this._buttons = buttons;

            InitializeComponent();
            if ( _buttons == MessageBoxButtons.OK)
            {
                btnNo.Visible = false;
                btnYes.Visible = false;
            }
            else
            {
                btnOK.Visible = false;
            }
        }

        private void MyMessageBox_Load(object sender, EventArgs e)
        {
            this.Text = this._title;
            txtMessage.Text = this._message;
            txtMessage.SelectionStart = this.txtMessage.Text.Length;
            txtMessage.SelectionLength = 0;

            if (_buttons == MessageBoxButtons.YesNo)
            {
                btnNo.Focus();
            }
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}