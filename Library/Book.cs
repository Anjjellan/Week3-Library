using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
     class Book
    {
        private string title; // FIELD
        private string author; // FIELD
        private string isbn; // FIELD

        // Title property to allow access
        // to the title private field
        public string Title
        {
            get { return title; } // get method returns the value of the private field
            set { title = value; } // set method assigns a value to the private field
        }
        
        // Author property to allow access
        // to the author private field
        public string Author
        {
            get { return author; } // get method returns the value of the private field
            set
            {
                // Check if any character in the incoming string is a digit
                if (!value.Any(char.IsDigit))
                {
                    author = value; // set method assigns a value to the private field
                }
                else
                {
                    Console.WriteLine("Error: Author name cannot contain numbers.");
                }
            }
        }

        // ISBN property to allow access
        // to the isbn private field
        public string ISBN
        {
            get { return isbn; } // get method returns the value of the private field
            set
            {
                // Check if incoming string is not blank
                if (value != "")
                {
                    isbn = value; // set method assigns a value to the private field
                }
                else
                {
                    Console.WriteLine("Error: ISBN cannot be blank.");
                }
            }
        }

        // Example of a constructor that allows us to 'construct' a new
        // Bool object.
        public Book(string bookTitle, string bookAuthor, string bookISBN)
        {
            this.Title = bookTitle;
            this.Author = bookAuthor;
            this.ISBN = bookISBN;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Book Title: {Title}");
            Console.WriteLine($"Book Author: {Author}");
            Console.WriteLine($"Book ISBN: {ISBN}");
            Console.WriteLine();            
        }
    }
}
