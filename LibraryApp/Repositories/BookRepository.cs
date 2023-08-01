using LibraryApp.Interfaces;
using LibraryApp.Models;
using PetaPoco;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Repositories
{
    public class BookRepository : IBookRepository
    {
        public event EventHandler BookAdded;
        private readonly IDatabase libraryDbInstance;
        public BookRepository(IDatabase libraryDbInstance)
        {
            this.libraryDbInstance = libraryDbInstance;
        }
        public Book GetBookById(int bookId)
        {
            Book book = libraryDbInstance.SingleOrDefault<Book>("WHERE Id = @0", bookId);
            List<Review> reviews = libraryDbInstance.Fetch<Review>("WHERE BookId = @0", bookId);
            if (reviews.Count > 0)
            {
                book.Reviews = reviews;
            }
            else
            {
                book.Reviews = new List<Review>(); 
            }
            return book;
        }
        public List<Book> GetAllBooksWithReviews()
        {
            List<Book> books = libraryDbInstance.Fetch<Book>();
            foreach (var book in books)
            {
                book.Reviews = libraryDbInstance.Fetch<Review>("WHERE BookId = @0", book.Id);
            }
            return books;
        }
        public void AddBook(string title, string author)
        {
            Book book = new Book
            {
                Title = title,
                Author = author
            };
            // walidacja powinna być wydzielona do oddzielnej klasy 
            var validationContext = new ValidationContext(book, serviceProvider: null, items: null);
            var validationResults = new List<ValidationResult>();
            bool isValid = Validator.TryValidateObject(book, validationContext, validationResults);
            if (isValid)
            {
                libraryDbInstance.Insert(book);
                BookAdded?.Invoke(this, EventArgs.Empty);
                MessageBox.Show("Książka została dodana.");
            }
            else
            {
                foreach (var validationResult in validationResults)
                {
                    MessageBox.Show(validationResult.ErrorMessage, "Błąd walidacji", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public void DeleteBook(int bookId)
        {
            List<Review> reviews = libraryDbInstance.Fetch<Review>("WHERE BookId = @0", bookId);
            foreach (var review in reviews)
            {
                libraryDbInstance.Delete(review);
            }
            Book book = libraryDbInstance.SingleOrDefault<Book>("WHERE Id=@0", bookId);
            if (book != null)
            {
                libraryDbInstance.Delete(book);
            }
        }
    }

}
