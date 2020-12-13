using Project.Models;
using System;
using System.Windows.Forms;

namespace Project.Views
{
    public partial class AuthorEditorForm : Form
    {
        private int id;

        public Author NewAuthor 
        {
            get 
            {
                return new Author
                {
                    Id = id,
                    Name = nameBox.Text,
                    Surname = surnameBox.Text
                };
            }
        }

        public AuthorEditorForm()
        {
            InitializeComponent();
        }

        public DialogResult ShowDialog(Author author) 
        {
            id = author.Id;
            nameBox.Text = author.Name;
            surnameBox.Text = author.Surname;

            return ShowDialog();
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nameBox.Text) || string.IsNullOrEmpty(surnameBox.Text)) 
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