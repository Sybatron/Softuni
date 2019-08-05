using P00LibraryIterator;
using System;
using System.Collections.Generic;
using System.Linq;

namespace P00EnumeratorsLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            var books = new List<Book>()
            {
                new Book("Harry Potter",2000, "J.K. Rowling"),
                new Book("Strom",2010,"Emanuel dyo Saint Sama"),
                new Book("Dancing with Dragons",2012,"Martin"),
                new Book("I, Robot",1978,"Azimov"),
                new Book("Programming Basic",2000, "Svetlin Nakov", "Nikolay Nedyalkov")
            };

            var library = new Library(books);

            foreach (var book in library)
            {
                Console.WriteLine(book);
            }
        }
    }
}
