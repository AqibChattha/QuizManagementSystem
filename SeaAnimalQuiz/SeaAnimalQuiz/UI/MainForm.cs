using SeaAnimalQuiz.Classes;
using SeaAnimalQuiz.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeaAnimalQuiz
{
    /// <summary>
    /// user control for displaying the question of type MCQ to the user.
    /// </summary>
    public partial class MainForm : Form
    {
        // singleton object for the main form
        private static MainForm _instance;

        /// <summary>
        /// get the singleton object of the MainForm class
        /// </summary>
        public static MainForm Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new MainForm();
                }
                return _instance;
            }
        }

        private MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Exit the application when the user clicks the Exit button.
            Application.Exit();
        }

        public void SetHomePage()
        {
            // set the home page as the current user control
            scMainPage.BringToFront();
        }

        public void SetHomePageMenu()
        {
            // set the home page as the current user control
            tlpMainMenu.BringToFront();
        }

        public void SetQuizPage()
        {
            if (pnlMain.Controls.Contains(ucQuiz.Instance))
            {
                ucQuiz.Instance.Dock = DockStyle.Fill;
                ucQuiz.Instance.RefreshUc();
                ucQuiz.Instance.BringToFront();
            }
            else
            {
                pnlMain.Controls.Add(ucQuiz.Instance);
                ucQuiz.Instance.Dock = DockStyle.Fill;
                ucQuiz.Instance.BringToFront();
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (scMainPage.Panel1.Controls.Contains(ucCategories.Instance))
            {
                ucCategories.Instance.Dock = DockStyle.Fill;
                ucCategories.Instance.BringToFront();
            }
            else
            {
                scMainPage.Panel1.Controls.Add(ucCategories.Instance);
                ucCategories.Instance.Dock = DockStyle.Fill;
                ucCategories.Instance.BringToFront();
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {

        }

        private void btnAddQuestions_Click(object sender, EventArgs e)
        {

        }
    }
}
