using System;
using System.Drawing;
using System.Windows.Forms;

namespace PassShed.GUI
{
    public partial class frmOptions : Form
    {
        // Variables to get and set user settings.
        Color menuBackColor, menuForeColor, rowColor, alternatingRowColor;
        DataGridViewCellBorderStyle gridlines;
        DataGridViewAutoSizeColumnsMode autoSizeColumnMode;

        // Color dialog used for various color settings.
        ColorDialog dlgColor = new ColorDialog();

        public frmOptions()
        {
            InitializeComponent();
        }

        private void frmCustomize_Load(object sender, EventArgs e)
        {
            LoadSettings();
            RefreshUI();
        }

        // Loads the user's UI settings.
        private void LoadSettings()
        {
            // Menu colors.
            menuBackColor = Properties.Settings.Default.MenuBackColor;
            menuForeColor = Properties.Settings.Default.MenuForeColor;

            // DataGridView settings.
            rowColor = Properties.Settings.Default.RowColor;
            alternatingRowColor = Properties.Settings.Default.AlternatingRowColor;
            gridlines = Properties.Settings.Default.GridlinesStyle;
            autoSizeColumnMode = Properties.Settings.Default.AutosizeColumnsMode;
        }

        private void RefreshUI()
        {
            // Menu preview color.
            menuPreview.BackColor = menuBackColor;
            menuItemPreview.ForeColor = menuForeColor;

            // Gridlines ComboBox.
            switch (gridlines)
            {
                case DataGridViewCellBorderStyle.Single:
                    cboGridlines.Text = "Vertical & Horizontal";
                    break;
                case DataGridViewCellBorderStyle.SingleHorizontal:
                    cboGridlines.Text = "Horizontal";
                    break;
                case DataGridViewCellBorderStyle.None:
                    cboGridlines.Text = "None";
                    break;
            }

            // ColumnSizeMode ComboBox.
            switch (autoSizeColumnMode)
            {
                case DataGridViewAutoSizeColumnsMode.AllCells:
                    cboAutosizeColumnsMode.Text = "Fit To Cells";
                    break;
                case DataGridViewAutoSizeColumnsMode.Fill:
                    cboAutosizeColumnsMode.Text = "Fill";
                    break;
            }
        }

        // Save the user's UI settings.
        private void SaveSettings()
        {
            // Set user settings using class variables.
            Properties.Settings.Default.MenuBackColor = menuBackColor;
            Properties.Settings.Default.MenuForeColor = menuForeColor;
            Properties.Settings.Default.RowColor = rowColor;
            Properties.Settings.Default.AlternatingRowColor = alternatingRowColor;
            Properties.Settings.Default.GridlinesStyle = gridlines;
            Properties.Settings.Default.AutosizeColumnsMode = autoSizeColumnMode;

            // Save changes.
            Properties.Settings.Default.Save();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            SaveSettings();
        }

        private void cboGridlines_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Set the gridlines property.
            switch (cboGridlines.Text)
            {
                case "Vertical & Horizontal":
                    gridlines = DataGridViewCellBorderStyle.Single;
                    break;
                case "Horizontal":
                    gridlines = DataGridViewCellBorderStyle.SingleHorizontal;
                    break;
                case "None":
                    gridlines = DataGridViewCellBorderStyle.None;
                    break;
            }

            RefreshUI();
        }

        private void btnMenuColor_Click(object sender, EventArgs e)
        {
            // Confirm that the user pressed OK.
            if (dlgColor.ShowDialog() == DialogResult.OK)
            {
                // Set the menu BackColor.
                menuBackColor = dlgColor.Color;

                RefreshUI();
            }
        }

        private void btnFontColor_Click(object sender, EventArgs e)
        {
            // Confirm that the user pressed OK.
            if (dlgColor.ShowDialog() == DialogResult.OK)
            {
                // Set the menu ForeColor.
                menuForeColor = dlgColor.Color;

                RefreshUI();
            }
        }

        private void btnRowColor_Click(object sender, EventArgs e)
        {
            // Confirm that the user pressed OK.
            if (dlgColor.ShowDialog() == DialogResult.OK)
            {
                // Set the row color.
                rowColor = dlgColor.Color;

                RefreshUI();
            }
        }

        private void btnAlternatingRowColor_Click(object sender, EventArgs e)
        {
            // Confirm that the user pressed OK.
            if (dlgColor.ShowDialog() == DialogResult.OK)
            {
                // Set the alternating row color.
                alternatingRowColor = dlgColor.Color;

                RefreshUI();
            }
        }

        private void btnDefault_Click(object sender, EventArgs e)
        {
            // Set default settings.
            menuBackColor = Color.SteelBlue;
            menuForeColor = Color.White;
            rowColor = Color.White;
            alternatingRowColor = Color.AliceBlue;
            gridlines = DataGridViewCellBorderStyle.None;
            autoSizeColumnMode = DataGridViewAutoSizeColumnsMode.Fill;

            RefreshUI();
        }

        private void cboColumnSizeMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Set the ColumnSizeMode property.
            switch (cboAutosizeColumnsMode.Text)
            {
                case "Fit To Cells":
                    autoSizeColumnMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    break;
                case "Fill":
                    autoSizeColumnMode = DataGridViewAutoSizeColumnsMode.Fill;
                    break;
            }

            RefreshUI();
        }
    }
}
