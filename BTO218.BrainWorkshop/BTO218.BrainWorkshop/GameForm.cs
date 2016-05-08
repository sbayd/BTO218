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
    public partial class GameForm : Form
    {
        public GameForm()
        {
            InitializeComponent();
        }
        UserSettings uSettings { get; set; }
        int sessionCount = 21;
        int nBackLevel = 1;
        int currentSession = 1;
        List<GameMaterial> materialList = new List<GameMaterial>();
        Timer sessionTimer;
        Timer animationTimer;
        private void GameForm_Load(object sender, EventArgs e)
        {
            InitGame();
            sessionTimer = new Timer();
            sessionTimer.Interval = 3000;
            sessionTimer.Tick += sessionTimer_Tick;
            animationTimer = new Timer();
            animationTimer.Interval = 400;
            animationTimer.Tick += animationTimer_Tick;
            sessionTimer.Start();    

        }

        void animationTimer_Tick(object sender, EventArgs e)
        {
            //clear First
            game_panel.Refresh();
            animationTimer.Stop();
        }

        void sessionTimer_Tick(object sender, EventArgs e)
        {
            InitSessionText();
            DrawRectangle(materialList[currentSession - 1]);
            animationTimer.Start();
            currentSession++;
            if (currentSession == sessionCount)
            {
                sessionTimer.Stop();
                lbl_game_info.Text = "Tur bitti.";
            }
        }

        private void InitGame()
        {
            uSettings = UserHelper.LoadSettings();
            if (uSettings.IsPositionEnabled && uSettings.IsAudioEnabled && uSettings.IsColorEnabled)
            {
                //hardest game. triple
            }
            else if (uSettings.IsPositionEnabled && uSettings.IsColorEnabled)
            {

            }
            else if (uSettings.IsColorEnabled && uSettings.IsAudioEnabled)
            {

            }
            else if (uSettings.IsPositionEnabled && uSettings.IsAudioEnabled)
            {

            }
            else if (uSettings.IsColorEnabled)
            {

            }
            else if (uSettings.IsPositionEnabled)
            {
                Random r = new Random();
                Colorizer c = new Colorizer();
                for (int i = 0; i < sessionCount; i++)
                {
                    materialList.Add(new GameMaterial() { color = c.getRandomColor(), PositionNumber = r.Next(1, 10) });
                }
            }
            else if (uSettings.IsAudioEnabled)
            {

            }
            InitSessionText();
        }

        private void game_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void game_panel_Click(object sender, EventArgs e)
        {
            switch (((MouseEventArgs)e).Button)
            {
                case System.Windows.Forms.MouseButtons.Right:
                    RightButtonClicked();
                    break;
                default:
                    LeftButtonClicked();
                    break;


            }

        }
        void LeftButtonClicked()
        {

        }
        void RightButtonClicked()
        {

        }
        public void DrawRectangle(GameMaterial material)
        {
          
            using (Graphics g = this.game_panel.CreateGraphics())
            {
                int rowNumber = (((double)material.PositionNumber) / 3) % 1 == 0 ?
                    (material.PositionNumber / 3) : (material.PositionNumber / 3) + 1;
                int colNumber = ((material.PositionNumber - 1) % 3) + 1;
                Pen pen = new Pen(material.color, 1);
                Brush brush = new SolidBrush(material.color);
                g.FillRectangle(brush, ((colNumber - 1) * 120) + 5, ((rowNumber - 1) * 120) + 5 + 10, 90, 90);
                g.DrawRectangle(pen, ((colNumber - 1) * 120) + 5, ((rowNumber - 1) * 120) + 5 + 10, 90, 90);
                pen.Dispose();
            }
        }

        void InitSessionText()
        {
            lbl_object_info.Text = String.Format("{0} / {1}", currentSession, sessionCount);
        }
    }
}
