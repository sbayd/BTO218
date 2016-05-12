using BTO218.BrainWorkshop.Helpers;
using BTO218.BrainWorkshop.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTO218.BrainWorkshop
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        UserSettings uSettings { get; set; }
        private void MainForm_Load(object sender, EventArgs e)
        {
            InitSettings();
        }

        private void InitSettings()
        {
            uSettings = UserHelper.LoadSettings(txt_email.Text);
            checkbox_color.Checked = uSettings.IsColorEnabled;
            checkbox_location.Checked = uSettings.IsPositionEnabled;
            txt_email.Text = uSettings.UserId;
            txt_name.Text = uSettings.Name + " " + uSettings.Surname;
            txt_level.Text = uSettings.Level.ToString();
            //to disable first change causes
            this.checkbox_color.CheckedChanged += new System.EventHandler(this.checkbox_color_CheckedChanged);
            this.checkbox_location.CheckedChanged += new System.EventHandler(this.checkbox_location_CheckedChanged);
        }

        private void checkbox_location_CheckedChanged(object sender, EventArgs e)
        {
            uSettings.IsPositionEnabled = !uSettings.IsPositionEnabled;
            UserHelper.SaveSettings(uSettings);
        }

        private void checkbox_color_CheckedChanged(object sender, EventArgs e)
        {
            uSettings.IsColorEnabled = !uSettings.IsColorEnabled;
            UserHelper.SaveSettings(uSettings);
        }


        private void button_begin_game_Click(object sender, EventArgs e)
        {
            if (!ValidateName())
            {
                MessageBox.Show("Adınızı ve soyadınızı doğru olarak girmelisiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!ValidateEmail())
            {
                MessageBox.Show("Geçerli bir mail adresi girmelisiniz.\nBu adres kimlik alanı olarak kullanılacaktır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!ValidateLevel())
            {
                MessageBox.Show("Geçerli bir seviye girmelisiniz.\nSeviye 1-10 aralığında olmalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.Hide();
            var nameList = txt_name.Text.TrimStart(' ').TrimEnd(' ').Split(' ').ToList();

            uSettings.Surname = nameList[nameList.Count - 1];
            nameList.RemoveAt(nameList.Count - 1);
            uSettings.Name = string.Join(" ", nameList.ToArray());
            uSettings.UserId = txt_email.Text;
            uSettings.Level = int.Parse(txt_level.Text);
            UserHelper.SaveSettings(uSettings);

            GameForm gameForm = new GameForm(txt_email.Text, this);
            gameForm.Show();
        }

        private bool ValidateName()
        {
            if (string.IsNullOrEmpty(txt_name.Text))
                return false;
            return txt_name.Text.TrimStart(' ').TrimEnd(' ').Split(' ').Count() > 1;
        }

        bool invalid = false;
        private bool ValidateEmail()
        {
            string strIn = txt_email.Text;

            if (String.IsNullOrEmpty(strIn))
                return false;

            // Use IdnMapping class to convert Unicode domain names.
            try
            {
                strIn = Regex.Replace(strIn, @"(@)(.+)$", this.DomainMapper,
                                      RegexOptions.None, TimeSpan.FromMilliseconds(200));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }

            if (invalid)
                return false;

            // Return true if strIn is in valid e-mail format.
            try
            {
                return Regex.IsMatch(strIn,
                      @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                      @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
                      RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }
        private bool ValidateLevel()
        {
            int level = 0;
            if (int.TryParse(txt_level.Text, out level) && level < 10 && level > 0)
                return true;
            return false;
        }
        private string DomainMapper(Match match)
        {
            // IdnMapping class with default property values.
            IdnMapping idn = new IdnMapping();

            string domainName = match.Groups[2].Value;
            try
            {
                domainName = idn.GetAscii(domainName);
            }
            catch (ArgumentException)
            {
                invalid = true;
            }
            return match.Groups[1].Value + domainName;
        }
    }
}
