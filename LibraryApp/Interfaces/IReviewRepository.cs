using LibraryApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Interfaces
{
    public interface IReviewRepository
    {
        event EventHandler ReviewAdded;

        public List<Review> GetAllReviewsOfBook(int bookId);
        public void AddReview(string description, int rate, int bookId);
    }
}
