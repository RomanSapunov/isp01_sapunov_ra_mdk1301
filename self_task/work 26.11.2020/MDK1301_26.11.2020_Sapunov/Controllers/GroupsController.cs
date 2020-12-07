using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MDK1301_26._11._2020_Sapunov.Views;
using MDK1301_26._11._2020_Sapunov.Services;
using MDK1301_26._11._2020_Sapunov.Models;
using System.Windows.Forms;

namespace MDK1301_26._11._2020_Sapunov.Controllers
{
    class GroupsController
    {
        private GroupsForm _view { get; set; } = null;

        private StorageContext _context;

        public GroupsController(GroupsForm view, StorageContext context)
        {
            _view = view;
            _view.Load += LoadHandler;
            _view.RefreshData += RefreshDataHandler;
            _view.ChangeData += ChangeDataHandler;
            _view.AddData += AddDataHandler;
            _view.DeleteData += DeleteDataHandler;
            _view.ShowStudentsWindow += ShowStudentsWindowHandler;
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
                List<Group> groups = _context.Groups.GetAllWithSpecialty();
                _view.ShowData(groups);
            }
            catch
            {
                MessageBox.Show("Произошла ошибка при чтении данных");
            }
        }

        public void ShowStudentsWindowHandler() 
        {
            StudentsForm studentsForm = new StudentsForm();

            _ = new StudentsController(studentsForm, _context);

            _view.Hide();

            studentsForm.ShowDialog();

            _view.Show();
        }

        public void AddDataHandler() 
        {
            GroupEditorForm groupForm = new GroupEditorForm();
            DialogResult result = groupForm.ShowDialog(_context.Specialties.GetAll());

            if (result != DialogResult.OK)
                return;

            try
            {
                _context.Groups.Add(groupForm.NewData);
                RefreshDataHandler();
            }
            catch
            {
                MessageBox.Show("Произошла ошибка при добавлении данных");
            }
        }

        public void ChangeDataHandler(Group data) 
        {
            GroupEditorForm groupForm = new GroupEditorForm();

            DialogResult result = groupForm.ShowDialog(
                data, 
                _context.Specialties.GetAll()
            );

            if (result != DialogResult.OK)
                return;

            try
            {
                _context.Groups.Update(data.Id, groupForm.ChangedData);
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
                _context.Groups.Delete(id);
                RefreshDataHandler();
            }
            catch
            {

                MessageBox.Show("Произошла ошибка при удалении данных");
            }
        }
    }
}