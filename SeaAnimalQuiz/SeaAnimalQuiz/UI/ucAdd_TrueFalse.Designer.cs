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
            this.pnlQuestionSection = new System.Windows.Forms.Panel();
            this.tbQuestion = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pbQuestion = new System.Windows.Forms.PictureBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tlpTrueFalseQuestionAnswers.SuspendLayout();
            this.tlpMcqAnswers.SuspendLayout();
            this.pnlQuestionSection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuestion)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpTrueFalseQuestionAnswers
            // 
            this.tlpTrueFalseQuestionAnswers.BackColor = System.Drawing.Color.White;
            this.tlpTrueFalseQuestionAnswers.ColumnCount = 1;
            this.tlpTrueFalseQuestionAnswers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpTrueFalseQuestionAnswers.Controls.Add(this.tlpMcqAnswers, 0, 1);
            this.tlpTrueFalseQuestionAnswers.Controls.Add(this.pnlQuestionSection, 0, 0);
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
            // pnlQuestionSection
            // 
            this.pnlQuestionSection.Controls.Add(this.tbQuestion);
            this.pnlQuestionSection.Controls.Add(this.tableLayoutPanel2);
            this.pnlQuestionSection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlQuestionSection.Location = new System.Drawing.Point(3, 3);
            this.pnlQuestionSection.Name = "pnlQuestionSection";
            this.pnlQuestionSection.Size = new System.Drawing.Size(522, 185);
            this.pnlQuestionSection.TabIndex = 1;
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
            this.tbQuestion.Size = new System.Drawing.Size(361, 185);
            this.tbQuestion.TabIndex = 8;
            this.tbQuestion.Tag = "Question";
            this.tbQuestion.Text = "Question";
            this.tbQuestion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbQuestion.Enter += new System.EventHandler(this.tbQuestion_Enter);
            this.tbQuestion.Leave += new System.EventHandler(this.tbQuestion_Leave);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pbQuestion
            // 
            this.pbQuestion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbQuestion.Location = new System.Drawing.Point(3, 3);
            this.pbQuestion.Name = "pbQuestion";
            this.pbQuestion.Size = new System.Drawing.Size(155, 141);
            this.pbQuestion.TabIndex = 0;
            this.pbQuestion.TabStop = false;
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
            this.btnBrowse.Location = new System.Drawing.Point(98, 152);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(60, 27);
            this.btnBrowse.TabIndex = 3;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnBrowse, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.pbQuestion, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(361, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 79.45946F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.54054F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(161, 185);
            this.tableLayoutPanel2.TabIndex = 7;
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
            this.tlpMcqAnswers.ResumeLayout(false);
            this.tlpMcqAnswers.PerformLayout();
            this.pnlQuestionSection.ResumeLayout(false);
            this.pnlQuestionSection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuestion)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpTrueFalseQuestionAnswers;
        private System.Windows.Forms.TableLayoutPanel tlpMcqAnswers;
        private System.Windows.Forms.RadioButton rbAnswer1;
        private System.Windows.Forms.RadioButton rbAnswer2;
        private System.Windows.Forms.Panel pnlQuestionSection;
        private System.Windows.Forms.TextBox tbQuestion;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.PictureBox pbQuestion;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
