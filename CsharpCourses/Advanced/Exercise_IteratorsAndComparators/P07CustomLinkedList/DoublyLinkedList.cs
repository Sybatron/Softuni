using System;
using System.Collections;
using System.Collections.Generic;

namespace P07CustomLinkedList
{
    public class DoublyLinkedList<T>:IEnumerable
    {
        //List who has head and tail and has nodes. 
        //Every node has value and save 
        //the value of the next node and the previous node.
        internal class LinkNode
        {
            public T Value { get; private set; }

            public LinkNode NextNode { get; set; }

            public LinkNode PreviousNode { get; set; }

            public LinkNode(T value)
            {
                this.Value = value;
            }
        }

        private LinkNode head;

        private LinkNode tail;

        public int Count { get; private set; }

        public void AddFirst(T value)
        {
            LinkNode newHead = new LinkNode(value);

            if (this.Count == 0)
            {
                this.tail = this.head = newHead;
            }
            else
            {
                newHead.NextNode = this.head;
                this.head.PreviousNode = newHead;
                this.head = newHead;
            }

            this.Count++;
        }

        public void AddLast(T value)
        {
            LinkNode newTail = new LinkNode(value);

            if (Count == 0)
            {
                this.tail = this.head = newTail;
            }
            else
            {
                newTail.PreviousNode = this.tail;
                this.tail.NextNode = newTail;
                this.tail = newTail;
            }

            this.Count++;
        }

        public T RemoveFirst()
        {
            IfEmptyThrowException();

            T firstElement = this.head.Value;

            this.head = this.head.NextNode;

            if (this.head == null)
            {
                this.tail = null;
            }
            else
            {
                this.head.PreviousNode = null;
            }

            this.Count--;

            return firstElement;
        }

        public T RemoveLast()
        {
            IfEmptyThrowException();

            T lastElement = this.tail.Value;

            this.tail = this.tail.PreviousNode;

            if (this.tail == null)
            {
                this.head = null;
            }
            else
            {
                this.tail.NextNode = null;
            }

            this.Count--;

            return lastElement;
        }



        public T[] ToArray()
        {
            T[] array = new T[this.Count];

            var currentNode = this.head;

            int index = 0;
            while (currentNode != null)
            {
                array[index++] = currentNode.Value;

                currentNode = currentNode.NextNode;
            }

            return array;
        }

        public void Print(Action<T> action)
        {
            LinkNode currentNode = this.head;

            while (currentNode != null)
            {
                action(currentNode.Value);

                currentNode = currentNode.NextNode;
            }
        }

        void IfEmptyThrowException()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("The list is empty");
            }
        }

        public IEnumerator GetEnumerator()
        {
            LinkNode currentNode = this.head;

            while (currentNode != null)
            {
                yield return currentNode.Value;

                currentNode = currentNode.NextNode;
            }
        }
    }
}
