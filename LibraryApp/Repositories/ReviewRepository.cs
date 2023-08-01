using LibraryApp.Interfaces;
using LibraryApp.Models;
using PetaPoco;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace LibraryApp.Repositories
{
    internal class ReviewRepository : IReviewRepository
    {
        public event EventHandler ReviewAdded;

        private readonly IDatabase libraryDbInstance;
        public ReviewRepository(IDatabase libraryDbInstance)
        {
            this.libraryDbInstance = libraryDbInstance;
        }
        public List<Review> GetAllReviewsOfBook(int bookId)
        {
            var reviews = libraryDbInstance.Fetch<Review>("WHERE BookId = @0", bookId);
            foreach (var review in reviews)
            {
                // Pobranie recenzji przypisanychs do danej książki
                review.Book = libraryDbInstance.SingleOrDefault<Book>("WHERE Id = @0", review.BookId);
            }
            return reviews;
        }
        public void AddReview(string description, int rate, int bookId)
        {
            var review = new Review
            {
                Description = description,
                Rate = rate,
                BookId=bookId
            };
            // rozdzielić walidację do innej klasy
            var validationContext = new ValidationContext(review, serviceProvider: null, items: null);
            var validationResults = new List<ValidationResult>();
            bool isValid = Validator.TryValidateObject(review, validationContext, validationResults);
            if (isValid)
            {
                libraryDbInstance.Insert(review);
                ReviewAdded?.Invoke(this, EventArgs.Empty);
                MessageBox.Show("Recenzja została dodana.");
            }
            else
            {
                foreach (var validationResult in validationResults)
                {
                    MessageBox.Show(validationResult.ErrorMessage, "Błąd walidacji", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
