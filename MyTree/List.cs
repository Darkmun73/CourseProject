using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTree
{
    public class Node
    {
        private Review _Data;
        private Node _Next;
        private Node _Prev;
        public Review Value
        {
            get { return _Data; }
            set { _Data = value; }
        }
        public Node(Review Data)
        {
            this._Data = Data;
        }
        public Node Next
        {
            get { return this._Next; }
            set { this._Next = value; }
        }
        public Node Prev
        {
            get { return this._Prev; }
            set { this._Prev = value; }
        }
    }

    public class List
    {
        private Node First;
        private Node Current;
        private Node Last;
        private uint size;

        public List()
        {
            size = 0;
            First = Current = Last = null;
        }

        public uint Count //свойство для size
        {
            get { return size; }
            set { size = value; }
        }

        public bool isEmpty //проверка на пустоту
        {
            get
            {
                return size == 0;
            }
        }

        //public void Insert_Index(Review newElement, uint index) //вставить по индекусу
        //{
        //    if (index < 1 || index > size) //вброс ошибки, если неправильный индекс
        //    {
        //        throw new InvalidOperationException();
        //    }
        //    else if (index == 1) //если начало
        //    {
        //        Push_Front(newElement);
        //    }
        //    else if (index == size) //если конец
        //    {
        //        Add(newElement);
        //    }
        //    else //иначе ищем элемент с таким индексом
        //    {
        //        uint count = 1;
        //        Current = First;
        //        while (Current != null && count != index)
        //        {
        //            Current = Current.Next;
        //            count++;
        //        }
        //        Node newNode = new Node(newElement); //создаем объект
        //        Current.Prev.Next = newNode;
        //        newNode.Prev = Current.Prev;
        //        Current.Prev = newNode;
        //        newNode.Next = Current;
        //    }
        //}

        //public void Push_Front(Review newElement)
        //{
        //    Node newNode = new Node(newElement);

        //    if (First == null)
        //    {
        //        First = Last = newNode;
        //    }
        //    else
        //    {
        //        newNode.Next = First;
        //        First = newNode; //First и newNode указывают на один и тот же объект
        //        newNode.Next.Prev = First;
        //    }
        //    Count++;
        //}
        public Review At(int index)
        {
            if (index < 0 || index > size)
            {
                throw new InvalidOperationException();
            }
            else if (index == 0)
            {
                return First.Value;
            }
            else if (index == size)
            {
                return Last.Value;
            }
            else
            {
                Current = First;
                for (int count = 0; count < index; count++)
                    Current = Current.Next;
                return Current.Value;
            }
        }

        public void Add(Review newElement)
        {
            Node newNode = new Node(newElement);

            if (First == null)
            {
                First = Last = newNode;
            }
            else
            {
                Last.Next = newNode;
                newNode.Prev = Last;
                Last = newNode;
            }
            Count++;
        }

        public Node Pop_Front()
        {
            if (First == null)
            {
                throw new InvalidOperationException();
            }
            else
            {
                Node temp = First;
                if (First.Next != null)
                {
                    First.Next.Prev = null;
                }
                First = First.Next;
                Count--;
                return temp;
            }
        }

        public Node Pop_Back()
        {
            if (Last == null)
            {
                throw new InvalidOperationException();
            }
            else
            {
                Node temp = Last;
                if (Last.Prev != null)
                {
                    Last.Prev.Next = null;
                }
                Last = Last.Prev;
                Count--;
                return temp;
            }
        }

        public void Clear() //полностью очистить список
        {
            while (!isEmpty)
            {
                Pop_Front();
            }
        }

        //public void Display() //вывести в прямом порядке
        //{
        //    if (First == null)
        //    {
        //        Console.WriteLine("Doubly Linked List is empty");
        //        return;
        //    }
        //    Current = First;
        //    uint count = 1;
        //    while (Current != null)
        //    {
        //        Console.WriteLine("Element " + count.ToString() + " : " + Current.Value.ToString());
        //        count++;
        //        Current = Current.Next;
        //    }
        //}

        //public void DeleteElement(uint index)
        //{ //удалить элемент по индексу
        //    if (index < 0 || index > size)
        //    {
        //        throw new InvalidOperationException();
        //    }
        //    else if (index == 0)
        //    {
        //        Pop_Front();
        //    }
        //    else if (index == size)
        //    {
        //        Pop_Back();
        //    }
        //    else
        //    {
        //        uint count = 1;
        //        Current = First;
        //        while (Current != null && count != index)
        //        {
        //            Current = Current.Next;
        //            count++;
        //        }
        //        Current.Prev.Next = Current.Next;
        //        Current.Next.Prev = Current.Prev;
        //    }
        //}

        public bool Remove(Review Data)
        {
            Current = First;
            while (Current != null)
            {
                if (Current.Value == Data)
                {
                    if (Current == First)
                    {
                        Pop_Front();
                        return true;
                    }
                    if (Current == Last)
                    {
                        Pop_Back();
                        return true;
                    }
                    Current.Prev.Next = Current.Next;
                    Current.Next.Prev = Current.Prev;
                    Count--;
                    return true;
                }
                Current = Current.Next;
            }
            return false;
        }
        public Node Find(Review Data) //найти Node и вернуть его
        {
            Current = First;
            while (Current != null)
            {
                if (Current.Value == Data)
                {
                    return Current;
                }
                Current = Current.Next;
            }
            return Current;
        }
        public Node Find(Predicate<Review> match) //найти Node и вернуть его
        {
            Current = First;
            while (Current != null)
            {
                if (match(Current.Value))
                {
                    return Current;
                }
                Current = Current.Next;
            }
            return Current;
        }

        public List FindAll(Predicate<Review> match)
        {
            List lst = new();
            Current = First;
            while (Current != null)
            {
                if (match(Current.Value))
                {
                    lst.Add(Current.Value);
                }
                Current = Current.Next;
            }
            return lst;
        }

        public bool Contains(Review Data)
        {
            Current = First;
            while (Current != null)
            {
                if (Current.Value == Data)
                {
                    return true;
                }
                Current = Current.Next;
            }
            return false;
        }
    }
}
