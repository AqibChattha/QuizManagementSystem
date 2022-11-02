using SeaAnimalQuiz.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SeaAnimalQuiz.UI
{
    public partial class ucTrueFalse : UserControl
    {
        // singleton object for the true false user control
        private static ucTrueFalse _instance;

        // current question it is displaying
        private TrueFalse _currentQuestion;

        /// <summary>
        /// get the singleton object of the TrueFalse class
        /// </summary>
        public static ucTrueFalse Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ucTrueFalse();
                }
                return _instance;
            }
        }

        private ucTrueFalse()
        {
            InitializeComponent();
        }

        public void DisplayTrueFalse(Question question)
        {
            TrueFalse trueFalse = (TrueFalse)question;
            _currentQuestion = trueFalse;

            // set question text
            tbQuestionText.Text = trueFalse.QuestionText;
            setTextBox_Scroll();
            
            rbAnswer1.Text = trueFalse.FirstAnswer;
            rbAnswer2.Text = trueFalse.SecondAnswer; 

            // set buttons color to default
            rbAnswer1.BackColor = Color.White;
            rbAnswer2.BackColor = Color.White;

            // set buttons to enabled
            rbAnswer1.Enabled = true;
            rbAnswer2.Enabled = true;
            btnSubmit.Enabled = true;

            // set buttons to unchecked
            rbAnswer1.Checked = false;
            rbAnswer2.Checked = false;
        }

        private void setTextBox_Scroll()
        {
            if (tbQuestionText.Multiline)
            {
                tbQuestionText.ScrollBars = tbQuestionText.Text.Length > (tbQuestionText.Width + tbQuestionText.Height) / 1.30f ? ScrollBars.Vertical : tbQuestionText.Text.Split('\n').Length > tbQuestionText.Height / tbQuestionText.Font.Size / 1.4f ? ScrollBars.Vertical : ScrollBars.None;
            }
        }

        private void tmrNextQuestion_Tick(object sender, EventArgs e)
        {
            tmrNextQuestion.Stop();
            ucQuiz.Instance.NextQuestion();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            RadioButton radioButton;
            if (rbAnswer1.Checked)
            {
                radioButton = rbAnswer1;
            }
            else if(rbAnswer2.Checked)
            {
                    radioButton = rbAnswer2;
            }
            else
            {
                    MessageBox.Show("Please select an answer");
                    return;
            }

            if (ucQuiz.Instance.CurrentQuiz.CheckAnswer(radioButton.Text))
            {
                radioButton.BackColor = Color.LightGreen;
            }
            else
            {
                radioButton.BackColor = Color.MistyRose;

                // set the correct answer button to green
                if (rbAnswer1.Text.Equals(_currentQuestion.CorrectAnswer))
                {
                    rbAnswer1.BackColor = Color.LightGreen;
                }
                else if (rbAnswer2.Text.Equals(_currentQuestion.CorrectAnswer))
                {
                    rbAnswer2.BackColor = Color.LightGreen;
                }
                ucQuiz.Instance.IncorrectQuestion.Add(ucQuiz.Instance.CurrentQuiz.CurrentQuestionNumber - 1);
            }

            // set buttons to disabled
            rbAnswer1.Enabled = false;
            rbAnswer2.Enabled = false;
            btnSubmit.Enabled = false;

            // lose focus from the text box
            ucQuiz.Instance.LoseFocus();

            // refresh the score
            ucQuiz.Instance.RefreshScore();
            
            // start the timer to move to the next question
            tmrNextQuestion.Start();
        }

        private void tbQuestionText_Enter(object sender, EventArgs e)
        {
            
        }
    }
}
