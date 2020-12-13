using Project.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Project.Views
{
    public partial class BooksForm : Form
    {
        public event Action AddData;
        public event Action<Book> ChangeData;
        public event Action<int> DeleteData;
        public event Action RefreshData;

        public BooksForm()
        {
            InitializeComponent();
            booksView.AutoGenerateColumns = false;
        }

        public void ShowBooks(List<Book> books) 
        {
            booksView.DataSource = books;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddData();
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            ChangeData(booksView.SelectedRows[0].DataBoundItem as Book);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DeleteData((booksView.SelectedRows[0].DataBoundItem as Book).Id);
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void authorsView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (booksView.Columns[e.ColumnIndex].Name != "authorColumn")
                return;

            Book book = booksView.Rows[e.RowIndex].DataBoundItem as Book;

            e.Value = book.Author.Name;
        }
    }
}
