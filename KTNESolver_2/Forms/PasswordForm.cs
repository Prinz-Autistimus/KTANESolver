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
    public partial class PasswordForm : Form
    {

        string[] solutions = { "angst", "atmen", "beten", "bombe", "danke",
                               "draht", "druck", "drück", "farbe", "fehlt",
                               "ferse", "kabel", "knall", "knapp", "knopf",
                               "leere", "legal", "lehre", "mathe", "matte",
                               "panik", "pieps", "rauch", "ruhig", "saite",
                               "sehne", "seite", "sende", "strom", "super",
                               "timer", "übrig", "verse", "warte", "zange" };

        public PasswordForm()
        {
            InitializeComponent();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string[] slots = { tb1.Text, tb2.Text, tb3.Text, tb4.Text, tb5.Text };

            foreach(string word in solutions)
            {
                for(int i = 0; i < word.Length; ++i)
                {
                    if (!slots[i].Contains(word[i]))
                    {
                        continue;
                    }
                }
                lblSolution.Text = word;
                return;
            }
        }
    }
}
