using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDK1301_10._01._20_Sapunov
{
    public partial class CoolForm : Form
    {
        public CoolForm(int number)
        {
            InitializeComponent();
            Text = number.ToString();
        }
    }
}