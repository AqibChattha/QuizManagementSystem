using System;
using System.Collections.Generic;
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
        public void LoadQuestions(QuizCategory category)
        {
            // load the questions from the FishQuestions.txt file in the Data directory.
            string file = "";
            if (category == QuizCategory.Fish)
            {
                file = "../../Data/FishQuestions.txt";
            }

            try
            {
                if (File.Exists(file))
                {
                    // Store each line in array of strings
                    string[] lines = File.ReadAllLines(file);


                    foreach (string ln in lines)
                    {
                        if (!(ln == null || ln == ""))
                        {
                            string[] data = ln.Split(',');
                            if (data[0].Equals(QuestionType.MultipleChoice.ToString()))
                            {
                                // create MCQ and load data
                                MCQ mcq = new MCQ(data[1], data[2], data[3], data[4], data[5], data[6]);
                                questions.Add(mcq);
                            }
                            else if (data[0].Equals(QuestionType.TrueFalse.ToString()))
                            {
                                // create True False and load data
                                TrueFalse trueFalse = new TrueFalse(data[1], data[2], data[3], data[4]);
                                questions.Add(trueFalse);
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("There was an error loading the questions.", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

            // Shuffle the questions.
            ShuffleQuestions();

            // Reset the current question number.
            currentQuestionNumber = 0;

            // Reset the number of correct answers.
            correctAnswers = 0;

            // Reset the number of incorrect answers.
            incorrectAnswers = 0;
        }

        /// <summary>
        /// shuffle the questions in the list and only retain 20 questions.
        /// </summary>
        private void ShuffleQuestions()
        {
            // Create a new random number generator.
            Random random = new Random();

            // Shuffle the questions in the list.
            for (int i = 0; i < questions.Count; i++)
            {
                // Get a random index.
                int randomIndex = random.Next(0, questions.Count);

                // Swap the questions at the current index and the random index.
                Question temp = questions[i];
                questions[i] = questions[randomIndex];
                questions[randomIndex] = temp;
            }

            try { questions = questions.GetRange(0, 20); } catch (Exception) { }
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
            catch (Exception e)
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

        public int QuestionsRemaining()
        {
            return questions.Count - CurrentQuestionNumber;
        }
    }
}
