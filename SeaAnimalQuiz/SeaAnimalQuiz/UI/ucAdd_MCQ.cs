using SeaAnimalQuiz.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeaAnimalQuiz.UI
{
    public partial class ucAdd_MCQ : UserControl
    {
        private static ucAdd_MCQ _instance;

        private string[] placeholders = { "Multiple Choice Question", "Correct Answer", "Optional Answer 1", "Optional Answer 2", "Optional Answer 3", "Optional Answer 4" };


        public static ucAdd_MCQ Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ucAdd_MCQ();
                }
                return _instance;
            }
        }

        private ucAdd_MCQ()
        {
            InitializeComponent();

        }

        public void RefreshUc()
        {
            // set all text box text to their tags (placeholders) and set the text color to dim gray
            tbQuestion.Text = tbQuestion.Tag.ToString();
            tbCorrectAnswer.Text = tbCorrectAnswer.Tag.ToString();
            tbAnswer1.Text = tbAnswer1.Tag.ToString();
            tbAnswer2.Text = tbAnswer2.Tag.ToString();
            tbAnswer3.Text = tbAnswer3.Tag.ToString();
            tbAnswer4.Text = tbAnswer4.Tag.ToString();

            tbQuestion.ForeColor = Color.DimGray;
            tbCorrectAnswer.ForeColor = Color.DimGray;
            tbAnswer1.ForeColor = Color.DimGray;
            tbAnswer2.ForeColor = Color.DimGray;
            tbAnswer3.ForeColor = Color.DimGray;
            tbAnswer4.ForeColor = Color.DimGray;

        }

        public void saveQuestion(string filePath)
        {
            try
            {
                if (!(tbQuestion.Text.Equals("Multiple Choice Question") || tbCorrectAnswer.Text.Equals("Correct Answer") || tbAnswer1.Text.Equals("Optional Answer 1") || tbAnswer2.Text.Equals("Optional Answer 2") || tbAnswer3.Text.Equals("Optional Answer 3") || tbAnswer4.Text.Equals("Optional Answer 4")))
                {
                    if (File.Exists(filePath))
                    {
                        using (StreamWriter sw = File.AppendText(filePath))
                        {
                            sw.WriteLine(QuestionType.MultipleChoice + ",;," + tbQuestion.Text + ",;," + tbCorrectAnswer.Text + ",;," + tbAnswer1.Text + ",;," + tbAnswer2.Text + ",;," + tbAnswer3.Text + ",;," + tbAnswer4.Text);
                        }
                        RefreshUc();
                    }
                    else
                    {
                        if (!Directory.Exists("../../Data"))
                            Directory.CreateDirectory("../../Data");

                        File.Create(filePath);
                        TextWriter sw = new StreamWriter(filePath);
                        sw.WriteLine(QuestionType.MultipleChoice + ",;," + tbQuestion.Text + ",;," + tbCorrectAnswer.Text + ",;," + tbAnswer1.Text + ",;," + tbAnswer2.Text + ",;," + tbAnswer3.Text + ",;," + tbAnswer4.Text);
                        sw.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Please fill in all the fields", "Fill the empty boxes", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error saving question", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxFocus_Enter(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (placeholders.Contains(textBox.Text))
            {
                textBox.Text = "";
                textBox.ForeColor = Color.Black;
            }
        }

        private void textBoxFocus_Leave(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox.Text.Equals(""))
            {
                textBox.Text = textBox.Tag.ToString();
                textBox.ForeColor = Color.DimGray;
            }
        }

        private void tbQuestion_TextChanged(object sender, EventArgs e)
        {
            if (tbQuestion.Multiline)
            {
                tbQuestion.ScrollBars = tbQuestion.Text.Length > (tbQuestion.Width + tbQuestion.Height) / 1.30f ? ScrollBars.Vertical : tbQuestion.Text.Split('\n').Length > tbQuestion.Height / tbQuestion.Font.Size / 1.4f ? ScrollBars.Vertical : ScrollBars.None;
            }
        }
    }
}
