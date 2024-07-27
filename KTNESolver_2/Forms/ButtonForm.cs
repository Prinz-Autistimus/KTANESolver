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
    public partial class ButtonForm : Form
    {

        Func<bombInfo> infoGetter;
        bombInfo currentInfo;

        public ButtonForm(Func<bombInfo> infoGetterFunc)
        {
            InitializeComponent();
            this.infoGetter = infoGetterFunc;
            solve(null, null);
        }

        private void solve(object sender, EventArgs e)
        {
            currentInfo = infoGetter();

            if (checkCombination("Blue", "Abbrechen")) // 1
            {
                executeHold();
            }
            else if (currentInfo.batteryCount > 1 && checkText("Sprengen")) // 2
            {
                executeShort();
            }
            else if (checkColor("White") && currentInfo.hasCAR) // 3
            {
                executeHold();
            }
            else if (currentInfo.batteryCount > 2 && currentInfo.hasFRK) // 4
            {
                executeShort();
            }
            else if (checkColor("Yellow")) // 5
            {
                executeShort();
            }
            else if (checkCombination("Red", "Gedrückt Halten")) // 6
            {
                executeShort();
            }
            else // 7
            {
                executeHold();
            }
        }

        private void holdColor(object sender, EventArgs e)
        {
            RadioButton rbChecked = new RadioButton();
            foreach (RadioButton rb in flowHold.Controls)
            {
                if (rb.Checked) rbChecked = rb;
            }
            switch (rbChecked.Name)
            {
                case "rbHoldBlue":
                    lblLetgo.Text = "Let go on # 4";
                    break;
                case "rbHoldWhite":
                    lblLetgo.Text = "Let go on # 1";
                    break;
                case "rbHoldYellow":
                    lblLetgo.Text = "Let go on # 5";
                    break;
                default:
                    lblLetgo.Text = "Let go on # 1";
                    break;
            }
        }

        private void executeHold()
        {
            grbHoldOnly.Visible = true;
            lblAction.Text = "Hold Button";
        }

        private void executeShort()
        {
            grbHoldOnly.Visible = false;
            lblAction.Text = "Press Shortly";
        }

        private bool checkColor(String color)
        {
            foreach (RadioButton rb in flowColor.Controls)
            {
                if (rb.Checked && rb.Name.Equals("rb" + color))
                {
                    return true;
                }
            }
            return false;
        }

        private bool checkText(String txt)
        {
            foreach (RadioButton rb in flowText.Controls)
            {
                if (rb.Checked && rb.Text.Equals(txt))
                {
                    return true;
                }
            }
            return false;
        }

        private bool checkCombination(String color, String txt)
        {
            return checkColor(color) && checkText(txt);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            rbHoldNone.Checked = true;
            rbNone.Checked = true;
            rbOther.Checked = true;
        }
    }
}
