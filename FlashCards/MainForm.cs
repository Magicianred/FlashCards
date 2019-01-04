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
            string path = ConfigurationManager.AppSettings["languageFilePath"];
            LanguageJsonData jap = Data.LoadFile(path);
            lstLanguages.Items.Clear();

            foreach ( Language l in jap.languages)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = l.name;
                lvi.SubItems.Add(l.alphabets.Count.ToString());
                lvi.Tag = l.name;
                lstLanguages.Items.Add(lvi);
            }
            btnOpenFlashCards.Visible = false;
        }

        private void lstLanguages_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnOpenFlashCards.Visible = lstLanguages.SelectedItems.Count > 0;
        }

        private void btnOpenFlashCards_Click(object sender, EventArgs e)
        {
            ShowFlashCardDialog();
        }

        private void lstLanguages_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ShowFlashCardDialog();
        }

        private void ShowFlashCardDialog()
        {
            if (lstLanguages.SelectedItems.Count == 0)
                return;

            this.Visible = false;
            FlashForm frm = new FlashForm(lstLanguages.SelectedItems[0].Text, chkRandom.Checked);
            frm.ShowDialog();
            this.Visible = true;
        }
    }
}