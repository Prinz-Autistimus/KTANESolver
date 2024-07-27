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
    public partial class MorseForm : Form
    {

        Dictionary<String, String> morseLookup = new Dictionary<String, String>();

        public MorseForm()
        {
            InitializeComponent();

            morseLookup.Add(".-", "a");
            morseLookup.Add("-...", "b");
            morseLookup.Add("-.-.", "c");
            morseLookup.Add("-..", "d");
            morseLookup.Add(".", "e");
            morseLookup.Add("..-.", "f");
            morseLookup.Add("--.", "g");
            morseLookup.Add("....", "h");
            morseLookup.Add("..", "i");
            morseLookup.Add(".---", "j");
            morseLookup.Add("-.-", "k");
            morseLookup.Add(".-..", "l");
            morseLookup.Add("--", "m");
            morseLookup.Add("-.", "n");
            morseLookup.Add("---", "o");
            morseLookup.Add(".--.", "p");
            morseLookup.Add("--.-", "q");
            morseLookup.Add(".-.", "r");
            morseLookup.Add("...", "s");
            morseLookup.Add("-", "t");
            morseLookup.Add("..-", "u");
            morseLookup.Add("...-", "v");
            morseLookup.Add(".--", "w");
            morseLookup.Add("-..-", "x");
            morseLookup.Add("-.--", "y");
            morseLookup.Add("--..", "z");
            morseLookup.Add(".-.-", "ä");
            morseLookup.Add("---.", "ö");
            morseLookup.Add("..--", "ü");
            morseLookup.Add("", "");

        }

        private void update()
        {
            string input = tbInput.Text;
            string[] splitted = input.Split(" ");

            StringBuilder sb = new StringBuilder();

            foreach (string s in splitted)
            {
                string next = morseLookup.ContainsKey(s) ? morseLookup[s] : "";
                sb.Append(morseLookup[s]);
            }

            string output = sb.ToString();
            lblOut.Text = output;

            foreach (ListViewItem item in lvTable.Items)
            {
                item.Selected = item.Text.StartsWith(output);
            }

        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            tbInput.Text += ".";
            update();
        }

        private void btnDash_Click(object sender, EventArgs e)
        {
            tbInput.Text += "-";
            update();
        }

        private void btnSpace_Click(object sender, EventArgs e)
        {
            tbInput.Text += " ";
            update();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tbInput.Text = string.Empty;
            update();
        }

        private void tbInput_TextChanged(object sender, EventArgs e)
        {
            update();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            tbInput.Text = tbInput.Text.Substring(0, tbInput.TextLength-1);
        }
    }

}
