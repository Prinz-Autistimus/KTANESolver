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

    }
}
