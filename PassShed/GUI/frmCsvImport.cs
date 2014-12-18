using System;
using System.IO;
using System.Windows.Forms;
using PassShed.Service;

namespace PassShed.GUI
{
    public partial class frmCsvImport : Form
    {
        public int SelectedCategoryId { get; set; }

        CsvHandler csvHandler;

        public frmCsvImport(int categoryId, string filePath)
        {
            this.SelectedCategoryId = categoryId;

            csvHandler = new CsvHandler(categoryId, File.ReadAllLines(filePath), this);

            InitializeComponent();
        }

        private void frmCsvImport_Load(object sender, EventArgs e)
        {
            PopulateCategoriesComboBox(this.SelectedCategoryId);
        }

        private void PopulateCategoriesComboBox(int categoryToSelectId)
        {
            cboCategories.SelectedIndexChanged -= cboCategories_SelectedIndexChanged;

            cboCategories.DisplayMember = "Label";
            cboCategories.ValueMember = "Id";
            cboCategories.DataSource = CategoryService.GetAllCategories();

            cboCategories.SelectedIndexChanged += cboCategories_SelectedIndexChanged;
            cboCategories.SelectedValue = categoryToSelectId;
        }

        private void cboCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            csvHandler.DestinationCategoryId = (int)cboCategories.SelectedValue;
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            btnImport.Enabled = false;
            btnCancel.Enabled = false;

            csvHandler.Import();

            btnOK.Enabled = true;
        }

        public void Log(string text)
        {
            txtLog.AppendText(text + Environment.NewLine);
        }
    }
}
