namespace SeaAnimalQuiz.UI
{
    partial class ucQuizResult
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
            this.dgvIncorrectQuestions = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lbTotalScore = new System.Windows.Forms.Label();
            this.lbObtainedByTotal = new System.Windows.Forms.Label();
            this.cQuestion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCorrectAnswer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncorrectQuestions)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvIncorrectQuestions
            // 
            this.dgvIncorrectQuestions.AllowUserToAddRows = false;
            this.dgvIncorrectQuestions.AllowUserToDeleteRows = false;
            this.dgvIncorrectQuestions.AllowUserToResizeColumns = false;
            this.dgvIncorrectQuestions.AllowUserToResizeRows = false;
            this.dgvIncorrectQuestions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvIncorrectQuestions.BackgroundColor = System.Drawing.Color.White;
            this.dgvIncorrectQuestions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvIncorrectQuestions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIncorrectQuestions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cQuestion,
            this.cCorrectAnswer});
            this.dgvIncorrectQuestions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvIncorrectQuestions.GridColor = System.Drawing.Color.LightGray;
            this.dgvIncorrectQuestions.Location = new System.Drawing.Point(3, 3);
            this.dgvIncorrectQuestions.Name = "dgvIncorrectQuestions";
            this.dgvIncorrectQuestions.ReadOnly = true;
            this.dgvIncorrectQuestions.RowHeadersVisible = false;
            this.dgvIncorrectQuestions.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvIncorrectQuestions.ShowCellErrors = false;
            this.dgvIncorrectQuestions.ShowCellToolTips = false;
            this.dgvIncorrectQuestions.ShowEditingIcon = false;
            this.dgvIncorrectQuestions.ShowRowErrors = false;
            this.dgvIncorrectQuestions.Size = new System.Drawing.Size(522, 197);
            this.dgvIncorrectQuestions.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dgvIncorrectQuestions, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.23237F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.76763F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(528, 241);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 206);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(522, 32);
            this.panel1.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.19157F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.80843F));
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(522, 32);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Completed!";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tableLayoutPanel2.Controls.Add(this.lbTotalScore, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbObtainedByTotal, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(330, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(189, 26);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // lbTotalScore
            // 
            this.lbTotalScore.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbTotalScore.AutoSize = true;
            this.lbTotalScore.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalScore.Location = new System.Drawing.Point(28, 2);
            this.lbTotalScore.Name = "lbTotalScore";
            this.lbTotalScore.Size = new System.Drawing.Size(99, 21);
            this.lbTotalScore.TabIndex = 2;
            this.lbTotalScore.Text = "Total Score :";
            // 
            // lbObtainedByTotal
            // 
            this.lbObtainedByTotal.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbObtainedByTotal.AutoSize = true;
            this.lbObtainedByTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbObtainedByTotal.Location = new System.Drawing.Point(133, 2);
            this.lbObtainedByTotal.Name = "lbObtainedByTotal";
            this.lbObtainedByTotal.Size = new System.Drawing.Size(50, 21);
            this.lbObtainedByTotal.TabIndex = 2;
            this.lbObtainedByTotal.Text = "score";
            // 
            // cQuestion
            // 
            this.cQuestion.HeaderText = "Incorrect Quesetion";
            this.cQuestion.Name = "cQuestion";
            this.cQuestion.ReadOnly = true;
            // 
            // cCorrectAnswer
            // 
            this.cCorrectAnswer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cCorrectAnswer.HeaderText = "Correct Answer";
            this.cCorrectAnswer.Name = "cCorrectAnswer";
            this.cCorrectAnswer.ReadOnly = true;
            this.cCorrectAnswer.Width = 96;
            // 
            // ucQuizResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ucQuizResult";
            this.Size = new System.Drawing.Size(528, 241);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncorrectQuestions)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvIncorrectQuestions;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lbTotalScore;
        private System.Windows.Forms.Label lbObtainedByTotal;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cQuestion;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCorrectAnswer;
    }
}
