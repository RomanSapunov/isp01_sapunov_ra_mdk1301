using MDK1301_26._11._2020_Sapunov.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MDK1301_26._11._2020_Sapunov.Views
{
    public partial class StudentsForm : Form
    {
        public event Action RefreshData;
        public event Action AddData;
        public event Action<Student> ChangeData;
        public event Action<int> DeleteData;

        public StudentsForm()
        {
            InitializeComponent();

            studentsView.AutoGenerateColumns = false;
        }

        public void ShowData(List<Student> data)
        {
            studentsView.DataSource = data;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddData();
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            var student = studentsView.SelectedRows[0]
                .DataBoundItem as Student;

            ChangeData(student);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            var student = studentsView.SelectedRows[0]
                .DataBoundItem as Student;

            DeleteData(student.Id);
        }

        private void refreshDataButton_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void studentsView_CellFormatting(
            object sender, 
            DataGridViewCellFormattingEventArgs e
        )
        {
            if (studentsView.Columns[e.ColumnIndex].Name != "groupColumn")
                return;

            Student student = studentsView.Rows[e.RowIndex].DataBoundItem as Student;

            e.Value = student.Group.Name;
        }
    }
}
