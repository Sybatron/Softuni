using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P01ListyIterator
{
    public class ListyIterator<T> : IEnumerable<T>
    {
        private int index = 0;

        private List<T> items;

        public ListyIterator(List<T> items)
        {
            this.items = items;
        }

        public bool Move()
        {
            if (index < items.Count - 1)
            {
                index++;
                return true;
            }

            return false;
        }

        public bool HasNext()
        {
            if (index < items.Count - 1)
            {
                return true;
            }

            return false;
        }

        public void Print()
        {
            if (items.Count == 0)
            {
                throw new InvalidOperationException("Invalid Operation!");
            }

            Console.WriteLine(items[index]);
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var currentItem in items)
            {
                yield return currentItem;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
