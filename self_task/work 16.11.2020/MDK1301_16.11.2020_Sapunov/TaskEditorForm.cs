using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDK1301_16._11._2020_Sapunov
{
    public partial class TaskEditorForm : Form
    {
        public Task ChangedTask { get; private set; } = null;

        public TaskEditorForm()
        {
            InitializeComponent();
        }

        public DialogResult ShowDialog(Task task) 
        {
            if (task == null)
                ChangedTask = new Task() {DateTimeByExecute = DateTime.Now, Title = ""};
            else
                ChangedTask = task;

            dateTimeByExecutePicker.Text = task.DateTimeByExecute.ToString();
            TitleTextBox.Text = task.Title;
            return ShowDialog();
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            if (ChangedTask == null)
                ChangedTask = new Task() { DateTimeByExecute = DateTime.Now, Title = ""};

            if (string.IsNullOrWhiteSpace(TitleTextBox.Text))
            {
                MessageBox.Show("Заголовок не должен быть пустым!");
                return;
            }

            ChangedTask = new Task() {DateTimeByExecute = dateTimeByExecutePicker.Value, Title = TitleTextBox.Text };
            DialogResult = DialogResult.OK;
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
