using Project.Models;
using Project.Services;
using Project.Views;
using System;
using System.Windows.Forms;

namespace Project.Controllers
{
    public class AuthorsController
    {
        private AuthorsForm _authorsForm { get; }

        private StorageContext _context { get; }

        public AuthorsController(AuthorsForm authorsForm, StorageContext context)
        {
            _authorsForm = authorsForm;
            _authorsForm.Load += Load;
            _authorsForm.AddData += AddDataHandler;
            _authorsForm.ChangeData += ChangeDataHandler;
            _authorsForm.DeleteData += DeleteDataHandler;
            _authorsForm.RefreshData += RefreshDataHandler;
            _context = context;
        }

        public void Load(object sender, EventArgs e) 
        {
            RefreshDataHandler();
        }

        public void AddDataHandler()
        {
            AuthorEditorForm editor = new AuthorEditorForm();
            DialogResult result = editor.ShowDialog();

            if (result != DialogResult.OK)
                return;

            try
            {
                _context.authorsProvider.Add(editor.NewAuthor);
                RefreshDataHandler();
            }
            catch
            {
                MessageBox.Show("Произошла ошибка при добавлении данных!");
            }
        }

        public void ChangeDataHandler(Author author)
        {
            AuthorEditorForm editor = new AuthorEditorForm();
            DialogResult result = editor.ShowDialog(author);

            if (result != DialogResult.OK)
                return;

            try
            {
                _context.authorsProvider.Update(author.Id, editor.NewAuthor);
                RefreshDataHandler();
            }
            catch
            {
                MessageBox.Show("Произошла ошибка при изменении данных!");
            }
        }

        public void DeleteDataHandler(int id) 
        {
            try
            {
                _context.authorsProvider.Delete(id);
                RefreshDataHandler();
            }
            catch
            {
                MessageBox.Show("Произошла ошибка при удалении данных!");
            }
        }
        
        public void RefreshDataHandler() 
        {
            try
            {
                _authorsForm.ShowAuthors(_context.authorsProvider.GetAll());
            }
            catch
            {
                MessageBox.Show("Произошла ошибка при обновлении данных!");
            }
        }
    }
}
