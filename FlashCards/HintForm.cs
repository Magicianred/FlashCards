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
    public partial class HintForm : Form
    {
        private System.Timers.Timer _totalTime;
        private string question = string.Empty;
        private string answer = string.Empty;
        public HintForm(string q, string a)
        {
            this.question = q;
            this.answer = a;
            InitializeComponent();
            _totalTime = new System.Timers.Timer(2000);
            _totalTime.Elapsed += TotalTime_Elapsed;
        }

        private void Clue_Load(object sender, EventArgs e)
        {
            _totalTime.Start();
            lblQ.Text = this.question;
            lblA.Text = this.answer;
        }

        private void TotalTime_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            this.Close();
        }
    }
}
