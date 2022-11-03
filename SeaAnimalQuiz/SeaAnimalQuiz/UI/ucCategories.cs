using SeaAnimalQuiz.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeaAnimalQuiz.UI
{
    public partial class ucCategories : UserControl
    {
        // singleton object for the categories user control
        private static ucCategories _instance;

        /// <summary>
        /// get the singleton object of the Categories class
        /// </summary>
        public static ucCategories Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ucCategories();
                }
                return _instance;
            }
        }
        public ucCategories()
        {
            InitializeComponent();
        }

        private void btnFish_Click(object sender, EventArgs e)
        {
            MainForm.Instance.SetQuizPage(QuizCategory.Fish);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainForm.Instance.SetHomePageMenu();
        }

        private void btnBirds_Click(object sender, EventArgs e)
        {
            MainForm.Instance.SetQuizPage(QuizCategory.Birds);
        }

        private void btnReptiles_Click(object sender, EventArgs e)
        {
            MainForm.Instance.SetQuizPage(QuizCategory.Reptiles);
        }
    }
}
