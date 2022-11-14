using SchoolManagementSystem.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace SeaAnimalQuiz.Classes
{
    public enum QuizCategory
    {
        Fish,
        Birds,
        Reptiles
    }

    /// <summary>
    /// This class represents a in the quiz. It will contain the questions between
    /// 10 to 20 regarding sea animals.
    /// </summary>
    public class Quiz
    {
        // The list of questions in the quiz.
        List<Question> questions;

        // The current question number.
        int currentQuestionNumber;

        // The number of correct answers.
        int correctAnswers;

        // The number of incorrect answers.
        int incorrectAnswers;

        /// <summary>
        /// The constructor for the Quiz class.
        /// </summary>
        public Quiz()
        {
            // Initialize the list of questions.
            questions = new List<Question>();

            // Initialize the current question number.
            currentQuestionNumber = 0;

            // Initialize the number of correct answers.
            correctAnswers = 0;

            // Initialize the number of incorrect answers.
            incorrectAnswers = 0;
        }

        /// <summary>
        /// load the questions from the text file.
        /// </summary>
        public bool LoadQuestions(QuizCategory category)
        {
            try
            {
                var con = Config.Instance.Connection;
                SqlCommand cmd = new SqlCommand("dbo.[Get_QuestionsForQuiz]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Category", category.ToString()));
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader["qType"].ToString().Equals(QuestionType.MultipleChoice.ToString()))
                    {
                        MCQ mcq = new MCQ(reader["qText"].ToString()
                            , reader["correctAnswer"].ToString()
                            , reader["option1"].ToString()
                            , reader["option2"].ToString()
                            , reader["option3"].ToString()
                            , reader["option4"].ToString()
                            , reader["image"] == DBNull.Value ? null : (byte[])reader["image"]);
                        questions.Add(mcq);
                    }
                    else if (reader["qType"].ToString().Equals(QuestionType.TrueFalse.ToString()))
                    {
                        TrueFalse trueFalse = new TrueFalse(reader["qText"].ToString()
                            , reader["correctAnswer"].ToString()
                            , reader["image"] == DBNull.Value ? null : (byte[])reader["image"]);
                        questions.Add(trueFalse);
                    }
                }
                reader.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("There was an error loading the questions.", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return false;
            }

            // Reset the current question number.
            currentQuestionNumber = 0;

            // Reset the number of correct answers.
            correctAnswers = 0;

            // Reset the number of incorrect answers.
            incorrectAnswers = 0;

            return true;
        }

        /// <summary>
        /// check the answer for the current question.
        /// </summary>
        /// <param name="answer">The answer to check.</param>
        /// <returns>True if the answer is correct, false otherwise.</returns>
        public bool CheckAnswer(string answer)
        {
            // Check if the answer is correct.
            if (questions[currentQuestionNumber].CheckAnswer(answer))
            {
                // Increment the number of correct answers.
                correctAnswers++;

                // Return true.
                return true;
            }
            else
            {
                // Increment the number of incorrect answers.
                incorrectAnswers++;

                // Return false.
                return false;
            }
        }

        /// <summary>
        /// Move to the next question.
        /// </summary>
        public void NextQuestion()
        {
            // Increment the current question number.
            currentQuestionNumber++;
        }

        /// <summary>
        /// Check if end of the quiz.
        /// </summary>
        /// <returns>True if end of the quiz, false otherwise.</returns>
        public bool IsEndOfQuiz()
        {
            // Check if the current question number is greater than or equal to the number of questions.
            if (CurrentQuestionNumber >= questions.Count)
            {
                // Return true.
                return true;
            }
            else
            {
                // Return false.
                return false;
            }
        }

        /// <summary>
        /// Get the current question.
        /// </summary>
        /// <returns>The current question.</returns>
        public Question CurrentQuestion
        {
            get
            {
                // Return the current question.
                try
                {
                    return questions[currentQuestionNumber];
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// Get the number of correct answers.
        /// </summary>
        /// <param name="index"></param>
        /// <returns>Question of given index otherwise null</returns>
        public Question GetQuestion(int index)
        {
#pragma warning disable CS0168 // The variable 'e' is declared but never used
            try
            {
                return questions[index];
            }
            catch (Exception)
            {
                return null;
            }
#pragma warning restore CS0168 // The variable 'e' is declared but never used
        }

        /// <summary>
        /// Get the number of correct answers.
        /// </summary>
        /// <returns>The number of correct answers.</returns>
        public int CorrectAnswers
        {
            get
            {
                // Return the number of correct answers.
                return correctAnswers;
            }
        }

        /// <summary>
        /// Get the number of incorrect answers.
        /// </summary>\
        /// <returns>The number of incorrect answers.</returns>
        public int IncorrectAnswers
        {
            get
            {
                // Return the number of incorrect answers.
                return incorrectAnswers;
            }
        }

        /// <summary>
        /// Get the number of questions.
        /// </summary>
        /// <returns>The number of questions.</returns>
        public int NumberOfQuestions
        {
            get
            {
                // Return the number of questions.
                return questions.Count;
            }
        }

        /// <summary>
        /// Get the current question number.
        /// </summary>
        /// <returns>The current question number.</returns>
        public int CurrentQuestionNumber
        {
            get
            {
                // Return the current question number.
                return currentQuestionNumber + 1;
            }
        }
        /// <summary>
        /// This method returns the number of questions remaining in the quiz
        /// </summary>
        /// <returns></returns>
        public int QuestionsRemaining()
        {
            return questions.Count - (IncorrectAnswers + CorrectAnswers);
        }

        /// <summary>
        /// This method returns the total number of questions in the quiz
        /// </summary>
        /// <returns></returns>
        public int totalQuestions()
        {
            return questions.Count;
        }
    }
}
