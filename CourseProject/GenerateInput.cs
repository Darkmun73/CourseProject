using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CourseProject
{
    public static class GenerateInput
    {

        private readonly static string[] recipeNames = { "Печень в шубе", "Чевапчичи", "Гречаники", "Куриные завороты","Мясо с кунжутом и мёдом",
                "Картофельное пюре", "Картофель по-португальски", "Сырно-луковый суп" };

        private readonly static string[] recipeAuthors = { "Трофимова Анна Станиславовна","Табаков Валерий Филиппович","Илларионов Тимофей Сергеевич","Яковлева Надежда Ростиславовна",
                "Спиваковский Георгий Родионович","Холопов Федор Андреевич","Каблукова Людмила Олеговна","Боярских Анатолий Ярославович","Левченко Лев Даниилович",
                "Батагов Вадим Владимирович","Царевский Юрий Тарасович","Бойченко Галина Викторовна","Ермолаев Вячеслав Евгеньевич","Костюкова Татьяна Ивановна","Шпак Елена Антоновна"};
        private readonly static string[] reviewAuthors = { "Филатов Елисей Германнович", "Дмитриев Василий Макарович", "Новиков Август Витальевич", "Дмитриев Андрей Альвианович",
            "Панфилов Карл Филатович", "Гурьев Вальтер Мартынович", "Крылов Иосиф Тихонович", "Русаков Вилен Гордеевич", "Горбунов Самуил Рубенович", "Цветков Лука Глебович",
        "Лазарева Адель Тимофеевна", "Сидорова Верона Альвиановна", "Ситникова Эжени Ярославовна", "Носова Виргиния Платоновна", "Меркушева Ирэн Витальевна", "Александрова Верона Якововна"};
        private readonly static string[] reviewTexts = { "qwe", "ert", "Гречetryeки", "Куриdfgdfdfgные завороты","Мясо xcvxcс кунжутом и мёдом",
                "Картофельvcxvxное пюре", "Картофель sdfпо-португальски", "Сырно-лукqweовый суп", "aszxvx", "asdadqwq", "asdasdaswrw", "asdasdxzvbnntt" };

        public static void GenerateRandomRecipesIn(string filePath)
        {
            Random rnd = new Random();
            int randomNum;
            string recipeName;
            string author;
            string date;
            string[] recipes = new string[10];
            for (int i = 0; i < 10; i++)
            {
                randomNum = rnd.Next(0, recipeNames.Length - 1);
                recipeName = recipeNames[randomNum];
                randomNum = rnd.Next(0, recipeAuthors.Length - 1);
                author = recipeAuthors[randomNum];
                DateTime start = new DateTime(2010, 1, 1);
                int range = (DateTime.Today - start).Days;
                start = start.AddDays(rnd.Next(range));
                date = start.Day + "." + start.Month + "." + start.Year;
                recipes[i] = recipeName + "| " + author + "| " + date;
            }
            File.WriteAllLines(filePath, recipes);
        }
        public static void GenerateRandomRecipesIn(string filePath, int numOfStrings)
        {
            Random rnd = new Random();
            int randomNum;
            string recipeName;
            string recipeAuthor;
            string date;
            string[] recipes = new string[numOfStrings];
            for (int i = 0; i < numOfStrings; i++)
            {
                randomNum = rnd.Next(0, recipeNames.Length - 1);
                recipeName = recipeNames[randomNum];
                randomNum = rnd.Next(0, recipeAuthors.Length - 1);
                recipeAuthor = recipeAuthors[randomNum];
                DateTime start = new DateTime(2010, 1, 1);
                int range = (DateTime.Today - start).Days;
                start = start.AddDays(rnd.Next(range));
                date = start.Day + "." + start.Month + "." + start.Year;
                recipes[i] = recipeName + "| " + recipeAuthor + "| " + date;
            }
            File.WriteAllLines(filePath, recipes);
        }

        public static void GenerateRandomReviewsIn(string filePath)
        {
            Random rnd = new Random();
            int randomNum;
            string recipeName;
            string recipeAuthor;
            string reviewAuthor;
            string reviewText;
            string date;
            string[] recipes = new string[10];
            for (int i = 0; i < 10; i++)
            {
                randomNum = rnd.Next(0, recipeNames.Length - 1);
                recipeName = recipeNames[randomNum];
                randomNum = rnd.Next(0, recipeAuthors.Length - 1);
                recipeAuthor = recipeAuthors[randomNum];
                randomNum = rnd.Next(0, reviewAuthors.Length - 1);
                reviewAuthor = reviewAuthors[randomNum];
                randomNum = rnd.Next(0, reviewTexts.Length - 1);
                reviewText = reviewTexts[randomNum];
                DateTime start = new DateTime(2010, 1, 1);
                int range = (DateTime.Today - start).Days;
                start = start.AddDays(rnd.Next(range));
                date = start.Day + "." + start.Month + "." + start.Year;
                recipes[i] = reviewText + "| " + reviewAuthor + "| " + recipeName + "| " + recipeAuthor + "| " + date;
            }
            File.WriteAllLines(filePath, recipes);
        }
        public static void GenerateRandomReviewsIn(string filePath, int numOfStrings)
        {
            Random rnd = new Random();
            int randomNum;
            string recipeName;
            string recipeAuthor;
            string reviewAuthor;
            string reviewText;
            string date;
            string[] recipes = new string[numOfStrings];
            for (int i = 0; i < numOfStrings; i++)
            {
                randomNum = rnd.Next(0, recipeNames.Length - 1);
                recipeName = recipeNames[randomNum];
                randomNum = rnd.Next(0, recipeAuthors.Length - 1);
                recipeAuthor = recipeAuthors[randomNum];
                randomNum = rnd.Next(0, reviewAuthors.Length - 1);
                reviewAuthor = reviewAuthors[randomNum];
                randomNum = rnd.Next(0, reviewTexts.Length - 1);
                reviewText = reviewTexts[randomNum];
                DateTime start = new DateTime(2010, 1, 1);
                int range = (DateTime.Today - start).Days;
                start = start.AddDays(rnd.Next(range));
                date = start.Day + "." + start.Month + "." + start.Year;
                recipes[i] = reviewText + "| " + reviewAuthor + "| " + recipeName + "| " + recipeAuthor + "| " + date;
            }
            File.WriteAllLines(filePath, recipes);
        }
    }
}
