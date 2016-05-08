namespace BTO218.BrainWorkshop
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
                /*
               
                 
                 */
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupbox_settings = new System.Windows.Forms.GroupBox();
            this.checkbox_audio = new System.Windows.Forms.CheckBox();
            this.checkbox_color = new System.Windows.Forms.CheckBox();
            this.checkbox_location = new System.Windows.Forms.CheckBox();
            this.groupbox_info = new System.Windows.Forms.GroupBox();
            this.button_begin_game = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupbox_settings.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupbox_settings
            // 
            this.groupbox_settings.Controls.Add(this.checkbox_audio);
            this.groupbox_settings.Controls.Add(this.checkbox_color);
            this.groupbox_settings.Controls.Add(this.checkbox_location);
            this.groupbox_settings.Location = new System.Drawing.Point(12, 12);
            this.groupbox_settings.Name = "groupbox_settings";
            this.groupbox_settings.Size = new System.Drawing.Size(300, 163);
            this.groupbox_settings.TabIndex = 0;
            this.groupbox_settings.TabStop = false;
            this.groupbox_settings.Text = "Ayarlar";
            // 
            // checkbox_audio
            // 
            this.checkbox_audio.AutoSize = true;
            this.checkbox_audio.Location = new System.Drawing.Point(6, 75);
            this.checkbox_audio.Name = "checkbox_audio";
            this.checkbox_audio.Size = new System.Drawing.Size(54, 21);
            this.checkbox_audio.TabIndex = 2;
            this.checkbox_audio.Text = "Ses";
            this.checkbox_audio.UseVisualStyleBackColor = true;
            this.checkbox_audio.CheckedChanged += new System.EventHandler(this.checkbox_audio_CheckedChanged);
            // 
            // checkbox_color
            // 
            this.checkbox_color.AutoSize = true;
            this.checkbox_color.Location = new System.Drawing.Point(6, 48);
            this.checkbox_color.Name = "checkbox_color";
            this.checkbox_color.Size = new System.Drawing.Size(63, 21);
            this.checkbox_color.TabIndex = 1;
            this.checkbox_color.Text = "Renk";
            this.checkbox_color.UseVisualStyleBackColor = true;
            this.checkbox_color.CheckedChanged += new System.EventHandler(this.checkbox_color_CheckedChanged);
            // 
            // checkbox_location
            // 
            this.checkbox_location.AutoSize = true;
            this.checkbox_location.Location = new System.Drawing.Point(6, 21);
            this.checkbox_location.Name = "checkbox_location";
            this.checkbox_location.Size = new System.Drawing.Size(87, 21);
            this.checkbox_location.TabIndex = 0;
            this.checkbox_location.Text = "Pozisyon";
            this.checkbox_location.UseVisualStyleBackColor = true;
            this.checkbox_location.CheckedChanged += new System.EventHandler(this.checkbox_location_CheckedChanged);
            // 
            // groupbox_info
            // 
            this.groupbox_info.Location = new System.Drawing.Point(12, 181);
            this.groupbox_info.Name = "groupbox_info";
            this.groupbox_info.Size = new System.Drawing.Size(758, 118);
            this.groupbox_info.TabIndex = 1;
            this.groupbox_info.TabStop = false;
            this.groupbox_info.Text = "Açıklamalar";
            // 
            // button_begin_game
            // 
            this.button_begin_game.Location = new System.Drawing.Point(318, 23);
            this.button_begin_game.Name = "button_begin_game";
            this.button_begin_game.Size = new System.Drawing.Size(452, 73);
            this.button_begin_game.TabIndex = 2;
            this.button_begin_game.Text = "BAŞLA";
            this.button_begin_game.UseVisualStyleBackColor = true;
            this.button_begin_game.Click += new System.EventHandler(this.button_begin_game_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(318, 102);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(452, 73);
            this.button2.TabIndex = 3;
            this.button2.Text = "GELİŞİM RAPORUM";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 313);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button_begin_game);
            this.Controls.Add(this.groupbox_info);
            this.Controls.Add(this.groupbox_settings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "N-Back Beyin Egzersizi";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupbox_settings.ResumeLayout(false);
            this.groupbox_settings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupbox_settings;
        private System.Windows.Forms.CheckBox checkbox_audio;
        private System.Windows.Forms.CheckBox checkbox_color;
        private System.Windows.Forms.CheckBox checkbox_location;
        private System.Windows.Forms.GroupBox groupbox_info;
        private System.Windows.Forms.Button button_begin_game;
        private System.Windows.Forms.Button button2;
    }
}

