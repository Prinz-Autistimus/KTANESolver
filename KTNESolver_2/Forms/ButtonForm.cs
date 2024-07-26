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
        }

    }
}
