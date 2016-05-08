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
            this.lbl_game_info.Location = new System.Drawing.Point(12, 9);
            this.lbl_game_info.Name = "lbl_game_info";
            this.lbl_game_info.Size = new System.Drawing.Size(46, 17);
            this.lbl_game_info.TabIndex = 1;
            this.lbl_game_info.Text = "label1";
            // 
            // lbl_object_info
            // 
            this.lbl_object_info.AutoSize = true;
            this.lbl_object_info.Location = new System.Drawing.Point(724, 9);
            this.lbl_object_info.Name = "lbl_object_info";
            this.lbl_object_info.Size = new System.Drawing.Size(46, 17);
            this.lbl_object_info.TabIndex = 2;
            this.lbl_object_info.Text = "label2";
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.lbl_object_info);
            this.Controls.Add(this.lbl_game_info);
            this.Controls.Add(this.game_panel);
            this.Name = "GameForm";
            this.Text = "GameForm";
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel game_panel;
        private System.Windows.Forms.Label lbl_game_info;
        private System.Windows.Forms.Label lbl_object_info;

    }
}