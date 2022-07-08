using System;

namespace MyTree
{
    class Program
    {
        static void Main(string[] args)
        {
            //проверить если recipename recipeauthor и author равны, то добавлять нельзя
            //if (node._record.reviews.Find(x => (x._recipeName == rev._recipeName) && (x._recipeAuthor == rev._recipeAuthor) && (x._author == rev._author)) != default)
            Tree tree = new();
            tree.print();
            tree.AddNode(new("asdasd", "asd", "asd", "asdas", new(2022, 7, 6)));
            tree.print();
            tree.AddNode(new("asdasd", "asd", "asd", "asdas", new(2022, 2, 6)));
            tree.AddNode(new("asdasd", "asd", "asd", "asdas", new(2022, 6, 6)));
            tree.AddNode(new("asdasd", "asd", "asd", "asdas", new(2022, 8, 6)));
            tree.print();
            tree.AddNode(new("a23asd", "asacd", "aujsd", "asdas", new(2022, 2, 6)));
            tree.AddNode(new("asd54asd", "asjkd", "asd", "asdas", new(2022, 2, 6)));
            tree.AddNode(new("asd54asd", "asjkd", "asd", "asdas", new(2022, 1, 6)));
            tree.print();

            tree.delReview(new("asd54asd", "asjkd", "asd", "asdas", new(2022, 1, 6)));
            tree.delReview(new("a23asd", "asacd", "aujsd", "asdas", new(2022, 2, 6)));
            tree.print();
            tree.delReview(new("asd54asd", "asjkd", "asd", "asdas", new(2022, 2, 6)));
            tree.print();
            tree.delReview(new("asdasd", "asd", "asd", "asdas", new(2022, 2, 6)));
            tree.print();
            tree.delReview(new("asdasd", "asd", "asd", "asdas", new(2022, 6, 6)));
            tree.print();
            tree.delReview(new("asdasd", "asd", "asd", "asdas", new(2022, 7, 6)));
            tree.print();
            tree.delReview(new("asdasd", "asd", "asd", "asdas", new(2022, 8, 6)));
            tree.print();
            tree.AddNode(new("a23asd", "asacd", "aujsd", "asdas", new(2022, 2, 6)));
            tree.print();
        }
    }
}
