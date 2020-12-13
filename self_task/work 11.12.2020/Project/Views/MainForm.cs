using Project.Controllers;
using Project.Services;
using System;
using System.Windows.Forms;

namespace Project.Views
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void authorButton_Click(object sender, EventArgs e)
        {
            Hide();
            AuthorsForm authorsForm = new AuthorsForm();
            StorageContext context = new StorageContext();
            _ = new AuthorsController(authorsForm, context);
            authorsForm.ShowDialog();
            Show();
        }

        private void booksButton_Click(object sender, EventArgs e)
        {
            Hide();
            BooksForm booksForm = new BooksForm();
            StorageContext context = new StorageContext();
            _ = new BooksController(booksForm, context);
            booksForm.ShowDialog();
            Show();
        }
    }
}