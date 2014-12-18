using System;
using System.Windows.Forms;

namespace PassShed.GUI
{
    public partial class frmInput : Form
    {
        public string Prompt { get; set; }
        public int MaxInputLength { get; set; }
        public string Input { get; set; }

        public frmInput(string prompt, int maxInputLength)
        {
            this.Prompt = prompt;
            this.MaxInputLength = maxInputLength;

            InitializeComponent();
        }

        private void frmInput_Load(object sender, EventArgs e)
        {
            lblPrompt.Text = this.Prompt;
            txtInput.MaxLength = this.MaxInputLength;
            txtInput.Select();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtInput.Text.Length > 0)
            {
                this.Input = txtInput.Text;
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("I don't have time for blank names.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}