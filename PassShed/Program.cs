using System;
using System.Windows.Forms;
using PassShed.GUI;
using System.IO;

namespace PassShed
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (AppDataIsAccessible())
            {
                UpdateSettings();

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                var frmLogin = new frmMasterPassword();
                if (frmLogin.ShowDialog() == DialogResult.OK)
                {
                    Application.Run(new frmMain());
                }
            }
            else
            {
                MessageBox.Show("PassShed and/or the current user lack sufficient privileges to access the local %AppData% directory."
                    + Environment.NewLine + Environment.NewLine + "PassShed cannot start without access to this directory."
                    , "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                Application.Exit();
            }
        }

        private static void UpdateSettings()
        {
            if (Properties.Settings.Default.UpdateSettings)
            {
                Properties.Settings.Default.Upgrade();
                Properties.Settings.Default.UpdateSettings = false;
                Properties.Settings.Default.Save();
            }
        }

        private static bool AppDataIsAccessible()
        {
            try
            {
                Directory.GetDirectories(Constants.PassShedAppDataPath);
                return true;
            }
            catch (UnauthorizedAccessException)
            {
                return false;
            }
        }
    }
}
