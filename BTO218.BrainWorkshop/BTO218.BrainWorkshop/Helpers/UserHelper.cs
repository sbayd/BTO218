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
        public static UserSettings LoadSettings(string UserId)
        {
            CreateSettingsIfEmpty();
            if (string.IsNullOrEmpty(UserId))
                UserId = "default";
            var allSettings = LoadAllSettings();
            if (allSettings.Count > 1 && UserId != "default")
                return allSettings.FirstOrDefault(x => x.UserId == UserId);
            else
                return allSettings.LastOrDefault();

        }
        private static List<UserSettings> LoadAllSettings()
        {

            System.IO.StreamReader sr = new System.IO.StreamReader(AppConfig.UserSettingsPath);

            var settings = Newtonsoft.Json.JsonConvert.DeserializeObject<List<UserSettings>>(sr.ReadToEnd());
            sr.Close();
            return settings;

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
                List<UserSettings> setting = new List<UserSettings>();
                UserSettings defaultSettings = new UserSettings();
                defaultSettings.IsPositionEnabled = true;
                defaultSettings.IsColorEnabled = false;
                defaultSettings.UserId = "default";
                setting.Add(defaultSettings);
                SaveSettings(defaultSettings);
            }

        }
        private static bool _saveSingleSetting(List<UserSettings> settings)
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

        public static bool SaveSettings(UserSettings settings)
        {
            try
            {
                List<UserSettings> allSettings = new List<UserSettings>();
                if (!settings.UserId.Equals("default"))
                    allSettings = LoadAllSettings();
                if (allSettings.Any(x => x.UserId == settings.UserId))
                {
                    allSettings.RemoveAll(x => x.UserId == settings.UserId);
                    allSettings.Add(settings);
                }
                else
                {
                    allSettings.Add(settings);
                }
                string jsonData = JsonConvert.SerializeObject(allSettings);
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

        public static bool SaveData(UserSettings settings, int point)
        {
            try
            {

                using (StreamWriter sw = new StreamWriter(AppConfig.DataPath, true))
                {
                    sw.WriteLine(String.Format("{0};{1};{2};{3};{4};{5}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), "BELLEK", "N-Back Testi", settings.Name + " " + settings.Surname, point));
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
