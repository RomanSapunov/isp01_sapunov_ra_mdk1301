using BooksStorage.Controllers;
using BooksStorage.Models;
using BooksStorage.Services;
using System;
using System.Windows.Forms;

namespace BooksStorage.Views
{
    public partial class AuthenticationForm : Form
    {
        private StorageContext _context { get; set; }

        public AuthenticationForm(StorageContext context)
        {
            InitializeComponent();
            _context = context;
        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            User user = _context
                .UsersProvider
                .GetUserByLoginAndPassword(
                loginBox.Text, 
                passwordBox.Text
            );

            if (user == null) 
            {
                MessageBox.Show("Введены невалидные значения!");
                return;
            }

            Hide();

            BooksForm booksForm = new BooksForm(user);
            _ = new BooksController(booksForm, new StorageContext());
            booksForm.ShowDialog();

            Show();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
