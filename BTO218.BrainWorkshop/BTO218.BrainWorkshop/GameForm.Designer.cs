namespace BTO218.BrainWorkshop
{
    partial class GameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.game_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl_game_info = new System.Windows.Forms.Label();
            this.lbl_object_info = new System.Windows.Forms.Label();
            this.lbl_instructions = new System.Windows.Forms.Label();
            this.btn_pause = new System.Windows.Forms.Button();
            this.btn_main = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.lbl_instructions_2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // game_panel
            // 
            this.game_panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("game_panel.BackgroundImage")));
            this.game_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.game_panel.Location = new System.Drawing.Point(149, 47);
            this.game_panel.Name = "game_panel";
            this.game_panel.Size = new System.Drawing.Size(450, 450);
            this.game_panel.TabIndex = 0;
            this.game_panel.Click += new System.EventHandler(this.game_panel_Click);
            // 
            // lbl_game_info
            // 
            this.lbl_game_info.AutoSize = true;
            this.lbl_game_info.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_game_info.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_game_info.Location = new System.Drawing.Point(12, 9);
            this.lbl_game_info.Name = "lbl_game_info";
            this.lbl_game_info.Size = new System.Drawing.Size(46, 18);
            this.lbl_game_info.TabIndex = 1;
            this.lbl_game_info.Text = "label1";
            // 
            // lbl_object_info
            // 
            this.lbl_object_info.AutoSize = true;
            this.lbl_object_info.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_object_info.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_object_info.Location = new System.Drawing.Point(724, 9);
            this.lbl_object_info.Name = "lbl_object_info";
            this.lbl_object_info.Size = new System.Drawing.Size(46, 18);
            this.lbl_object_info.TabIndex = 2;
            this.lbl_object_info.Text = "label2";
            // 
            // lbl_instructions
            // 
            this.lbl_instructions.AutoSize = true;
            this.lbl_instructions.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_instructions.Location = new System.Drawing.Point(146, 514);
            this.lbl_instructions.Name = "lbl_instructions";
            this.lbl_instructions.Size = new System.Drawing.Size(106, 20);
            this.lbl_instructions.TabIndex = 3;
            this.lbl_instructions.Text = "lbl_instructions";
            // 
            // btn_pause
            // 
            this.btn_pause.Location = new System.Drawing.Point(640, 47);
            this.btn_pause.Name = "btn_pause";
            this.btn_pause.Size = new System.Drawing.Size(130, 36);
            this.btn_pause.TabIndex = 4;
            this.btn_pause.Text = "Durdur";
            this.btn_pause.UseVisualStyleBackColor = true;
            this.btn_pause.Click += new System.EventHandler(this.btn_pause_Click);
            // 
            // btn_main
            // 
            this.btn_main.Location = new System.Drawing.Point(640, 89);
            this.btn_main.Name = "btn_main";
            this.btn_main.Size = new System.Drawing.Size(130, 36);
            this.btn_main.TabIndex = 5;
            this.btn_main.Text = "Geri dön";
            this.btn_main.UseVisualStyleBackColor = true;
            this.btn_main.Click += new System.EventHandler(this.btn_main_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(640, 131);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(130, 36);
            this.btn_exit.TabIndex = 6;
            this.btn_exit.Text = "Çıkış";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // lbl_instructions_2
            // 
            this.lbl_instructions_2.AutoSize = true;
            this.lbl_instructions_2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_instructions_2.Location = new System.Drawing.Point(394, 514);
            this.lbl_instructions_2.Name = "lbl_instructions_2";
            this.lbl_instructions_2.Size = new System.Drawing.Size(95, 18);
            this.lbl_instructions_2.TabIndex = 7;
            this.lbl_instructions_2.Text = "instructions_2";
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 603);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_instructions_2);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_main);
            this.Controls.Add(this.btn_pause);
            this.Controls.Add(this.lbl_instructions);
            this.Controls.Add(this.lbl_object_info);
            this.Controls.Add(this.lbl_game_info);
            this.Controls.Add(this.game_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameForm_FormClosing);
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.Click += new System.EventHandler(this.game_panel_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel game_panel;
        private System.Windows.Forms.Label lbl_game_info;
        private System.Windows.Forms.Label lbl_object_info;
        private System.Windows.Forms.Label lbl_instructions;
        private System.Windows.Forms.Button btn_pause;
        private System.Windows.Forms.Button btn_main;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label lbl_instructions_2;

    }
}