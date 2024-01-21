namespace ExamApp
{
    partial class MainWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.settingsBtn = new System.Windows.Forms.Button();
            this.startBtn = new System.Windows.Forms.Button();
            this.analyticsBtn = new System.Windows.Forms.Button();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // settingsBtn
            // 
            this.settingsBtn.Location = new System.Drawing.Point(12, 12);
            this.settingsBtn.Name = "settingsBtn";
            this.settingsBtn.Size = new System.Drawing.Size(202, 41);
            this.settingsBtn.TabIndex = 0;
            this.settingsBtn.Text = "НАСТРОЙКИ";
            this.settingsBtn.UseVisualStyleBackColor = true;
            this.settingsBtn.Click += new System.EventHandler(this.settingsBtn_Click);
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(12, 59);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(202, 41);
            this.startBtn.TabIndex = 1;
            this.startBtn.Text = "СТАРТ";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // analyticsBtn
            // 
            this.analyticsBtn.Location = new System.Drawing.Point(12, 106);
            this.analyticsBtn.Name = "analyticsBtn";
            this.analyticsBtn.Size = new System.Drawing.Size(202, 41);
            this.analyticsBtn.TabIndex = 2;
            this.analyticsBtn.Text = "АНАЛИТИКА";
            this.analyticsBtn.UseVisualStyleBackColor = true;
            this.analyticsBtn.Click += new System.EventHandler(this.analyticsBtn_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Слежка";
            this.notifyIcon.DoubleClick += new System.EventHandler(this.OnTrayClick);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 156);
            this.Controls.Add(this.analyticsBtn);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.settingsBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Слежка";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button settingsBtn;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button analyticsBtn;
        private System.Windows.Forms.NotifyIcon notifyIcon;
    }
}

