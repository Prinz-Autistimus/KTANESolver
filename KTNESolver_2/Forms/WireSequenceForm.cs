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
    public partial class WireSequenceForm : Form
    {

        private int redCount = 0, blueCount = 0, blackCount = 0;

        private string[] redLookup = { "C", "B", "A", "AC", "B", "AC", "ABC", "AB", "B" };
        private string[] blueLookup = { "B", "AC", "B", "A", "B", "BC", "C", "AC", "A" };
        private string[] blackLookup = { "ABC", "AC", "B", "AC", "B", "BC", "AB", "C", "C" };

        public WireSequenceForm()
        {
            InitializeComponent();
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            string connection = "";
            foreach (RadioButton rb in flowRed.Controls)
            {
                if (rb.Checked)
                {
                    connection = rb.Text;
                }
            }

            bool cut = false;
            if (redLookup[redCount].Contains(connection))
            {
                cut = true;
            }

            pbTick.Visible = cut;
            pbX.Visible = !cut;
            lblRed.Text = $"{redCount = Math.Min(redLookup.Length-1, ++redCount)}";
        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            string connection = "";
            foreach (RadioButton rb in flowBlue.Controls)
            {
                if (rb.Checked)
                {
                    connection = rb.Text;
                }
            }

            bool cut = false;
            if (blueLookup[blueCount].Contains(connection))
            {
                cut = true;
            }

            pbTick.Visible = cut;
            pbX.Visible = !cut;
            lblBlue.Text = $"{blueCount = Math.Min(blueLookup.Length-1, ++blueCount)}";
        }

        private void btnBlack_Click(object sender, EventArgs e)
        {
            string connection = "";
            foreach (RadioButton rb in flowBlack.Controls)
            {
                if (rb.Checked)
                {
                    connection = rb.Text;
                }
            }

            bool cut = false;
            if (blackLookup[blackCount].Contains(connection))
            {
                cut = true;
            }

            pbTick.Visible = cut;
            pbX.Visible = !cut;
            lblBlack.Text = $"{blackCount = Math.Min(blackLookup.Length-1, ++blackCount)}";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            redCount = blueCount = blackCount = 0;
            rbRedA.Checked = rbBlueA.Checked = rbBlackA.Checked = true;
            pbTick.Visible = false;
            pbX.Visible = false;

            lblRed.Text = lblBlue.Text = lblBlack.Text = "0";
        }
    }
}
