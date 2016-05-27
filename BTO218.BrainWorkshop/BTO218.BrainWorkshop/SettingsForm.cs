using BTO218.BrainWorkshop.Helpers;
using BTO218.BrainWorkshop.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTO218.BrainWorkshop
{
    public partial class SettingsForm : Form
    {
        public SettingsForm(Config config)
        {
            InitializeComponent();
            InitForm(config);
        }

        public void InitForm(Config conf)
        {
            check_is_app_dir.Checked = conf.IsInAppData;
            if (conf.IsInAppData)
            {
                txt_path.Text = conf.DataPath.Replace(string.Format("{0}{1}\\", Application.StartupPath, AppConfig.AppDataPath), "");

            }
            else
            {
                txt_path.Text = conf.DataPath;
            }
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            //Validasyonları yapıp ayarları kaydeden fonksiyon.

            bool previousValue = AppConfig.IsDataInAppFolder;
            string previousDataPath = AppConfig.DataPath;
            AppConfig.IsDataInAppFolder = check_is_app_dir.Checked;
            AppConfig.DataPath = txt_path.Text;
            if (!checkFolderIsAvailable())
            {
                AppConfig.IsDataInAppFolder = previousValue;
                AppConfig.DataPath = previousDataPath;
                MessageBox.Show("İşlem başarısız oldu");

            }
            else
            {
                Config conf = new Config();
                conf.IsInAppData = AppConfig.IsDataInAppFolder;
                conf.DataPath = AppConfig.DataPath;
                ConfigHelper.SaveConfig(conf);
                MessageBox.Show("Ayarlar kayıt edildi.");

            }

        }

        private bool checkFolderIsAvailable()
        {
            if (!File.Exists(AppConfig.DataPath))
            {
                if (!Directory.Exists(Path.GetDirectoryName(AppConfig.DataPath)))
                {
                    var result = MessageBox.Show("Klasör bulunamadı, yaratmak istiyor musunuz?", "UYARI", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result == System.Windows.Forms.DialogResult.OK)
                    {
                        try
                        {
                            Directory.CreateDirectory(Path.GetDirectoryName(AppConfig.UserSettingsPath));

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Klasör yaratma başarısız oldu!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }

                    }
                    else
                        return false;
                }
                var msgResult = MessageBox.Show("Dosya bulunamadı, yaratmak istiyor musunuz?", "UYARI", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (msgResult == System.Windows.Forms.DialogResult.OK)
                {
                    try
                    {
                        File.Create(AppConfig.DataPath).Close();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Klasör yaratma başarısız oldu!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }

                }
                else
                    return false;
            }
            else
            {
                var result = MessageBox.Show("Aynı isimde bir dosya var, yine de devam etmek istiyor musunuz?", "UYARI", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == System.Windows.Forms.DialogResult.OK)
                    return true;
                else
                    return false;
            }
        }
    }
}
