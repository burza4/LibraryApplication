using LibraryApp.Interfaces;
using LibraryApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Reflection.Metadata.BlobBuilder;

namespace LibraryApp
{
    public partial class BookDetailsForm : Form
    {
        private readonly IBookRepository bookRepository;
        private readonly IReviewRepository reviewRepository;
        private int bookId;
        private Book currentBook;
        private List<Review> reviews;
        public BookDetailsForm(IBookRepository bookRepository, IReviewRepository reviewRepository, int bookId)
        {
            InitializeComponent();
            this.bookRepository = bookRepository;
            this.reviewRepository = reviewRepository;
            this.bookId = bookId;
            currentBook = bookRepository.GetBookById(bookId);
            this.reviews = reviewRepository.GetAllReviewsOfBook(bookId);
            SetupLabelsValues();
            SetupReviewsDataGridView(reviews);
            reviewRepository.ReviewAdded += ReviewRepository_ReviewAdded;
        }
        private void SetupLabelsValues()
        {
            labelTitle.Text = currentBook.Title;
            labelAuthor.Text = currentBook.Author;
            labelAverageRate.Text = currentBook.Reviews.Count > 0 ? currentBook.Reviews.Average(r => r.Rate).ToString("N2") + "/5" : "Brak ocen";
            labelRatingsCount.Text = currentBook.Reviews.Count > 0 ? "(" + currentBook.Reviews.Count.ToString() + ")" : "";
            labelRatingsCount.Left = labelAverageRate.Left + labelAverageRate.Width + 2;
        }
        private void SetupReviewsDataGridView(List<Review> reviews)
        {
            dataGridViewReviews.Rows.Clear();
            var rows = new List<DataGridViewRow>();
            foreach (var review in reviews)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridViewReviews);
                row.Cells[0].Value = review.Id;
                row.Cells[1].Value = review.Description;
                row.Cells[2].Value = review.Rate;
                rows.Add(row);
            }
            // AddRange() potrzebuje tablicy, a nie listy, dlatego przekształcamy listę rows na tablicę
            dataGridViewReviews.Rows.AddRange(rows.ToArray());
        }
        private void ReviewRepository_ReviewAdded(object sender, EventArgs e)
        {
            reviews = reviewRepository.GetAllReviewsOfBook(bookId);
            SetupReviewsDataGridView(reviews);
            UpdateAverageRating();
            labelRatingsCount.Left = labelAverageRate.Left + labelAverageRate.Width + 2;

        }
        private void UpdateAverageRating()
        {
            currentBook = bookRepository.GetBookById(bookId);
            labelAverageRate.Text = currentBook.Reviews.Count > 0 ? currentBook.Reviews.Average(r => r.Rate).ToString("N2") + "/5" : "Brak ocen";
        }
        private void btnAddReview_Click(object sender, EventArgs e)
        {
            AddReviewForm addReviewForm = new AddReviewForm(reviewRepository, bookId);
            addReviewForm.ShowDialog();
        }

        private void dataGridViewReviews_SelectionChanged(object sender, EventArgs e)
        {
            dataGridViewReviews.ClearSelection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
