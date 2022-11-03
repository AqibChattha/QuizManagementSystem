namespace SeaAnimalQuiz.UI
{
    partial class ucMCQ
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
            this.btnAnswer1 = new System.Windows.Forms.Button();
            this.btnAnswer2 = new System.Windows.Forms.Button();
            this.btnAnswer3 = new System.Windows.Forms.Button();
            this.btnAnswer4 = new System.Windows.Forms.Button();
            this.tbQuestionText = new System.Windows.Forms.TextBox();
            this.tmrNextQuestion = new System.Windows.Forms.Timer(this.components);
            this.tlpMcqQuestionAnswers.SuspendLayout();
            this.tlpMcqAnswers.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMcqQuestionAnswers
            // 
            this.tlpMcqQuestionAnswers.BackColor = System.Drawing.Color.White;
            this.tlpMcqQuestionAnswers.ColumnCount = 1;
            this.tlpMcqQuestionAnswers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMcqQuestionAnswers.Controls.Add(this.tlpMcqAnswers, 0, 1);
            this.tlpMcqQuestionAnswers.Controls.Add(this.tbQuestionText, 0, 0);
            this.tlpMcqQuestionAnswers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMcqQuestionAnswers.Location = new System.Drawing.Point(0, 0);
            this.tlpMcqQuestionAnswers.Name = "tlpMcqQuestionAnswers";
            this.tlpMcqQuestionAnswers.RowCount = 2;
            this.tlpMcqQuestionAnswers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.16597F));
            this.tlpMcqQuestionAnswers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.83403F));
            this.tlpMcqQuestionAnswers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMcqQuestionAnswers.Size = new System.Drawing.Size(528, 241);
            this.tlpMcqQuestionAnswers.TabIndex = 2;
            // 
            // tlpMcqAnswers
            // 
            this.tlpMcqAnswers.ColumnCount = 2;
            this.tlpMcqAnswers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMcqAnswers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMcqAnswers.Controls.Add(this.btnAnswer1, 0, 0);
            this.tlpMcqAnswers.Controls.Add(this.btnAnswer2, 1, 0);
            this.tlpMcqAnswers.Controls.Add(this.btnAnswer3, 0, 1);
            this.tlpMcqAnswers.Controls.Add(this.btnAnswer4, 1, 1);
            this.tlpMcqAnswers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMcqAnswers.Location = new System.Drawing.Point(3, 147);
            this.tlpMcqAnswers.Name = "tlpMcqAnswers";
            this.tlpMcqAnswers.RowCount = 2;
            this.tlpMcqAnswers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMcqAnswers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMcqAnswers.Size = new System.Drawing.Size(522, 91);
            this.tlpMcqAnswers.TabIndex = 0;
            // 
            // btnAnswer1
            // 
            this.btnAnswer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnswer1.BackColor = System.Drawing.Color.SlateGray;
            this.btnAnswer1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnswer1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnswer1.ForeColor = System.Drawing.Color.White;
            this.btnAnswer1.Location = new System.Drawing.Point(3, 3);
            this.btnAnswer1.Name = "btnAnswer1";
            this.btnAnswer1.Size = new System.Drawing.Size(255, 39);
            this.btnAnswer1.TabIndex = 1;
            this.btnAnswer1.Text = "Answer 1";
            this.btnAnswer1.UseVisualStyleBackColor = false;
            this.btnAnswer1.Click += new System.EventHandler(this.btnAnswer_Click);
            // 
            // btnAnswer2
            // 
            this.btnAnswer2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnswer2.BackColor = System.Drawing.Color.SlateGray;
            this.btnAnswer2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnswer2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnswer2.ForeColor = System.Drawing.Color.White;
            this.btnAnswer2.Location = new System.Drawing.Point(264, 3);
            this.btnAnswer2.Name = "btnAnswer2";
            this.btnAnswer2.Size = new System.Drawing.Size(255, 39);
            this.btnAnswer2.TabIndex = 1;
            this.btnAnswer2.Text = "Answer 2";
            this.btnAnswer2.UseVisualStyleBackColor = false;
            this.btnAnswer2.Click += new System.EventHandler(this.btnAnswer_Click);
            // 
            // btnAnswer3
            // 
            this.btnAnswer3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnswer3.BackColor = System.Drawing.Color.SlateGray;
            this.btnAnswer3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnswer3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnswer3.ForeColor = System.Drawing.Color.White;
            this.btnAnswer3.Location = new System.Drawing.Point(3, 48);
            this.btnAnswer3.Name = "btnAnswer3";
            this.btnAnswer3.Size = new System.Drawing.Size(255, 40);
            this.btnAnswer3.TabIndex = 1;
            this.btnAnswer3.Text = "Answer 3";
            this.btnAnswer3.UseVisualStyleBackColor = false;
            this.btnAnswer3.Click += new System.EventHandler(this.btnAnswer_Click);
            // 
            // btnAnswer4
            // 
            this.btnAnswer4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnswer4.BackColor = System.Drawing.Color.SlateGray;
            this.btnAnswer4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnswer4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnswer4.ForeColor = System.Drawing.Color.White;
            this.btnAnswer4.Location = new System.Drawing.Point(264, 48);
            this.btnAnswer4.Name = "btnAnswer4";
            this.btnAnswer4.Size = new System.Drawing.Size(255, 40);
            this.btnAnswer4.TabIndex = 1;
            this.btnAnswer4.Text = "Answer 4";
            this.btnAnswer4.UseVisualStyleBackColor = false;
            this.btnAnswer4.Click += new System.EventHandler(this.btnAnswer_Click);
            // 
            // tbQuestionText
            // 
            this.tbQuestionText.BackColor = System.Drawing.Color.White;
            this.tbQuestionText.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbQuestionText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbQuestionText.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbQuestionText.Location = new System.Drawing.Point(3, 3);
            this.tbQuestionText.Multiline = true;
            this.tbQuestionText.Name = "tbQuestionText";
            this.tbQuestionText.ReadOnly = true;
            this.tbQuestionText.ShortcutsEnabled = false;
            this.tbQuestionText.Size = new System.Drawing.Size(522, 138);
            this.tbQuestionText.TabIndex = 1;
            this.tbQuestionText.Text = "Multiple Choice Questions";
            this.tbQuestionText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tmrNextQuestion
            // 
            this.tmrNextQuestion.Interval = 800;
            this.tmrNextQuestion.Tick += new System.EventHandler(this.tmrNextQuestion_Tick);
            // 
            // ucMCQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tlpMcqQuestionAnswers);
            this.Name = "ucMCQ";
            this.Size = new System.Drawing.Size(528, 241);
            this.tlpMcqQuestionAnswers.ResumeLayout(false);
            this.tlpMcqQuestionAnswers.PerformLayout();
            this.tlpMcqAnswers.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMcqQuestionAnswers;
        private System.Windows.Forms.TableLayoutPanel tlpMcqAnswers;
        private System.Windows.Forms.Button btnAnswer1;
        private System.Windows.Forms.Button btnAnswer2;
        private System.Windows.Forms.Button btnAnswer3;
        private System.Windows.Forms.Button btnAnswer4;
        private System.Windows.Forms.Timer tmrNextQuestion;
        private System.Windows.Forms.TextBox tbQuestionText;
    }
}
