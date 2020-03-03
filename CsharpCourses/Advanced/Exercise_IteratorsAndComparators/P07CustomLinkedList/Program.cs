using System;
using System.Collections.Generic;
namespace P07CustomLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            var doublyLinkedList = new DoublyLinkedList<bool>();
            doublyLinkedList.AddLast(true);
            doublyLinkedList.RemoveLast();
            doublyLinkedList.AddFirst(true);
            doublyLinkedList.AddLast(false);
            doublyLinkedList.RemoveFirst();
            doublyLinkedList.AddFirst(true);
            doublyLinkedList.AddFirst(false);
            doublyLinkedList.AddLast(true);
            doublyLinkedList.AddLast(true);

            //doublyLinkedList.Print(Console.WriteLine);
            //Console.WriteLine(doublyLinkedList.Count == 2);

            foreach (var item in doublyLinkedList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
