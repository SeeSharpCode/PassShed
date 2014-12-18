using System;
using System.Drawing;
using System.Windows.Forms;
using PassShed.DataAccess;
using PassShed.Service;

namespace PassShed.GUI
{
    public partial class frmMasterPassword : Form
    {
        string passwordHash;

        public frmMasterPassword()
        {
            passwordHash = PasswordService.GetPasswordHash();

            InitializeComponent();
        }

        private void frmMasterPassword_Load(object sender, EventArgs e)
        {
            if (passwordHash != "")
            {
                lblPrompt.Text = "Please enter your master password:";
                lblConfirm.Visible = false;
                txtConfirm.Visible = false;
            }

            txtPassword.Select();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string enteredPasswordHash = Security.HashString(txtPassword.Text);

            if (passwordHash == "")
            {
                if (txtPassword.Text != "" && txtPassword.Text == txtConfirm.Text)
                {
                    PasswordService.AddNew(new MasterPassword {PasswordHash = enteredPasswordHash});

                    this.DialogResult = DialogResult.OK;
                }
                else if (txtPassword.Text == "")
                {
                    SendMessage("I can't approve of this.", Color.Red);
                }
                else if (txtPassword.Text != txtConfirm.Text)
                {
                    SendMessage("Passwords do not match.", Color.Red);
                }
            }
            else
            {
                if (enteredPasswordHash == passwordHash)
                {
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    SendMessage("Incorrect.", Color.Red);
                }
            }
        }

        private void SendMessage(string text, Color foreColor)
        {
            toolStripStatusLabel1.Text = text;
            toolStripStatusLabel1.ForeColor = foreColor;
        }
    }
}
