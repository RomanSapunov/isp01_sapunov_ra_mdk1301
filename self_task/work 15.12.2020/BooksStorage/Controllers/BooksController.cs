using BooksStorage.Models;
using BooksStorage.Services;
using BooksStorage.Views;
using System;
using System.Windows.Forms;

namespace BooksStorage.Controllers
{
    public class BooksController
    {
        private BooksForm _booksForm { get; set; }

        private StorageContext _context { get; set; }

        public BooksController(BooksForm booksForm, StorageContext context)
        {
            _booksForm = booksForm;
            _booksForm.Load += LoadHandler;
            _booksForm.AddData += AddDataHandler;
            _booksForm.ChangeData += ChangeDataHandler;
            _booksForm.DeleteData += DeleteDataHandler;
            _booksForm.RefreshData += RefreshDataHandler;
            _context = context;
        }

        public void LoadHandler(object sender, EventArgs e) 
        {
            RefreshDataHandler();
        }

        public void AddDataHandler() 
        {
            try
            {
                BookEditorForm bookEditor = new BookEditorForm();

                bookEditor.ShowDialog();

                _context.BooksProvider.Add(bookEditor.NewBook);

                RefreshDataHandler();
            }
            catch
            {
                MessageBox.Show("Произошла ошибка при добавлении данных!");
            }
        }

        public void ChangeDataHandler(Book book)
        {
            try
            {
                BookEditorForm bookEditor = new BookEditorForm();

                bookEditor.ShowDialog(book);

                _context.BooksProvider.Update(book.Id, bookEditor.NewBook);

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
                _context.BooksProvider.Delete(id);

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
                _booksForm.ShowBooks(_context.BooksProvider.GetAll());
            }
            catch
            {
                MessageBox.Show("Произошла ошибка при обновлении данных!");
            }
        }
    }
}