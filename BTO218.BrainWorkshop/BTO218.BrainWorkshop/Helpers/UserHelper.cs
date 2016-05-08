using BTO218.BrainWorkshop.Objects;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTO218.BrainWorkshop.Helpers
{
    public static class UserHelper
    {
        public static UserSettings LoadSettings()
        {
            CreateSettingsIfEmpty();
            System.IO.StreamReader sr = new System.IO.StreamReader(AppConfig.UserSettingsPath);
            return Newtonsoft.Json.JsonConvert.DeserializeObject<UserSettings>(sr.ReadToEnd());

        }

        private static void CreateSettingsIfEmpty()
        {
            if (!File.Exists(AppConfig.UserSettingsPath))
            {
                if (!Directory.Exists(Path.GetDirectoryName(AppConfig.UserSettingsPath)))
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(AppConfig.UserSettingsPath));
                }
                File.Create(AppConfig.UserSettingsPath).Close();
                UserSettings defaultSettings = new UserSettings();
                defaultSettings.IsPositionEnabled = true;
                defaultSettings.IsColorEnabled = false;
                defaultSettings.IsAudioEnabled = false;
                SaveSettings(defaultSettings);
            }

        }

        public static bool SaveSettings(UserSettings settings)
        {
            try
            {
                string jsonData = JsonConvert.SerializeObject(settings);
                using (StreamWriter sw = new StreamWriter(AppConfig.UserSettingsPath))
                {
                    sw.Write(jsonData);
                    sw.Close();
                }

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
