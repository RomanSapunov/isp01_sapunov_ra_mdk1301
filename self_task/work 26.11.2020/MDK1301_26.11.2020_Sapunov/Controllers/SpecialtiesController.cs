using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using MDK1301_26._11._2020_Sapunov.Views;
using MDK1301_26._11._2020_Sapunov.Services;
using MDK1301_26._11._2020_Sapunov.Models;

namespace MDK1301_26._11._2020_Sapunov.Controllers
{
    class SpecialtiesController
    {
        private SpecialtiesForm _view { get; set; } = null;

        private StorageContext _context;

        public SpecialtiesController(SpecialtiesForm view, StorageContext context)
        {
            _view = view;
            _view.Load += LoadHandler;
            _view.RefreshData += RefreshDataHandler;
            _view.ChangeData += ChangeDataHandler;
            _view.AddData += AddDataHandler;
            _view.DeleteData += DeleteDataHandler;
            _view.ShowGroupsWindow += ShowGroupsWindowHandler;
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
                List<Specialty> specialties = _context.Specialties.GetAll();
                _view.ShowData(specialties);
            }
            catch
            {
                MessageBox.Show("Произошла ошибка при чтении данных");
            }
        }

        public void ChangeDataHandler(Specialty data)
        {
            SpecialtyEditorForm specEditor = new SpecialtyEditorForm();
            DialogResult result = specEditor.ShowDialog(data);

            if (result != DialogResult.OK)
                return;

            try
            {
                _context.Specialties.Update(data.Id, specEditor.ChangedData);
                RefreshDataHandler();
            }
            catch
            {
                MessageBox.Show("Произошла ошибка при обновлении данных");
            }
        }

        public void AddDataHandler()
        {
            SpecialtyEditorForm specEditor = new SpecialtyEditorForm();
            DialogResult result = specEditor.ShowDialog();

            if (result != DialogResult.OK)
                return;

            try
            {
                _context.Specialties.Add(specEditor.NewData);
                RefreshDataHandler();
            }
            catch
            {
                MessageBox.Show("Произошла ошибка при добавлении данных");
            }
        }

        public void DeleteDataHandler(int id)
        {
            try
            {
                _context.Specialties.Delete(id);
                RefreshDataHandler();
            }
            catch
            {

                MessageBox.Show("Произошла ошибка при удалении данных");
            }
        }

        public void ShowGroupsWindowHandler() 
        {
            GroupsForm groupsForm = new GroupsForm();

            _ = new GroupsController(groupsForm, _context);

            _view.Hide();

            groupsForm.ShowDialog();

            _view.Show();
        }
    }
}