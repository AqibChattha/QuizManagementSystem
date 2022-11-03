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
    public partial class ucAdd_TrueFalse : UserControl
    {
        private static ucAdd_TrueFalse _instance;

        public static ucAdd_TrueFalse Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ucAdd_TrueFalse();
                }
                return _instance;
            }
        }

        private ucAdd_TrueFalse()
        {
            InitializeComponent();
        }

        public void RefreshUc()
        {
            tbQuestion.Text = "True False Question";
            tbQuestion.ForeColor = Color.DimGray;

            rbAnswer1.Checked = false;
            rbAnswer2.Checked = false;
        }

        private void tbQuestion_Enter(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox.Text.Equals("True False Question"))
            {
                textBox.Text = "";
                textBox.ForeColor = Color.Black;
            }
        }

        private void tbQuestion_Leave(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox.Text.Equals(""))
            {
                textBox.Text = textBox.Tag.ToString();
                textBox.ForeColor = Color.DimGray;
            }
        }

        private string getChoice()
        {
            if (rbAnswer1.Checked)
            {
                return "True";
            }
            else if (rbAnswer2.Checked)
            {
                return "False";
            }
            else
            {
                MessageBox.Show("Please select an answer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }
        }

        public void saveQuestion(string filePath)
        {
            if (!getChoice().Equals("") && !tbQuestion.Text.Equals(""))
            {
                try
                {
                    if (!(tbQuestion.Text.Equals("True False Question")))
                    {
                        if (File.Exists(filePath))
                        {
                            using (StreamWriter sw = File.AppendText(filePath))
                            {
                                sw.WriteLine(QuestionType.TrueFalse + ",;," + tbQuestion.Text + ",;," + getChoice() + ",;," + rbAnswer1.Text + ",;," + rbAnswer2.Text);
                            }
                            RefreshUc();
                        }
                        else
                        {
                            if (!Directory.Exists("../../Data"))
                                Directory.CreateDirectory("../../Data");

                            File.Create(filePath);
                            TextWriter sw = new StreamWriter(filePath);
                            sw.WriteLine(QuestionType.TrueFalse + ",;," + tbQuestion.Text + ",;," + getChoice() + ",;," + rbAnswer1.Text + ",;," + rbAnswer2.Text);
                            sw.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter the question", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Error saving question", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
