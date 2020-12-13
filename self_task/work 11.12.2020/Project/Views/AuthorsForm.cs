using Project.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Project.Views
{
    public partial class AuthorsForm : Form
    {
        public event Action AddData;
        public event Action<Author> ChangeData;
        public event Action<int> DeleteData;
        public event Action RefreshData;

        public AuthorsForm()
        {
            InitializeComponent();
            authorsView.AutoGenerateColumns = false;
        }

        public void ShowAuthors(List<Author> authors) => authorsView.DataSource = authors;

        private void addButton_Click(object sender, EventArgs e)
        {
            AddData();
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            ChangeData(authorsView.SelectedRows[0].DataBoundItem as Author);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DeleteData((authorsView.SelectedRows[0].DataBoundItem as Author).Id);
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            RefreshData();
        }
    }
}