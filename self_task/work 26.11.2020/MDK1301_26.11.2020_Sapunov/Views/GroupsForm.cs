using MDK1301_26._11._2020_Sapunov.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MDK1301_26._11._2020_Sapunov.Views
{
    public partial class GroupsForm : Form
    {
        public event Action ShowStudentsWindow;
        public event Action RefreshData;
        public event Action AddData;
        public event Action<Group> ChangeData;
        public event Action<int> DeleteData;

        public GroupsForm()
        {
            InitializeComponent();

            groupsView.AutoGenerateColumns = false;
        }

        public void ShowData(List<Group> data)
        {
            groupsView.DataSource = data;
        }

        private void showStudentsButton_Click(object sender, EventArgs e)
        {
            ShowStudentsWindow();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddData();
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            var group = groupsView.SelectedRows[0]
                .DataBoundItem as Group;

            ChangeData(group);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            var group = groupsView.SelectedRows[0]
                .DataBoundItem as Group;

            DeleteData(group.Id);
        }

        private void refreshDataButton_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void groupsView_CellFormatting(
            object sender, 
            DataGridViewCellFormattingEventArgs e
        )
        {
            if (groupsView.Columns[e.ColumnIndex].Name != "specColumn")
                return;

            Group group = groupsView.Rows[e.RowIndex].DataBoundItem as Group;

            e.Value = group.Specialty.Name;
        }
    }
}