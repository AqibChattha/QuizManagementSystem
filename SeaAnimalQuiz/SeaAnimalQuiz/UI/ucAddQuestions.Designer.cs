namespace SeaAnimalQuiz.UI
{
    partial class ucAddQuestions
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
            this.btnBack = new System.Windows.Forms.Button();
            this.pnlAddQuestion = new System.Windows.Forms.Panel();
            this.pbAddQestionBackground = new System.Windows.Forms.PictureBox();
            this.cbCategories = new System.Windows.Forms.ComboBox();
            this.rbtnMcq = new System.Windows.Forms.RadioButton();
            this.rbtnTrueFalse = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddQestionBackground)).BeginInit();
            this.SuspendLayout();
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
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pnlAddQuestion
            // 
            this.pnlAddQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAddQuestion.BackColor = System.Drawing.Color.White;
            this.pnlAddQuestion.Location = new System.Drawing.Point(128, 130);
            this.pnlAddQuestion.Name = "pnlAddQuestion";
            this.pnlAddQuestion.Size = new System.Drawing.Size(528, 198);
            this.pnlAddQuestion.TabIndex = 4;
            // 
            // pbAddQestionBackground
            // 
            this.pbAddQestionBackground.BackgroundImage = global::SeaAnimalQuiz.Properties.Resources.question;
            this.pbAddQestionBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbAddQestionBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbAddQestionBackground.Location = new System.Drawing.Point(0, 0);
            this.pbAddQestionBackground.Name = "pbAddQestionBackground";
            this.pbAddQestionBackground.Size = new System.Drawing.Size(784, 450);
            this.pbAddQestionBackground.TabIndex = 3;
            this.pbAddQestionBackground.TabStop = false;
            // 
            // cbCategories
            // 
            this.cbCategories.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbCategories.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCategories.FormattingEnabled = true;
            this.cbCategories.Items.AddRange(new object[] {
            "Fish",
            "Birds",
            "Reptiles"});
            this.cbCategories.Location = new System.Drawing.Point(180, 103);
            this.cbCategories.Name = "cbCategories";
            this.cbCategories.Size = new System.Drawing.Size(121, 21);
            this.cbCategories.TabIndex = 6;
            // 
            // rbtnMcq
            // 
            this.rbtnMcq.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.rbtnMcq.AutoSize = true;
            this.rbtnMcq.Location = new System.Drawing.Point(516, 107);
            this.rbtnMcq.Name = "rbtnMcq";
            this.rbtnMcq.Size = new System.Drawing.Size(49, 17);
            this.rbtnMcq.TabIndex = 7;
            this.rbtnMcq.TabStop = true;
            this.rbtnMcq.Text = "MCQ";
            this.rbtnMcq.UseVisualStyleBackColor = true;
            this.rbtnMcq.CheckedChanged += new System.EventHandler(this.rbtnMcq_CheckedChanged);
            // 
            // rbtnTrueFalse
            // 
            this.rbtnTrueFalse.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.rbtnTrueFalse.AutoSize = true;
            this.rbtnTrueFalse.Location = new System.Drawing.Point(571, 107);
            this.rbtnTrueFalse.Name = "rbtnTrueFalse";
            this.rbtnTrueFalse.Size = new System.Drawing.Size(75, 17);
            this.rbtnTrueFalse.TabIndex = 8;
            this.rbtnTrueFalse.TabStop = true;
            this.rbtnTrueFalse.Text = "True False";
            this.rbtnTrueFalse.UseVisualStyleBackColor = true;
            this.rbtnTrueFalse.CheckedChanged += new System.EventHandler(this.rbtnTrueFalse_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Category";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAdd.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(571, 334);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(89, 33);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // ucAddQuestions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbtnTrueFalse);
            this.Controls.Add(this.rbtnMcq);
            this.Controls.Add(this.cbCategories);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pnlAddQuestion);
            this.Controls.Add(this.pbAddQestionBackground);
            this.Name = "ucAddQuestions";
            this.Size = new System.Drawing.Size(784, 450);
            this.Load += new System.EventHandler(this.ucAddQuestions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbAddQestionBackground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel pnlAddQuestion;
        private System.Windows.Forms.PictureBox pbAddQestionBackground;
        private System.Windows.Forms.ComboBox cbCategories;
        private System.Windows.Forms.RadioButton rbtnMcq;
        private System.Windows.Forms.RadioButton rbtnTrueFalse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
    }
}
