using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaAnimalQuiz.Classes
{
    /// <summary>
    /// The class represents a multiple choice question in the quiz.
    /// It will contain the question and 3 possible answers.
    /// </summary>
    public class MCQ : Question
    {
        // The first possible answer.
        string answer1;

        // The second possible answer.
        string answer2;

        // The third possible answer.
        string answer3;

        // The fourth possible answer.
        string answer4;

        // image file name
        string imageFileName;

        /// <summary>
        /// constructor for the MCQ class.
        /// create a constructor on the basis of the given parameters.
        /// </summary>
        /// <param name="questionText"></param>
        /// <param name="answer1"></param>
        /// <param name="answer2"></param>
        /// <param name="answer3"></param>
        /// <param name="correctAnswer"></param>
        public MCQ(string questionText, string correctAnswer, string answer1, string answer2, string answer3, string answer4, string imageFileName)
            : base(questionText, correctAnswer, QuestionType.MultipleChoice)
        {
            this.answer1 = answer1;
            this.answer2 = answer2;
            this.answer3 = answer3;
            this.answer4 = answer4;
            this.imageFileName = imageFileName;
        }

        /// <summary>
        /// This method will check the whether the answer is the correct anwer
        /// </summary>
        /// <param name="answer"></param>
        /// <returns>True if the answer is the correct anwer</returns>
        public override bool CheckAnswer(string answer)
        {
            return answer == CorrectAnswer;
        }

        /// <summary>
        /// This will return the first possible answer.
        /// </summary>
        public string Answer1
        {
            get
            {
                return answer1;
            }
        }

        /// <summary>
        /// This will return the second possible answer.
        /// </summary>
        public string Answer2
        {
            get
            {
                return answer2;
            }
        }

        /// <summary>
        /// This will return the third possible answer.
        /// </summary>
        public string Answer3
        {
            get
            {
                return answer3;
            }
        }

        /// <summary>
        /// This will return the fourth possible answer.
        /// </summary>
        public string Answer4
        {
            get
            {
                return answer4;
            }
        }

        /// <summary>
        /// this will return the image file name
        /// </summary>
        public string ImageFileName
        {
            get
            {
                return imageFileName;
            }
        }

        /// <summary>
        /// This method will convert the question into its string representation.
        /// </summary>
        /// <returns>String representation of MCQ</returns>
        public override string ToString()
        {
            return QuestionText + "," + answer1 + "," + answer2 + "," + answer3 + "," + CorrectAnswer;
        }
    }
}