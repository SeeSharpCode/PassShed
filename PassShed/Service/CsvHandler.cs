using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using PassShed.DataAccess;
using PassShed.GUI;

namespace PassShed.Service
{
    class CsvHandler
    {
        public string[] FileLines { get; set; }
        public int DestinationCategoryId { get; set; }
        public string LogFilePath { get; set; }

        private frmCsvImport frmImport;

        public CsvHandler(int categoryId, string[] fileLines, frmCsvImport frmCurrent)
        {
            this.DestinationCategoryId = categoryId;
            this.FileLines = fileLines;

            string fileName = String.Format("{0:yyyy-MM-dd hh-mm-ss}", DateTime.Now) + " Import.log";
            this.LogFilePath = Path.Combine(Application.LocalUserAppDataPath, fileName);

            frmImport = frmCurrent;
        }

        private string[] ExtractFieldNames()
        {
            return this.FileLines[0].Split(',');
        }

        private string[] ExtractCredentials(int rowId)
        {
            return this.FileLines[rowId].Split(',');
        }

        public void Import()
        {
            Log("Beginning new .CSV import - " + DateTime.Now + Environment.NewLine);

            ImportFields();
            ImportAccounts();

            Log(Environment.NewLine + "Import completed.");
        }

        private void ImportFields()
        {
            Log("Processing fields...");

            foreach (string s in this.FileLines[0].Split(','))
            {
                try
                {
                    FieldService.AddNew(new Field { CategoryId = DestinationCategoryId, Label = s.Trim() });

                    Log("Added field: '" + s + "'");

                }
                catch (ArgumentException)
                {
                    Log("'" + s + "' field already exists.");
                }
            }
        }

        private void ImportAccounts()
        {
            Log(Environment.NewLine + "Processing accounts...");

            for (int rowIndex = 1; rowIndex < this.FileLines.Count(); rowIndex++)
            {
                int accountId = AccountService.AddNewWithBlankCredentials
                    (new Account { CategoryId = this.DestinationCategoryId });

                Log("Added account with the following credentials:");

                ImportCredentials(rowIndex, accountId);
            }
        }

        private void ImportCredentials(int rowIndex, int accountId)
        {
            for (int credentialIndex = 0; credentialIndex < ExtractCredentials(rowIndex).Length; credentialIndex++)
            {
                string credentialValue = ExtractCredentials(rowIndex)[credentialIndex].Trim();

                try
                {
                    string fieldName = ExtractFieldNames()[credentialIndex].Trim();

                    CredentialService.Update(accountId, FieldService.GetFieldByName(this.DestinationCategoryId, fieldName).Id,
                        credentialValue);

                    Log("   " + fieldName + ": '" + credentialValue + "'");
                }
                catch (IndexOutOfRangeException)
                {
                    Log("   '" + credentialValue + "' does not belong to a field and was not added.");
                }
            }
        }

        private void Log(string text)
        {
            try
            {
                using (StreamWriter writer = File.AppendText(this.LogFilePath))
                {
                    writer.WriteLine(text);
                }
            }
            catch (UnauthorizedAccessException) { }

            frmImport.Log(text);
        }
    }
}