namespace SeaAnimalQuiz.UI
{
    partial class ucCategories
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbCategory = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnReptiles = new System.Windows.Forms.Button();
            this.btnBirds = new System.Windows.Forms.Button();
            this.btnFish = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbCategory, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.26671F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.73329F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(329, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lbCategory
            // 
            this.lbCategory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbCategory.AutoSize = true;
            this.lbCategory.Font = new System.Drawing.Font("Century", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCategory.ForeColor = System.Drawing.Color.White;
            this.lbCategory.Location = new System.Drawing.Point(17, 24);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Size = new System.Drawing.Size(295, 33);
            this.lbCategory.TabIndex = 2;
            this.lbCategory.Text = "Select Any Category";
            this.lbCategory.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.btnReptiles);
            this.panel1.Controls.Add(this.btnBirds);
            this.panel1.Controls.Add(this.btnFish);
            this.panel1.Location = new System.Drawing.Point(3, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(323, 362);
            this.panel1.TabIndex = 3;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBack.BackColor = System.Drawing.Color.DarkOrange;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(23, 291);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(89, 45);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnReptiles
            // 
            this.btnReptiles.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnReptiles.BackColor = System.Drawing.Color.DarkOrange;
            this.btnReptiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReptiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReptiles.ForeColor = System.Drawing.Color.White;
            this.btnReptiles.Location = new System.Drawing.Point(20, 156);
            this.btnReptiles.Name = "btnReptiles";
            this.btnReptiles.Size = new System.Drawing.Size(283, 45);
            this.btnReptiles.TabIndex = 0;
            this.btnReptiles.Text = "Reptiles";
            this.btnReptiles.UseVisualStyleBackColor = false;
            // 
            // btnBirds
            // 
            this.btnBirds.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBirds.BackColor = System.Drawing.Color.DarkOrange;
            this.btnBirds.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBirds.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBirds.ForeColor = System.Drawing.Color.White;
            this.btnBirds.Location = new System.Drawing.Point(20, 12);
            this.btnBirds.Name = "btnBirds";
            this.btnBirds.Size = new System.Drawing.Size(283, 45);
            this.btnBirds.TabIndex = 0;
            this.btnBirds.Text = "Birds";
            this.btnBirds.UseVisualStyleBackColor = false;
            // 
            // btnFish
            // 
            this.btnFish.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnFish.BackColor = System.Drawing.Color.DarkOrange;
            this.btnFish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFish.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFish.ForeColor = System.Drawing.Color.White;
            this.btnFish.Location = new System.Drawing.Point(20, 84);
            this.btnFish.Name = "btnFish";
            this.btnFish.Size = new System.Drawing.Size(283, 45);
            this.btnFish.TabIndex = 0;
            this.btnFish.Text = "Fish";
            this.btnFish.UseVisualStyleBackColor = false;
            this.btnFish.Click += new System.EventHandler(this.btnFish_Click);
            // 
            // ucCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ucCategories";
            this.Size = new System.Drawing.Size(329, 450);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbCategory;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnReptiles;
        private System.Windows.Forms.Button btnBirds;
        private System.Windows.Forms.Button btnFish;
    }
}
