namespace ExamApp
{
    partial class Settings
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
            this.trayCheck = new System.Windows.Forms.CheckBox();
            this.selectPathBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // trayCheck
            // 
            this.trayCheck.AutoSize = true;
            this.trayCheck.Location = new System.Drawing.Point(12, 12);
            this.trayCheck.Name = "trayCheck";
            this.trayCheck.Size = new System.Drawing.Size(99, 17);
            this.trayCheck.TabIndex = 0;
            this.trayCheck.Text = "Скрыть в трей";
            this.trayCheck.UseVisualStyleBackColor = true;
            this.trayCheck.CheckedChanged += new System.EventHandler(this.OnTrayCheckChange);
            // 
            // selectPathBtn
            // 
            this.selectPathBtn.Location = new System.Drawing.Point(12, 35);
            this.selectPathBtn.Name = "selectPathBtn";
            this.selectPathBtn.Size = new System.Drawing.Size(207, 23);
            this.selectPathBtn.TabIndex = 1;
            this.selectPathBtn.Text = "Выбор папки для сохранения";
            this.selectPathBtn.UseVisualStyleBackColor = true;
            this.selectPathBtn.Click += new System.EventHandler(this.selectPathBtn_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 73);
            this.Controls.Add(this.selectPathBtn);
            this.Controls.Add(this.trayCheck);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройки";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox trayCheck;
        private System.Windows.Forms.Button selectPathBtn;
    }
}