﻿using BooksStorage.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BooksStorage.Views
{
    public partial class BooksForm : Form
    {
        public event Action AddData;
        public event Action<Book> ChangeData;
        public event Action<int> DeleteData;
        public event Action RefreshData;

        public BooksForm(User user)
        {
            InitializeComponent();
            booksView.AutoGenerateColumns = false;
            if (user.Role == "guest") 
            {
                addButton.Visible = false;
                changeButton.Visible = false;
                deleteButton.Visible = false;
                refreshButton.Visible = false;
                booksView.Dock = DockStyle.Fill;
            }
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
    }
}