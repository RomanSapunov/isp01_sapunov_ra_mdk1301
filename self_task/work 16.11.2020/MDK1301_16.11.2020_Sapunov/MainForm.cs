using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MDK1301_16._11._2020_Sapunov
{
    public partial class MainForm : Form
    {
        private const string filePath = @"C:\Users\taks.txt";

        public MainForm()
        {
            InitializeComponent();
        }

        private void addTaskButton_Click(object sender, EventArgs e)
        {
            TaskEditorForm taskEditorForm = new TaskEditorForm();

            DialogResult dialogResult = taskEditorForm.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                ListViewItem item = new ListViewItem();
                item.SubItems[0].Text = taskEditorForm.ChangedTask.DateTimeByExecute.ToString();
                item.SubItems.Add(taskEditorForm.ChangedTask.Title);
                toDoListView.Items.Add(item);
            }
        }

        private void deleteTaskButton_Click(object sender, EventArgs e)
        {
            if (toDoListView.FullRowSelect)
                toDoListView.SelectedItems[0].Remove();
        }

        private void toDoListView_DoubleClick(object sender, EventArgs e)
        {
            if (toDoListView.SelectedItems.Count < 1)
                return;

            ListViewItem selectedItem = toDoListView.SelectedItems[0];

            TaskEditorForm taskEditorForm = new TaskEditorForm();

            Task task = new Task()
            {
                DateTimeByExecute = DateTime.Parse(selectedItem.SubItems[0].Text),
                Title = selectedItem.SubItems[1].Text
            };

            DialogResult dialogResult = taskEditorForm.ShowDialog(task);

            if (dialogResult == DialogResult.OK)
            {
                selectedItem.SubItems[0].Text = taskEditorForm.ChangedTask.DateTimeByExecute.ToString();
                selectedItem.SubItems[1].Text = taskEditorForm.ChangedTask.Title;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            FileStream fstream = new FileStream(filePath, FileMode.OpenOrCreate);

            StreamReader reader = new StreamReader(fstream);

            string line;

            while ((line = reader.ReadLine()) != null)
            {
                string[] dataLine = line.Split(new[] { "___" }, StringSplitOptions.RemoveEmptyEntries);

                ListViewItem item = new ListViewItem();
                item.SubItems[0].Text = dataLine[0];
                item.SubItems.Add(dataLine[1]);
                toDoListView.Items.Add(item);
            }

            fstream.Close();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            FileStream fstream = new FileStream(filePath, FileMode.Create);

            StreamWriter writer = new StreamWriter(fstream);

            foreach (ListViewItem item in toDoListView.Items)
            {
                writer.WriteLine($"{item.SubItems[0].Text}___{item.SubItems[1].Text}");
            }

            writer.Flush();

            fstream.Close();
        }
    }
}