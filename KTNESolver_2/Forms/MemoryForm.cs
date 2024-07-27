using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KTNESolver_2.Forms
{
    public partial class MemoryForm : Form
    {
        public MemoryForm()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            foreach(RadioButton rb in grbDisplay.Controls)
            {
                rb.Checked = false;
            }

            nudPos.Value = 0;
            nudValue.Value = 0;

            lvState.Items.Clear();
        }
    }
}
