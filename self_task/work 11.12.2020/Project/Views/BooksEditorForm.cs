using Project.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Project.Views
{
    public partial class BooksEditorForm : Form
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
                    AuthorId = (authorBox.SelectedItem as Author).Id,
                    Author = authorBox.SelectedItem as Author
                };
            }
        }

        public BooksEditorForm()
        {
            InitializeComponent();
            authorBox.DisplayMember = "Name";
        }

        public DialogResult ShowDialog(Book book, List<Author> authors)
        {
            id = book.Id;
            titleBox.Text = book.Title;
            countOfPagesUpDown.Value = book.CountOfPages;
            authorBox.DataSource = authors;

            Author selectedAuthor = null;

            foreach (var author in authors)
            {
                if (author.Id == book.Author.Id)
                {
                    selectedAuthor = author;
                    break;
                }
            }

            authorBox.SelectedItem = selectedAuthor;

            return ShowDialog();
        }

        public DialogResult ShowDialog(List<Author> authors)
        {
            authorBox.DataSource = authors;

            return ShowDialog();
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(titleBox.Text) || string.IsNullOrEmpty(countOfPagesUpDown.Value.ToString()))
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
