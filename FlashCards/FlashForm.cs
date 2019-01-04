using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace FlashCards
{
    public partial class FlashForm : Form
    {
        private System.Timers.Timer _totalTime;
        private Random _rand = new Random();
        private string _language = string.Empty;
        private bool _randomMode = false;
        private int _wrongAnswers = 0;
        private int _rightAnswers = 0;

        private string _currentAnswer = string.Empty;
        private int _currentQuestionIndex = 0;

        private DateTime _startTime;
        private LanguageJsonData _languageData;
        private bool _bFirstTime = true;

        private Dictionary<string, string> _alphabets = new Dictionary<string, string>(32);

        public FlashForm(string lang, bool surpriseMode)
        {
            InitializeComponent();
            _totalTime = new System.Timers.Timer(1000);

            this._language = lang;
            this._randomMode = surpriseMode;
            string path = ConfigurationManager.AppSettings["languageFilePath"];
            _languageData = Data.LoadFile(path);

            foreach(Language l in _languageData.languages)
            {
                if (l.name == this._language)
                    _alphabets = l.alphabets;
            }

            _totalTime.Elapsed += TotalTime_Elapsed;
            toolStrip4.Text = string.Empty;
        }

        private void TotalTime_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            TimeSpan ts = (DateTime.Now - _startTime);
            toolStrip4.Text = string.Format("{0:hh\\:mm\\:ss}", ts);
        }

        private void FlashForm_Load(object sender, EventArgs e)
        {
            this.Text = "Flash Cards for " + this._language.ToUpperInvariant();
            grpCharacter.Text = _alphabets.Count.ToString() + " flash cards!";
            UpdateCounts();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            if (_bFirstTime)
            {
                _startTime = DateTime.Now;
                _totalTime.Start();
                FlashNewCard();
                _bFirstTime = false;
            }
            else
            {
                if (!VerifyAnswer())
                {
                    this.Visible = false;
                    new HintForm(lblCharacter.Text, _currentAnswer).ShowDialog();
                    this.Visible = true;
                }
                FlashNewCard();
            }
        }

        private bool VerifyAnswer()
        {
            // verify the text and if it is correct, increment right answer 
            // else increment wrong answer and move on
            bool bRetVal = false;
            if (txtAnswer.Text == _currentAnswer)
            {
                _rightAnswers++;
                bRetVal = true;
            }
            else
            {
                _wrongAnswers++;
                bRetVal = false;
            }

            UpdateCounts();
            return bRetVal;
        }

        private void UpdateCounts()
        {
            toolStrip1.Text = _rightAnswers.ToString() + " RIGHT!     ";
            toolStrip2.Text = _wrongAnswers.ToString() + " WRONG!     ";
        }

        private void FlashNewCard()
        {
            if (_randomMode)
            {
                int randomKey = _rand.Next(_alphabets.Count);
                string key = _alphabets.Keys.ElementAt(randomKey);
                lblCharacter.Text = key;
                _currentAnswer = _alphabets[key].Split('-')[0].Trim();
            }
            else
            {
                if (_currentQuestionIndex >= _alphabets.Count)
                {
                    MessageBox.Show("You have reached end of alphabets. Good job!");
                }
                else
                {
                    string key = _alphabets.Keys.ElementAt(_currentQuestionIndex++);
                    lblCharacter.Text = key;
                    _currentAnswer = _alphabets[key].Split('-')[0].Trim();
                }
            }

            txtAnswer.Text = string.Empty;
            txtAnswer.Focus();

            toolStripProgressBar1.Minimum = 0;
            toolStripProgressBar1.Maximum = _alphabets.Count;
            toolStripProgressBar1.Increment(1);
        }
    }
}