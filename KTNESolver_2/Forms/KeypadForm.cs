using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KTNESolver_2.Forms
{

    public partial class KeypadForm : Form
    {
        private Func<bombInfo> infoGetter;
        private bombInfo currentInfo;

        private List<CheckBox>[] solutionColumns = new List<CheckBox>[6];
        private CheckBox[] outputBoxes;

        public KeypadForm(Func<bombInfo> getterFunction)
        {
            InitializeComponent();
            this.infoGetter = getterFunction;

            solutionColumns[0] = new List<CheckBox>() { cbBallon, cbAt, cbUpsideDownY, cbSquigglyN, cbSquidknife, cbHookN, cbLeftC };
            solutionColumns[1] = new List<CheckBox>() { cbEuro, cbBallon, cbLeftC, cbCursive, cbHollowStar, cbHookN, cbQuestionmark };
            solutionColumns[2] = new List<CheckBox>() { cbCopyright, cbPumpkin, cbCursive, cbDouleK, cbMeltedThree, cbUpsideDownY, cbHollowStar };
            solutionColumns[3] = new List<CheckBox>() { cbSix, cbParagraph, cbBt, cbSquidknife, cbDouleK, cbQuestionmark, cbSmileyface };
            solutionColumns[4] = new List<CheckBox>() { cbPitchfork, cbSmileyface, cbBt, cbRightC, cbParagraph, cbDragon, cbFilledStar };
            solutionColumns[5] = new List<CheckBox>() { cbSix, cbEuro, cbTracks, cbAe, cbPitchfork, cbNWithHat, cbOmega };

            outputBoxes = new CheckBox[] { cbOut1, cbOut2, cbOut3, cbOut4 };
        }

        private void solve(object sender, EventArgs e)
        {
            currentInfo = infoGetter();

            List<CheckBox> input = gatherInput();

            resetOutput();

            if (input.Count != 4) return;

            List<CheckBox> solutionColumn = findSolutionColumn(input);

            if (solutionColumn.Count == 0) return;

            List<CheckBox> inputSorted = new List<CheckBox>();

            solutionColumn.ForEach(c =>
            {
                if (input.Contains(c)) inputSorted.Add(c);
            });

            for (int i = 0; i < 4; ++i)
            {
                outputBoxes[i].BackgroundImage = inputSorted[i].BackgroundImage;
            }
        }

        private void resetSelection()
        {
            foreach (CheckBox cb in flowKepads.Controls)
            {
                cb.Checked = false;
            }
        }

        private void resetOutput()
        {
            foreach (CheckBox cb in outputBoxes)
            {
                cb.BackgroundImage = null;
            }
        }

        private List<CheckBox> findSolutionColumn(List<CheckBox> input)
        {
            return Array.Find<List<CheckBox>>(solutionColumns, col => input.All(val => col.Contains(val))) ?? new List<CheckBox>();
        }

        private List<CheckBox> gatherInput()
        {
            List<CheckBox> collector = new List<CheckBox>();
            foreach (Control c in flowKepads.Controls)
            {
                CheckBox cb = (CheckBox)c;
                if (cb.Checked)
                {
                    collector.Add(cb);
                }
            }
            return collector;
        }

        private void KeypadForm_Load(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            resetSelection();
        }
    }
}
