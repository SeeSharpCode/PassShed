using System;
using System.Windows.Forms;

namespace PassShed.GUI
{
    public partial class frmDeleteWarning : Form
    {
        public string WarningText { get; set; }

        public string TriggerButtonName { get; set; }

        public frmDeleteWarning(ToolStripButton triggerButton, string warningText)
        {
            this.WarningText = warningText;
            this.TriggerButtonName = triggerButton.Name;

            InitializeComponent();
        }

        private void frmDeleteWarning_Load(object sender, EventArgs e)
        {
            lblWarningText.Text = this.WarningText;
        }

        private void frmDeleteWarning_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.TriggerButtonName == "btnDeleteCategory")
            {
                Properties.Settings.Default.ShowCategoryWarning = !chkStopShowing.Checked;
            }
            else
            {
                Properties.Settings.Default.ShowFieldWarning = !chkStopShowing.Checked;
            }

            Properties.Settings.Default.Save();
        }
    }
}
