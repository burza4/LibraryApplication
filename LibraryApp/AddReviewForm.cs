using LibraryApp.Interfaces;
using LibraryApp.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryApp
{
    public partial class AddReviewForm : Form
    {
        private readonly IReviewRepository reviewRepository;
        private int bookId;
        public AddReviewForm(IReviewRepository reviewRepository, int bookId)
        {
            InitializeComponent();
            this.reviewRepository = reviewRepository;
            this.bookId = bookId;
        }
        private void btnAddReview_Click(object sender, EventArgs e)
        {
            string description = txtBoxDescription.Text;
            int rate;
            if (int.TryParse(comboBoxRate.Text, out rate))
            {
                reviewRepository.AddReview(description, rate, bookId);
            }
            else
            {
                MessageBox.Show("Ocena jest wymagana.", "Błąd walidacji", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBackFromAddReview_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
