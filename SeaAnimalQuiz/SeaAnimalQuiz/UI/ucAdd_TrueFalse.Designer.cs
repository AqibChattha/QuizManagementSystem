namespace SeaAnimalQuiz.UI
{
    partial class ucAdd_TrueFalse
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
            this.tlpTrueFalseQuestionAnswers = new System.Windows.Forms.TableLayoutPanel();
            this.tlpMcqAnswers = new System.Windows.Forms.TableLayoutPanel();
            this.rbAnswer1 = new System.Windows.Forms.RadioButton();
            this.rbAnswer2 = new System.Windows.Forms.RadioButton();
            this.tbQuestion = new System.Windows.Forms.TextBox();
            this.tlpTrueFalseQuestionAnswers.SuspendLayout();
            this.tlpMcqAnswers.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpTrueFalseQuestionAnswers
            // 
            this.tlpTrueFalseQuestionAnswers.BackColor = System.Drawing.Color.White;
            this.tlpTrueFalseQuestionAnswers.ColumnCount = 1;
            this.tlpTrueFalseQuestionAnswers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpTrueFalseQuestionAnswers.Controls.Add(this.tbQuestion, 0, 0);
            this.tlpTrueFalseQuestionAnswers.Controls.Add(this.tlpMcqAnswers, 0, 1);
            this.tlpTrueFalseQuestionAnswers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTrueFalseQuestionAnswers.Location = new System.Drawing.Point(0, 0);
            this.tlpTrueFalseQuestionAnswers.Name = "tlpTrueFalseQuestionAnswers";
            this.tlpTrueFalseQuestionAnswers.RowCount = 2;
            this.tlpTrueFalseQuestionAnswers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 79.25311F));
            this.tlpTrueFalseQuestionAnswers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.74689F));
            this.tlpTrueFalseQuestionAnswers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpTrueFalseQuestionAnswers.Size = new System.Drawing.Size(528, 241);
            this.tlpTrueFalseQuestionAnswers.TabIndex = 4;
            // 
            // tlpMcqAnswers
            // 
            this.tlpMcqAnswers.ColumnCount = 2;
            this.tlpMcqAnswers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMcqAnswers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMcqAnswers.Controls.Add(this.rbAnswer1, 0, 0);
            this.tlpMcqAnswers.Controls.Add(this.rbAnswer2, 1, 0);
            this.tlpMcqAnswers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMcqAnswers.Location = new System.Drawing.Point(3, 194);
            this.tlpMcqAnswers.Name = "tlpMcqAnswers";
            this.tlpMcqAnswers.RowCount = 1;
            this.tlpMcqAnswers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMcqAnswers.Size = new System.Drawing.Size(522, 44);
            this.tlpMcqAnswers.TabIndex = 0;
            // 
            // rbAnswer1
            // 
            this.rbAnswer1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbAnswer1.AutoSize = true;
            this.rbAnswer1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAnswer1.Location = new System.Drawing.Point(104, 11);
            this.rbAnswer1.Name = "rbAnswer1";
            this.rbAnswer1.Size = new System.Drawing.Size(52, 21);
            this.rbAnswer1.TabIndex = 2;
            this.rbAnswer1.TabStop = true;
            this.rbAnswer1.Text = "True";
            this.rbAnswer1.UseVisualStyleBackColor = true;
            // 
            // rbAnswer2
            // 
            this.rbAnswer2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbAnswer2.AutoSize = true;
            this.rbAnswer2.BackColor = System.Drawing.Color.White;
            this.rbAnswer2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAnswer2.Location = new System.Drawing.Point(363, 11);
            this.rbAnswer2.Name = "rbAnswer2";
            this.rbAnswer2.Size = new System.Drawing.Size(56, 21);
            this.rbAnswer2.TabIndex = 3;
            this.rbAnswer2.TabStop = true;
            this.rbAnswer2.Text = "False";
            this.rbAnswer2.UseVisualStyleBackColor = false;
            // 
            // tbQuestion
            // 
            this.tbQuestion.BackColor = System.Drawing.Color.White;
            this.tbQuestion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbQuestion.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tbQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbQuestion.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbQuestion.ForeColor = System.Drawing.Color.DimGray;
            this.tbQuestion.Location = new System.Drawing.Point(3, 3);
            this.tbQuestion.Multiline = true;
            this.tbQuestion.Name = "tbQuestion";
            this.tbQuestion.Size = new System.Drawing.Size(522, 185);
            this.tbQuestion.TabIndex = 1;
            this.tbQuestion.Tag = "True False Question";
            this.tbQuestion.Text = "True False Question";
            this.tbQuestion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbQuestion.Enter += new System.EventHandler(this.tbQuestion_Enter);
            this.tbQuestion.Leave += new System.EventHandler(this.tbQuestion_Leave);
            // 
            // ucAdd_TrueFalse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tlpTrueFalseQuestionAnswers);
            this.Name = "ucAdd_TrueFalse";
            this.Size = new System.Drawing.Size(528, 241);
            this.tlpTrueFalseQuestionAnswers.ResumeLayout(false);
            this.tlpTrueFalseQuestionAnswers.PerformLayout();
            this.tlpMcqAnswers.ResumeLayout(false);
            this.tlpMcqAnswers.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpTrueFalseQuestionAnswers;
        private System.Windows.Forms.TableLayoutPanel tlpMcqAnswers;
        private System.Windows.Forms.RadioButton rbAnswer1;
        private System.Windows.Forms.RadioButton rbAnswer2;
        private System.Windows.Forms.TextBox tbQuestion;
    }
}
