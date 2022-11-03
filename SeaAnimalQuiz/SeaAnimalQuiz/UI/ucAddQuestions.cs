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
    public partial class ucAddQuestions : UserControl
    {
        private static ucAddQuestions _instance;

        public static ucAddQuestions Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ucAddQuestions();
                }
                return _instance;
            }
        }

        private ucAddQuestions()
        {
            InitializeComponent();
        }
        

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainForm.Instance.SetHomePage();
        }

        private void ucAddQuestions_Load(object sender, EventArgs e)
        {
            if (!pnlAddQuestion.Controls.Contains(ucAdd_TrueFalse.Instance))
            {
                pnlAddQuestion.Controls.Add(ucAdd_TrueFalse.Instance);
                ucAdd_TrueFalse.Instance.Dock = DockStyle.Fill;
            }
            if (!pnlAddQuestion.Controls.Contains(ucAdd_MCQ.Instance))
            {
                pnlAddQuestion.Controls.Add(ucAdd_MCQ.Instance);
                ucAdd_MCQ.Instance.Dock = DockStyle.Fill;
            }

            cbCategories.SelectedIndex = 0;
            rbtnMcq.Checked = true;
        }

        public void RefreshUc()
        {
            cbCategories.SelectedIndex = 0;
            rbtnMcq.Checked = true;
            ucAdd_MCQ.Instance.RefreshUc();
        }

        private void rbtnMcq_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnMcq.Checked)
            {
                ucAdd_MCQ.Instance.RefreshUc();
                ucAdd_MCQ.Instance.BringToFront();
            }
        }

        private void rbtnTrueFalse_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnTrueFalse.Checked)
            {
                ucAdd_TrueFalse.Instance.RefreshUc();
                ucAdd_TrueFalse.Instance.BringToFront();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string fileToAppend = "";
            if (cbCategories.SelectedItem.ToString().Equals("Fish"))
            {
                fileToAppend = "../../Data/FishQuestions.txt";
            }
            else if (cbCategories.SelectedItem.ToString().Equals("Birds"))
            {
                fileToAppend = "../../Data/BirdQuestions.txt";
            }
            else if (cbCategories.SelectedItem.ToString().Equals("Reptiles"))
            {
                fileToAppend = "../../Data/ReptileQuestions.txt";
            }
            else
            {
                MessageBox.Show("Please select the question category.", "Select category", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (rbtnMcq.Checked)
            {
                ucAdd_MCQ.Instance.saveQuestion(fileToAppend);
            }
            else if (rbtnTrueFalse.Checked)
            {
                ucAdd_TrueFalse.Instance.saveQuestion(fileToAppend);
            }
            else
            {
                MessageBox.Show("Please select the question type.", "Select type", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
