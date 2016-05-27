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

    //Program config dosyalarını düzenlememize ve çekmemize yarayan helper.
    public static class ConfigHelper
    {
        //Pathden JSON olarak Config dosyasını okuyan ve parse eden fonksiyon.
        public static Config GetConfig()
        {
            CreateConfigIfEmpty();
            System.IO.StreamReader sr = new System.IO.StreamReader(AppConfig.AppConfigPath);
            var config = Newtonsoft.Json.JsonConvert.DeserializeObject<Config>(sr.ReadToEnd());
            sr.Close();
            return config;
        }
        //Config dosyasını AppConfig içerisinde gereken yerlere yazan fonksiyon
        public static void InitConfig()
        {
            Config conf = GetConfig();
            AppConfig.IsDataInAppFolder = conf.IsInAppData;
            AppConfig.DataPath = conf.DataPath;
        }
        //Config dosyası yoksa oluşturan fonksiyon.
        private static void CreateConfigIfEmpty()
        {
            if (!File.Exists(AppConfig.AppConfigPath))
            {
                if (!Directory.Exists(Path.GetDirectoryName(AppConfig.AppConfigPath)))
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(AppConfig.AppConfigPath));
                }
                File.Create(AppConfig.AppConfigPath).Close();
                Config conf = new Config();
                AppConfig.IsDataInAppFolder = true;
                conf.IsInAppData = true;
                conf.DataPath = AppConfig.DataPath;
                SaveConfig(conf);
            }

        }

        //Config dosyasını diske JSON olarak kaydeden fonksiyon
        public static bool SaveConfig(Config conf)
        {
            try
            {
                string jsonData = JsonConvert.SerializeObject(conf);
                using (StreamWriter sw = new StreamWriter(AppConfig.AppConfigPath))
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
