
namespace CourseProject
{
    partial class Form2
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lstRecipeHeshtable = new System.Windows.Forms.ListBox();
            this.fldReviewTree = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.fldRecipeName = new System.Windows.Forms.TextBox();
            this.fldRecipeAuthor = new System.Windows.Forms.TextBox();
            this.fldRecipeDate = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.butAddRecipe = new System.Windows.Forms.Button();
            this.butDelRecipe = new System.Windows.Forms.Button();
            this.butFindRecipe = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.fldReviewRecipeName = new System.Windows.Forms.TextBox();
            this.fldReviewRecipeAuthor = new System.Windows.Forms.TextBox();
            this.fldReviewDate = new System.Windows.Forms.MaskedTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.butAddReview = new System.Windows.Forms.Button();
            this.butDelReview = new System.Windows.Forms.Button();
            this.butFindReview = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.fldReviewAuthor = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.fldReviewText = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.butDelAllRecipes = new System.Windows.Forms.Button();
            this.butSearchTask = new System.Windows.Forms.Button();
            this.fldSearchTask = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstRecipeHeshtable
            // 
            this.lstRecipeHeshtable.FormattingEnabled = true;
            this.lstRecipeHeshtable.HorizontalScrollbar = true;
            this.lstRecipeHeshtable.ItemHeight = 15;
            this.lstRecipeHeshtable.Location = new System.Drawing.Point(12, 27);
            this.lstRecipeHeshtable.Name = "lstRecipeHeshtable";
            this.lstRecipeHeshtable.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lstRecipeHeshtable.Size = new System.Drawing.Size(439, 334);
            this.lstRecipeHeshtable.TabIndex = 0;
            // 
            // fldReviewTree
            // 
            this.fldReviewTree.Location = new System.Drawing.Point(457, 27);
            this.fldReviewTree.Multiline = true;
            this.fldReviewTree.Name = "fldReviewTree";
            this.fldReviewTree.ReadOnly = true;
            this.fldReviewTree.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.fldReviewTree.Size = new System.Drawing.Size(689, 243);
            this.fldReviewTree.TabIndex = 1;
            this.fldReviewTree.WordWrap = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Хештаблица рецептов:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(457, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Дерево отзывов:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 405);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Название рецепта:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 429);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Автор рецепта:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 453);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 15);
            this.label9.TabIndex = 4;
            this.label9.Text = "Дата создания рецепта:";
            // 
            // fldRecipeName
            // 
            this.fldRecipeName.Location = new System.Drawing.Point(136, 402);
            this.fldRecipeName.Name = "fldRecipeName";
            this.fldRecipeName.Size = new System.Drawing.Size(132, 23);
            this.fldRecipeName.TabIndex = 6;
            // 
            // fldRecipeAuthor
            // 
            this.fldRecipeAuthor.Location = new System.Drawing.Point(116, 427);
            this.fldRecipeAuthor.Name = "fldRecipeAuthor";
            this.fldRecipeAuthor.Size = new System.Drawing.Size(152, 23);
            this.fldRecipeAuthor.TabIndex = 6;
            // 
            // fldRecipeDate
            // 
            this.fldRecipeDate.Location = new System.Drawing.Point(162, 453);
            this.fldRecipeDate.Mask = "00/00/0000";
            this.fldRecipeDate.Name = "fldRecipeDate";
            this.fldRecipeDate.Size = new System.Drawing.Size(106, 23);
            this.fldRecipeDate.TabIndex = 7;
            this.toolTip1.SetToolTip(this.fldRecipeDate, "Если дата не будет введена, то за нее возьмется текущая дата");
            this.fldRecipeDate.ValidatingType = typeof(System.DateTime);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 369);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(231, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Обязательные для ввода поля отмечены";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(253, 367);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 19);
            this.label8.TabIndex = 5;
            this.label8.Text = "*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(9, 427);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(15, 19);
            this.label10.TabIndex = 5;
            this.label10.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(9, 402);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "*";
            // 
            // butAddRecipe
            // 
            this.butAddRecipe.Location = new System.Drawing.Point(31, 482);
            this.butAddRecipe.Name = "butAddRecipe";
            this.butAddRecipe.Size = new System.Drawing.Size(75, 23);
            this.butAddRecipe.TabIndex = 9;
            this.butAddRecipe.Text = "Добавить";
            this.butAddRecipe.UseVisualStyleBackColor = true;
            this.butAddRecipe.Click += new System.EventHandler(this.butAddRecipe_Click);
            // 
            // butDelRecipe
            // 
            this.butDelRecipe.Location = new System.Drawing.Point(112, 482);
            this.butDelRecipe.Name = "butDelRecipe";
            this.butDelRecipe.Size = new System.Drawing.Size(75, 23);
            this.butDelRecipe.TabIndex = 9;
            this.butDelRecipe.Text = "Удалить";
            this.butDelRecipe.UseVisualStyleBackColor = true;
            this.butDelRecipe.Click += new System.EventHandler(this.butDelRecipe_Click);
            // 
            // butFindRecipe
            // 
            this.butFindRecipe.Location = new System.Drawing.Point(193, 482);
            this.butFindRecipe.Name = "butFindRecipe";
            this.butFindRecipe.Size = new System.Drawing.Size(75, 23);
            this.butFindRecipe.TabIndex = 9;
            this.butFindRecipe.Text = "Найти";
            this.butFindRecipe.UseVisualStyleBackColor = true;
            this.butFindRecipe.Click += new System.EventHandler(this.butFindRecipe_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(893, 312);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 15);
            this.label7.TabIndex = 4;
            this.label7.Text = "Название рецепта:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(893, 336);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 15);
            this.label11.TabIndex = 4;
            this.label11.Text = "Автор рецепта:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(893, 387);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(165, 15);
            this.label12.TabIndex = 4;
            this.label12.Text = "Дата опубликования отзыва:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(1125, 274);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(15, 19);
            this.label13.TabIndex = 5;
            this.label13.Text = "*";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(881, 309);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(15, 19);
            this.label14.TabIndex = 5;
            this.label14.Text = "*";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(881, 334);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(15, 19);
            this.label15.TabIndex = 5;
            this.label15.Text = "*";
            // 
            // fldReviewRecipeName
            // 
            this.fldReviewRecipeName.Location = new System.Drawing.Point(1008, 309);
            this.fldReviewRecipeName.Name = "fldReviewRecipeName";
            this.fldReviewRecipeName.Size = new System.Drawing.Size(132, 23);
            this.fldReviewRecipeName.TabIndex = 6;
            // 
            // fldReviewRecipeAuthor
            // 
            this.fldReviewRecipeAuthor.Location = new System.Drawing.Point(988, 334);
            this.fldReviewRecipeAuthor.Name = "fldReviewRecipeAuthor";
            this.fldReviewRecipeAuthor.Size = new System.Drawing.Size(152, 23);
            this.fldReviewRecipeAuthor.TabIndex = 6;
            // 
            // fldReviewDate
            // 
            this.fldReviewDate.Location = new System.Drawing.Point(1064, 387);
            this.fldReviewDate.Mask = "00/00/0000";
            this.fldReviewDate.Name = "fldReviewDate";
            this.fldReviewDate.Size = new System.Drawing.Size(76, 23);
            this.fldReviewDate.TabIndex = 7;
            this.toolTip1.SetToolTip(this.fldReviewDate, "Если дата не будет введена, то за нее возьмется текущая дата");
            this.fldReviewDate.ValidatingType = typeof(System.DateTime);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(893, 276);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(231, 15);
            this.label16.TabIndex = 8;
            this.label16.Text = "Обязательные для ввода поля отмечены";
            // 
            // butAddReview
            // 
            this.butAddReview.Location = new System.Drawing.Point(903, 550);
            this.butAddReview.Name = "butAddReview";
            this.butAddReview.Size = new System.Drawing.Size(75, 23);
            this.butAddReview.TabIndex = 9;
            this.butAddReview.Text = "Добавить";
            this.butAddReview.UseVisualStyleBackColor = true;
            this.butAddReview.Click += new System.EventHandler(this.butAddReview_Click);
            // 
            // butDelReview
            // 
            this.butDelReview.Location = new System.Drawing.Point(984, 550);
            this.butDelReview.Name = "butDelReview";
            this.butDelReview.Size = new System.Drawing.Size(75, 23);
            this.butDelReview.TabIndex = 9;
            this.butDelReview.Text = "Удалить";
            this.butDelReview.UseVisualStyleBackColor = true;
            this.butDelReview.Click += new System.EventHandler(this.butDelReview_Click);
            // 
            // butFindReview
            // 
            this.butFindReview.Location = new System.Drawing.Point(1065, 550);
            this.butFindReview.Name = "butFindReview";
            this.butFindReview.Size = new System.Drawing.Size(75, 23);
            this.butFindReview.TabIndex = 9;
            this.butFindReview.Text = "Найти";
            this.butFindReview.UseVisualStyleBackColor = true;
            this.butFindReview.Click += new System.EventHandler(this.butFindReview_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(893, 363);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(84, 15);
            this.label17.TabIndex = 4;
            this.label17.Text = "Автор отзыва:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label18.ForeColor = System.Drawing.Color.Red;
            this.label18.Location = new System.Drawing.Point(881, 361);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(15, 19);
            this.label18.TabIndex = 5;
            this.label18.Text = "*";
            // 
            // fldReviewAuthor
            // 
            this.fldReviewAuthor.Location = new System.Drawing.Point(988, 361);
            this.fldReviewAuthor.Name = "fldReviewAuthor";
            this.fldReviewAuthor.Size = new System.Drawing.Size(152, 23);
            this.fldReviewAuthor.TabIndex = 6;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(893, 411);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(80, 15);
            this.label19.TabIndex = 4;
            this.label19.Text = "Текст отзыва:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label20.ForeColor = System.Drawing.Color.Red;
            this.label20.Location = new System.Drawing.Point(881, 409);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(15, 19);
            this.label20.TabIndex = 5;
            this.label20.Text = "*";
            // 
            // fldReviewText
            // 
            this.fldReviewText.Location = new System.Drawing.Point(893, 429);
            this.fldReviewText.Multiline = true;
            this.fldReviewText.Name = "fldReviewText";
            this.fldReviewText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.fldReviewText.Size = new System.Drawing.Size(247, 115);
            this.fldReviewText.TabIndex = 6;
            // 
            // butDelAllRecipes
            // 
            this.butDelAllRecipes.Location = new System.Drawing.Point(79, 511);
            this.butDelAllRecipes.Name = "butDelAllRecipes";
            this.butDelAllRecipes.Size = new System.Drawing.Size(140, 23);
            this.butDelAllRecipes.TabIndex = 10;
            this.butDelAllRecipes.Text = "Удалить все рецепты";
            this.butDelAllRecipes.UseVisualStyleBackColor = true;
            this.butDelAllRecipes.Click += new System.EventHandler(this.butDelAllRecipes_Click);
            // 
            // butSearchTask
            // 
            this.butSearchTask.Location = new System.Drawing.Point(225, 511);
            this.butSearchTask.Name = "butSearchTask";
            this.butSearchTask.Size = new System.Drawing.Size(100, 23);
            this.butSearchTask.TabIndex = 11;
            this.butSearchTask.Text = "Задача поиска";
            this.butSearchTask.UseVisualStyleBackColor = true;
            this.butSearchTask.Click += new System.EventHandler(this.butSearchTask_Click);
            // 
            // fldSearchTask
            // 
            this.fldSearchTask.Location = new System.Drawing.Point(471, 308);
            this.fldSearchTask.Multiline = true;
            this.fldSearchTask.Name = "fldSearchTask";
            this.fldSearchTask.ReadOnly = true;
            this.fldSearchTask.Size = new System.Drawing.Size(312, 320);
            this.fldSearchTask.TabIndex = 12;
            this.fldSearchTask.WordWrap = false;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(471, 287);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(90, 15);
            this.label21.TabIndex = 13;
            this.label21.Text = "Задача поиска:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 641);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.fldSearchTask);
            this.Controls.Add(this.butSearchTask);
            this.Controls.Add(this.butDelAllRecipes);
            this.Controls.Add(this.butFindReview);
            this.Controls.Add(this.butFindRecipe);
            this.Controls.Add(this.butDelReview);
            this.Controls.Add(this.butDelRecipe);
            this.Controls.Add(this.butAddReview);
            this.Controls.Add(this.butAddRecipe);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.fldReviewDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.fldReviewText);
            this.Controls.Add(this.fldReviewAuthor);
            this.Controls.Add(this.fldReviewRecipeAuthor);
            this.Controls.Add(this.fldRecipeDate);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.fldReviewRecipeName);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.fldRecipeAuthor);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.fldRecipeName);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fldReviewTree);
            this.Controls.Add(this.lstRecipeHeshtable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Text = "RecipeAndReviews";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstRecipeHeshtable;
        private System.Windows.Forms.TextBox fldReviewTree;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox fldRecipeName;
        private System.Windows.Forms.TextBox fldRecipeAuthor;
        private System.Windows.Forms.MaskedTextBox fldRecipeDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button butAddRecipe;
        private System.Windows.Forms.Button butDelRecipe;
        private System.Windows.Forms.Button butFindRecipe;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox fldReviewRecipeName;
        private System.Windows.Forms.TextBox fldReviewRecipeAuthor;
        private System.Windows.Forms.MaskedTextBox fldReviewDate;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button butAddReview;
        private System.Windows.Forms.Button butDelReview;
        private System.Windows.Forms.Button butFindReview;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox fldReviewAuthor;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox fldReviewText;
        private System.Windows.Forms.Button butDelAllRecipes;
        private System.Windows.Forms.Button butSearchTask;
        private System.Windows.Forms.TextBox fldSearchTask;
        private System.Windows.Forms.Label label21;
    }
}