namespace SeaAnimalQuiz.UI
{
    partial class ucAdd_MCQ
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
            this.components = new System.ComponentModel.Container();
            this.tlpMcqQuestionAnswers = new System.Windows.Forms.TableLayoutPanel();
            this.tlpMcqAnswers = new System.Windows.Forms.TableLayoutPanel();
            this.tbAnswer2 = new System.Windows.Forms.TextBox();
            this.tbAnswer3 = new System.Windows.Forms.TextBox();
            this.tbAnswer4 = new System.Windows.Forms.TextBox();
            this.tbAnswer1 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tbCorrectAnswer = new System.Windows.Forms.TextBox();
            this.pnlQuestionSection = new System.Windows.Forms.Panel();
            this.pnlQuestion = new System.Windows.Forms.Panel();
            this.tbQuestion = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.pbQuestion = new System.Windows.Forms.PictureBox();
            this.tmrNextQuestion = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tlpMcqQuestionAnswers.SuspendLayout();
            this.tlpMcqAnswers.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlQuestionSection.SuspendLayout();
            this.pnlQuestion.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuestion)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpMcqQuestionAnswers
            // 
            this.tlpMcqQuestionAnswers.BackColor = System.Drawing.Color.White;
            this.tlpMcqQuestionAnswers.ColumnCount = 1;
            this.tlpMcqQuestionAnswers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMcqQuestionAnswers.Controls.Add(this.tlpMcqAnswers, 0, 1);
            this.tlpMcqQuestionAnswers.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tlpMcqQuestionAnswers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMcqQuestionAnswers.Location = new System.Drawing.Point(0, 0);
            this.tlpMcqQuestionAnswers.Name = "tlpMcqQuestionAnswers";
            this.tlpMcqQuestionAnswers.RowCount = 2;
            this.tlpMcqQuestionAnswers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 74.27386F));
            this.tlpMcqQuestionAnswers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.72614F));
            this.tlpMcqQuestionAnswers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMcqQuestionAnswers.Size = new System.Drawing.Size(528, 241);
            this.tlpMcqQuestionAnswers.TabIndex = 3;
            // 
            // tlpMcqAnswers
            // 
            this.tlpMcqAnswers.ColumnCount = 2;
            this.tlpMcqAnswers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMcqAnswers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMcqAnswers.Controls.Add(this.tbAnswer2, 1, 0);
            this.tlpMcqAnswers.Controls.Add(this.tbAnswer3, 0, 1);
            this.tlpMcqAnswers.Controls.Add(this.tbAnswer4, 1, 1);
            this.tlpMcqAnswers.Controls.Add(this.tbAnswer1, 0, 0);
            this.tlpMcqAnswers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMcqAnswers.Location = new System.Drawing.Point(3, 182);
            this.tlpMcqAnswers.Name = "tlpMcqAnswers";
            this.tlpMcqAnswers.RowCount = 2;
            this.tlpMcqAnswers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpMcqAnswers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpMcqAnswers.Size = new System.Drawing.Size(522, 56);
            this.tlpMcqAnswers.TabIndex = 0;
            // 
            // tbAnswer2
            // 
            this.tbAnswer2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbAnswer2.BackColor = System.Drawing.Color.White;
            this.tbAnswer2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbAnswer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAnswer2.ForeColor = System.Drawing.Color.DimGray;
            this.tbAnswer2.Location = new System.Drawing.Point(274, 6);
            this.tbAnswer2.Name = "tbAnswer2";
            this.tbAnswer2.Size = new System.Drawing.Size(235, 15);
            this.tbAnswer2.TabIndex = 0;
            this.tbAnswer2.Tag = "Optional Answer 2";
            this.tbAnswer2.Text = "Optional Answer 2";
            this.tbAnswer2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbAnswer2.Enter += new System.EventHandler(this.textBoxFocus_Enter);
            this.tbAnswer2.Leave += new System.EventHandler(this.textBoxFocus_Leave);
            // 
            // tbAnswer3
            // 
            this.tbAnswer3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbAnswer3.BackColor = System.Drawing.Color.White;
            this.tbAnswer3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbAnswer3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAnswer3.ForeColor = System.Drawing.Color.DimGray;
            this.tbAnswer3.Location = new System.Drawing.Point(13, 34);
            this.tbAnswer3.Name = "tbAnswer3";
            this.tbAnswer3.Size = new System.Drawing.Size(235, 15);
            this.tbAnswer3.TabIndex = 0;
            this.tbAnswer3.Tag = "Optional Answer 3";
            this.tbAnswer3.Text = "Optional Answer 3";
            this.tbAnswer3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbAnswer3.Enter += new System.EventHandler(this.textBoxFocus_Enter);
            this.tbAnswer3.Leave += new System.EventHandler(this.textBoxFocus_Leave);
            // 
            // tbAnswer4
            // 
            this.tbAnswer4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbAnswer4.BackColor = System.Drawing.Color.White;
            this.tbAnswer4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbAnswer4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAnswer4.ForeColor = System.Drawing.Color.DimGray;
            this.tbAnswer4.Location = new System.Drawing.Point(274, 34);
            this.tbAnswer4.Name = "tbAnswer4";
            this.tbAnswer4.Size = new System.Drawing.Size(235, 15);
            this.tbAnswer4.TabIndex = 0;
            this.tbAnswer4.Tag = "Optional Answer 4";
            this.tbAnswer4.Text = "Optional Answer 4";
            this.tbAnswer4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbAnswer4.Enter += new System.EventHandler(this.textBoxFocus_Enter);
            this.tbAnswer4.Leave += new System.EventHandler(this.textBoxFocus_Leave);
            // 
            // tbAnswer1
            // 
            this.tbAnswer1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbAnswer1.BackColor = System.Drawing.Color.White;
            this.tbAnswer1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbAnswer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAnswer1.ForeColor = System.Drawing.Color.DimGray;
            this.tbAnswer1.Location = new System.Drawing.Point(13, 6);
            this.tbAnswer1.Name = "tbAnswer1";
            this.tbAnswer1.Size = new System.Drawing.Size(235, 15);
            this.tbAnswer1.TabIndex = 0;
            this.tbAnswer1.Tag = "Optional Answer 1";
            this.tbAnswer1.Text = "Optional Answer 1";
            this.tbAnswer1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbAnswer1.Enter += new System.EventHandler(this.textBoxFocus_Enter);
            this.tbAnswer1.Leave += new System.EventHandler(this.textBoxFocus_Leave);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tbCorrectAnswer, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pnlQuestionSection, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.50289F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.49711F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(522, 173);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tbCorrectAnswer
            // 
            this.tbCorrectAnswer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbCorrectAnswer.BackColor = System.Drawing.Color.White;
            this.tbCorrectAnswer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbCorrectAnswer.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.tbCorrectAnswer.ForeColor = System.Drawing.Color.DimGray;
            this.tbCorrectAnswer.Location = new System.Drawing.Point(143, 146);
            this.tbCorrectAnswer.Name = "tbCorrectAnswer";
            this.tbCorrectAnswer.Size = new System.Drawing.Size(235, 22);
            this.tbCorrectAnswer.TabIndex = 0;
            this.tbCorrectAnswer.Tag = "Correct Answer";
            this.tbCorrectAnswer.Text = "Correct Answer";
            this.tbCorrectAnswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbCorrectAnswer.Enter += new System.EventHandler(this.textBoxFocus_Enter);
            this.tbCorrectAnswer.Leave += new System.EventHandler(this.textBoxFocus_Leave);
            // 
            // pnlQuestionSection
            // 
            this.pnlQuestionSection.Controls.Add(this.pnlQuestion);
            this.pnlQuestionSection.Controls.Add(this.tableLayoutPanel2);
            this.pnlQuestionSection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlQuestionSection.Location = new System.Drawing.Point(3, 3);
            this.pnlQuestionSection.Name = "pnlQuestionSection";
            this.pnlQuestionSection.Size = new System.Drawing.Size(516, 135);
            this.pnlQuestionSection.TabIndex = 1;
            // 
            // pnlQuestion
            // 
            this.pnlQuestion.Controls.Add(this.tbQuestion);
            this.pnlQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlQuestion.Location = new System.Drawing.Point(0, 0);
            this.pnlQuestion.Name = "pnlQuestion";
            this.pnlQuestion.Size = new System.Drawing.Size(355, 135);
            this.pnlQuestion.TabIndex = 7;
            // 
            // tbQuestion
            // 
            this.tbQuestion.AcceptsReturn = true;
            this.tbQuestion.AcceptsTab = true;
            this.tbQuestion.BackColor = System.Drawing.Color.White;
            this.tbQuestion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbQuestion.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbQuestion.ForeColor = System.Drawing.Color.DimGray;
            this.tbQuestion.Location = new System.Drawing.Point(0, 0);
            this.tbQuestion.Multiline = true;
            this.tbQuestion.Name = "tbQuestion";
            this.tbQuestion.ShortcutsEnabled = false;
            this.tbQuestion.Size = new System.Drawing.Size(355, 135);
            this.tbQuestion.TabIndex = 4;
            this.tbQuestion.Tag = "Question";
            this.tbQuestion.Text = "Question";
            this.tbQuestion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbQuestion.Enter += new System.EventHandler(this.textBoxFocus_Enter);
            this.tbQuestion.Leave += new System.EventHandler(this.textBoxFocus_Leave);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnBrowse, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.pbQuestion, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(355, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.55556F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.44444F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(161, 135);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnBrowse.AutoSize = true;
            this.btnBrowse.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnBrowse.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.ForeColor = System.Drawing.Color.White;
            this.btnBrowse.Location = new System.Drawing.Point(98, 105);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(60, 27);
            this.btnBrowse.TabIndex = 3;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // pbQuestion
            // 
            this.pbQuestion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbQuestion.Location = new System.Drawing.Point(3, 3);
            this.pbQuestion.Name = "pbQuestion";
            this.pbQuestion.Size = new System.Drawing.Size(155, 96);
            this.pbQuestion.TabIndex = 0;
            this.pbQuestion.TabStop = false;
            // 
            // tmrNextQuestion
            // 
            this.tmrNextQuestion.Interval = 800;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ucAdd_MCQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tlpMcqQuestionAnswers);
            this.Name = "ucAdd_MCQ";
            this.Size = new System.Drawing.Size(528, 241);
            this.tlpMcqQuestionAnswers.ResumeLayout(false);
            this.tlpMcqAnswers.ResumeLayout(false);
            this.tlpMcqAnswers.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.pnlQuestionSection.ResumeLayout(false);
            this.pnlQuestion.ResumeLayout(false);
            this.pnlQuestion.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuestion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMcqQuestionAnswers;
        private System.Windows.Forms.TableLayoutPanel tlpMcqAnswers;
        private System.Windows.Forms.Timer tmrNextQuestion;
        private System.Windows.Forms.TextBox tbAnswer1;
        private System.Windows.Forms.TextBox tbAnswer3;
        private System.Windows.Forms.TextBox tbAnswer2;
        private System.Windows.Forms.TextBox tbAnswer4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox tbCorrectAnswer;
        private System.Windows.Forms.Panel pnlQuestionSection;
        private System.Windows.Forms.Panel pnlQuestion;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.PictureBox pbQuestion;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox tbQuestion;
    }
}
