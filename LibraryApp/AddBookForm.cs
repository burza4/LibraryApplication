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
    public partial class AddBookForm : Form
    {
        private readonly IBookRepository bookRepository;
        public AddBookForm(IBookRepository bookRepository)
        {
            InitializeComponent();
            this.bookRepository = bookRepository;
        }

        private void btnBackFromAddBook_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            string title = txtBoxBookTitle.Text;
            string author = txtBoxBookAuthor.Text;
            bookRepository.AddBook(title, author);
        }
    }
}
