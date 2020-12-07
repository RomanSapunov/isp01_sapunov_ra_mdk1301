using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MDK1301_26._11._2020_Sapunov.Models;

namespace MDK1301_26._11._2020_Sapunov.Views
{
    public partial class SpecialtyEditorForm : Form
    {
        private int id;

        public Specialty ChangedData
        {
            get
            {
                return new Specialty
                {
                    Id = id,
                    Code = codeBox.Text,
                    Name = nameBox.Text
                };
            }
        }

        public Specialty NewData
        {
            get
            {
                return new Specialty
                {
                    Id = id,
                    Code = codeBox.Text,
                    Name = nameBox.Text
                };
            }
        }

        public SpecialtyEditorForm()
        {
            InitializeComponent();
        }

        public DialogResult ShowDialog(Specialty data)
        {
            if (data == null)
                data = new Specialty();

            id = data.Id;
            codeBox.Text = data.Code;
            nameBox.Text = data.Name;

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
