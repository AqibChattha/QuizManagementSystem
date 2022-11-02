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
    public partial class ucQuizResult : UserControl
    {
        // singleton object for the quiz result user control
        private static ucQuizResult _instance;

        /// <summary>
        /// get the singleton object of the Quiz Result class
        /// </summary>
        public static ucQuizResult Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ucQuizResult();
                }
                return _instance;
            }
        }
        public ucQuizResult()
        {
            InitializeComponent();
        }

        public void RefreshUc(List<int> incorrectQuestions, string result)
        {
            dgvIncorrectQuestions.Rows.Clear();
            
            // load the incorrectQuestions key question number, question text and value into the data grid view
            foreach (int index in incorrectQuestions)
            {
                Question question = ucQuiz.Instance.CurrentQuiz.GetQuestion(index);
                dgvIncorrectQuestions.Rows.Add(question.QuestionText, question.CorrectAnswer);
            }

            lbObtainedByTotal.Text = result;
        }
    }
}
