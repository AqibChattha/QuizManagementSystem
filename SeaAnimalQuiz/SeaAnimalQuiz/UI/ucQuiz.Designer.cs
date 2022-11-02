namespace SeaAnimalQuiz.UI
{
    partial class ucQuiz
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlQuestion = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbCorrectAnswers = new System.Windows.Forms.Label();
            this.lbIncorrectAnswers = new System.Windows.Forms.Label();
            this.lbTotalAnswers = new System.Windows.Forms.Label();
            this.lbCorrectAnswersCount = new System.Windows.Forms.Label();
            this.lbIncorrectAnswersCount = new System.Windows.Forms.Label();
            this.lbTotalAnswersCount = new System.Windows.Forms.Label();
            this.pbQuizBackground = new System.Windows.Forms.PictureBox();
            this.lbLoseFocus = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuizBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlQuestion
            // 
            this.pnlQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlQuestion.BackColor = System.Drawing.Color.White;
            this.pnlQuestion.Location = new System.Drawing.Point(128, 130);
            this.pnlQuestion.Name = "pnlQuestion";
            this.pnlQuestion.Size = new System.Drawing.Size(528, 198);
            this.pnlQuestion.TabIndex = 1;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBack.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(23, 385);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(89, 33);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.71028F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.28972F));
            this.tableLayoutPanel1.Controls.Add(this.lbCorrectAnswers, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbIncorrectAnswers, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbTotalAnswers, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbCorrectAnswersCount, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbIncorrectAnswersCount, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbTotalAnswersCount, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(15, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(179, 58);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // lbCorrectAnswers
            // 
            this.lbCorrectAnswers.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbCorrectAnswers.AutoSize = true;
            this.lbCorrectAnswers.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCorrectAnswers.Location = new System.Drawing.Point(33, 1);
            this.lbCorrectAnswers.Name = "lbCorrectAnswers";
            this.lbCorrectAnswers.Size = new System.Drawing.Size(110, 17);
            this.lbCorrectAnswers.TabIndex = 0;
            this.lbCorrectAnswers.Text = "Correct Answers :";
            // 
            // lbIncorrectAnswers
            // 
            this.lbIncorrectAnswers.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbIncorrectAnswers.AutoSize = true;
            this.lbIncorrectAnswers.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIncorrectAnswers.Location = new System.Drawing.Point(30, 19);
            this.lbIncorrectAnswers.Name = "lbIncorrectAnswers";
            this.lbIncorrectAnswers.Size = new System.Drawing.Size(113, 17);
            this.lbIncorrectAnswers.TabIndex = 1;
            this.lbIncorrectAnswers.Text = "Incorrect Answes :";
            // 
            // lbTotalAnswers
            // 
            this.lbTotalAnswers.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbTotalAnswers.AutoSize = true;
            this.lbTotalAnswers.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalAnswers.Location = new System.Drawing.Point(5, 38);
            this.lbTotalAnswers.Name = "lbTotalAnswers";
            this.lbTotalAnswers.Size = new System.Drawing.Size(138, 17);
            this.lbTotalAnswers.TabIndex = 1;
            this.lbTotalAnswers.Text = "Questions Remaining :";
            this.lbTotalAnswers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbCorrectAnswersCount
            // 
            this.lbCorrectAnswersCount.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbCorrectAnswersCount.AutoSize = true;
            this.lbCorrectAnswersCount.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCorrectAnswersCount.Location = new System.Drawing.Point(150, 1);
            this.lbCorrectAnswersCount.Name = "lbCorrectAnswersCount";
            this.lbCorrectAnswersCount.Size = new System.Drawing.Size(24, 17);
            this.lbCorrectAnswersCount.TabIndex = 0;
            this.lbCorrectAnswersCount.Text = "Cor";
            // 
            // lbIncorrectAnswersCount
            // 
            this.lbIncorrectAnswersCount.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbIncorrectAnswersCount.AutoSize = true;
            this.lbIncorrectAnswersCount.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIncorrectAnswersCount.Location = new System.Drawing.Point(150, 19);
            this.lbIncorrectAnswersCount.Name = "lbIncorrectAnswersCount";
            this.lbIncorrectAnswersCount.Size = new System.Drawing.Size(24, 17);
            this.lbIncorrectAnswersCount.TabIndex = 0;
            this.lbIncorrectAnswersCount.Text = "Inc";
            // 
            // lbTotalAnswersCount
            // 
            this.lbTotalAnswersCount.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbTotalAnswersCount.AutoSize = true;
            this.lbTotalAnswersCount.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalAnswersCount.Location = new System.Drawing.Point(150, 38);
            this.lbTotalAnswersCount.Name = "lbTotalAnswersCount";
            this.lbTotalAnswersCount.Size = new System.Drawing.Size(22, 17);
            this.lbTotalAnswersCount.TabIndex = 0;
            this.lbTotalAnswersCount.Text = "Ttl";
            // 
            // pbQuizBackground
            // 
            this.pbQuizBackground.BackgroundImage = global::SeaAnimalQuiz.Properties.Resources.question;
            this.pbQuizBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbQuizBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbQuizBackground.Location = new System.Drawing.Point(0, 0);
            this.pbQuizBackground.Name = "pbQuizBackground";
            this.pbQuizBackground.Size = new System.Drawing.Size(784, 450);
            this.pbQuizBackground.TabIndex = 0;
            this.pbQuizBackground.TabStop = false;
            // 
            // lbLoseFocus
            // 
            this.lbLoseFocus.AutoSize = true;
            this.lbLoseFocus.Location = new System.Drawing.Point(766, 13);
            this.lbLoseFocus.Name = "lbLoseFocus";
            this.lbLoseFocus.Size = new System.Drawing.Size(0, 13);
            this.lbLoseFocus.TabIndex = 4;
            // 
            // ucQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pnlQuestion);
            this.Controls.Add(this.pbQuizBackground);
            this.Controls.Add(this.lbLoseFocus);
            this.Name = "ucQuiz";
            this.Size = new System.Drawing.Size(784, 450);
            this.Load += new System.EventHandler(this.ucQuiz_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuizBackground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlQuestion;
        private System.Windows.Forms.PictureBox pbQuizBackground;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbCorrectAnswers;
        private System.Windows.Forms.Label lbIncorrectAnswers;
        private System.Windows.Forms.Label lbTotalAnswers;
        private System.Windows.Forms.Label lbCorrectAnswersCount;
        private System.Windows.Forms.Label lbIncorrectAnswersCount;
        private System.Windows.Forms.Label lbTotalAnswersCount;
        private System.Windows.Forms.Label lbLoseFocus;
    }
}
