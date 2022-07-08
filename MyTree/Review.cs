using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTree
{
    public class Review
    {
        public string _text;
        public string _author;
        public string _recipeName;
        public string _recipeAuthor;
        public DateTime _date;
        public Review(string text, string author, string recipeName, string recipeAuthor, DateTime date)
        {
            _text = text;
            _author = author;
            _recipeName = recipeName;
            _recipeAuthor = recipeAuthor;
            _date = date;
        }
        public Review(string text, string author, string recipeName, string recipeAuthor)
        {
            _text = text;
            _author = author;
            _recipeName = recipeName;
            _recipeAuthor = recipeAuthor;
            _date = DateTime.Now;
        }
        public static bool operator ==(Review other1, Review other2)
        {
            if (ReferenceEquals(other1, null) || ReferenceEquals(other2, null))
                return ReferenceEquals(other1, other2);

            return (other1._text == other2._text) && (other1._author == other2._author)
                && (other1._recipeName == other2._recipeName) && (other1._recipeAuthor == other2._recipeAuthor)
                && (other1._date.Date == other2._date.Date);
        }
        public static bool operator !=(Review other1, Review other2)
        {
            if (ReferenceEquals(other1, null) || ReferenceEquals(other2, null))
                return !ReferenceEquals(other1, other2);
            return (other1._text != other2._text) || (other1._author != other2._author)
                || (other1._recipeName != other2._recipeName) || (other1._recipeAuthor != other2._recipeAuthor)
                || (other1._date.Date != other2._date.Date);
        }
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Review objAsPart = obj as Review;
            if (objAsPart == null) return false;
            else return this == objAsPart;
        }
        public override int GetHashCode()
        {
            return _date.GetHashCode();
        }
    }
}
