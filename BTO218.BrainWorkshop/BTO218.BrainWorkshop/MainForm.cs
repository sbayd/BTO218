using BTO218.BrainWorkshop.Helpers;
using BTO218.BrainWorkshop.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
            uSettings = UserHelper.LoadSettings();
            checkbox_audio.Checked = uSettings.IsAudioEnabled;
            checkbox_color.Checked = uSettings.IsColorEnabled;
            checkbox_location.Checked = uSettings.IsPositionEnabled;
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

        private void checkbox_audio_CheckedChanged(object sender, EventArgs e)
        {
            uSettings.IsAudioEnabled = !uSettings.IsAudioEnabled;
            UserHelper.SaveSettings(uSettings);
        }

        private void button_begin_game_Click(object sender, EventArgs e)
        {
            this.Hide();
            GameForm gameForm = new GameForm();
            gameForm.Show();
        }
    }
}
