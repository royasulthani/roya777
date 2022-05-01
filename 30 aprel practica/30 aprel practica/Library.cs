using System;
using System.Collections.Generic;
using System.Text;

namespace _30_aprel_practica
{
    class Library
    {
        public List<Book> books = new List<Book>();
        public List<Book> FindAllBooksByName(string value)
        {
            return books.FindAll(book => book.Name.Contains(value));
        }
        public void RemoveAllBooksByName(string value)
        {
            books.RemoveAll(Book => Book.Name.Contains(value));
        }
        public List<Book> SearchBooks(string value)
        {
            return books.FindAll(books.Name.Contains(value) || books.AuthorName.Contains() || books.PageCount.ToString().Contains(value));
        }
        public List<Book> FindAllBooksByPageCountRange(int min, int max)
        {
            return books.FindAll(Book => Book.PageCount >= min && Book.PageCount <= max);
        }
        public void RemoveBookByCode(String value)
        {
            Book WantedBook = books.Find(Book => Book.Code == value);
            if (WantedBook != null)
                books.Remove(WantedBook);
        }
    }
}

