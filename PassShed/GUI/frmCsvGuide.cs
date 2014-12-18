using System;
using System.Windows.Forms;

namespace PassShed.GUI
{
    public partial class frmCsvGuide : Form
    {
        public frmCsvGuide()
        {
            InitializeComponent();
        }

        private void frmCsvGuide_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.ShowCsvGuide = !chkStopShowing.Checked;
            Properties.Settings.Default.Save();
        }

        private void frmCsvGuide_Load(object sender, EventArgs e)
        {

        }
    }
}
