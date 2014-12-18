using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;
using System.Xml;
using System.Xml.XPath;

namespace PassShed.GUI
{
    public partial class frmUpdatePrompt : Form
    {
        Version currentVersion;
        Version newestVersion;
        string downloadUrl;
        string changelogUrl;

        public frmUpdatePrompt()
        {
            InitializeComponent();
        }

        private void frmUpdatePrompt_Load(object sender, EventArgs e)
        {
            lblCurrentVersion.Text = "Your Version: " + currentVersion;
            lblNewestVersion.Text = "Newest Version: " + newestVersion;

            txtChangelog.LoadFile(changelogUrl);
        }

        public bool UpdateAvailable()
        {
            var appVersionDoc = new XmlDocument();

            try
            {
                appVersionDoc.Load("http://blusharkmedia.com/PassShed/AppVersion.xml");

                currentVersion = new Version(Application.ProductVersion);
                newestVersion = new Version(appVersionDoc.DocumentElement.SelectSingleNode("/app/newestVersion").InnerText);

                //if (newestVersion > currentVersion && !File.ReadAllText(Constants.IgnoreListFilePath).Contains(newestVersion.ToString()))
                //{
                    downloadUrl = appVersionDoc.DocumentElement.SelectSingleNode("/app/downloadUrl").InnerText;
                    changelogUrl = appVersionDoc.DocumentElement.SelectSingleNode("/app/changelogUrl").InnerText;

                    return true;
                //}
            }
            catch (WebException)
            {
                frmMain.ShowBalloonTip("Update Error", "Unable to retrieve update information." + Environment.NewLine + Environment.NewLine +
                    "Check for updates @ blusharkmedia.com/PassShed", SystemIcons.Error, ToolTipIcon.Error);
            }
            catch (IOException)
            {
                frmMain.ShowBalloonTip("Update Error", "Unable to read update ignore list." + Environment.NewLine + Environment.NewLine +
                    "Check for updates @ blusharkmedia.com/PassShed", SystemIcons.Error, ToolTipIcon.Error);
            }
            catch (XPathException)
            {
                frmMain.ShowBalloonTip("Update Error", "Unable to parse update XML file." + Environment.NewLine + Environment.NewLine +
                    "Check for updates @ blusharkmedia.com/PassShed", SystemIcons.Error, ToolTipIcon.Error);
            }

            return false;
        }

        private void btnIgnore_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamWriter streamWriter = File.AppendText(Constants.IgnoreListFilePath))
                {
                    streamWriter.WriteLine(newestVersion);
                }
            }
            catch (IOException)
            {
                MessageBox.Show("Error writing to the ignore list. The file may not exist or is in use.", "File Access Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDownloadPage_Click(object sender, EventArgs e)
        {
            Process.Start("http://blusharkmedia.com/PassShed");

            frmMain.ShowBalloonTip("PassShed", "PassShed has been minimized.", SystemIcons.Error, ToolTipIcon.Error);
        }

        private void btnDownloadAutomatically_Click(object sender, EventArgs e)
        {
            string filePath = Path.Combine(Constants.PassShedAppDataPath, Path.GetFileName(downloadUrl));

            using (var webClient = new WebClient())
            {
                try
                {
                    webClient.DownloadFile(downloadUrl, filePath);

                    try
                    {
                        Process.Start(filePath);

                        Application.Exit();
                    }
                    catch (IOException)
                    {
                        MessageBox.Show("Error running setup file." + Environment.NewLine + Environment.NewLine
                        + "Please visit http://blusharkmedia.com/passshed.html to download and install the latest version manually.", "File Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (WebException)
                {
                    MessageBox.Show("Error downloading setup file." + Environment.NewLine + Environment.NewLine
                        + "Please visit http://blusharkmedia.com/passshed.html to download and install the latest version manually.", "Web Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
