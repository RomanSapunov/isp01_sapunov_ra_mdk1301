using System;
using System.Windows.Forms;
using System.IO;

namespace MDK1301_11._11._20_Sapunov
{
    public partial class MainForm : Form
    {
        public string FilePath = @"C:\Users\tasks.txt";

        public MainForm()
        {
            InitializeComponent();
        }

        private void addTaskButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(taskTextBox.Text))
            {
                taskTextBox.Text = "";
                return;
            }

            toDoListBox.Items.Add(taskTextBox.Text);
            taskTextBox.Text = "";
        }

        private void deleteTaskButton_Click(object sender, EventArgs e)
        {
            if (toDoListBox.SelectedIndex < 0)
                return;

            toDoListBox.Items.RemoveAt(toDoListBox.SelectedIndex);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            FileStream fstream = new FileStream(FilePath, FileMode.OpenOrCreate);

            StreamReader reader = new StreamReader(fstream);

            while (!reader.EndOfStream)
            {
                toDoListBox.Items.Add(reader.ReadLine());
            }

            fstream.Close();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            FileStream fstream = new FileStream(FilePath, FileMode.Create);

            StreamWriter writer = new StreamWriter(fstream);

            foreach (var item in toDoListBox.Items)
                writer.WriteLine(item);

            writer.Flush();

            fstream.Close();
        }
    }
}