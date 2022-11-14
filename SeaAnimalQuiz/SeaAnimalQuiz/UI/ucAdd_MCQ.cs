using SchoolManagementSystem.Classes;
using SeaAnimalQuiz.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

        private string[] placeholders = { "Question", "Correct Answer", "Optional Answer 1", "Optional Answer 2", "Optional Answer 3", "Optional Answer 4" };

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

            pbQuestion.BackgroundImage = null;

        }

        public void saveQuestion(string category)
        {
            try
            {
                if (!(tbQuestion.Text.Equals("Question") || tbCorrectAnswer.Text.Equals("Correct Answer") || tbAnswer1.Text.Equals("Optional Answer 1") || tbAnswer2.Text.Equals("Optional Answer 2") || tbAnswer3.Text.Equals("Optional Answer 3") || tbAnswer4.Text.Equals("Optional Answer 4")))
                {

                    var con = Config.Instance.Connection;
                    SqlCommand cmd = new SqlCommand("dbo.[Add_MCQ]", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@questionText", tbQuestion.Text));
                    cmd.Parameters.Add(new SqlParameter("@correctAnswer", tbCorrectAnswer.Text));
                    cmd.Parameters.Add(new SqlParameter("@option1", tbAnswer1.Text));
                    cmd.Parameters.Add(new SqlParameter("@option2", tbAnswer2.Text));
                    cmd.Parameters.Add(new SqlParameter("@option3", tbAnswer3.Text));
                    cmd.Parameters.Add(new SqlParameter("@option4", tbAnswer4.Text));
                    cmd.Parameters.Add(new SqlParameter("@category", category));
                    if (pbQuestion.BackgroundImage != null)
                        cmd.Parameters.Add(new SqlParameter("@image", getImageForDB()));

                    cmd.ExecuteNonQuery();
                    RefreshUc();
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

        private byte[] getImageForDB()
        {
            MemoryStream ms = new MemoryStream();
            pbQuestion.BackgroundImage.Save(ms, pbQuestion.BackgroundImage.RawFormat);
            return ms.GetBuffer();
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

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string file = openFileDialog1.FileName;
                try
                {
                    pbQuestion.BackgroundImage = new Bitmap(openFileDialog1.FileName);
                }
                catch (Exception)
                {
                    MessageBox.Show("Error loading the image, please select another image.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
