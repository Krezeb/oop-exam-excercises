using System;
using System.Collections.Generic;
using System.IO;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] _bookList = File.ReadAllLines("books.txt");
            List<Book> _bookList2 = new List<Book>();

            foreach (string row in _bookList)
            {

                if (row == _bookList[0])
                {
                    Book newBook = new Book()
                    {
                        Title = "Title",
                        Author = "Author",
                        Genre = "Genre"
                    };
                    _bookList2.Add(newBook);
                }
                else
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
                
            }

            string format = "{0,-30} {1,-20} {2}";
            Console.WriteLine(format, $"{_bookList2[0].Title}", $"{_bookList2[0].Author}", $"{_bookList2[0].Genre}");
            foreach (Book book in _bookList2)
            {
                if (book.Genre == "Programming")
                {
                    if (book.Title.Length < 30)
                    {
                        Console.WriteLine(format, $"{book.Title}", $"{book.Author}", $"{ book.Genre}");
                    }
                    else
                    {
                        string _title = book.Title.Substring(0, 29);
                        Console.WriteLine(format, $"{_title}", $"{book.Author}", $"{ book.Genre}");
                    }
                }
            }
        }
    }
}
