using System;
using System.Collections.Generic;
using System.IO;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputGenre = "Programming"; //If Lines 14 + 15 are commented out, program will run as Assignment decrees with this variable.
            string format = "{0,-30} {1,-20} {2}"; //String Formatting. Positive numbers are padding added to the end of the item.

            Console.WriteLine("Input Genre to list: ");
            inputGenre = Console.ReadLine();

            string[] _bookArray = File.ReadAllLines("books.txt"); //ReadAllLines returns an Array. This code will create a new Array and then call ReadAllLines. Each line will be placed in its own index.
            List<Book> _bookList2 = new List<Book>(); //Creates a new List.

            _bookList2.Add(new Book() { Title = "Title", Author = "Author", Genre = "Genre" }); //First line in new List is a Header item.

            foreach (string row in _bookArray)
            {
                string[] subs = row.Split('§'); //Creates a new array, splits the string inside the old Array at the symbol provided ('§'), and places each split item in its own index inside the new Array.
                Book newBook = new Book() //Creates a new object of type "Book" using strings inside the new Array's index values.
                {
                    Title = subs[0],
                    Author = subs[1],
                    Genre = subs[2]
                };
                _bookList2.Add(newBook); //Adds the newly created book to the new book List.
            }
            _bookList2.RemoveAt(1); //Removes duplicate header item (can be cut if header line in books.txt is formatted correctly.

            Console.WriteLine(format, _bookList2[0].Title, _bookList2[0].Author, _bookList2[0].Genre); //Using List[0] as list headers.
            foreach (Book book in _bookList2)
            {
                if (book.Genre.ToLower() == inputGenre.ToLower())
                {
                    string _title = book.Title;
                    if (_title.Length > 30)
                    {
                        _title = book.Title.Substring(0, 29); //0 is the starting letter, 29 is the last.
                        //book.Title[..29]; //Shortening strings can be done like this aswell.
                    }
                    Console.WriteLine(format, _title, book.Author, book.Genre);
                }
            }
        }
    }
}
