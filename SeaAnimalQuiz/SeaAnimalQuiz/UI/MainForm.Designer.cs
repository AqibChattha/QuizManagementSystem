namespace SeaAnimalQuiz
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlMain = new System.Windows.Forms.Panel();
            this.scMainPage = new System.Windows.Forms.SplitContainer();
            this.tlpMainMenu = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAddQuestions = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.lbTitel = new System.Windows.Forms.Label();
            this.pdBackground = new System.Windows.Forms.PictureBox();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scMainPage)).BeginInit();
            this.scMainPage.Panel1.SuspendLayout();
            this.scMainPage.Panel2.SuspendLayout();
            this.scMainPage.SuspendLayout();
            this.tlpMainMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pdBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.Transparent;
            this.pnlMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlMain.Controls.Add(this.scMainPage);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(784, 450);
            this.pnlMain.TabIndex = 0;
            // 
            // scMainPage
            // 
            this.scMainPage.BackColor = System.Drawing.Color.Orange;
            this.scMainPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scMainPage.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.scMainPage.IsSplitterFixed = true;
            this.scMainPage.Location = new System.Drawing.Point(0, 0);
            this.scMainPage.Name = "scMainPage";
            // 
            // scMainPage.Panel1
            // 
            this.scMainPage.Panel1.Controls.Add(this.tlpMainMenu);
            // 
            // scMainPage.Panel2
            // 
            this.scMainPage.Panel2.Controls.Add(this.pdBackground);
            this.scMainPage.Size = new System.Drawing.Size(784, 450);
            this.scMainPage.SplitterDistance = 335;
            this.scMainPage.SplitterWidth = 1;
            this.scMainPage.TabIndex = 0;
            // 
            // tlpMainMenu
            // 
            this.tlpMainMenu.BackColor = System.Drawing.Color.Orange;
            this.tlpMainMenu.ColumnCount = 1;
            this.tlpMainMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMainMenu.Controls.Add(this.panel1, 0, 1);
            this.tlpMainMenu.Controls.Add(this.lbTitel, 0, 0);
            this.tlpMainMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMainMenu.Location = new System.Drawing.Point(0, 0);
            this.tlpMainMenu.Name = "tlpMainMenu";
            this.tlpMainMenu.RowCount = 2;
            this.tlpMainMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.77778F));
            this.tlpMainMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.22222F));
            this.tlpMainMenu.Size = new System.Drawing.Size(335, 450);
            this.tlpMainMenu.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnAddQuestions);
            this.panel1.Controls.Add(this.btnStart);
            this.panel1.Controls.Add(this.btnHelp);
            this.panel1.Location = new System.Drawing.Point(3, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(329, 364);
            this.panel1.TabIndex = 2;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExit.BackColor = System.Drawing.Color.DarkOrange;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(23, 301);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(89, 37);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAddQuestions
            // 
            this.btnAddQuestions.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddQuestions.BackColor = System.Drawing.Color.DarkOrange;
            this.btnAddQuestions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddQuestions.ForeColor = System.Drawing.Color.White;
            this.btnAddQuestions.Location = new System.Drawing.Point(23, 86);
            this.btnAddQuestions.Name = "btnAddQuestions";
            this.btnAddQuestions.Size = new System.Drawing.Size(283, 45);
            this.btnAddQuestions.TabIndex = 0;
            this.btnAddQuestions.Text = "Add Questions";
            this.btnAddQuestions.UseVisualStyleBackColor = false;
            this.btnAddQuestions.Click += new System.EventHandler(this.btnAddQuestions_Click);
            // 
            // btnStart
            // 
            this.btnStart.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnStart.BackColor = System.Drawing.Color.DarkOrange;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(23, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(283, 45);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start Quiz";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnHelp.BackColor = System.Drawing.Color.DarkOrange;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.ForeColor = System.Drawing.Color.White;
            this.btnHelp.Location = new System.Drawing.Point(23, 160);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(283, 45);
            this.btnHelp.TabIndex = 0;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // lbTitel
            // 
            this.lbTitel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbTitel.AutoSize = true;
            this.lbTitel.Font = new System.Drawing.Font("Century", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitel.ForeColor = System.Drawing.Color.White;
            this.lbTitel.Location = new System.Drawing.Point(44, 23);
            this.lbTitel.Name = "lbTitel";
            this.lbTitel.Size = new System.Drawing.Size(246, 33);
            this.lbTitel.TabIndex = 1;
            this.lbTitel.Text = "Sea Animal Quiz";
            this.lbTitel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pdBackground
            // 
            this.pdBackground.BackgroundImage = global::SeaAnimalQuiz.Properties.Resources.main;
            this.pdBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pdBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pdBackground.Location = new System.Drawing.Point(0, 0);
            this.pdBackground.Name = "pdBackground";
            this.pdBackground.Size = new System.Drawing.Size(448, 450);
            this.pdBackground.TabIndex = 0;
            this.pdBackground.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 450);
            this.Controls.Add(this.pnlMain);
            this.MinimumSize = new System.Drawing.Size(800, 440);
            this.Name = "MainForm";
            this.Text = "Quiz";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnlMain.ResumeLayout(false);
            this.scMainPage.Panel1.ResumeLayout(false);
            this.scMainPage.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scMainPage)).EndInit();
            this.scMainPage.ResumeLayout(false);
            this.tlpMainMenu.ResumeLayout(false);
            this.tlpMainMenu.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pdBackground)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.SplitContainer scMainPage;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAddQuestions;
        private System.Windows.Forms.PictureBox pdBackground;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Label lbTitel;
        private System.Windows.Forms.TableLayoutPanel tlpMainMenu;
        private System.Windows.Forms.Panel panel1;
    }
}

