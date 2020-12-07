using MDK1301_26._11._2020_Sapunov.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDK1301_26._11._2020_Sapunov.Views
{
    public partial class StudentsEditorForm : Form
    {
        private int id;

        public Student ChangedData
        {
            get
            {
                return new Student
                {
                    Id = id,
                    Name = nameBox.Text,
                    Surname = surnameBox.Text,
                    GroupId = (groupsBox.SelectedItem as Group).Id,
                    Group = groupsBox.SelectedItem as Group
                };
            }
        }

        public Student NewData
        {
            get
            {
                return new Student
                {
                    Id = id,
                    Name = nameBox.Text,
                    Surname = surnameBox.Text,
                    GroupId = (groupsBox.SelectedItem as Group).Id,
                    Group = groupsBox.SelectedItem as Group
                };
            }
        }

        public StudentsEditorForm()
        {
            InitializeComponent();
        }

        public DialogResult ShowDialog(Student data, List<Group> groups)
        {
            if (data == null)
                data = new Student();

            id = data.Id;

            nameBox.Text = data.Name;
            surnameBox.Text = data.Surname;

            groupsBox.DataSource = groups;
            groupsBox.DisplayMember = "Name";

            Group selectedGroup = null;

            foreach (var group in groups)
            {
                if (group.Id == data.Group.Id)
                {
                    selectedGroup = group;
                    break;
                }
            }

            groupsBox.SelectedItem = selectedGroup;

            return ShowDialog();
        }

        public DialogResult ShowDialog(List<Group> groups)
        {
            groupsBox.DataSource = groups;
            groupsBox.DisplayMember = "Name";

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
