using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTO218.BrainWorkshop.Objects
{
    public static class AppConfig
    {
        private static string AppDataPath = "\\App_Data";
        private static string SettingsName = "user_settings.json";
        private static string DataFileName = "BTO218Veri.dat";

        public static string UserSettingsPath
        {
            get
            {
                return Application.StartupPath + string.Format("{0}\\{1}", AppDataPath, SettingsName);
            }
        }
        public static string DataPath
        {
            get
            {
                return Application.StartupPath + string.Format("{0}\\{1}", AppDataPath, DataFileName);
            }
        }
    }
}
