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
            wireForm.StartPosition = FormStartPosition.Manual;
            wireForm.DesktopLocation = this.DesktopLocation;
            wireForm.Show();
        }
        private void btnButton_Click(object sender, EventArgs e)
        {
            ButtonForm buttonForm = new ButtonForm(getBombInfo);
            buttonForm.StartPosition = FormStartPosition.Manual;
            buttonForm.DesktopLocation = this.DesktopLocation;
            buttonForm.Show();
        }
        private void btnKeypad_Click(object sender, EventArgs e)
        {
            KeypadForm keypadForm = new KeypadForm(getBombInfo);
            keypadForm.StartPosition = FormStartPosition.Manual;
            keypadForm.DesktopLocation = this.DesktopLocation;
            keypadForm.Show();
        }
        private void btnSimonSays_Click(object sender, EventArgs e)
        {
            SimonSaysForm simonSaysForm = new SimonSaysForm(getBombInfo);
            simonSaysForm.StartPosition = FormStartPosition.Manual;
            simonSaysForm.DesktopLocation = this.DesktopLocation;
            simonSaysForm.Show();
        }

        private void btnWhosOnFirst_Click(object sender, EventArgs e)
        {
            WhosOnFirstForm whosOnFirstForm = new WhosOnFirstForm(getBombInfo);
            whosOnFirstForm.StartPosition = FormStartPosition.Manual;
            whosOnFirstForm.DesktopLocation = this.DesktopLocation;
            whosOnFirstForm.Show();
        }

        private void btnMemory_Click(object sender, EventArgs e)
        {
            MemoryForm memoryForm = new MemoryForm();
            memoryForm.StartPosition = FormStartPosition.Manual;
            memoryForm.DesktopLocation = this.DesktopLocation;
            memoryForm.Show();
        }
        private void btnMorse_Click(object sender, EventArgs e)
        {
            MorseForm morseForm = new MorseForm();
            morseForm.StartPosition = FormStartPosition.Manual;
            morseForm.DesktopLocation = this.DesktopLocation;
            morseForm.Show();
        }
        private void btnCWire_Click(object sender, EventArgs e)
        {
            CWireForm cwireForm = new CWireForm(getBombInfo);
            cwireForm.StartPosition = FormStartPosition.Manual;
            cwireForm.DesktopLocation = this.DesktopLocation;
            cwireForm.Show();
        }
        private void btnWireSequence_Click(object sender, EventArgs e)
        {
            WireSequenceForm wireSequenceForm = new WireSequenceForm();
            wireSequenceForm.StartPosition = FormStartPosition.Manual;
            wireSequenceForm.DesktopLocation = this.DesktopLocation;
            wireSequenceForm.Show();
        }
        private void btnPassword_Click(object sender, EventArgs e)
        {
            PasswordForm passwordForm = new PasswordForm();
            passwordForm.StartPosition = FormStartPosition.Manual;
            passwordForm.DesktopLocation = this.DesktopLocation;
            passwordForm.Show();
        }
        private void btnMaze_Click(object sender, EventArgs e)
        {
            MazeForm mazeForm = new MazeForm();
            mazeForm.StartPosition = FormStartPosition.Manual;
            mazeForm.DesktopLocation = this.DesktopLocation;
            mazeForm.Show();
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
