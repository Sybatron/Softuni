using System;
using System.Collections.Generic;
using System.Text;

namespace P00LibraryIterator
{
    class BookComparator : IComparer<Book>
    {
        public int Compare(Book x, Book y)
        {
            if (x.Title != y.Title)
            {
                return x.Title.CompareTo(y.Title);
            }

            if (x.Year != y.Year)
            {
                return y.Year - x.Year;
            }

            return 0;
        }
    }
}
