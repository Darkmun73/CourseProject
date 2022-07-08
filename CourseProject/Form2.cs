using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyHeshtable;
using MyTree;

namespace CourseProject
{
    public partial class Form2 : Form
    {
        private HeshAndTree hat = new();
        public Form2(string recipeFilePath, string reviewFilePath, int heshtableSize)
        {
            InitializeComponent();
            hat.recipes = new Heshtable(heshtableSize);
            hat.reviews = new Tree();
            ReadRecipeFile(recipeFilePath);
            ReadReviewFile(reviewFilePath);
            FormClosed += Form2_FormClosed;
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void ReadRecipeFile(string filePath)
        {
            string[] records = File.ReadAllLines(filePath);
            string[] recipe = new string[3];
            string[] date = new string[3];
            for (int i = 0; i < records.Length; i++)
            {
                recipe = records[i].Split("| ");
                date = recipe[2].Split(".");
                hat.recipes.Add(new Recipe(recipe[0], recipe[1], new DateTime(int.Parse(date[2]), int.Parse(date[1]), int.Parse(date[0]))));
            }
            hat.PrintRecipesToList(lstRecipeHeshtable);
        }

        private void ReadReviewFile(string filePath)
        {
            string[] records = File.ReadAllLines(filePath);
            string[] review = new string[5];
            string[] date = new string[3];
            for (int i = 0; i < records.Length; i++)
            {
                review = records[i].Split("| ");
                date = review[4].Split(".");
                hat.AddReview(new Review(review[0], review[1], review[2], review[3], new DateTime(int.Parse(date[2]), int.Parse(date[1]), int.Parse(date[0]))), fldReviewTree);
            }
            //hat.PrintRecipesToList(lstRecipeHeshtable);
        }

        private void butAddRecipe_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(fldRecipeName.Text) && !string.IsNullOrWhiteSpace(fldRecipeAuthor.Text))
            {
                if (!fldRecipeDate.MaskCompleted)
                    hat.AddRecipe(new(fldRecipeName.Text, fldRecipeAuthor.Text), lstRecipeHeshtable);
                else
                    hat.AddRecipe(new(fldRecipeName.Text, fldRecipeAuthor.Text, (DateTime)fldRecipeDate.ValidateText()), lstRecipeHeshtable);
            }
        }

        private void butDelRecipe_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(fldRecipeName.Text) && !string.IsNullOrWhiteSpace(fldRecipeAuthor.Text))
            {
                if (!fldRecipeDate.MaskCompleted)
                    hat.DelRecipe(new(fldRecipeName.Text, fldRecipeAuthor.Text), lstRecipeHeshtable, fldReviewTree);
                else
                    hat.DelRecipe(new(fldRecipeName.Text, fldRecipeAuthor.Text, (DateTime)fldRecipeDate.ValidateText()), lstRecipeHeshtable, fldReviewTree);
            }
        }

        private void butFindRecipe_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(fldRecipeName.Text) && !string.IsNullOrWhiteSpace(fldRecipeAuthor.Text))
            {
                int count = 0;
                int foundRecipeIndex = hat.recipes.SearchByKeys(fldRecipeName.Text, fldRecipeAuthor.Text, ref count);
                if (foundRecipeIndex != -1)
                    MessageBox.Show(string.Format("Рецепт найден. Его номер в списке: {0}. Количество сравнений: {1}", foundRecipeIndex, count), "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void butDelAllRecipes_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < hat.recipes.Size; i++)
            {
                if (hat.recipes.Records[i].status == Status.filled)
                    hat.DelRecipe(hat.recipes.Records[i].recipe, lstRecipeHeshtable, fldReviewTree);
            }
        }

        private void butAddReview_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(fldReviewRecipeName.Text) && !string.IsNullOrWhiteSpace(fldReviewRecipeAuthor.Text)
                && !string.IsNullOrWhiteSpace(fldReviewAuthor.Text) && !string.IsNullOrWhiteSpace(fldReviewText.Text))
            {
                if (!fldRecipeDate.MaskCompleted)
                    hat.AddReview(new(fldReviewText.Text, fldReviewAuthor.Text, fldReviewRecipeName.Text, fldReviewRecipeAuthor.Text), fldReviewTree);
                else
                    hat.AddReview(new(fldReviewText.Text, fldReviewAuthor.Text, fldReviewRecipeName.Text, fldReviewRecipeAuthor.Text, (DateTime)fldReviewDate.ValidateText()), fldReviewTree);
            }
        }

        private void butDelReview_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(fldReviewRecipeName.Text) && !string.IsNullOrWhiteSpace(fldReviewRecipeAuthor.Text)
                && !string.IsNullOrWhiteSpace(fldReviewAuthor.Text) && !string.IsNullOrWhiteSpace(fldReviewText.Text))
            {
                if (!fldRecipeDate.MaskCompleted)
                    hat.DelReview(new(fldReviewText.Text, fldReviewAuthor.Text, fldReviewRecipeName.Text, fldReviewRecipeAuthor.Text), fldReviewTree);
                else
                    hat.DelReview(new(fldReviewText.Text, fldReviewAuthor.Text, fldReviewRecipeName.Text, fldReviewRecipeAuthor.Text, (DateTime)fldReviewDate.ValidateText()), fldReviewTree);
            }
        }

        private void butFindReview_Click(object sender, EventArgs e)
        {
            int count = 0;
            Tree foundReview;
            if (!fldReviewDate.MaskCompleted)
                foundReview = hat.reviews.FoundKey(DateTime.Now, ref count);
            else
                foundReview = hat.reviews.FoundKey((DateTime)fldReviewDate.ValidateText(), ref count);
            if (foundReview != null)
                MessageBox.Show(string.Format("Узел с заданным ключом (дата) найден. Количество сравнений: {0}", count), "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void butSearchTask_Click(object sender, EventArgs e)
        {
            fldSearchTask.Text = "";
            if (!string.IsNullOrWhiteSpace(fldRecipeName.Text) && !string.IsNullOrWhiteSpace(fldRecipeAuthor.Text))
            {
                int foundRecipe = hat.recipes.SearchByKeys(fldRecipeName.Text, fldRecipeAuthor.Text);
                if (foundRecipe != -1)
                {
                    int count = 0;
                    Tree foundReview = hat.reviews.FoundKey(hat.recipes.Records[foundRecipe].recipe._date, ref count);
                    if (foundReview != null)
                    {
                        for (int i = 0; i < foundReview.Record.reviews.Count; i++)
                            fldSearchTask.Text += foundReview.Record.reviews[i]._author + " " + foundReview.Record.reviews[i]._text + " " + foundReview.Record.reviews[i]._date.Day + "." + foundReview.Record.reviews[i]._date.Month + "." + foundReview.Record.reviews[i]._date.Year + " " + foundReview.Record.reviews[i]._recipeName + " " + foundReview.Record.reviews[i]._recipeAuthor + Environment.NewLine;
                    }
                }

            }
        }
    }
}
