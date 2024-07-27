using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace KTNESolver_2.Forms
{

    public partial class CWireForm : Form
    {

        Func<bombInfo> getBombInfo;
        bombInfo currentInfo;

        string[,,,] solution = new string[2, 2, 2, 2];

        public CWireForm(Func<bombInfo> getterFunction)
        {
            getBombInfo = getterFunction;

            InitializeComponent();

            // C => Cut,
            // D => Dont,
            // B => Battery at least two,
            // E => Even Serial,
            // P => Parallel

            //      RED | BLUE | STAR | LED 
            solution[0, 0, 0, 0] = "C";
            solution[0, 0, 0, 1] = "D";
            solution[0, 0, 1, 0] = "C";
            solution[0, 0, 1, 1] = "B";
            solution[0, 1, 0, 0] = "E";
            solution[0, 1, 0, 1] = "P";
            solution[0, 1, 1, 0] = "D";
            solution[0, 1, 1, 1] = "P";
            solution[1, 0, 0, 0] = "E";
            solution[1, 0, 0, 1] = "B";
            solution[1, 0, 1, 0] = "C";
            solution[1, 0, 1, 1] = "B";
            solution[1, 1, 0, 0] = "E";
            solution[1, 1, 0, 1] = "E";
            solution[1, 1, 1, 0] = "P";
            solution[1, 1, 1, 1] = "D";
        }

        private void solve(object sender, EventArgs e)
        {

            currentInfo = getBombInfo();

            int red = Convert.ToInt32(cbRed.Checked);
            int blue = Convert.ToInt32(cbBlue.Checked);
            int star = Convert.ToInt32(cbStar.Checked);
            int led = Convert.ToInt32(cbLED.Checked);

            bool cut = checkCut(solution[red, blue, star, led]);
            pbCut.Visible = cut;
            pbDont.Visible = !cut;
        }

        private bool checkCut(string s)
        {
            switch (s)
            {
                case "C":
                    return true;
                case "B":
                    return currentInfo.batteryCount >= 2;
                case "E":
                    return currentInfo.serialEven;
                case "P":
                    return currentInfo.hasParallel;
                default:
                    return false;
            }
        }
    }
}
