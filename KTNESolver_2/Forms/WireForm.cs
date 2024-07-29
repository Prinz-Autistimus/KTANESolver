using System;
using System.Collections;
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
    public partial class WireForm : Form
    {

        Func<bombInfo> infoGetter;
        bombInfo currentInfo;

        private List<RadioButton> redButtons, blueButtons, whiteButtons, blackButtons, yellowButtons, noneButtons;

        public WireForm(Func<bombInfo> bombInfoGetter)
        {
            InitializeComponent();

            redButtons = new List<RadioButton> { rbRed1, rbRed2, rbRed3, rbRed4, rbRed5, rbRed6 };
            blueButtons = new List<RadioButton> { rbBlue1, rbBlue2, rbBlue3, rbBlue4, rbBlue5, rbBlue6 };
            whiteButtons = new List<RadioButton> { rbWhite1, rbWhite2, rbWhite3, rbWhite4, rbWhite5, rbWhite6 };
            blackButtons = new List<RadioButton> { rbBlack1, rbBlack2, rbBlack3, rbBlack4, rbBlack5, rbBlack6 };
            yellowButtons = new List<RadioButton> { rbYellow1, rbYellow2, rbYellow3, rbYellow4, rbYellow5, rbYellow6 };
            noneButtons = new List<RadioButton> { rbNone1, rbNone2, rbNone3, rbNone4, rbNone5, rbNone6 };

            infoGetter = bombInfoGetter;
        }

        private void solve(object sender, EventArgs e)
        {
            if (!atLeastThreeWires())
            {
                lblOut.Text = "Nicht genug Kabel ausgewählt";
                return;
            }

            currentInfo = infoGetter();

            int wireToCut = totalWireCount() switch
            {
                3 => solveThree(),
                4 => solveFour(),
                5 => solveFive(),
                6 => solveSix(),
                _ => 0
            };

            lblOut.Text = "Schneide Kabel #" + wireToCut;
        }

        private int solveThree()
        {
            if(redCount() == 0)
            {
                return 2;
            }
            else if(rbWhite3.Checked)
            {
                return 3;
            }
            else if(blueCount() > 1)
            {
                return rbBlue3.Checked ? 3 : 2;
            }
            return 3;
        }

        private int solveFour()
        {
            if(redCount() >= 1 && !currentInfo.serialEven)
            {
                return redButtons.FindLastIndex(rb => rb.Checked);
            }
            else if(rbYellow4.Checked && redCount() == 0)
            {
                return 1;
            }
            else if(blueCount() == 1)
            {
                return 1;
            }
            else if(yellowCount() >= 1)
            {
                return 4;
            }
            return 2;
        }
        private int solveFive()
        {
            if(rbBlack5.Checked && !currentInfo.serialEven)
            {
                return 4;
            }
            else if(redCount() == 1 && yellowCount() > 1)
            {
                return 1;
            }
            else if(blackCount() == 0)
            {
                return 2;
            }
            return 1;
        }
        private int solveSix()
        {
            if(yellowCount() == 0 && !currentInfo.serialEven)
            {
                return 3;
            }
            else if(yellowCount() == 1 && whiteCount() >= 1)
            {
                return 4;
            }
            else if(redCount() == 0)
            {
                return 6;
            }
            return 4;
        }

        private bool atLeastThreeWires()
        {
            return totalWireCount() >= 3;
        }

        private int redCount()
        {
            int redCount = 0;
            foreach (RadioButton rb in redButtons)
            {
                if (rb.Checked) ++redCount;
            }
            return redCount;
        }

        private int blueCount()
        {
            int blueCount = 0;
            foreach (RadioButton rb in blueButtons)
            {
                if (rb.Checked) ++blueCount;
            }
            return blueCount;
        }

        private int yellowCount()
        {
            int yellowCount = 0;
            foreach (RadioButton rb in yellowButtons)
            {
                if (rb.Checked) ++yellowCount;
            }
            return yellowCount;
        }

        private int blackCount()
        {
            int blackCount = 0;
            foreach (RadioButton rb in blackButtons)
            {
                if (rb.Checked) ++blackCount;
            }
            return blackCount;
        }

        private int whiteCount()
        {
            int whiteCount = 0;
            foreach (RadioButton rb in whiteButtons)
            {
                if (rb.Checked) ++whiteCount;
            }
            return whiteCount;
        }

        private int noneCount()
        {
            int noneCount = 0;
            foreach (RadioButton rb in noneButtons)
            {
                if (rb.Checked) ++noneCount;
            }
            return noneCount;
        }

        private int totalWireCount()
        {
            return 6 - noneCount();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            foreach (RadioButton rb in noneButtons)
            {
                rb.Select();
            }
        }
    }
}
