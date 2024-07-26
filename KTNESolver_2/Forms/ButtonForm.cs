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
        }

        private void solve(object sender, EventArgs e)
        {
            currentInfo = infoGetter();

            if(checkCombination("Blue", "Abbrechen")) // 1
            {
                executeHold();
            }
            else if(currentInfo.batteryCount >= 1 && checkText("Sprengen")) // 2
            {
                executeShort();
            }
            else if(checkColor("White") && currentInfo.hasCAR) // 3
            {
                executeHold();
            }
            else if(currentInfo.batteryCount >= 2 && currentInfo.hasFRK) // 4
            {
                executeShort();
            }
            else if(checkColor("Yellow")) // 5
            {
                executeShort();
            }
            else if(checkCombination("Red", "Gedrückt Halten")) // 6
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
            switch(comboHold.Text)
            {
                case "Blue":
                    lblLetgo.Text = "Let go on # 4";
                    break;
                case "White":
                    lblLetgo.Text = "Let go on # 1";
                    break;
                case "Yellow":
                    lblLetgo.Text = "Let go on # 5";
                    break;
                default: 
                    lblLetgo.Text = "Let go on # 1";
                    break;
            }
        }

        private void executeHold()
        {
            grbHold.Visible = true;
            lblAction.Text = "Hold Button";
        }

        private void executeShort()
        {
            grbHold.Visible = false;
            lblAction.Text = "Press Shortly";
        }

        private bool checkColor(String color)
        {
            return comboColor.Text.Equals(color);
        }

        private bool checkText(String txt)
        {
            return comboText.Text.Equals(txt);
        }

        private bool checkCombination(String color, String txt)
        {
            return checkColor(color) && checkText(txt);
        }

    }
}
