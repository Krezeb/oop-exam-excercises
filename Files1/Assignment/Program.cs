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
            string format = "{0,-30} {1,-20} {2}";

            Console.WriteLine("Input Genre to list: ");
            inputGenre = Console.ReadLine();

            string[] _bookList = File.ReadAllLines("books.txt");
            List<Book> _bookList2 = new List<Book>();

            _bookList2.Add(new Book() { Title = "Title", Author = "Author", Genre = "Genre" });

            foreach (string row in _bookList)
            {
                string[] subs = row.Split('§');
                Book newBook = new Book()
                {
                    Title = subs[0],
                    Author = subs[1],
                    Genre = subs[2]
                };
                _bookList2.Add(newBook);
            }
            _bookList2.RemoveAt(1);

            Console.WriteLine(format, _bookList2[0].Title, _bookList2[0].Author, _bookList2[0].Genre);
            foreach (Book book in _bookList2)
            {
                if (book.Genre.ToLower() == inputGenre.ToLower())
                {
                    string _title = book.Title;
                    if (_title.Length > 30)
                    {
                        _title = book.Title.Substring(0, 29); //0 is the starting letter, 29 is the last
                        //book.Title[..29]; //Shortening strings can be done like this aswell
                    }
                    Console.WriteLine(format, _title, book.Author, book.Genre);
                }
            }
        }
    }
}
