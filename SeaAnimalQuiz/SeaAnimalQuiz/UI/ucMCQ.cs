using SeaAnimalQuiz.Classes;
using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Button = System.Windows.Forms.Button;

namespace SeaAnimalQuiz.UI
{
    /// <summary>
    /// user control for displaying the question of type MCQ to the user.
    /// </summary>
    public partial class ucMCQ : UserControl
    {
        // singleton object for the mcq user control
        private static ucMCQ _instance;

        // current question it is displaying
        private MCQ _currentQuestion;

        /// <summary>
        /// get the singleton object of the MCQ class
        /// </summary>
        public static ucMCQ Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ucMCQ();
                }
                return _instance;
            }
        }

        private ucMCQ()
        {
            InitializeComponent();
        }

        public void DisplayMCQ(Question question)
        {
            MCQ mcq = (MCQ)question;
            _currentQuestion = mcq;

            // set question text
            tbQuestionText.Text = mcq.QuestionText;
            setTextBox_Scroll();

            btnAnswer1.Text = mcq.Answer1;
            btnAnswer2.Text = mcq.Answer2;
            btnAnswer3.Text = mcq.Answer3;
            btnAnswer4.Text = mcq.Answer4;

            // set buttons color to default
            btnAnswer1.BackColor = Color.SlateGray;
            btnAnswer2.BackColor = Color.SlateGray;
            btnAnswer3.BackColor = Color.SlateGray;
            btnAnswer4.BackColor = Color.SlateGray;

            // set buttons to enabled
            btnAnswer1.Enabled = true;
            btnAnswer2.Enabled = true;
            btnAnswer3.Enabled = true;
            btnAnswer4.Enabled = true;
        }

        private void setTextBox_Scroll()
        {
            if (tbQuestionText.Multiline)
            {
                tbQuestionText.ScrollBars = tbQuestionText.Text.Length > (tbQuestionText.Width + tbQuestionText.Height) / 1.30f ? ScrollBars.Vertical : tbQuestionText.Text.Split('\n').Length > tbQuestionText.Height / tbQuestionText.Font.Size / 1.4f ? ScrollBars.Vertical : ScrollBars.None;
            }
        }

        private void btnAnswer_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (ucQuiz.Instance.CurrentQuiz.CheckAnswer(btn.Text))
            {
                btn.BackColor = Color.LightGreen;
            }
            else
            {
                btn.BackColor = Color.MistyRose;

                // set the correct answer button to green
                if (btnAnswer1.Text.Equals(_currentQuestion.CorrectAnswer))
                {
                    btnAnswer1.BackColor = Color.LightGreen;
                }
                else if (btnAnswer2.Text.Equals(_currentQuestion.CorrectAnswer))
                {
                    btnAnswer2.BackColor = Color.LightGreen;
                }
                else if (btnAnswer3.Text.Equals(_currentQuestion.CorrectAnswer))
                {
                    btnAnswer3.BackColor = Color.LightGreen;
                }
                else if (btnAnswer4.Text.Equals(_currentQuestion.CorrectAnswer))
                {
                    btnAnswer4.BackColor = Color.LightGreen;
                }
                ucQuiz.Instance.IncorrectQuestion.Add(ucQuiz.Instance.CurrentQuiz.CurrentQuestionNumber - 1);
            }

            // set buttons to disabled
            btnAnswer1.Enabled = false;
            btnAnswer2.Enabled = false;
            btnAnswer3.Enabled = false;
            btnAnswer4.Enabled = false;

            // refresh the score
            ucQuiz.Instance.RefreshScore();

            // start the timer to move to the next question
            tmrNextQuestion.Start();
        }

        private void tmrNextQuestion_Tick(object sender, EventArgs e)
        {
            tmrNextQuestion.Stop();
            ucQuiz.Instance.NextQuestion();
        }
    }
}
