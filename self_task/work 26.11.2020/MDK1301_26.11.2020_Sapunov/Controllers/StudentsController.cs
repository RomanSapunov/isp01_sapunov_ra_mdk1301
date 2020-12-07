using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MDK1301_26._11._2020_Sapunov.Views;
using MDK1301_26._11._2020_Sapunov.Services;
using MDK1301_26._11._2020_Sapunov.Models;

namespace MDK1301_26._11._2020_Sapunov.Controllers
{
    class StudentsController
    {
        private StudentsForm _view { get; set; } = null;

        private StorageContext _context;

        public StudentsController(StudentsForm view, StorageContext context)
        {
            _view = view;
            _view.Load += LoadHandler;
            _view.RefreshData += RefreshDataHandler;
            _view.AddData += AddDataHandler;
            _view.ChangeData += ChangeDataHandler;
            _view.DeleteData += DeleteDataHandler;
            _context = context;
        }

        public void LoadHandler(object s, EventArgs e)
        {
            RefreshDataHandler();
        }

        public void RefreshDataHandler()
        {
            try
            {
                List<Student> students = _context.Students.GetAllWithGroup();
                _view.ShowData(students);
            }
            catch
            {
                MessageBox.Show("Произошла ошибка при чтении данных");
            }
        }

        public void AddDataHandler() 
        {
            StudentsEditorForm studentForm = new StudentsEditorForm();
            DialogResult result = studentForm.ShowDialog(_context.Groups.GetAll());

            if (result != DialogResult.OK)
                return;

            try
            {
                _context.Students.Add(studentForm.NewData);
                RefreshDataHandler();
            }
            catch
            {
                MessageBox.Show("Произошла ошибка при добавлении данных");
            }
        }

        public void ChangeDataHandler(Student data) 
        {
            StudentsEditorForm studentForm = new StudentsEditorForm();
            DialogResult result = studentForm.ShowDialog(
                data, 
                _context.Groups.GetAll()
            );

            if (result != DialogResult.OK)
                return;

            try
            {
                _context.Students.Update(data.Id, studentForm.ChangedData);
                RefreshDataHandler();
            }
            catch
            {
                MessageBox.Show("Произошла ошибка при обновлении данных");
            }
        }

        public void DeleteDataHandler(int id)
        {
            try
            {
                _context.Students.Delete(id);
                RefreshDataHandler();
            }
            catch
            {

                MessageBox.Show("Произошла ошибка при удалении данных");
            }
        }
    }
}