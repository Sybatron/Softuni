using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace P03Stack
{
    public class CustomStack<T> : IEnumerable<T>
    {
        private List<T> items;

        public CustomStack()
        {
            items = new List<T>();
        }

        public void Push(params T[] items)
        {
            this.items.AddRange(items);
        }

        public void Pop()
        {
            if (items.Count > 0)
            {
                items.RemoveAt(items.Count - 1);
            }
            else
            {
                Console.WriteLine("No elements");
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = items.Count - 1; i >= 0; i--)
            {
                yield return items[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
