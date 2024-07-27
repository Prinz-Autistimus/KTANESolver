using KTNESolver_2.Forms;

namespace KTNESolver_2
{
    public partial class KTNESolver : Form
    {
        public KTNESolver()
        {
            InitializeComponent();
        }

        private void btnWire_Click(object sender, EventArgs e)
        {
            WireForm wireForm = new WireForm(getBombInfo);
            wireForm.Show();
        }
        private void btnButton_Click(object sender, EventArgs e)
        {
            ButtonForm buttonForm = new ButtonForm(getBombInfo);
            buttonForm.Show();
        }
        private void btnKeypad_Click(object sender, EventArgs e)
        {
            KeypadForm keypadForm = new KeypadForm(getBombInfo);
            keypadForm.Show();
        }
        private void btnSimonSays_Click(object sender, EventArgs e)
        {
            SimonSaysForm simonSaysForm = new SimonSaysForm(getBombInfo);
            simonSaysForm.Show();
        }

        private void btnWhosOnFirst_Click(object sender, EventArgs e)
        {
            WhosOnFirstForm whosOnFirstForm = new WhosOnFirstForm(getBombInfo);
            whosOnFirstForm.Show();
        }

        private void btnMemory_Click(object sender, EventArgs e)
        {
            MemoryForm memoryForm = new MemoryForm();
            memoryForm.Show();
        }
        private void btnMorse_Click(object sender, EventArgs e)
        {
            MorseForm morseForm = new MorseForm();
            morseForm.Show();
        }
        private void btnCWire_Click(object sender, EventArgs e)
        {
            CWireForm cwireForm = new CWireForm(getBombInfo);
            cwireForm.Show();
        }

        private int getStrikes()
        {
            if (rbStrike0.Checked) return 0;
            if (rbStrike1.Checked) return 1;
            return 2;
        }

        public bombInfo getBombInfo()
        {
            return new bombInfo(Convert.ToInt32(nudBatteries.Value), rbSerialEven.Checked, cbSerialVowel.Checked, cbParallel.Checked, cbFRK.Checked, cbCAR.Checked, getStrikes());
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            nudBatteries.Value = 0;
            cbParallel.Checked = false;
            cbSerialVowel.Checked = false;
            rbSerialEven.Checked = true;
            rbSerialOdd.Checked = false;
            cbFRK.Checked = false;
            cbCAR.Checked = false;
            rbStrike0.Checked = true;
            rbStrike1.Checked = false;
            rbStrike2.Checked = false;
        }

    }
}
