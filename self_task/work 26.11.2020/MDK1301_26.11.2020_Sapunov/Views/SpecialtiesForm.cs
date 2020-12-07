using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MDK1301_26._11._2020_Sapunov.Models;

namespace MDK1301_26._11._2020_Sapunov.Views
{
    public partial class SpecialtiesForm : Form
    {
        public event Action RefreshData;
        public event Action<Specialty> ChangeData;
        public event Action AddData;
        public event Action<int> DeleteData;
        public event Action ShowGroupsWindow;

        public SpecialtiesForm()
        {
            InitializeComponent();
        }

        public void ShowData(List<Specialty> data)
        {
            specialtiesView.DataSource = data;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddData();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            var specialty = specialtiesView.SelectedRows[0]
                .DataBoundItem as Specialty;

            DeleteData(specialty.Id);
        }

        private void showGroupsButton_Click(object sender, EventArgs e)
        {
            ShowGroupsWindow();
        }

        private void refreshDataButton_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            var specialty = specialtiesView.SelectedRows[0]
                .DataBoundItem as Specialty;

            ChangeData(specialty);
        }
    }
}
