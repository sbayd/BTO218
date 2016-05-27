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

    //Kullanıcılar ile ilgili işlemleri yapan helper
    public static class UserHelper
    {
        //Geçerli kullanıcının ayarlarını döndüren fonksiyon.
        public static UserSettings LoadSettings(string UserId)
        {
            CreateSettingsIfEmpty();
            if (string.IsNullOrEmpty(UserId))
                UserId = "default"; // Eğer kullanıcının ilk girişi ise id'sini default veriyorum.
            var allSettings = LoadAllSettings();
            if (allSettings.Count > 1 && UserId != "default")
                return allSettings.OrderByDescending(x => x.ModifiedDate).FirstOrDefault(); // Son giriş yapan kullanıcıyı tarihe göre bulup döndürüyorum.
            else
                return allSettings.OrderByDescending(x => x.ModifiedDate).FirstOrDefault();

        }
        //Kullanıcı DB'si
        private static List<UserSettings> LoadAllSettings()
        {

            System.IO.StreamReader sr = new System.IO.StreamReader(AppConfig.UserSettingsPath);
            var settings = Newtonsoft.Json.JsonConvert.DeserializeObject<List<UserSettings>>(sr.ReadToEnd());
            sr.Close();
            return settings;

        }
        //Kullanıcılar Json dosyası yoksa oluşturan fonksiyon.
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
                defaultSettings.ModifiedDate = DateTime.Now;
                defaultSettings.IsColorEnabled = false;
                defaultSettings.UserId = "default";
                defaultSettings.Level = 1;
                setting.Add(defaultSettings);
                SaveSettings(defaultSettings);
            }

        }

        //Kullanıcının ayarlarını JSON'a kayıt eden fonksiyon.
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
                    settings.ModifiedDate = DateTime.Now;
                    allSettings.Add(settings);
                }
                else
                {
                    settings.ModifiedDate = DateTime.Now;
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

        //Kullanıcının skorunu Kayıt eden fonksiyon.
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
