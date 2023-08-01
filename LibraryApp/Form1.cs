using LibraryApp.Interfaces;
using LibraryApp.Models;
using LibraryApp.Repositories;
using PetaPoco;
using System.ComponentModel;
using System.Windows.Forms;
using static System.Reflection.Metadata.BlobBuilder;

namespace LibraryApp
{
    public partial class Form1 : Form
    {
        private IDatabase libraryDbInstance;
        private readonly IBookRepository bookRepository;
        private readonly IReviewRepository reviewRepository;
        private List<Book> books;
        private Color originalRowBackColor;
        public Form1()
        {
            InitializeComponent();
            libraryDbInstance = LibraryDb.GetDatabaseInstance();
            bookRepository = new BookRepository(libraryDbInstance);
            reviewRepository = new ReviewRepository(libraryDbInstance);
            books = bookRepository.GetAllBooksWithReviews();
            UpdateBooksDataGridView(books);
            bookRepository.BookAdded += BookRepository_BookAdded;
            reviewRepository.ReviewAdded += ReviewRepository_ReviewAdded;
        }
        private void btnOpenAddBookForm_Click(object sender, EventArgs e)
        {
            AddBookForm addBookForm = new AddBookForm(bookRepository);
            addBookForm.ShowDialog();
        }

        private void txtBoxFilterBooks_TextChanged(object sender, EventArgs e)
        {
            var searchedText = txtBoxFilterBooks.Text.ToLower();
            var filteredBooks = books.Where(book => book.Title.ToLower().Contains(searchedText) || book.Author.ToLower().Contains(searchedText)).ToList();
            UpdateBooksDataGridView(filteredBooks);
        }
        private void UpdateBooksDataGridView(List<Book> books)
        {
            dataGridViewBooks.Rows.Clear();
            var rows = new List<DataGridViewRow>();
            foreach (var book in books)
            {
                double averageRating = book.Reviews.Count > 0 ? book.Reviews.Average(r => r.Rate) : 0;
                int ratingsCount = book.Reviews.Count;
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridViewBooks);
                row.Cells[0].Value = book.Id;
                row.Cells[1].Value = book.Title;
                row.Cells[2].Value = book.Author;
                row.Cells[3].Value = averageRating.ToString("N2");
                row.Cells[4].Value = ratingsCount;
                rows.Add(row);
            }
            // AddRange() potrzebuje tablicy, a nie listy, dlatego przekszta³camy listê rows na tablicê
            dataGridViewBooks.Rows.AddRange(rows.ToArray());
        }
        private void BookRepository_BookAdded(object sender, EventArgs e)
        {
            books = bookRepository.GetAllBooksWithReviews();
            UpdateBooksDataGridView(books);
        }
        private void ReviewRepository_ReviewAdded(object sender, EventArgs e)
        {
            books = bookRepository.GetAllBooksWithReviews();
            UpdateBooksDataGridView(books);
        }
        private void dataGridViewBooks_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            this.Cursor = Cursors.Hand;
            if (e.RowIndex >= 0)
            {
                originalRowBackColor = dataGridViewBooks.Rows[e.RowIndex].DefaultCellStyle.BackColor;
                dataGridViewBooks.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGray;
            }
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                dataGridViewBooks.Rows[e.RowIndex].Cells[e.ColumnIndex].ToolTipText = "Kliknij, ¿eby zobaczyæ szczegó³y";
            }
        }
        private void dataGridViewBooks_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            this.Cursor = Cursors.Default;
            if (e.RowIndex >= 0)
            {
                dataGridViewBooks.Rows[e.RowIndex].DefaultCellStyle.BackColor = originalRowBackColor;
            }
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                dataGridViewBooks.Rows[e.RowIndex].Cells[e.ColumnIndex].ToolTipText = string.Empty;
            }
        }
        private void dataGridViewBooks_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // sprawdzenie, czy klikniêta komórka nale¿y do ostatniej kolumny i nie jest czêœci¹ nag³ówka
            if (e.RowIndex > -1 && e.ColumnIndex == dataGridViewBooks.Columns.Count - 1)
            {
                var result = MessageBox.Show("Czy na pewno chcesz usun¹æ ksi¹¿kê?", "Potwierdzenie usuwania", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    int bookId = (int)dataGridViewBooks.Rows[e.RowIndex].Cells["Id"].Value;
                    bookRepository.DeleteBook(bookId);
                    books = bookRepository.GetAllBooksWithReviews();
                    UpdateBooksDataGridView(books);
                }
            }
        }
        private void dataGridViewBooks_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //sprawdzenie, czy wybrana komórka nie nale¿y do nag³ówka i nie nale¿y do ostatniej kolumny
            if (e.RowIndex > -1 && e.ColumnIndex != dataGridViewBooks.Columns.Count - 1)
            {
                BookDetailsForm bookDetailsForm = new BookDetailsForm(bookRepository, reviewRepository, (int)dataGridViewBooks.Rows[e.RowIndex].Cells["Id"].Value);
                bookDetailsForm.ShowDialog();
            }
        }
        private void comboBoxSortBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            SortBooksDataGridView();
        }
        private void SortBooksDataGridView()
        {
            var selectedSorting = comboBoxSortBooks.SelectedIndex;
            switch (selectedSorting)
            {
                case 0:
                    dataGridViewBooks.Sort(dataGridViewBooks.Columns["RatesCount"], ListSortDirection.Descending);
                    break;
                case 1:
                    dataGridViewBooks.Sort(dataGridViewBooks.Columns["RatesCount"], ListSortDirection.Ascending);
                    break;
                case 2:
                    dataGridViewBooks.Sort(dataGridViewBooks.Columns["AverageRate"], ListSortDirection.Descending);
                    break;
                case 3:
                    dataGridViewBooks.Sort(dataGridViewBooks.Columns["AverageRate"], ListSortDirection.Ascending);
                    break;
            }
        }
        private void dataGridViewBooks_SelectionChanged(object sender, EventArgs e)
        {
            dataGridViewBooks.ClearSelection();
        }
    }
}