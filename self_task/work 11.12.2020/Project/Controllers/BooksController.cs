using Project.Models;
using Project.Services;
using Project.Views;
using System;
using System.Windows.Forms;

namespace Project.Controllers
{
    class BooksController
    {
        private BooksForm _booksForm { get; }

        private StorageContext _context { get; }

        public BooksController(BooksForm booksForm, StorageContext context)
        {
            _booksForm = booksForm;
            _booksForm.Load += Load;
            _booksForm.AddData += AddDataHandler;
            _booksForm.ChangeData += ChangeDataHandler;
            _booksForm.DeleteData += DeleteDataHandler;
            _booksForm.RefreshData += RefreshDataHandler;
            _context = context;
        }

        public void Load(object sender, EventArgs e)
        {
            RefreshDataHandler();
        }

        public void AddDataHandler()
        {
            BooksEditorForm editor = new BooksEditorForm();
            DialogResult result = editor.ShowDialog(_context.authorsProvider.GetAll());

            if (result != DialogResult.OK)
                return;

            try
            {
                _context.booksProvider.Add(editor.NewBook);
                RefreshDataHandler();
            }
            catch
            {
                MessageBox.Show("Произошла ошибка при добавлении данных!");
            }
        }

        public void ChangeDataHandler(Book book)
        {
            BooksEditorForm editor = new BooksEditorForm();
            DialogResult result = editor.ShowDialog(book, _context.authorsProvider.GetAll());

            if (result != DialogResult.OK)
                return;

            try
            {
                _context.booksProvider.Update(book.Id, editor.NewBook);
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
                _context.booksProvider.Delete(id);
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
                _booksForm.ShowBooks(_context.booksProvider.GetAll());
            }
            catch
            {
                MessageBox.Show("Произошла ошибка при обновлении данных!");
            }
        }
    }
}
