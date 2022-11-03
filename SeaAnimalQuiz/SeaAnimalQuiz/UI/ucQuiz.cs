using SeaAnimalQuiz.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeaAnimalQuiz.UI
{

    /// <summary>
    /// user control for displaying the quiz to the user.
    /// </summary>
    public partial class ucQuiz : UserControl
    {
        // singleton object for the quiz user control
        private static ucQuiz _instance;

        // current quiz being undertaken
        private Quiz _currentQuiz;

        // incorrect questions
        private List<int> _incorrectQuestions = new List<int>();

        /// <summary>
        /// get the singleton object of the Quiz class
        /// </summary>
        public static ucQuiz Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ucQuiz();
                }
                return _instance;
            }
        }

        private ucQuiz()
        {
            InitializeComponent();
        }

        private void ucQuiz_Load(object sender, EventArgs e)
        {

        }

        public bool SetQuiz(QuizCategory category)
        {
            // set the current quiz
            _currentQuiz = new Quiz();

            // set the quiz title
            _currentQuiz.LoadQuestions(category);

            if (_currentQuiz.totalQuestions() >= 10)
                return true;

            return false;
        }

        public void RefreshUc()
        {
            RefreshScore();
            if (_currentQuiz.CurrentQuestion.QuestionType == QuestionType.MultipleChoice)
            {
                DisplayMCQ(_currentQuiz.CurrentQuestion);
            }
            else if (_currentQuiz.CurrentQuestion.QuestionType == QuestionType.TrueFalse)
            {
                DisplayTrueFalse(_currentQuiz.CurrentQuestion);
            }
        }

        public void RefreshScore()
        {
            lbCorrectAnswersCount.Text = _currentQuiz.CorrectAnswers.ToString();
            lbIncorrectAnswersCount.Text = _currentQuiz.IncorrectAnswers.ToString();
            lbTotalAnswersCount.Text = _currentQuiz.QuestionsRemaining().ToString();
        }

        // get the current quiz
        public Quiz CurrentQuiz
        {
            get
            {
                return _currentQuiz;
            }
        }

        // get the dictionary of the incorrect attempted questions with correct answers
        public List<int> IncorrectQuestion
        {
            get
            {
                return _incorrectQuestions;
            }
        }

        public void NextQuestion()
        {

            if (_currentQuiz.IsEndOfQuiz())
            {
                // string representation of the result
                string result = _currentQuiz.CorrectAnswers + "/" + (_currentQuiz.CorrectAnswers + _currentQuiz.IncorrectAnswers);

                if (!pnlQuestion.Controls.Contains(ucQuizResult.Instance))
                {
                    pnlQuestion.Controls.Add(ucQuizResult.Instance);
                }
                ucQuizResult.Instance.Dock = DockStyle.Fill;
                ucQuizResult.Instance.RefreshUc(_incorrectQuestions, result);
                ucQuizResult.Instance.BringToFront();
            }
            else
            {
                _currentQuiz.NextQuestion();
                if (_currentQuiz.CurrentQuestion.QuestionType == QuestionType.MultipleChoice)
                {
                    DisplayMCQ(_currentQuiz.CurrentQuestion);
                }
                else if (_currentQuiz.CurrentQuestion.QuestionType == QuestionType.TrueFalse)
                {
                    DisplayTrueFalse(_currentQuiz.CurrentQuestion);
                }
            }
        }

        public void LoseFocus()
        {
            lbLoseFocus.Focus();
        }

        private void DisplayTrueFalse(Question question)
        {
            if (!pnlQuestion.Controls.Contains(ucTrueFalse.Instance))
            {
                pnlQuestion.Controls.Add(ucTrueFalse.Instance);
            }
            ucTrueFalse.Instance.Dock = DockStyle.Fill;
            ucTrueFalse.Instance.DisplayTrueFalse(question);
            ucTrueFalse.Instance.BringToFront();
        }

        private void DisplayMCQ(Question question)
        {
            if (!pnlQuestion.Controls.Contains(ucMCQ.Instance))
            {
                pnlQuestion.Controls.Add(ucMCQ.Instance);
            }
            ucMCQ.Instance.Dock = DockStyle.Fill;
            ucMCQ.Instance.DisplayMCQ(question);
            ucMCQ.Instance.BringToFront();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainForm.Instance.SetHomePage();
        }

        private void pbQuizBackground_Click(object sender, EventArgs e)
        {

        }

        private void lbLoseFocus_Click(object sender, EventArgs e)
        {

        }

        private void pnlQuestion_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
