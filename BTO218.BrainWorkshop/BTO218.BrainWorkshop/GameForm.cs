using BTO218.BrainWorkshop.Helpers;
using BTO218.BrainWorkshop.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BTO218.BrainWorkshop
{
    public partial class GameForm : Form
    {
        public GameForm(string userId, MainForm parent)
        {
            uSettings = UserHelper.LoadSettings(userId);
            nBackLevel = uSettings.Level;
            mainForm = parent;
            InitializeComponent();
        }
        MainForm mainForm { get; set; }
        UserSettings uSettings { get; set; }
        /// <summary>
        /// Tur sayısı, testte her tur 3 saniye sürüyor, buna göre de 21*3 63 saniyede testin aşaması tamamlanıyor.
        /// </summary>
        int sessionCount = 21;
        //N-Back seviyesi
        int nBackLevel = 1;
        //Geçerli tur
        int currentSession = 1;
        //Programın çalışıp çalışmadığı
        bool is_running = true;
        //Pozisyon - renk bilgilerini tutan materyal listesi.
        List<GameMaterial> materialList = new List<GameMaterial>();
        //Tur timer'i
        Timer sessionTimer;
        //Pozisyon ve renk değişimi sırasında kullanılan timer 0.4 saniye gösterim yapar.
        Timer animationTimer;
        // Mümkün olan eşleşme değişkenleri
        int availableColorMatch, availablePositionMatch, availableTotalMatch, correctMatch = 0;
        //Yapılan Eşleşme listeleri.
        List<int> usedColorMatches = new List<int>();
        List<int> usedPositionMatches = new List<int>();
        private void GameForm_Load(object sender, EventArgs e)
        {
            InitGame(); // Oyunu hazırlayan fonksiyon.
            sessionTimer = new Timer();
            sessionTimer.Interval = 3000;
            sessionTimer.Tick += sessionTimer_Tick;
            animationTimer = new Timer();
            animationTimer.Interval = 400;
            animationTimer.Tick += animationTimer_Tick;
            sessionTimer.Start(); // İlk turu başlatıyoruz.

        }

        void animationTimer_Tick(object sender, EventArgs e)
        {
            //bu fonksiyon ekrandaki nesneyi temiziyor.
            //clear First
            game_panel.Refresh();
            animationTimer.Stop();
        }

        void sessionTimer_Tick(object sender, EventArgs e)
        {
            InitSessionText(); //Geçerli ekrandaki yazıları gösteren fonksiyon
            GetGameMaterial(); 
            currentSession++;
            animationTimer.Start();
            if (currentSession == sessionCount)
            {
                stopSession();
            }


        }
        void stopSession()
        {
            sessionTimer.Stop();
            lbl_game_info.Text = "Tur bitti.";
            if (usedColorMatches.Count() == 0 && usedPositionMatches.Count() == 0)
                usedColorMatches.Add(0);
            double successRate = (100 / (usedColorMatches.Count() + usedPositionMatches.Count())) * correctMatch;
            if (successRate >= 80)
            {
                MessageBox.Show(String.Format("Başarı yüzdeniz {0}\nBir sonraki seviyeye geçtiniz.", int.Parse(Math.Ceiling(successRate).ToString())), "TEBRİKLER", MessageBoxButtons.OK, MessageBoxIcon.Information);
                uSettings.Level += 1;
                UserHelper.SaveSettings(uSettings);
            }
            else
            {
                MessageBox.Show(String.Format("Başarı yüzdeniz {0}\nBu seviyeyi tekrar etmelisiniz.", int.Parse(Math.Ceiling(successRate).ToString())), "SEVİYE TEKRARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //save user data
            UserHelper.SaveData(uSettings, int.Parse(Math.Ceiling(successRate).ToString()));
            this.Close();
            GameForm gf = new GameForm(uSettings.UserId, mainForm);
            gf.Show();
        }
        void GetGameMaterial()
        {
            // Geçerli turdaki materyali gösteren ve labelleri eski haline getiren fonksiyon.
            lbl_instructions.ForeColor = Color.Black;
            lbl_instructions_2.ForeColor = Color.Black;
            DrawRectangle(materialList[currentSession - 1]);

        }
        private void InitGameText()
        {
            if (uSettings.IsColorEnabled && uSettings.IsPositionEnabled)
            {
                lbl_game_info.Text = String.Format("Çiftli Beyin Egzersizi, Seviye : {0}-Geri", nBackLevel);
                lbl_instructions_2.Text = "Sağ tuş : Pozisyon eşleşmesi";
                lbl_instructions.Text = "Sol tuş : Renk eşleşmesi";

            }
            else
            {
                lbl_game_info.Text = String.Format("Beyin Egzersizi, Seviye : {0}-Geri", nBackLevel);
                lbl_instructions.Text = "Sol tuş : Eşleşme";
                lbl_instructions_2.Text = "";

            }
            this.Text = lbl_game_info.Text;
        }
        private void InitGame()
        { 
            //Oyunu hazırlayan fonksiyon.
            InitGameText();
            materialList.Clear();
            // Kullanıcının seçtiği oyun modlarına göre aşağıda materyalleri hazırlıyoruz. 
            if (uSettings.IsColorEnabled && uSettings.IsPositionEnabled)
            {
                while (availableTotalMatch < 10)
                { InitGameMaterialList(); }
            }
            else
            {
                while (availableTotalMatch < 7) 
                { InitGameMaterialList(); }
            }

            InitSessionText();
        }

        void InitGameMaterialList()
        {
            //Materyal listesini hazırlayıp toplam eşleşme sayısını gösteriyoruz.
            materialList = new List<GameMaterial>();
            Random r = new Random();
            Colorizer c = new Colorizer();
            for (int i = 0; i < sessionCount; i++)
            {

                //Init game by modes selected by user.
                if (uSettings.IsPositionEnabled && uSettings.IsColorEnabled)
                    materialList.Add(new GameMaterial() { color = c.getRandomColor(), PositionNumber = r.Next(1, 10) });
                else if (uSettings.IsColorEnabled)
                    materialList.Add(new GameMaterial() { color = c.getRandomColor(), PositionNumber = 5 });
                else if (uSettings.IsPositionEnabled)
                    materialList.Add(new GameMaterial() { color = Color.Blue, PositionNumber = r.Next(1, 10) });

            }
            InitMatchCounts(); // Toplam eşleşme sayısını hesapla.
        }
        void InitMatchCounts()
        {
            //Materyal listesine ve kullanıcının N-Back seçimine göre yapılabilecek toplam eşleşme sayısı hesaplanıyor. Puanlama buna göre yapılacak.
            for (int i = 0; i < sessionCount - nBackLevel; i++)
            {
                if (uSettings.IsColorEnabled)
                    if (materialList[i].color == materialList[i + nBackLevel].color)
                        availableColorMatch++;
                if (uSettings.IsPositionEnabled)
                    if (materialList[i].PositionNumber == materialList[i + nBackLevel].PositionNumber)
                        availablePositionMatch++;
            }


            availableTotalMatch = availableColorMatch + availablePositionMatch;
        }
        private void game_panel_Paint(object sender, PaintEventArgs e)
        {
            // EMPTY 
        }

        private void game_panel_Click(object sender, EventArgs e)
        {
            switch (((MouseEventArgs)e).Button)
            {
                case System.Windows.Forms.MouseButtons.Right:
                    RightButtonClicked(); // Sağ tuş tıklandı
                    break;
                default:
                    LeftButtonClicked();  // Sol tuş tıklandı.
                    break;


            }

        }
        void LeftButtonClicked()
        {
            //Oyun türüne göre kontrollerin yapılıp eşleşme olup olmadığını kontrol ediyoruz.
            if (!is_running)
                return;
            if (uSettings.IsColorEnabled && uSettings.IsPositionEnabled)
            {
                if (IsColorMatch())
                    CorrectColorMatch();
                else WrongColorMatch();

            }
            else if (uSettings.IsColorEnabled)
            {
                if (IsColorMatch())
                    CorrectColorMatch();
                else WrongColorMatch();
            }
            else
            {
                if (IsPositionMatch())
                    CorrectPositionMatch();
                else WrongPositionMatch();
            }

        }
        void RightButtonClicked()
        {
            //Oyun türüne göre kontrollerin yapılıp eşleşme olup olmadığını kontrol ediyoruz.

            if (!is_running)
                return;
            if (uSettings.IsColorEnabled && uSettings.IsPositionEnabled)
            {

                if (IsPositionMatch())
                    CorrectPositionMatch();
                else WrongPositionMatch();

            }
        }
        public void DrawRectangle(GameMaterial material)
        {
            //verilen materyale göre ekranda gösterim yapıyurz.
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
            //Geçerli ekrandaki yazıları gösteren fonksiyon
            lbl_object_info.Text = String.Format("{0} / {1}", currentSession, sessionCount - 1);
        }
        //Durdur butonu tıklanırsa değişkenleri ayarlıyoruz.
        private void btn_pause_Click(object sender, EventArgs e)
        {
            if (is_running)
            {
                is_running = false;
                btn_pause.Text = "Devam Et";
                sessionTimer.Stop();
            }
            else
            {
                btn_pause.Text = "Durdur";
                is_running = true;
                sessionTimer.Start();

            }

        }
        //Ana ekrana dönüyoruz.
        private void btn_main_Click(object sender, EventArgs e)
        {
            mainForm.Show();
            this.Close();
        }
        //timerları kapatıyoruz.
        private void GameForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            animationTimer.Stop();
            sessionTimer.Stop();
        }
        // aşağıdaki fonksiyonlar eşleşme var mı diye kontrol ediyor.
        bool IsColorMatch()
        {
            if (usedColorMatches.Contains(currentSession - 2))
                return false;
            int materialIndex = (currentSession - 2) - nBackLevel;
            if (materialIndex < 0)
            {
                return false;
            }
            usedColorMatches.Add(currentSession - 2);
            if (materialList[materialIndex].color == materialList[currentSession - 2].color)
                return true;
            return false;
        }
        void WrongColorMatch()
        {

            BlindLabel(lbl_instructions, Color.Red);
        }
        void CorrectColorMatch()
        {
            correctMatch++;
            BlindLabel(lbl_instructions, Color.Green);

        }
        bool IsPositionMatch()
        {

            if (usedPositionMatches.Contains(currentSession - 2))
            { return false; }
            int materialIndex = (currentSession - 2) - nBackLevel;
            if (materialIndex < 0)
            {
                return false;
            }
            usedPositionMatches.Add(currentSession - 2);
            if (materialList[materialIndex].PositionNumber == materialList[currentSession - 2].PositionNumber)
                return true;
            return false;
        }
        void WrongPositionMatch()
        {
            if (uSettings.IsColorEnabled)
                BlindLabel(lbl_instructions_2, Color.Red);
            else
                BlindLabel(lbl_instructions, Color.Red);
        }
        void CorrectPositionMatch()
        {
            correctMatch++;
            if (uSettings.IsColorEnabled)
                BlindLabel(lbl_instructions_2, Color.Green);
            else
                BlindLabel(lbl_instructions, Color.Green);

        }

        //Label'in renk değşşim fonksiyonu
        void BlindLabel(Label lbl, Color color)
        {
            lbl.ForeColor = color;
            Timer t1 = new Timer();
            t1.Interval = 500;
            t1.Tick += delegate
            {
                lbl.ForeColor = Color.Black;
                t1.Stop();
            };
            t1.Start();
        }

        // Çıkış fonksiyonu
        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
