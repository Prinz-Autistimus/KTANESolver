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
    public partial class WhosOnFirstForm : Form
    {
        Func<bombInfo> getBombInfo;
        bombInfo currentInfo;

        HashSet<string> topLeft = new HashSet<string>() { "CN" };
        HashSet<string> topRight = new HashSet<string>() { "MOMENT", "OKAY", "C" };
        HashSet<string> midLeft = new HashSet<string>() { "JA", "NICHTS", "KUH", "ZEH" };
        HashSet<string> midRight = new HashSet<string>() { "LEER", "COUP", "WARTE", "SO EIN", "SOHN", "ZEHN", "ZÄH" };
        HashSet<string> bottomLeft = new HashSet<string>() { "*", "OH GOTT", "FERTIG", "10" };
        HashSet<string> bottomRight = new HashSet<string>() { "OBEN", "DA STEHT", "NEIN", "Q", "BUMM", "SO\'N", "ZEHEN", "CE", "ZU SPÄT" };

        Dictionary<string, List<string>> solutions = new Dictionary<string, List<string>>();

        HashSet<string>[] eyePositions;
        PictureBox[] pBoxes;

        int outputIndex = 0;
        List<string> outlist = new List<string>();

        public WhosOnFirstForm(Func<bombInfo> getterFunction)
        {
            InitializeComponent();
            getBombInfo = getterFunction;

            eyePositions = new HashSet<string>[6] { topLeft, topRight, midLeft, midRight, bottomLeft, bottomRight };
            pBoxes = new PictureBox[6] { pbTL, pbTR, pbML, pbMR, pbBL, pbBR };

            solutions.Add("DRÜCK", new List<string>() { "JA", "Q", "NEIN", "O.K.", "OKAY", "COUP", "OK", "LEER", "DRÜCK", "*", "NOCHMAL", "WAS", "NICHTS", "KUH" });
            solutions.Add("NOCHMAL", new List<string>() { "OKAY", "Q", "JA", "O.K.", "*", "OK", "NICHTS", "WAS", "KUH", "DRÜCK", "LEER", "NEIN", "COUP", "NOCHMAL" });
            solutions.Add("*", new List<string>() { "LEER", "WAS", "KUH", "NOCHMAL", "NEIN", "DRÜCK", "OK", "JA", "NICHTS", "OKAY", "COUP", "Q", "*", "O.K." });
            solutions.Add("LEER", new List<string>() { "KUH", "OK", "Q", "O.K.", "LEER", "COUP", "DRÜCK", "NICHTS", "*", "NEIN", "OKAY", "WAS", "JA", "NOCHMAL" });
            solutions.Add("NICHTS", new List<string>() { "WAS", "OK", "Q", "O.K.", "JA", "LEER", "*", "COUP", "OKAY", "NEIN", "KUH", "NOCHMAL", "NICHTS", "DRÜCK" });
            solutions.Add("JA", new List<string>() { "Q", "OK", "WAS", "O.K.", "NOCHMAL", "NEIN", "COUP", "DRÜCK", "NICHTS", "JA", "OKAY", "LEER", "*", "KUH" });
            solutions.Add("NEIN", new List<string>() { "WAS", "NEIN", "OKAY", "NICHTS", "DRÜCK", "LEER", "O.K.", "*", "Q", "NOCHMAL", "KUH", "JA", "COUP", "OK" });
            solutions.Add("WAS", new List<string>() { "DRÜCK", "NICHTS", "OKAY", "NEIN", "Q", "JA", "OK", "*", "COUP", "LEER", "WAS", "O.K.", "KUH", "NOCHMAL" });
            solutions.Add("OKAY", new List<string>() { "OK", "OKAY", "NOCHMAL", "*", "O.K.", "JA", "LEER", "NEIN", "WAS", "KUH", "COUP", "DRÜCK", "Q", "NICHTS" });
            solutions.Add("OK", new List<string>() { "JA", "NICHTS", "DRÜCK", "COUP", "*", "KUH", "NEIN", "OK", "O.K.", "OKAY", "WAS", "LEER", "Q", "NOCHMAL" });
            solutions.Add("O.K.", new List<string>() { "LEER", "DRÜCK", "Q", "NEIN", "NICHTS", "COUP", "*", "KUH", "OKAY", "O.K.", "OK", "NOCHMAL", "WAS", "JA" });
            solutions.Add("Q", new List<string>() { "O.K.", "*", "NOCHMAL", "JA", "WAS", "NICHTS", "KUH", "Q", "OKAY", "DRÜCK", "LEER", "COUP", "NEIN", "OK" });
            solutions.Add("KUH", new List<string>() { "WAS", "*", "LEER", "Q", "JA", "OKAY", "NOCHMAL", "COUP", "NEIN", "KUH", "NICHTS", "DRÜCK", "OK", "O.K." });
            solutions.Add("COUP", new List<string>() { "OK", "O.K.", "JA", "DRÜCK", "COUP", "Q", "NICHTS", "WAS", "LEER", "OKAY", "NOCHMAL", "NEIN", "*", "KUH" });
            solutions.Add("SOHN", new List<string>() { "MOMENT", "SO EIN", "SO'N", "OHGOTT", "WAS?", "ZEH", "ZEHN", "WARTE", "C", "SOHN", "10", "DA STEHT", "ZEHEN", "CN" });
            solutions.Add("SO EIN", new List<string>() { "SO'N", "WAS?", "DASTEHT", "ZEH", "C", "ZEHEN", "10", "WARTE", "SOHN", "CN", "OHGOTT", "MOMENT", "ZEHN", "SO EIN" });
            solutions.Add("SO'N", new List<string>() { "10", "SO EIN", "ZEH", "SO'N", "WAS?", "ZEHN", "MOMENT", "CN", "OHGOTT", "SOHN", "C", "WARTE", "DA STEHT", "ZEHEN" });
            solutions.Add("OH GOTT", new List<string>() { "SOHN", "OHGOTT", "ZEHN", "WAS?", "10", "SO EIN", "CN", "SO'N", "C", "ZEH", "MOMENT", "ZEHEN", "DA STEHT", "WARTE" });
            solutions.Add("ZEHN", new List<string>() { "ZEHEN", "CN", "ZEHN", "ZEH", "C", "MOMENT", "SO'N", "WARTE", "OHGOTT", "DASTEHT", "WAS?", "10", "SOEIN", "SOHN" });
            solutions.Add("CN", new List<string>() { "ZEH", "MOMENT", "WAS?", "C", "OHGOTT", "ZEHN", "10", "ZEHEN", "CN", "SOHN", "DASTEHT", "WARTE", "SOEIN", "SO'N" });
            solutions.Add("ZEH", new List<string>() { "ZEH", "SO'N", "SOEIN", "SOHN", "ZEHEN", "WARTE", "10", "WAS?", "MOMENT", "DASTEHT", "OHGOTT", "ZEHN", "CN", "C" });
            solutions.Add("10", new List<string>() { "ZEHN", "CN", "SOEIN", "OHGOTT", "WAS?", "10", "ZEHEN", "SOHN", "ZEH", "DASTEHT", "SO'N", "MOMENT", "WARTE", "C" });
            solutions.Add("C", new List<string>() { "SOHN", "WARTE", "OHGOTT", "SO'N", "CN", "ZEHEN", "10", "DASTEHT", "SOEIN", "ZEH", "ZEHN", "WAS?", "C", "MOMENT" });
            solutions.Add("ZEHEN", new List<string>() { "MOMENT", "ZEH", "WAS?", "C", "SO'N", "ZEHN", "OHGOTT", "WARTE", "DASTEHT", "SOHN", "CN", "SOEIN", "10", "ZEHEN" });
            solutions.Add("WAS?", new List<string>() { "C", "ZEH", "10", "SO'N", "WARTE", "MOMENT", "WAS?", "DASTEHT", "ZEHEN", "SOEIN", "ZEHN", "OHGOTT", "CN", "SOHN" });
            solutions.Add("WARTE", new List<string>() { "SOEIN", "CN", "ZEHEN", "10", "SOHN", "ZEHN", "MOMENT", "C", "OHGOTT", "WAS?", "WARTE", "ZEH", "SO'N", "DASTEHT" });
            solutions.Add("MOMENT", new List<string>() { "SOEIN", "ZEHEN", "DASTEHT", "OHGOTT", "SOHN", "WARTE", "ZEH", "ZEHN", "MOMENT", "CN", "C", "WAS?", "SO'N", "10" });
            solutions.Add("DA STEHT", new List<string>() { "OHGOTT", "WAS?", "CN", "ZEHN", "WARTE", "ZEHEN", "10", "C", "ZEH", "SOHN", "DASTEHT", "MOMENT", "SOEIN", "SO'N" });

            foreach (string s in solutions.Keys)
            {
                comboRead.Items.Add(s);
            }
        }

        private void comboTitle_SelectionChangeCommitted(object sender, EventArgs e)
        {
            resetEyes();

            string input = (string)(comboTitle.SelectedItem ?? "Hier ist was schief gelaufen");
            for (int i = 0; i < 6; ++i)
            {
                if (eyePositions[i].Contains(input))
                {
                    pBoxes[i].Visible = true;
                }
            }
        }
        private void comboRead_SelectedIndexChanged(object sender, EventArgs e)
        {
            string input = (string)(comboRead.SelectedItem ?? "cool nh");
            outlist = solutions[input];
            outputIndex = 0;

            updateOutput();
        }

        private void updateOutput()
        {
            lblAnswer.Text = outlist[outputIndex];
        }

        private void resetEyes()
        {
            foreach (PictureBox pb in tableBoxes.Controls)
            {
                pb.Visible = false;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            outputIndex = 0;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (++outputIndex >= outlist.Count)
            {
                outputIndex -= outlist.Count;
            }
            updateOutput();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (--outputIndex < 0)
            {
                outputIndex += outlist.Count;
            }
            updateOutput();
        }
    }
}
