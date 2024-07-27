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
            foreach (RadioButton rb in grbDisplay.Controls)
            {
                rb.Checked = false;
            }

            nudPos.Value = 0;
            nudValue.Value = 0;

            lvState.Items.Clear();
        }

        private int getStage()
        {
            return lvState.Items.Count + 1;
        }

        private void rbOne_CheckedChanged(object sender, EventArgs e)
        {
            updateOne();
        }
        private void rb2_CheckedChanged(object sender, EventArgs e)
        {
            updateTwo();
        }
        private void rb3_CheckedChanged(object sender, EventArgs e)
        {
            updateThree();
        }
        private void rb4_CheckedChanged(object sender, EventArgs e)
        {
            updateFour();
        }


        private void updateOne()
        {
            switch (getStage())
            {
                case 1:
                    nudPos.Value = 2;
                    nudValue.Value = 0;
                    break;
                case 2:
                    nudPos.Value = 0;
                    nudValue.Value = 4;
                    break;
                case 3:
                    nudPos.Value = 0;
                    nudValue.Value = getNumberFromStage(2);
                    break;
                case 4:
                    nudPos.Value = getPositionFromStage(1);
                    nudValue.Value = 0;
                    break;
                case 5:
                    nudPos.Value = 0;
                    nudValue.Value = getNumberFromStage(1);
                    break;
            }
        }

        private void updateTwo()
        {
            switch (getStage())
            {
                case 1:
                    nudPos.Value = 2;
                    nudValue.Value = 0;
                    break;
                case 2:
                    nudPos.Value = getPositionFromStage(1);
                    nudValue.Value = 0;
                    break;
                case 3:
                    nudPos.Value = 0;
                    nudValue.Value = getNumberFromStage(1);
                    break;
                case 4:
                    nudPos.Value = 1;
                    nudValue.Value = 0;
                    break;
                case 5:
                    nudPos.Value = 0;
                    nudValue.Value = getNumberFromStage(2);
                    break;
            }
        }

        private void updateThree()
        {
            switch (getStage())
            {
                case 1:
                    nudPos.Value = 3;
                    nudValue.Value = 0;
                    break;
                case 2:
                    nudPos.Value = 1;
                    nudValue.Value = 0;
                    break;
                case 3:
                    nudPos.Value = 3;
                    nudValue.Value = 0;
                    break;
                case 4:
                    nudPos.Value = getPositionFromStage(2);
                    nudValue.Value = 0;
                    break;
                case 5:
                    nudPos.Value = 0;
                    nudValue.Value = getNumberFromStage(4);
                    break;
            }
        }

        private void updateFour()
        {
            switch (getStage())
            {
                case 1:
                    nudPos.Value = 4;
                    nudValue.Value = 0;
                    break;
                case 2:
                    nudPos.Value = getPositionFromStage(1);
                    nudValue.Value = 0;
                    break;
                case 3:
                    nudPos.Value = 0;
                    nudValue.Value = 4;
                    break;
                case 4:
                    nudPos.Value = getPositionFromStage(2);
                    nudValue.Value = 0;
                    break;
                case 5:
                    nudPos.Value = 0;
                    nudValue.Value = getNumberFromStage(3);
                    break;
            }
        }

        private int getNumberFromStage(int stage)
        {
            return getInfoFromStage(stage, 1);
        }

        private int getPositionFromStage(int stage)
        {
            return getInfoFromStage(stage, 0);
        }

        private int getInfoFromStage(int stage, int index)
        {
            return Convert.ToInt32(lvState.Items[stage - 1].Text.Split(";")[index]);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            lvState.Items.Add(nudPos.Value + ";" + nudValue.Value);
            foreach ( RadioButton rb in grbDisplay.Controls )
            {
                if (!rb.Checked) { continue; }
                Action[] updateFunctions = new Action[] { updateOne, updateTwo, updateThree, updateFour};
                updateFunctions[Convert.ToInt32(rb.Text)-1].Invoke();
            }
        }
    }
}
