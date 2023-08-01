using LibraryApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Interfaces
{
    public interface IBookRepository
    {
        event EventHandler BookAdded;
        public Book GetBookById(int bookId);
        public List<Book> GetAllBooksWithReviews();
        public void AddBook(string title, string author);
        public void DeleteBook(int bookId);
    }
}
