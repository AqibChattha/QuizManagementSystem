using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaAnimalQuiz.Classes
{
    /// <summary>
    /// The class represents a true/false question in the quiz.
    /// </summary>
    internal class TrueFalse : Question
    {
        // image file
        byte[] image;

        public TrueFalse(string questionText, string correctAnswer, byte[] image)
            : base(questionText, correctAnswer, QuestionType.TrueFalse)
        {
            this.image = image;
        }

        /// <summary>
        /// This method will get the image file name.
        /// </summary>
        public byte[] Image
        {
            get
            {
                return image;
            }
        }

        /// <summary>
        /// This method will check the answer with the correct answer.
        /// </summary>
        /// <param name="answer"></param>
        /// <returns>True if the answer is the correct anwer</returns>
        public override bool CheckAnswer(string answer)
        {
            return answer == CorrectAnswer;
        }

        /// <summary>
        /// This method will convert the question into its string representation.
        /// </summary>
        /// <returns>String representation of TrueFalse</returns>
        public override string ToString()
        {
            return QuestionText + "," + CorrectAnswer;
        }
    }
}
