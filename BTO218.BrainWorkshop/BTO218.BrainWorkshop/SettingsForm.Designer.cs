namespace BTO218.BrainWorkshop
{
    partial class SettingsForm
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
            this.check_is_app_dir = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_path = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // check_is_app_dir
            // 
            this.check_is_app_dir.AutoSize = true;
            this.check_is_app_dir.Location = new System.Drawing.Point(15, 12);
            this.check_is_app_dir.Name = "check_is_app_dir";
            this.check_is_app_dir.Size = new System.Drawing.Size(172, 21);
            this.check_is_app_dir.TabIndex = 0;
            this.check_is_app_dir.Text = "Program Dizininde Mi?";
            this.check_is_app_dir.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dosya Yolu";
            // 
            // txt_path
            // 
            this.txt_path.Location = new System.Drawing.Point(12, 72);
            this.txt_path.Name = "txt_path";
            this.txt_path.Size = new System.Drawing.Size(245, 22);
            this.txt_path.TabIndex = 2;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(12, 100);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(245, 23);
            this.btn_save.TabIndex = 3;
            this.btn_save.Text = "Kaydet";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 151);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txt_path);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.check_is_app_dir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SettingsForm";
            this.Text = "Ayarlar";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox check_is_app_dir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_path;
        private System.Windows.Forms.Button btn_save;
    }
}