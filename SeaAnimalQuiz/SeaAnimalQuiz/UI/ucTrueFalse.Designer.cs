namespace SeaAnimalQuiz.UI
{
    partial class ucTrueFalse
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
            this.tlpTrueFalseQuestionAnswers = new System.Windows.Forms.TableLayoutPanel();
            this.tlpMcqAnswers = new System.Windows.Forms.TableLayoutPanel();
            this.rbAnswer1 = new System.Windows.Forms.RadioButton();
            this.rbAnswer2 = new System.Windows.Forms.RadioButton();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.pnlQuestion = new System.Windows.Forms.Panel();
            this.tbQuestionText = new System.Windows.Forms.TextBox();
            this.pbQuestion = new System.Windows.Forms.PictureBox();
            this.tmrNextQuestion = new System.Windows.Forms.Timer(this.components);
            this.tlpTrueFalseQuestionAnswers.SuspendLayout();
            this.tlpMcqAnswers.SuspendLayout();
            this.pnlQuestion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuestion)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpTrueFalseQuestionAnswers
            // 
            this.tlpTrueFalseQuestionAnswers.BackColor = System.Drawing.Color.White;
            this.tlpTrueFalseQuestionAnswers.ColumnCount = 1;
            this.tlpTrueFalseQuestionAnswers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpTrueFalseQuestionAnswers.Controls.Add(this.tlpMcqAnswers, 0, 1);
            this.tlpTrueFalseQuestionAnswers.Controls.Add(this.pnlQuestion, 0, 0);
            this.tlpTrueFalseQuestionAnswers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTrueFalseQuestionAnswers.Location = new System.Drawing.Point(0, 0);
            this.tlpTrueFalseQuestionAnswers.Name = "tlpTrueFalseQuestionAnswers";
            this.tlpTrueFalseQuestionAnswers.RowCount = 2;
            this.tlpTrueFalseQuestionAnswers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.16597F));
            this.tlpTrueFalseQuestionAnswers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.83403F));
            this.tlpTrueFalseQuestionAnswers.Size = new System.Drawing.Size(528, 241);
            this.tlpTrueFalseQuestionAnswers.TabIndex = 3;
            // 
            // tlpMcqAnswers
            // 
            this.tlpMcqAnswers.ColumnCount = 2;
            this.tlpMcqAnswers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMcqAnswers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMcqAnswers.Controls.Add(this.rbAnswer1, 0, 0);
            this.tlpMcqAnswers.Controls.Add(this.rbAnswer2, 1, 0);
            this.tlpMcqAnswers.Controls.Add(this.btnSubmit, 1, 1);
            this.tlpMcqAnswers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMcqAnswers.Location = new System.Drawing.Point(3, 147);
            this.tlpMcqAnswers.Name = "tlpMcqAnswers";
            this.tlpMcqAnswers.RowCount = 2;
            this.tlpMcqAnswers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMcqAnswers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMcqAnswers.Size = new System.Drawing.Size(522, 91);
            this.tlpMcqAnswers.TabIndex = 0;
            // 
            // rbAnswer1
            // 
            this.rbAnswer1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbAnswer1.AutoSize = true;
            this.rbAnswer1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAnswer1.Location = new System.Drawing.Point(104, 12);
            this.rbAnswer1.Name = "rbAnswer1";
            this.rbAnswer1.Size = new System.Drawing.Size(52, 21);
            this.rbAnswer1.TabIndex = 0;
            this.rbAnswer1.Text = "True";
            this.rbAnswer1.UseVisualStyleBackColor = true;
            // 
            // rbAnswer2
            // 
            this.rbAnswer2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbAnswer2.AutoSize = true;
            this.rbAnswer2.BackColor = System.Drawing.Color.White;
            this.rbAnswer2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAnswer2.Location = new System.Drawing.Point(363, 12);
            this.rbAnswer2.Name = "rbAnswer2";
            this.rbAnswer2.Size = new System.Drawing.Size(56, 21);
            this.rbAnswer2.TabIndex = 1;
            this.rbAnswer2.Text = "False";
            this.rbAnswer2.UseVisualStyleBackColor = false;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSubmit.BackColor = System.Drawing.Color.SlateGray;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(443, 48);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(76, 39);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // pnlQuestion
            // 
            this.pnlQuestion.Controls.Add(this.tbQuestionText);
            this.pnlQuestion.Controls.Add(this.pbQuestion);
            this.pnlQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlQuestion.Location = new System.Drawing.Point(3, 3);
            this.pnlQuestion.Name = "pnlQuestion";
            this.pnlQuestion.Size = new System.Drawing.Size(522, 138);
            this.pnlQuestion.TabIndex = 1;
            // 
            // tbQuestionText
            // 
            this.tbQuestionText.BackColor = System.Drawing.Color.White;
            this.tbQuestionText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbQuestionText.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbQuestionText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbQuestionText.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbQuestionText.Location = new System.Drawing.Point(0, 0);
            this.tbQuestionText.Multiline = true;
            this.tbQuestionText.Name = "tbQuestionText";
            this.tbQuestionText.ReadOnly = true;
            this.tbQuestionText.ShortcutsEnabled = false;
            this.tbQuestionText.Size = new System.Drawing.Size(384, 138);
            this.tbQuestionText.TabIndex = 4;
            this.tbQuestionText.Text = "True False Questions";
            this.tbQuestionText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pbQuestion
            // 
            this.pbQuestion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbQuestion.Dock = System.Windows.Forms.DockStyle.Right;
            this.pbQuestion.Location = new System.Drawing.Point(384, 0);
            this.pbQuestion.Name = "pbQuestion";
            this.pbQuestion.Size = new System.Drawing.Size(138, 138);
            this.pbQuestion.TabIndex = 3;
            this.pbQuestion.TabStop = false;
            // 
            // tmrNextQuestion
            // 
            this.tmrNextQuestion.Interval = 800;
            this.tmrNextQuestion.Tick += new System.EventHandler(this.tmrNextQuestion_Tick);
            // 
            // ucTrueFalse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tlpTrueFalseQuestionAnswers);
            this.Name = "ucTrueFalse";
            this.Size = new System.Drawing.Size(528, 241);
            this.tlpTrueFalseQuestionAnswers.ResumeLayout(false);
            this.tlpMcqAnswers.ResumeLayout(false);
            this.tlpMcqAnswers.PerformLayout();
            this.pnlQuestion.ResumeLayout(false);
            this.pnlQuestion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuestion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpTrueFalseQuestionAnswers;
        private System.Windows.Forms.TableLayoutPanel tlpMcqAnswers;
        private System.Windows.Forms.RadioButton rbAnswer1;
        private System.Windows.Forms.RadioButton rbAnswer2;
        private System.Windows.Forms.Timer tmrNextQuestion;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Panel pnlQuestion;
        private System.Windows.Forms.TextBox tbQuestionText;
        private System.Windows.Forms.PictureBox pbQuestion;
    }
}
