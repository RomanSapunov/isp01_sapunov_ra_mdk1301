using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MDK1301_26._11._2020_Sapunov.Models;

namespace MDK1301_26._11._2020_Sapunov.Views
{
    public partial class GroupEditorForm : Form
    {
        private int id;

        public Group ChangedData
        {
            get
            {
                return new Group
                {
                    Id = id,
                    Name = nameBox.Text,
                    Year = int.Parse(yearBox.Text),
                    SpecialtyId = (specBox.SelectedItem as Specialty).Id,
                    Specialty = specBox.SelectedItem as Specialty,
                };
            }
        }

        public Group NewData
        {
            get
            {
                return new Group
                {
                    Id = id,
                    Name = nameBox.Text,
                    Year = int.Parse(yearBox.Text),
                    SpecialtyId = (specBox.SelectedItem as Specialty).Id,
                    Specialty = specBox.SelectedItem as Specialty
                };
            }
        }

        public GroupEditorForm()
        {
            InitializeComponent();
        }

        public DialogResult ShowDialog(Group data, List<Specialty> specialties)
        {
            if (data == null)
                data = new Group();

            id = data.Id;

            nameBox.Text = data.Name;
            yearBox.Text = data.Year.ToString();

            specBox.DataSource = specialties;
            specBox.DisplayMember = "Name";

            Specialty selectedSpecialty = null;

            foreach (var specialty in specialties)
            {
                if (specialty.Id == data.Specialty.Id)
                {
                    selectedSpecialty = specialty;
                    break;
                }
            }

            specBox.SelectedItem = selectedSpecialty;

            return ShowDialog();
        }

        public DialogResult ShowDialog(List<Specialty> specialties)
        {
            specBox.DataSource = specialties;
            specBox.DisplayMember = "Name";

            return ShowDialog();
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void rejectButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}