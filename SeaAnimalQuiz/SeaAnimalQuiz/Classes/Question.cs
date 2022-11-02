using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaAnimalQuiz.Classes
{
    public enum QuestionType
    {
        MultipleChoice,
        TrueFalse
    }

    /// <summary>
    /// The class represents a question in the quiz. It will contain the questions of
    /// 2 types. The first type will contain the question and 3 possible answers.
    /// The second will be fill in the blanks.
    /// </summary>
    public abstract class Question
    {
        // The question text.
        string questionText;

        // The question type.
        QuestionType questionType;

        // The correct answer
        string correctAnswer;

        public Question(string questionText, string correctAnswer, QuestionType questionType)
        {
            this.questionText = questionText;
            this.correctAnswer = correctAnswer;
            this.questionType = questionType;
        }

        /// <summary>
        /// This method returns the question text.
        /// </summary>
        public string QuestionText
        {
            get
            {
                return questionText;
            }
        }

        /// <summary>
        /// This method returns the correct answer.
        /// </summary>
        public string CorrectAnswer
        {
            get
            {
                return correctAnswer;
            }
        }

        /// <summary>
        /// The method get the type of the question.
        /// </summary>
        public QuestionType QuestionType
        {
            get
            {
                return questionType;
            }
        }

        /// <summary>
        /// This method will check if the answer is correct.
        /// </summary>
        /// <param name="answer"></param>
        public abstract bool CheckAnswer(string answer);
    }
}
