using BooksStorage.Models;
using System;
using System.Windows.Forms;

namespace BooksStorage.Views
{
    public partial class BookEditorForm : Form
    {
        private int id; 

        public Book NewBook 
        { 
            get 
            {
                return new Book
                {
                    Id = id,
                    Title = titleBox.Text,
                    CountOfPages = (int) countOfPagesUpDown.Value,
                    Author = authorBox.Text
                };
            } 
        }

        public BookEditorForm()
        {
            InitializeComponent();
        }

        public DialogResult ShowDialog(Book book) 
        {
            id = book.Id;
            titleBox.Text = book.Title;
            countOfPagesUpDown.Value = book.CountOfPages;
            authorBox.Text = book.Author;

            return ShowDialog();
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(titleBox.Text) || string.IsNullOrEmpty(authorBox.Text))
            {
                MessageBox.Show("Введены невалидные данные!");
                return;
            }

            DialogResult = DialogResult.OK;
        }

        private void rejectButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
