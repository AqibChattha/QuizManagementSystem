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
            tbQuestion.Text = tbQuestion.Tag.ToString();
            tbQuestion.ForeColor = Color.DimGray;

            rbAnswer1.Checked = false;
            rbAnswer2.Checked = false;

            pbQuestion.BackgroundImage = null;
        }

        private void tbQuestion_Enter(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox.Text.Equals("Question"))
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

        public void saveQuestion(string category)
        {
            if (!getChoice().Equals("") && !tbQuestion.Text.Equals(""))
            {
                try
                {
                    if (!(tbQuestion.Text.Equals("Question")))
                    {
                        var con = Config.Instance.Connection;
                        SqlCommand cmd = new SqlCommand("dbo.[Add_TrueFalse]", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@questionText", tbQuestion.Text));
                        cmd.Parameters.Add(new SqlParameter("@correctAnswer", getChoice()));
                        cmd.Parameters.Add(new SqlParameter("@category", category));
                        if (pbQuestion.BackgroundImage != null)
                            cmd.Parameters.Add(new SqlParameter("@image", getImageForDB()));

                        cmd.ExecuteNonQuery();
                        RefreshUc();
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

        private byte[] getImageForDB()
        {
            MemoryStream ms = new MemoryStream();
            pbQuestion.BackgroundImage.Save(ms, pbQuestion.BackgroundImage.RawFormat);
            return ms.GetBuffer();
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
                catch (IOException)
                {
                }
            }
        }
    }
}
