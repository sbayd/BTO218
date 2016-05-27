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
        public static string AppDataPath = "\\App_Data"; // Program içerisindeki data path.
        private static string SettingsName = "user_settings.json"; //default kullanıcı ayarları dosya adı.
        private static string DataFileName = "BTO218Veri.dat"; // default kullanıcı skorları dosya adı.
        private static string AppConfigName = "config.json"; // default program config dosya adı.
        public static bool IsDataInAppFolder { get; set; } // Kullanıcı skorlarının program klasöründe mi harici klasörde mi tutulduğunu bildiren değişken
        public static string UserSettingsPath 
        {
            get
            {
                //Programın başlangıç noktasına göre kullanıcı ayar dosyasının yolunu veren getter.
                return Application.StartupPath + string.Format("{0}\\{1}", AppDataPath, SettingsName);
            }
        }
        public static string AppConfigPath
        {
            get
            {
                //Programın başlangıç noktasına göre config dosyasının yolunu veren getter.

                return Application.StartupPath + string.Format("{0}\\{1}", AppDataPath, AppConfigName);
            }
        }
        public static string DataPath
        {
            //Programın başlangıç noktasına göre ve kullanıcının seçimine göre skor dosya yolunu veren property.

            get
            {
                if (IsDataInAppFolder)
                    return Application.StartupPath + string.Format("{0}\\{1}", AppDataPath, DataFileName);
                else
                {
                    return DataFileName;
                }
            }
            set
            {
                DataFileName = value;
            }
        }
    }
    /// <summary>
    /// Program config nesnesi.
    /// </summary>
    [Serializable]
    public class Config
    {
        /// <summary>
        /// Dosya yolunun program klasörü içinde olup olmadığı değişkeni
        /// </summary>
        public bool IsInAppData { get; set; }
        public string DataPath { get; set; }
    }
}
