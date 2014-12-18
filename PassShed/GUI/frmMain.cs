using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using PassShed.DataAccess;
using PassShed.Service;

namespace PassShed.GUI
{
    public partial class frmMain : Form
    {
        #region Class Variables
        const string CategoryInputPrompt = "Please enter a category name.";
        const string FieldInputPrompt = "Please enter a field name.";

        frmInput frmGetInput;
        #endregion

        #region Form Load
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            var frmUpdateCheck = new frmUpdatePrompt();
            if (frmUpdateCheck.UpdateAvailable())
            {
                if (frmUpdateCheck.ShowDialog() == DialogResult.Cancel)
                {
                    this.WindowState = FormWindowState.Minimized;
                }
            }

            PopulateCategoriesListBox();

            AdjustGUI();

            LoadUserSettings();
        }
        #endregion

        #region Field Management
        private void SaveColumnOrder()
        {
            foreach (DataGridViewColumn column in dgvShed.Columns)
            {
                FieldService.Update((int)column.Tag, column.DisplayIndex);
            }
        }

        private void dgvShed_ColumnDisplayIndexChanged(object sender, DataGridViewColumnEventArgs e)
        {
            SaveColumnOrder();
            PopulateFieldsListBox((int)lstCategories.SelectedValue);
        }

        private void PopulateFieldsColumns(int categoryId)
        {
            dgvShed.Columns.Clear();

            foreach (var field in FieldService.GetFieldsByCategoryId(categoryId))
            {
                var fieldColumn = new DataGridViewTextBoxColumn { Name = field.Label, Tag = field.Id };

                if (field.DisplayIndex != null)
                {
                    fieldColumn.DisplayIndex = (int)field.DisplayIndex;
                }

                dgvShed.Columns.Add(fieldColumn);
            }
        }

        private void PopulateFieldsListBox(int categoryId)
        {
            lstFields.ValueMember = "Id";
            lstFields.DisplayMember = "Label";
            lstFields.DataSource = FieldService.GetFieldsByCategoryId(categoryId)
                .OrderBy(f => f.DisplayIndex).ToList();
        }

        private void DeleteFieldAndRefreshUI()
        {
            FieldService.Delete((int)lstFields.SelectedValue);

            SendMessage("'" + lstFields.Text + "' field deleted successfully.", Color.Green);

            PopulateFieldsListBox((int)lstCategories.SelectedValue);
            PopulateFieldsColumns((int)lstCategories.SelectedValue);
            PopulateAccountRows((int)lstCategories.SelectedValue);

            AdjustGUI();
        }

        private void btnDeleteField_Click(object sender, EventArgs e)
        {
            const string DeleteFieldWarning = "Deleting a field will also delete all credentials associated with it.";

            if (Properties.Settings.Default.ShowFieldWarning)
            {
                if (new frmDeleteWarning((ToolStripButton)sender, DeleteFieldWarning).ShowDialog() == DialogResult.OK)
                {
                    DeleteFieldAndRefreshUI();
                }
            }
            else
            {
                DeleteFieldAndRefreshUI();
            }
        }

        private void btnRenameField_Click(object sender, EventArgs e)
        {
            frmGetInput = new frmInput(FieldInputPrompt, 60);

            if (frmGetInput.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    int selectedFieldId = (int)lstFields.SelectedValue;
                    string selectedFieldName = lstFields.Text;

                    FieldService.Update((int)lstFields.SelectedValue, frmGetInput.Input);

                    PopulateFieldsListBox((int)lstCategories.SelectedValue);
                    PopulateFieldsColumns((int)lstCategories.SelectedValue);
                    PopulateAccountRows((int)lstCategories.SelectedValue);

                    lstFields.SelectedValue = selectedFieldId;

                    SendMessage("'" + selectedFieldName + "' renamed to '" + frmGetInput.Input + ".'", Color.Green);
                }
                catch (ArgumentException ex)
                {
                    SendMessage(ex.Message, Color.Red);
                }
            }
        }

        private void btnAddField_Click(object sender, EventArgs e)
        {
            frmGetInput = new frmInput(FieldInputPrompt, 60);

            if (frmGetInput.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    FieldService.AddNew(new Field { CategoryId = (int)lstCategories.SelectedValue, Label = frmGetInput.Input });

                    PopulateFieldsListBox((int)lstCategories.SelectedValue);
                    lstFields.SelectedIndex = (lstFields.Items.Count - 1);
                    PopulateFieldsColumns((int)lstCategories.SelectedValue);
                    PopulateAccountRows((int)lstCategories.SelectedValue);

                    AdjustGUI();

                    SendMessage("'" + frmGetInput.Input + "' added.", Color.Green);
                }
                catch (ArgumentException ex)
                {
                    SendMessage(ex.Message, Color.Red);
                }
            }
        }
        #endregion

        #region Account Management
        private void PopulateAccountRows(int categoryId)
        {
            dgvShed.Rows.Clear();

            foreach (var account in AccountService.GetAccountsByCategoryId(categoryId))
            {
                var accountRow = new DataGridViewRow { Tag = account.Id };

                var credentialsInAccount = CredentialService.GetCredentialsByAccountId(account.Id);

                foreach (DataGridViewColumn column in dgvShed.Columns)
                {
                    Credential credential = credentialsInAccount.SingleOrDefault(c => c.FieldId == (int)column.Tag);

                    accountRow.Cells.Add(
                        new DataGridViewTextBoxCell { Value = credential.Value, Tag = credential.Id, MaxInputLength = 99 });
                }

                dgvShed.Rows.Add(accountRow);
            }
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            AccountService.AddNewWithBlankCredentials(new Account { CategoryId = (int)lstCategories.SelectedValue });

            PopulateAccountRows((int)lstCategories.SelectedValue);

            AdjustGUI();

            SendMessage("Account added successfully.", Color.Green);
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            AccountService.Delete((int)dgvShed.CurrentRow.Tag);

            PopulateAccountRows((int)lstCategories.SelectedValue);

            AdjustGUI();

            SendMessage("Account deleted.", Color.Green);
        }
        #endregion

        #region Category Management
        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            frmGetInput = new frmInput(CategoryInputPrompt, 60);

            if (frmGetInput.ShowDialog() == DialogResult.OK)
            {
                string input = frmGetInput.Input;
                try
                {
                    var category = new Category { Label = input };
                    CategoryService.AddNew(category);

                    PopulateCategoriesListBox(category.Id);

                    AdjustGUI();

                    SendMessage("'" + input + "' added.", Color.Green);
                }
                catch (ArgumentException ex)
                {
                    SendMessage(ex.Message, Color.Red);
                }
            }
        }

        private void btnRenameCategory_Click(object sender, EventArgs e)
        {
            frmGetInput = new frmInput(CategoryInputPrompt, 60);

            if (frmGetInput.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    int selectedCategoryId = (int)lstCategories.SelectedValue;
                    string categoryName = lstCategories.Text;

                    CategoryService.Update((int)lstCategories.SelectedValue, frmGetInput.Input.Trim());

                    PopulateCategoriesListBox(selectedCategoryId);

                    SendMessage("'" + categoryName + "' renamed to '" + frmGetInput.Input + ".'", Color.Green);
                }
                catch (ArgumentException ex)
                {
                    SendMessage(ex.Message, Color.Red);
                }
            }
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            const string DeleteCategoryWarning = "Deleting a category will also delete all fields and accounts" +
            " associated with it.";

            string currentCategory = lstCategories.Text;

            if (Properties.Settings.Default.ShowCategoryWarning)
            {
                if (new frmDeleteWarning((ToolStripButton)sender, DeleteCategoryWarning).ShowDialog() == DialogResult.OK)
                {
                    DeleteCategory();
                    SendMessage("'" + currentCategory + "' deleted.", Color.Green);
                }
            }
            else
            {
                DeleteCategory();
            }
        }

        private void DeleteCategory()
        {
            CategoryService.Delete((int)lstCategories.SelectedValue);

            PopulateCategoriesListBox();

            AdjustGUI();
        }

        private void lstCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateFieldsListBox((int)lstCategories.SelectedValue);
            PopulateFieldsColumns((int)lstCategories.SelectedValue);
            PopulateAccountRows((int)lstCategories.SelectedValue);

            AdjustGUI();
        }

        private void PopulateCategoriesListBox()
        {
            lstCategories.DisplayMember = "Label";
            lstCategories.ValueMember = "Id";
            lstCategories.DataSource = CategoryService.GetAllCategories();
        }

        private void PopulateCategoriesListBox(int categoryToSelectId)
        {
            lstCategories.SelectedIndexChanged -= lstCategories_SelectedIndexChanged;

            lstCategories.DisplayMember = "Label";
            lstCategories.ValueMember = "Id";
            lstCategories.DataSource = CategoryService.GetAllCategories();

            lstCategories.SelectedIndexChanged += lstCategories_SelectedIndexChanged;
            lstCategories.SelectedValue = categoryToSelectId;
        }
        #endregion

        #region Credential Management
        private void dgvShed_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvShed.CurrentCell.Value != null)
                CredentialService.Update((int)dgvShed.CurrentCell.Tag, dgvShed.CurrentCell.Value.ToString());
            else
                CredentialService.Update((int)dgvShed.CurrentCell.Tag, "");
        }

        private void dgvShed_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            Credential selectedCredential = CredentialService.GetCredential((int)dgvShed.CurrentCell.Tag);
            lblCreated.Text = "Created: " + selectedCredential.Created;
            lblModified.Text = "Modified: " + selectedCredential.Modified;
        }
        #endregion

        #region User Settings
        private void btnOptions_Click(object sender, EventArgs e)
        {
            var frmOptionsDialog = new frmOptions();

            if (frmOptionsDialog.ShowDialog() == DialogResult.OK)
            {
                LoadUserSettings();
            }
            else
            {
                SendMessage("No settings changed.", Color.Red);
            }
        }

        private void LoadUserSettings()
        {
            menuStrip.BackColor = Properties.Settings.Default.MenuBackColor;

            foreach (ToolStripMenuItem menuItem in menuStrip.Items)
            {
                menuItem.ForeColor = Properties.Settings.Default.MenuForeColor;
            }

            dgvShed.RowsDefaultCellStyle.BackColor = Properties.Settings.Default.RowColor;
            dgvShed.AlternatingRowsDefaultCellStyle.BackColor = Properties.Settings.Default.AlternatingRowColor;
            dgvShed.CellBorderStyle = Properties.Settings.Default.GridlinesStyle;
            dgvShed.AutoSizeColumnsMode = Properties.Settings.Default.AutosizeColumnsMode;
        }
        #endregion

        #region Application Information
        private void btnAbout_Click(object sender, EventArgs e)
        {
            new frmAbout().Show();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("PassShed Help.htm");
            }
            catch
            {
                MessageBox.Show("I can't seem to find the help file. What have you done?",
                    "Help File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region CSV Import
        private void btnCsvImport_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.ShowCsvGuide)
            {
                if (new frmCsvGuide().ShowDialog() == DialogResult.OK)
                {
                    PrepareCsvImport();
                }
            }
            else
            {
                PrepareCsvImport();
            }

            PopulateAccountRows((int)lstCategories.SelectedValue);
        }

        private void PrepareCsvImport()
        {
            var ofdCsvFile = new OpenFileDialog
            {
                Title = "Select .CSV File",
                Filter = "CSV Files (*.csv)|*.csv|All Files (*.*)|*.*"
            };

            if (ofdCsvFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (new frmCsvImport((int)lstCategories.SelectedValue, ofdCsvFile.FileName).ShowDialog() == DialogResult.OK)
                    {
                        PopulateCategoriesListBox((int)lstCategories.SelectedValue);
                    }
                }
                catch (IOException)
                {
                    MessageBox.Show("There was an error opening the file. The file may be in use by another program.",
                        "File Access Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #endregion

        #region Utility Methods
        private void AdjustGUI()
        {
            if (lstCategories.Items.Count > 0)
            {
                btnRenameCategory.Enabled = true;
                btnDeleteCategory.Enabled = true;
                btnAddField.Enabled = true;
                btnCsvImporter.Enabled = true;

                if (lstFields.Items.Count > 0)
                {
                    btnRenameField.Enabled = true;
                    btnDeleteField.Enabled = true;
                    btnNewAccount.Enabled = true;

                    if (dgvShed.Rows.Count > 0)
                    {
                        btnDeleteAccount.Enabled = true;
                    }
                    else
                    {
                        btnDeleteAccount.Enabled = false;
                    }
                }
                else
                {
                    btnRenameField.Enabled = false;
                    btnDeleteField.Enabled = false;
                    btnNewAccount.Enabled = false;
                    btnDeleteAccount.Enabled = false;
                }
            }
            else
            {
                dgvShed.Columns.Clear();
                dgvShed.Rows.Clear();
                lstFields.DataSource = null;
                btnRenameCategory.Enabled = false;
                btnDeleteCategory.Enabled = false;
                btnAddField.Enabled = false;
                btnRenameField.Enabled = false;
                btnDeleteField.Enabled = false;
                btnNewAccount.Enabled = false;
                btnDeleteAccount.Enabled = false;
                btnCsvImporter.Enabled = false;
            }
        }

        private void SendMessage(string text, Color foreColor)
        {
            lblStatus.Text = text;
            lblStatus.ForeColor = foreColor;
        }

        public static void ShowBalloonTip(string title, string message, Icon icon, ToolTipIcon balloonIcon)
        {
            var notification = new NotifyIcon()
            {
                Icon = icon,
                BalloonTipIcon = balloonIcon,
                BalloonTipTitle = title,
                BalloonTipText = message,
                Visible = true
            };

            notification.ShowBalloonTip(1);
        }
        #endregion

        private void tempToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdatePrompt frmUpdate = new frmUpdatePrompt();
            frmUpdate.UpdateAvailable();
            frmUpdate.Show();
        }
    }
}