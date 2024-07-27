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
    public partial class SimonSaysForm : Form
    {
        Func<bombInfo> getBombInfo;
        bombInfo currentInfo;

        List<String> inputColors = new List<String>();
        List<String> outputColors = new List<String>();

        String[][] withVowelTable = new String[3][];
        String[][] noVowelTable = new String[3][];

        String[] columnNames = new string[4] { "Rot", "Blau", "Grün", "Gelb" };

        public SimonSaysForm(Func<bombInfo> getterFunction)
        {
            InitializeComponent();
            this.getBombInfo = getterFunction;

            withVowelTable[0] = new string[4] { "Blau", "Rot", "Gelb", "Grün" };
            withVowelTable[1] = new string[4] { "Gelb", "Grün", "Blau", "Rot" };
            withVowelTable[2] = new string[4] { "Grün", "Rot", "Gelb", "Blau" };

            noVowelTable[0] = new string[4] { "Blau", "Gelb", "Grün", "Rot" };
            noVowelTable[1] = new string[4] { "Rot", "Blau", "Gelb", "Grün" };
            noVowelTable[2] = new string[4] { "Gelb", "Grün", "Blau", "Rot" };
        }

        private void update(String color)
        {
            currentInfo = getBombInfo();

            if (inputColors.Count >= 4) { return; }

            inputColors.Add(color);

            convertInToOut();

            updateOutput();
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            update("Rot");
        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            update("Blau");
        }

        private void btnGreen_Click(object sender, EventArgs e)
        {
            update("Grün");
        }

        private void btnYellow_Click(object sender, EventArgs e)
        {
            update("Gelb");
        }

        private void convertInToOut()
        {
            outputColors.Clear();
            foreach (String color in inputColors)
            {
                outputColors.Add(lookupColor(color));
            }
        }


        private String lookupColor(String color)
        {
            String[][] currTable = currentInfo.serialVowel ? withVowelTable : noVowelTable;
            int column = Array.IndexOf(columnNames, color);

            return currTable[currentInfo.strikes][column];
        }

        private void updateOutput()
        {
            lbOut.Items.Clear();
            foreach (string s in outputColors)
            {
                lbOut.Items.Add(s);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            inputColors.Clear();
            outputColors.Clear();
            updateOutput();
        }
    }
}
