using System;
using System.IO;
using System.Windows.Forms;

namespace PassShed
{
    static class Constants
    {
        private static readonly string localAppDataRootPath =
            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

        private static readonly string appDataSubPath = Path.Combine(Application.CompanyName, Application.ProductName);

        public static readonly string PassShedAppDataPath = Path.Combine(localAppDataRootPath, appDataSubPath);

        public static readonly string IgnoreListFilePath = Path.Combine(PassShedAppDataPath, "IgnoreList.cfg");
    }
}
