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
    public partial class FlashCardForm : Form
    {
        private System.Timers.Timer _totalTime;
        private Random _rand = new Random();
        private string _topic = string.Empty;
        private string _url = string.Empty;
        private bool _randomMode = false;
        private int _wrongAnswers = 0;
        private int _rightAnswers = 0;

        private string _currentAnswer = string.Empty;
        private int _currentQuestionIndex = 0;

        private DateTime _startTime;
        private TopicJsonData _data;

        private Dictionary<string, string> _flashCards = new Dictionary<string, string>(32);

        public FlashCardForm(TopicJsonData data, string topic, bool random)
        {
            InitializeComponent();
            _totalTime = new System.Timers.Timer(1000);

            this._topic = topic;
            this._randomMode = random;
            this._data = data;

            foreach(Topic t in _data.topics)
            {
                if (t.name == this._topic)
                {
                    _flashCards = t.data;
                    _url = t.url;
                }
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
            this.Text = "Flash Cards for " + this._topic.ToUpperInvariant();
            grpCharacter.Text = _flashCards.Count.ToString() + " flash cards!";

            // start flash cards
            Start();
        }

        private void Start()
        {
            // reset all variables
            _rightAnswers = 0;
            _wrongAnswers = 0;
            _currentAnswer = string.Empty;
            _currentQuestionIndex = 0;
            _startTime = DateTime.Now;

            FlashNewCard();
            UpdateToolBarStatus();

            // start timer!
            _totalTime.Start();
            if (_url == null || _url == string.Empty)
                lnkGoogleTranslate.Visible = false;
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            var checkedButton = grpAnswers.Controls.OfType<RadioButton>()
                          .FirstOrDefault(r => r.Checked);
            if (null == checkedButton)
            {
                MessageBox.Show("You have to select an answer to continue!", "Oops" , MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            // Go button is clicked, verify answer, and show hint if needed
            if (!VerifyAnswer())
            {
                string btnTag = string.Empty;
                object[] radios = new object[] { rdoAnswer1, rdoAnswer2, rdoAnswer3, rdoAnswer4 };
                foreach (RadioButton radio in radios)
                {
                    if (radio.Text == _currentAnswer)
                    {
                        radio.ForeColor = Color.Red;
                        btnTag = (string)radio.Tag;
                    }
                }
                string msg = string.Format("You guessed the wrong answer! The correct Answer is {0}",
                                            btnTag);
                MessageBox.Show(msg, "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // there maybe more than one radio button that may have correct answer, reset all radio colors
                foreach (RadioButton radio in radios)
                {
                    if (radio.Text == _currentAnswer)
                        radio.ForeColor = Color.Black;
                }
            }
            FlashNewCard();
        }

        private bool VerifyAnswer()
        {
            // verify the text and if it is correct, increment right answer 
            // else increment wrong answer and move on

            var checkedButton = grpAnswers.Controls.OfType<RadioButton>()
                                      .FirstOrDefault(r => r.Checked);
            bool bRetVal = false;
            if (checkedButton.Text == _currentAnswer)
            {
                _rightAnswers++;
                bRetVal = true;
            }
            else
            {
                _wrongAnswers++;
                bRetVal = false;
            }

            UpdateToolBarStatus();
            return bRetVal;
        }

        private void UpdateToolBarStatus()
        {
            toolStrip1.Text = _rightAnswers.ToString() + " RIGHT!     ";
            toolStrip2.Text = _wrongAnswers.ToString() + " WRONG!     ";
        }

        private void FlashNewCard()
        {
            if (_randomMode)
            {
                int randomKey = _rand.Next(_flashCards.Count);
                string key = _flashCards.Keys.ElementAt(randomKey);
                txtCharacter.Text = key;
                _currentAnswer = _flashCards[key];
                PopulateAnswers(_currentAnswer);
            }
            else
            {
                if (_currentQuestionIndex >= _flashCards.Count)
                {
                    _totalTime.Stop();
                    TimeSpan ts = DateTime.Now - _startTime;
                    string timespent = string.Empty;
                    if (ts.Hours > 0) timespent += ts.Hours.ToString() + " hours ";
                    if (ts.Minutes > 0) timespent += ts.Minutes.ToString() + " minutes ";
                    timespent += ts.Seconds.ToString() + " seconds! ";

                    string msg = string.Format("You finished {0} cards in {1} Great job!!!\nDo you want to start over?",
                                                    _flashCards.Count.ToString(), timespent);
                    if ( DialogResult.Yes == MessageBox.Show(msg, "Finish", 
                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        _currentQuestionIndex = 0;
                        _totalTime.Stop();
                        Start();
                    }
                    else
                    {
                        this.Close();
                    }
                }
                else
                {
                    string key = _flashCards.Keys.ElementAt(_currentQuestionIndex++);
                    txtCharacter.Text = key;
                    _currentAnswer = _flashCards[key];
                    PopulateAnswers(_currentAnswer);
                }
            }

            // set the caret position at the end of the text in the text box
            txtCharacter.SelectionStart = txtCharacter.Text.Length;
            txtCharacter.SelectionLength = 0;

            // set the progress bar limits based on number of questions
            toolStripProgressBar1.Minimum = 0;
            toolStripProgressBar1.Maximum = _flashCards.Count;
            toolStripProgressBar1.Increment(1);

            // uncheck all/any previous answers
            rdoAnswer1.Checked = false;
            rdoAnswer2.Checked = false;
            rdoAnswer3.Checked = false;
            rdoAnswer4.Checked = false;
        }

        private void PopulateAnswers(string currentAnswer)
        {
            // get a random radio button and set the correct answer first
            // then get random answers and set rest of the radio buttons
            // there will be duplicates if there aren't enough answers
            object[] radios = new object[] { rdoAnswer1, rdoAnswer2, rdoAnswer3, rdoAnswer4 };
            int randNum =_rand.Next(4);
            RadioButton btn = (RadioButton)radios[randNum];
            btn.Text = currentAnswer;
            foreach (var radio in radios)
            {
                RadioButton b = (RadioButton)radio;
                if (b.Text != currentAnswer)
                {
                    b.Text = GetRandomAnswer();
                }
            }
        }

        private string GetRandomAnswer()
        {
            int randomKey = _rand.Next(_flashCards.Count);
            string key = _flashCards.Keys.ElementAt(randomKey);
            return  _flashCards[key];
        }

        private void lnkGoogleTranslate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (txtCharacter.Text == string.Empty)
                return;

            // uses auto-translation link
            System.Diagnostics.Process.Start(string.Format(_url, txtCharacter.Text));
        }
    }
}