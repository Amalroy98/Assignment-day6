using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Day6_CollectionAssignment
{
    class BookStore
    {
        private Hashtable bookDetails;

        public BookStore()
        {
            bookDetails = new Hashtable();
        }

        public void AcceptDetails(int bookId, string bookName)
        {
            bookDetails[bookId] = bookName;
        }

        public void Display()
        {
            Console.WriteLine("\nBook Details using HashTable:");

            foreach (DictionaryEntry entry in bookDetails)
            {
                Console.WriteLine($"BookId: {entry.Key}, BookName: {entry.Value}");
            }
        }

        static void Main()
        {
            BookStore bookStore = new BookStore();

            bookStore.AcceptDetails(101, "Introduction to C#");
            bookStore.AcceptDetails(102, "MSSql");
            bookStore.AcceptDetails(103, ".Net framework");

            bookStore.Display();

            Console.ReadLine();
        }
    }
}