using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTree
{
    public class ReviewsWithKey
    {
        public DateTime date;
        public List<Review> reviews;
        public ReviewsWithKey()
        {
            date = default;
            reviews = new();
        }
    }
    public class Tree
    {
        private ReviewsWithKey _record;
        private Tree _left;
        private Tree _right;
        public ReviewsWithKey Record
        {
            get { return _record; }
        }
        public Tree Left
        {
            get { return _left; }
        }
        public Tree Right
        {
            get { return _right; }
        }

        public Tree()
        {
            _left = null;
            _right = null;
            _record = new();
        }
        public Tree(Review rev)
        {
            _left = null;
            _right = null;
            _record.date = rev._date;
            _record.reviews.Add(rev);
        }

        public static bool ReviewAlreadyEsists(Tree revs, Review rev)
        {
            if (revs != null)
            {
                if (revs.Record.reviews.Find(x => (x._recipeName == rev._recipeName) && (x._recipeAuthor == rev._recipeAuthor) && (x._author == rev._author)) != default)
                    return true;
                if (ReviewAlreadyEsists(revs.Left, rev))
                    return true;
                if (ReviewAlreadyEsists(revs.Right, rev))
                    return true;
            }
            return false;
        }

        public void AddNode(Review rev)  //добавление узла
        {
            Tree p = null;
            Tree node = FoundKey(rev._date, ref p);
            if (node == null)
            {
                Tree newNode = new Tree();
                newNode._record.date = rev._date;
                newNode._record.reviews = new();
                newNode._record.reviews.Add(rev);
                p = null;
                Tree cur = this;
                if (this._record.date != default)
                {
                    while (cur != null)
                    {
                        p = cur;
                        if (newNode._record.date.Date < cur._record.date.Date)
                        {
                            cur = cur._left;
                        }
                        else if (newNode._record.date.Date == cur._record.date.Date)
                        {
                            cur._record.reviews.Add(rev);
                            return;
                        }
                        else cur = cur._right;
                    }
                    if (newNode._record.date.Date < p._record.date.Date)
                    {
                        p._left = newNode;
                    }
                    else p._right = newNode;
                }
                else
                    this._record = newNode._record;
            }
            else 
                node._record.reviews.Add(rev);
        }

        private void transplant(ref Tree d, ref Tree r, ref Tree p)
        {
            if (p == null)
            {
                if (r == null)
                {
                    _left = null;
                    _right = null;
                    _record = new();
                }
                else
                {
                    //d = r;
                    if ((_left != null) && (_right != null))
                        r._left = _left;
                    _record = r._record;
                    if ((r._left == null) && (r._right == null))
                    {
                        _left = null; _right = null;
                    }
                    else if (r._left == null)
                    {
                        _right = r._right; _left = null;
                    }
                    else if (r._right == null)
                    {
                        _left = r._left; _right = null;
                    }
                    else
                    {
                        _left = r._left; _right = r._right;
                    }
                }
            }
            else if (d == p._left)
            {
                if ((d._left != null) && (d._right != null))
                    r._left = d._left;
                p._left = r;
            }
            else
            {
                if ((d._left != null) && (d._right != null))
                    r._left = d._left;
                p._right = r;
            }
        }

        private static Tree min(Tree n, ref Tree m)
        {
            while (n._left != null)
            {
                m = n;
                n = n._left;
            }
            return n;
        }

        public Tree FoundKey(DateTime date, ref Tree par)
        {
            Tree cur1 = null;
            Tree cur = this;
            while (cur != null)
            {
                par = cur;
                if ((date.Date < par._record.date.Date) && (par._left != null))
                {
                    if (par._left._record.date.Date == date.Date)
                    {
                        cur1 = par._left;
                        cur = null;
                    }
                    else
                    {
                        cur = cur._left;
                        if (cur == null)
                        {
                            return null;
                        }
                    }
                }
                else if ((date.Date > par._record.date.Date) && (par._right != null))
                {
                    if (par._right._record.date.Date == date.Date)
                    {
                        cur1 = par._right;
                        cur = null;
                    }
                    else
                    {
                        cur = cur._right;
                        if (cur == null)
                        {
                            return null;
                        }
                    }
                }
                else if (((date.Date < par._record.date.Date) && (par._left == null)) || ((date.Date > par._record.date.Date) && (par._right == null)))
                {
                    return null;
                }
                else
                {
                    cur1 = par;
                    par = null;
                    cur = null;
                }
            }
            return cur1;
        }
        public Tree FoundKey(DateTime date, ref int count)
        {
            Tree par;
            Tree cur1 = null;
            Tree cur = this;
            while (cur != null)
            {
                par = cur;
                if ((date.Date < par._record.date.Date) && (par._left != null))
                {
                    count++;
                    if (par._left._record.date.Date == date.Date)
                    {
                        count++;
                        cur1 = par._left;
                        cur = null;
                    }
                    else
                    {
                        cur = cur._left;
                        if (cur == null)
                        {
                            return null;
                        }
                    }
                }
                else if ((date.Date > par._record.date.Date) && (par._right != null))
                {
                    count++;
                    if (par._right._record.date.Date == date.Date)
                    {
                        count++;
                        cur1 = par._right;
                        cur = null;
                    }
                    else
                    {
                        cur = cur._right;
                        if (cur == null)
                        {
                            return null;
                        }
                    }
                }
                else if (((date.Date < par._record.date.Date) && (par._left == null)) || ((date.Date > par._record.date.Date) && (par._right == null)))
                {
                    count++;
                    return null;
                }
                else
                {
                    count++;
                    cur1 = par;
                    par = null;
                    cur = null;
                }
            }
            return cur1;
        }
        //Tree foundNode(Review x) //поиск заданного элемента
        //{
        //    Tree cur1 = new();
        //    Tree par = new();
        //    Tree* cur = T.root;
        //    while (cur != null)
        //    {
        //        par = cur;
        //        if ((x < par->x) && (par->left != null))
        //        {
        //            if (par->left->x == x)
        //            {
        //                cur1 = par->left;
        //                cur = null;
        //                return true;
        //            }
        //            else
        //            {
        //                cur = cur->left;
        //                if (cur == null)
        //                {
        //                    std::cout << "Элемент не найден" << std::endl;
        //                    return false;
        //                }
        //            }

        //        }
        //        else if ((x > par->x) && (par->right != null))
        //        {
        //            if (par->right->x == x)
        //            {
        //                cur1 = par->right;
        //                cur = null;
        //                return true;
        //            }

        //            else
        //            {
        //                cur = cur->right;
        //                if (cur == null)
        //                {
        //                    std::cout << "Элемент не найден" << std::endl;
        //                    return false;
        //                }

        //            }

        //        }
        //        else if (((x < par->x) && (par->left == null)) || ((x > par->x) && (par->right == null)))
        //        {
        //            std::cout << "Элемент не найден" << std::endl;
        //            return false;
        //        }
        //        else
        //        {
        //            cur1 = par;
        //            par = null;
        //            cur = null;
        //            return true;
        //        }
        //    }
        //}

        public bool delReview(Review rev) //удаление заданного элемента из дерева
        {
            Tree par = null;
            Tree par_min = null;
            Tree r;

            Tree cur1 = FoundKey(rev._date, ref par);
            if (cur1 != null)
            {
                if ((cur1._record.reviews.Count == 1) && cur1._record.reviews.Contains(rev))
                {
                    if (cur1._left == null)
                    {
                        transplant(ref cur1, ref cur1._right, ref par);
                    }
                    else if (cur1._right == null)
                    {
                        transplant(ref cur1, ref cur1._left, ref par);
                    }
                    else
                    {
                        par_min = cur1;
                        r = min(cur1._right, ref par_min);
                        if (par_min != cur1)
                        {
                            transplant(ref r, ref r._right, ref par_min);
                            r._right = cur1._right;
                        }
                        transplant(ref cur1, ref r, ref par);
                    }
                    return true;
                }
                else 
                    return cur1._record.reviews.Remove(rev);
            }
            else return false;
        }

        public void ClearTree()
        {
            _record = new();
            _left = null;
            _right = null;
        }

        //void countKeyPart(Tree* root, int &count)
        //{
        //    Tree* cur = root;
        //    if (cur == null)
        //        return;
        //    countKeyPart(cur->left, count);
        //    countKeyPart(cur->right, count);
        //    count++;
        //}

        //int countKey(Tree T) //количество ключей в дереве
        //{
        //    int count = 0;
        //    countKeyPart(T.root, count);
        //    std::cout << "Количество ключей в дереве: " << count << std::endl;
        //    return count;
        //}

        private void printNode(ReviewsWithKey rev, int h)
        {
            if ((rev == null) || (rev.date == default))
                return;

            for (int i = 0; i < h; i++)
            {
                Console.Write(" ");
            }
            Console.Write(rev.date.Day + " " + rev.date.Month + " " + rev.date.Year + " ");
            for (int i = 0; i < rev.reviews.Count; i++)
            {
                Console.Write(" " + rev.reviews[i]._author + " " + rev.reviews[i]._text);
            }
            Console.WriteLine();
        }

        private void printPodTree(Tree n, int h)
        {
            if (n == null)
            {
                return;
            }
            printPodTree(n._right, h + 4);
            printNode(n._record, h);
            printPodTree(n._left, h + 4);
        }

        public void print() //печать дерева
        {
            Console.WriteLine("---------------------------");
            printPodTree(this, 0);
            Console.WriteLine("---------------------------");
        }
    }
}
