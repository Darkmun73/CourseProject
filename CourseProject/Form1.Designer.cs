
namespace CourseProject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.numHeshtableSize = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.fldRecipeFile = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.fldReviewFile = new System.Windows.Forms.TextBox();
            this.butNext = new System.Windows.Forms.Button();
            this.butSelectRecipeFile = new System.Windows.Forms.Button();
            this.butSelectReviewFile = new System.Windows.Forms.Button();
            this.butHelp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numHeshtableSize)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите размер хештаблицы с рецептами:";
            // 
            // numHeshtableSize
            // 
            this.numHeshtableSize.Location = new System.Drawing.Point(260, 7);
            this.numHeshtableSize.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numHeshtableSize.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numHeshtableSize.Name = "numHeshtableSize";
            this.numHeshtableSize.Size = new System.Drawing.Size(79, 23);
            this.numHeshtableSize.TabIndex = 1;
            this.numHeshtableSize.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Введите путь к файлу с рецептами:";
            // 
            // fldRecipeFile
            // 
            this.fldRecipeFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fldRecipeFile.Location = new System.Drawing.Point(217, 36);
            this.fldRecipeFile.Name = "fldRecipeFile";
            this.fldRecipeFile.Size = new System.Drawing.Size(418, 23);
            this.fldRecipeFile.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Введите путь к файлу с отзывами:";
            // 
            // fldReviewFile
            // 
            this.fldReviewFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fldReviewFile.Location = new System.Drawing.Point(217, 65);
            this.fldReviewFile.Name = "fldReviewFile";
            this.fldReviewFile.Size = new System.Drawing.Size(418, 23);
            this.fldReviewFile.TabIndex = 5;
            // 
            // butNext
            // 
            this.butNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butNext.Location = new System.Drawing.Point(624, 100);
            this.butNext.Name = "butNext";
            this.butNext.Size = new System.Drawing.Size(75, 23);
            this.butNext.TabIndex = 6;
            this.butNext.Text = "Дальше";
            this.butNext.UseVisualStyleBackColor = true;
            this.butNext.Click += new System.EventHandler(this.butNext_Click);
            // 
            // butSelectRecipeFile
            // 
            this.butSelectRecipeFile.Location = new System.Drawing.Point(641, 36);
            this.butSelectRecipeFile.Name = "butSelectRecipeFile";
            this.butSelectRecipeFile.Size = new System.Drawing.Size(66, 23);
            this.butSelectRecipeFile.TabIndex = 7;
            this.butSelectRecipeFile.Text = "Обзор...";
            this.butSelectRecipeFile.UseVisualStyleBackColor = true;
            this.butSelectRecipeFile.Click += new System.EventHandler(this.butSelectRecipeFile_Click);
            // 
            // butSelectReviewFile
            // 
            this.butSelectReviewFile.Location = new System.Drawing.Point(641, 65);
            this.butSelectReviewFile.Name = "butSelectReviewFile";
            this.butSelectReviewFile.Size = new System.Drawing.Size(66, 23);
            this.butSelectReviewFile.TabIndex = 7;
            this.butSelectReviewFile.Text = "Обзор...";
            this.butSelectReviewFile.UseVisualStyleBackColor = true;
            this.butSelectReviewFile.Click += new System.EventHandler(this.butSelectReviewFile_Click);
            // 
            // butHelp
            // 
            this.butHelp.Location = new System.Drawing.Point(12, 122);
            this.butHelp.Name = "butHelp";
            this.butHelp.Size = new System.Drawing.Size(75, 23);
            this.butHelp.TabIndex = 8;
            this.butHelp.Text = "Справка";
            this.butHelp.UseVisualStyleBackColor = true;
            this.butHelp.Click += new System.EventHandler(this.butHelp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 157);
            this.Controls.Add(this.butHelp);
            this.Controls.Add(this.butSelectReviewFile);
            this.Controls.Add(this.butSelectRecipeFile);
            this.Controls.Add(this.butNext);
            this.Controls.Add(this.fldReviewFile);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fldRecipeFile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numHeshtableSize);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "RecipeAndReviews";
            ((System.ComponentModel.ISupportInitialize)(this.numHeshtableSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numHeshtableSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fldRecipeFile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox fldReviewFile;
        private System.Windows.Forms.Button butNext;
        private System.Windows.Forms.Button butSelectRecipeFile;
        private System.Windows.Forms.Button butSelectReviewFile;
        private System.Windows.Forms.Button butHelp;
    }
}

