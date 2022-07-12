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
            Form form1 = Application.OpenForms[0];
            form1.Show();
        }
        private void ReadRecipeFile(string filePath)
        {
            string[] records = File.ReadAllLines(filePath);
            string[] recipe = new string[3];
            string[] date = new string[3];
            for (int i = 0; i < records.Length; i++)
            {
                recipe = records[i].Split(" | ");
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
                review = records[i].Split(" | ");
                date = review[4].Split(".");
                hat.AddReview(new Review(review[0], review[1], review[2], review[3], new DateTime(int.Parse(date[2]), int.Parse(date[1]), int.Parse(date[0]))), fldReviewTree);
            }
            //hat.PrintRecipesToList(lstRecipeHeshtable);
        }
        private void SaveFile(List<string> text)
        {
            
            SaveFileDialog dlg = new();
            dlg.Filter = "Текстовые файлы|*.txt|Все файлы|*.*";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllLines(dlg.FileName, text);
            }
        }

        private void butAddRecipe_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(fldRecipeName.Text) && !string.IsNullOrWhiteSpace(fldRecipeAuthor.Text))
            {
                int codeOfAdd;
                if (!fldRecipeDate.MaskCompleted)
                    codeOfAdd = hat.AddRecipe(new(fldRecipeName.Text, fldRecipeAuthor.Text), lstRecipeHeshtable);
                else
                {
                    try
                    {
                        codeOfAdd = hat.AddRecipe(new(fldRecipeName.Text, fldRecipeAuthor.Text, (DateTime)fldRecipeDate.ValidateText()), lstRecipeHeshtable);
                    }
                    catch(NullReferenceException)
                    {
                        MessageBox.Show("Дата введена некорректно", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                if (codeOfAdd == -1)
                    MessageBox.Show("Хештаблица заполнена", "Добавление не удалось", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else if (codeOfAdd == -2)
                    MessageBox.Show("Заданный рецепт уже существует", "Добавление не удалось", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
                MessageBox.Show("Одно или несколько из обязательных полей не заполнены", "Пустые поля", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void butDelRecipe_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(fldRecipeName.Text) && !string.IsNullOrWhiteSpace(fldRecipeAuthor.Text))
            {
                int codeOfDel;
                if (!fldRecipeDate.MaskCompleted)
                    codeOfDel = hat.DelRecipe(new(fldRecipeName.Text, fldRecipeAuthor.Text), lstRecipeHeshtable, fldReviewTree);
                else
                {
                    try
                    {
                        codeOfDel = hat.DelRecipe(new(fldRecipeName.Text, fldRecipeAuthor.Text, (DateTime)fldRecipeDate.ValidateText()), lstRecipeHeshtable, fldReviewTree);
                    }
                    catch (NullReferenceException)
                    {
                        MessageBox.Show("Дата введена некорректно", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                if (codeOfDel == -1)
                    MessageBox.Show("Заданного рецепта нет в хештаблице", "Удаление не удалось", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
                MessageBox.Show("Одно или несколько из обязательных полей не заполнены", "Пустые поля", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void butFindRecipe_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(fldRecipeName.Text) && !string.IsNullOrWhiteSpace(fldRecipeAuthor.Text))
            {
                int count = 0;
                int foundRecipeIndex = hat.recipes.SearchByKeys(fldRecipeName.Text, fldRecipeAuthor.Text, ref count);
                if (foundRecipeIndex != -1)
                    MessageBox.Show(string.Format("Рецепт найден. Его номер в списке: {0}. Количество сравнений: {1}", foundRecipeIndex, count), "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Заданного рецепта нет в хештаблице", "Рецепт не найден", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Одно или несколько из обязательных полей не заполнены", "Пустые поля", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void butDelAllRecipes_Click(object sender, EventArgs e)
        {
            hat.DelAllRecipes(lstRecipeHeshtable, fldReviewTree);
        }

        private void butAddReview_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(fldReviewRecipeName.Text) && !string.IsNullOrWhiteSpace(fldReviewRecipeAuthor.Text)
                && !string.IsNullOrWhiteSpace(fldReviewAuthor.Text) && !string.IsNullOrWhiteSpace(fldReviewText.Text))
            {
                int codeOfAdd;
                if (!fldReviewDate.MaskCompleted)
                    codeOfAdd = hat.AddReview(new(fldReviewText.Text, fldReviewAuthor.Text, fldReviewRecipeName.Text, fldReviewRecipeAuthor.Text), fldReviewTree);
                else
                {
                    try
                    {
                        codeOfAdd = hat.AddReview(new(fldReviewText.Text, fldReviewAuthor.Text, fldReviewRecipeName.Text, fldReviewRecipeAuthor.Text, (DateTime)fldReviewDate.ValidateText()), fldReviewTree);
                    }
                    catch (NullReferenceException)
                    {
                        MessageBox.Show("Дата введена некорректно", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                if (codeOfAdd == 1)
                    MessageBox.Show("В хештаблице нет рецепта к которому добавляется данный отзыв", "Добавление не удалось", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else if (codeOfAdd == -1)
                    MessageBox.Show("Отзыв от заданного автора уже был написан к данному рецепту", "Добавление не удалось", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else if (codeOfAdd == 2)
                    MessageBox.Show("Заданный отзыв написан раньше создания рецепта", "Добавление не удалось", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
                MessageBox.Show("Одно или несколько из обязательных полей не заполнены", "Пустые поля", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void butDelReview_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(fldReviewRecipeName.Text) && !string.IsNullOrWhiteSpace(fldReviewRecipeAuthor.Text)
                && !string.IsNullOrWhiteSpace(fldReviewAuthor.Text) && !string.IsNullOrWhiteSpace(fldReviewText.Text))
            {
                int codeOfDel;
                if (!fldReviewDate.MaskCompleted)
                    codeOfDel = hat.DelReview(new(fldReviewText.Text, fldReviewAuthor.Text, fldReviewRecipeName.Text, fldReviewRecipeAuthor.Text), fldReviewTree);
                else
                {
                    try
                    {
                        codeOfDel = hat.DelReview(new(fldReviewText.Text, fldReviewAuthor.Text, fldReviewRecipeName.Text, fldReviewRecipeAuthor.Text, (DateTime)fldReviewDate.ValidateText()), fldReviewTree);
                    }
                    catch (NullReferenceException)
                    {
                        MessageBox.Show("Дата введена некорректно", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                if (codeOfDel == -1)
                    MessageBox.Show("Заданного отзыва нет в дереве", "Удаление не удалось", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
                MessageBox.Show("Одно или несколько из обязательных полей не заполнены", "Пустые поля", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void butFindReview_Click(object sender, EventArgs e)
        {
            int count = 0;
            Tree foundReview;
            if (!fldReviewDate.MaskCompleted)
                foundReview = hat.reviews.FoundKey(DateTime.Now, ref count);
            else
            {
                try
                {
                    foundReview = hat.reviews.FoundKey((DateTime)fldReviewDate.ValidateText(), ref count);
                }
                catch (NullReferenceException)
                {
                    MessageBox.Show("Дата введена некорректно", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }    
            if (foundReview != null)
                MessageBox.Show(string.Format("Узел с заданным ключом (дата) найден. Количество сравнений: {0}", count), "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("В заданную дату не было написано ни одного отзыва", "Отзывы не найдены", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void butSearchTask_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(fldRecipeNameForSearchTask.Text) && !string.IsNullOrWhiteSpace(fldRecipeAuthorForSearchTask.Text))
            {
                int codeOfSearch = hat.SearchTask(fldRecipeNameForSearchTask.Text, fldRecipeAuthorForSearchTask.Text, lstSearchTask);
                if (codeOfSearch == 1)
                    MessageBox.Show("Заданного рецепта нет в хештаблице", "Задача поиска не выполнилась", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else if (codeOfSearch == -1)
                    MessageBox.Show("Не было написано ни одного отзыва в день создания заданного рецепта", "Задача поиска не выполнилась", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else if (codeOfSearch == 2)
                    MessageBox.Show("Не было найдено ни одного отзыва к заданному рецепту удовлетворяющего задаче поиска", "Задача поиска завершена", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Одно или несколько из обязательных полей не заполнены", "Пустые поля", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void butHelp_Click(object sender, EventArgs e)
        {
            Help2 help = new();
            help.ShowDialog();
            if (help.DialogResult == DialogResult.OK)
                help.Dispose();
        }

        private void butBack_Click(object sender, EventArgs e)
        {
            Form form1 = Application.OpenForms[0];
            form1.Show();
            this.Close();
        }

        private void butSaveRecipes_Click(object sender, EventArgs e)
        {
            int count = lstRecipeHeshtable.Items.Count;
            List<string> text = new();
            string temp;
            string[] tempRec;
            for (int i = 0; i < count; i++)
            {
                temp = lstRecipeHeshtable.Items[i].ToString();
                tempRec = temp.Split(": ");
                text.Add(tempRec[1]);
            }

            SaveFile(text);
        }

        private void butSaveReviews_Click(object sender, EventArgs e)
        {
            int count = fldReviewTree.Lines.Length - 1;
            string temp;
            string[] tempRecord;
            List<string> text = new();
            for (int i = 0; i < count; i++)
            {
                temp = fldReviewTree.Lines[i];
                tempRecord = temp.Split(", //");
                for (int j = 1; j < tempRecord.Length; j++)
                {
                    string tempRecordTrue = tempRecord[0].TrimStart() + " || " + tempRecord[j].TrimEnd('\\', ' ');
                    text.Add(tempRecordTrue);
                }
            }

            SaveFile(text);
        }

        private void fldRecipeName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((number >= '0') && (number <= '9'))
            {
                e.Handled = true;
            }
        }

        private void fldRecipeAuthor_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((number >= '0') && (number <= '9'))
            {
                e.Handled = true;
            }
        }

        private void fldReviewRecipeName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((number >= '0') && (number <= '9'))
            {
                e.Handled = true;
            }
        }

        private void fldReviewRecipeAuthor_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((number >= '0') && (number <= '9'))
            {
                e.Handled = true;
            }
        }

        private void fldReviewAuthor_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((number >= '0') && (number <= '9'))
            {
                e.Handled = true;
            }
        }

        private void fldRecipeNameForSearchTask_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((number >= '0') && (number <= '9'))
            {
                e.Handled = true;
            }
        }

        private void fldRecipeAuthorForSearchTask_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((number >= '0') && (number <= '9'))
            {
                e.Handled = true;
            }
        }
    }
}
