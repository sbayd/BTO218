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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.groupbox_settings = new System.Windows.Forms.GroupBox();
            this.checkbox_color = new System.Windows.Forms.CheckBox();
            this.checkbox_location = new System.Windows.Forms.CheckBox();
            this.groupbox_info = new System.Windows.Forms.GroupBox();
            this.button_begin_game = new System.Windows.Forms.Button();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_level = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupbox_settings.SuspendLayout();
            this.groupbox_info.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupbox_settings
            // 
            this.groupbox_settings.Controls.Add(this.label3);
            this.groupbox_settings.Controls.Add(this.txt_level);
            this.groupbox_settings.Controls.Add(this.label2);
            this.groupbox_settings.Controls.Add(this.txt_email);
            this.groupbox_settings.Controls.Add(this.label1);
            this.groupbox_settings.Controls.Add(this.txt_name);
            this.groupbox_settings.Controls.Add(this.checkbox_color);
            this.groupbox_settings.Controls.Add(this.checkbox_location);
            this.groupbox_settings.Location = new System.Drawing.Point(12, 12);
            this.groupbox_settings.Name = "groupbox_settings";
            this.groupbox_settings.Size = new System.Drawing.Size(300, 163);
            this.groupbox_settings.TabIndex = 0;
            this.groupbox_settings.TabStop = false;
            this.groupbox_settings.Text = "Ayarlar";
            // 
            // checkbox_color
            // 
            this.checkbox_color.AutoSize = true;
            this.checkbox_color.Location = new System.Drawing.Point(161, 126);
            this.checkbox_color.Name = "checkbox_color";
            this.checkbox_color.Size = new System.Drawing.Size(63, 21);
            this.checkbox_color.TabIndex = 1;
            this.checkbox_color.Text = "Renk";
            this.checkbox_color.UseVisualStyleBackColor = true;
            // 
            // checkbox_location
            // 
            this.checkbox_location.AutoSize = true;
            this.checkbox_location.Location = new System.Drawing.Point(9, 126);
            this.checkbox_location.Name = "checkbox_location";
            this.checkbox_location.Size = new System.Drawing.Size(87, 21);
            this.checkbox_location.TabIndex = 0;
            this.checkbox_location.Text = "Pozisyon";
            this.checkbox_location.UseVisualStyleBackColor = true;
            // 
            // groupbox_info
            // 
            this.groupbox_info.Controls.Add(this.label4);
            this.groupbox_info.Location = new System.Drawing.Point(12, 206);
            this.groupbox_info.Name = "groupbox_info";
            this.groupbox_info.Size = new System.Drawing.Size(758, 93);
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
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(9, 38);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(215, 22);
            this.txt_name.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Adınız, Soyadınız :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "E-mail";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(9, 84);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(215, 22);
            this.txt_email.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(244, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Seviye";
            // 
            // txt_level
            // 
            this.txt_level.Location = new System.Drawing.Point(247, 38);
            this.txt_level.Name = "txt_level";
            this.txt_level.Size = new System.Drawing.Size(47, 22);
            this.txt_level.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(6, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(658, 63);
            this.label4.TabIndex = 0;
            this.label4.Text = resources.GetString("label4.Text");
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 313);
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
            this.groupbox_info.ResumeLayout(false);
            this.groupbox_info.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupbox_settings;
        private System.Windows.Forms.CheckBox checkbox_color;
        private System.Windows.Forms.CheckBox checkbox_location;
        private System.Windows.Forms.GroupBox groupbox_info;
        private System.Windows.Forms.Button button_begin_game;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_level;
        private System.Windows.Forms.Label label4;
    }
}

