using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyHeshtable;
using MyTree;

namespace CourseProject
{
    public class HeshAndTree
    {
        public Heshtable recipes;
        public Tree reviews;
        public HeshAndTree()
        {
            recipes = null;
            reviews = null;
        }

        public int AddRecipe(Recipe recipe, System.Windows.Forms.ListBox list) //0 - добавил, 1 - не добавил, потому что уже существует такая запись, -1 - не добавил потому что таблица заполнена
        {
            if (recipes.Add(recipe) == 0)
            {
                PrintRecipesToList(list);
                return 0;
            }
            else
                return recipes.Add(recipe);
        }

        private bool DelAllRecipeReviews(Tree revs, Recipe recipe)
        {
            bool recipeReviewExists = false;
            bool recipeReviewExists1;
            bool recipeReviewExists2;
            if (revs == null)
                return false;
            var foundRevs = revs.Record.reviews.FindAll(x => (x._recipeName == recipe._name) && (x._recipeAuthor == recipe._author));
            
            if (foundRevs.Count != 0) //чекнуть дефолт
            {
                for (int i = 0; i < foundRevs.Count; i++)
                {
                    recipeReviewExists = true;
                    reviews.delReview(foundRevs[i]);
                }
            }
            recipeReviewExists1 = DelAllRecipeReviews(revs.Left, recipe);
            recipeReviewExists2 = DelAllRecipeReviews(revs.Right, recipe);
            return recipeReviewExists || recipeReviewExists1 || recipeReviewExists2;
        }

        public int DelRecipe(Recipe recipe, System.Windows.Forms.ListBox list, System.Windows.Forms.TextBox textBox) 
        {
            if (recipes.Del(recipe) == 0)
            {
                while (DelAllRecipeReviews(reviews, recipe)) { }
                PrintReviewsToTextbox(textBox);
                PrintRecipesToList(list);
                return 0;
            }
            else return -1;
        }

        public int AddReview(Review review, System.Windows.Forms.TextBox textBox) //0 - добавил, 1 - не добавил, потому что рецепта не существует, -1 - не добавил, потому что автор уже писал отзыв к данному рецепту, 2 - отзыв написан раньше создания рецепта
        {
            int foundRecipe = recipes.SearchByKeys(review._recipeName, review._recipeAuthor);
            if (foundRecipe != -1)
            {
                if (review._date >= recipes.Records[foundRecipe].recipe._date)
                {
                    if (!Tree.ReviewAlreadyEsists(reviews, review))
                    {
                        reviews.AddNode(review);
                        PrintReviewsToTextbox(textBox);
                        return 0;
                    }
                    else return -1;
                }
                else return 2;
            }
            else return 1;
        }

        public int DelReview(Review review, System.Windows.Forms.TextBox textBox) //0 - удалил, -1 - отзыв не найден
        {
            if (reviews.delReview(review))
            {
                PrintReviewsToTextbox(textBox);
                return 0;
            }
            else return -1;
        }

        public void PrintRecipesToList(System.Windows.Forms.ListBox list)
        {
            string temp = null;
            list.Items.Clear();
            for (int i = 0; i < recipes.Size; i++)
            {
                if (recipes.Records[i].status == Status.filled)
                {
                    temp = string.Format("{0}: {1} | {2} | {3:dd/MM/yyyy}", i, recipes.Records[i].recipe._name, recipes.Records[i].recipe._author, recipes.Records[i].recipe._date);
                }
                else if ((recipes.Records[i].status == Status.empty) || (recipes.Records[i].status == Status.deleted))
                {
                    temp = string.Format("{0}: Empty", i);
                }
                list.Items.Add(temp);
            }
        }

        private void PrintNodeToTextbox(ReviewsWithKey revs, int h, System.Windows.Forms.TextBox textBox)
        {
            if ((revs == null) || (revs.date == default))
                return;

            for (int i = 0; i < h; i++)
            {
                textBox.Text += " ";
            }
            textBox.Text += revs.date.Day + "." + revs.date.Month + "." + revs.date.Year;
            for (int i = 0; i < revs.reviews.Count; i++)
            {
                textBox.Text += ", //" + revs.reviews[i]._author + " || " + revs.reviews[i]._recipeName + " || " + revs.reviews[i]._recipeAuthor + " || " + revs.reviews[i]._text + "\\\\ ";
            }
            textBox.Text += Environment.NewLine;
        }

        private void PrintPodTreeToTextbox(Tree n, int h, System.Windows.Forms.TextBox textBox)
        {
            if (n == null)
            {
                return;
            }
            PrintPodTreeToTextbox(n.Right, h + 4, textBox);
            PrintNodeToTextbox(n.Record, h, textBox);
            PrintPodTreeToTextbox(n.Left, h + 4, textBox);
        }

        public void PrintReviewsToTextbox(System.Windows.Forms.TextBox textBox)
        {

            textBox.Text = "";
            PrintPodTreeToTextbox(this.reviews, 0, textBox);
        }
    }
}
