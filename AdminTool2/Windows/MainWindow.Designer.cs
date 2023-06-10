namespace AdminTool2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкаЗначенийДляПлановогоПоказателяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonCreateReport = new AdminTool2.MyControls.CustomBTN();
            this.buttonAutoPlan = new AdminTool2.MyControls.CustomBTN();
            this.buttonSaveAutoPlan = new AdminTool2.MyControls.CustomBTN();
            this.buttonDownloadReport = new AdminTool2.MyControls.CustomBTN();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.настройкиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1347, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.настройкаЗначенийДляПлановогоПоказателяToolStripMenuItem});
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            // 
            // настройкаЗначенийДляПлановогоПоказателяToolStripMenuItem
            // 
            this.настройкаЗначенийДляПлановогоПоказателяToolStripMenuItem.Name = "настройкаЗначенийДляПлановогоПоказателяToolStripMenuItem";
            this.настройкаЗначенийДляПлановогоПоказателяToolStripMenuItem.Size = new System.Drawing.Size(291, 26);
            this.настройкаЗначенийДляПлановогоПоказателяToolStripMenuItem.Text = "Настройка значений для ПП";
            this.настройкаЗначенийДляПлановогоПоказателяToolStripMenuItem.Click += new System.EventHandler(this.configStripMenu_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(173)))), ((int)(((byte)(96)))));
            this.panelMenu.Controls.Add(this.panel2);
            this.panelMenu.Controls.Add(this.buttonCreateReport);
            this.panelMenu.Controls.Add(this.buttonAutoPlan);
            this.panelMenu.Controls.Add(this.buttonSaveAutoPlan);
            this.panelMenu.Controls.Add(this.buttonDownloadReport);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 28);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(249, 725);
            this.panelMenu.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::AdminTool2.Properties.Resources.logo_2;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(0, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(249, 53);
            this.panel2.TabIndex = 8;
            // 
            // buttonCreateReport
            // 
            this.buttonCreateReport.BackColor = System.Drawing.Color.White;
            this.buttonCreateReport.BackgroundColor = System.Drawing.Color.White;
            this.buttonCreateReport.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonCreateReport.BorderRadius = 20;
            this.buttonCreateReport.BorderSize = 0;
            this.buttonCreateReport.FlatAppearance.BorderSize = 0;
            this.buttonCreateReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(138)))), ((int)(((byte)(77)))));
            this.buttonCreateReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreateReport.Font = new System.Drawing.Font("Circe", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCreateReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(36)))), ((int)(((byte)(19)))));
            this.buttonCreateReport.Location = new System.Drawing.Point(30, 510);
            this.buttonCreateReport.Name = "buttonCreateReport";
            this.buttonCreateReport.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.buttonCreateReport.Size = new System.Drawing.Size(190, 85);
            this.buttonCreateReport.TabIndex = 7;
            this.buttonCreateReport.Text = "Построить отчёт";
            this.buttonCreateReport.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(36)))), ((int)(((byte)(19)))));
            this.buttonCreateReport.UseVisualStyleBackColor = false;
            this.buttonCreateReport.Click += new System.EventHandler(this.buttonCreateReport_Click);
            this.buttonCreateReport.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.buttonCreateReport.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // buttonAutoPlan
            // 
            this.buttonAutoPlan.BackColor = System.Drawing.Color.White;
            this.buttonAutoPlan.BackgroundColor = System.Drawing.Color.White;
            this.buttonAutoPlan.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonAutoPlan.BorderRadius = 20;
            this.buttonAutoPlan.BorderSize = 0;
            this.buttonAutoPlan.FlatAppearance.BorderSize = 0;
            this.buttonAutoPlan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(138)))), ((int)(((byte)(77)))));
            this.buttonAutoPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAutoPlan.Font = new System.Drawing.Font("Circe", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAutoPlan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(36)))), ((int)(((byte)(19)))));
            this.buttonAutoPlan.Location = new System.Drawing.Point(30, 165);
            this.buttonAutoPlan.Name = "buttonAutoPlan";
            this.buttonAutoPlan.Size = new System.Drawing.Size(190, 85);
            this.buttonAutoPlan.TabIndex = 0;
            this.buttonAutoPlan.Text = "Построить автоплан";
            this.buttonAutoPlan.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(36)))), ((int)(((byte)(19)))));
            this.buttonAutoPlan.UseVisualStyleBackColor = false;
            this.buttonAutoPlan.Click += new System.EventHandler(this.buttonAutoPlan_Click);
            this.buttonAutoPlan.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.buttonAutoPlan.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // buttonSaveAutoPlan
            // 
            this.buttonSaveAutoPlan.BackColor = System.Drawing.Color.White;
            this.buttonSaveAutoPlan.BackgroundColor = System.Drawing.Color.White;
            this.buttonSaveAutoPlan.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonSaveAutoPlan.BorderRadius = 20;
            this.buttonSaveAutoPlan.BorderSize = 0;
            this.buttonSaveAutoPlan.FlatAppearance.BorderSize = 0;
            this.buttonSaveAutoPlan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(138)))), ((int)(((byte)(77)))));
            this.buttonSaveAutoPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveAutoPlan.Font = new System.Drawing.Font("Circe", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSaveAutoPlan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(36)))), ((int)(((byte)(19)))));
            this.buttonSaveAutoPlan.Location = new System.Drawing.Point(30, 391);
            this.buttonSaveAutoPlan.Name = "buttonSaveAutoPlan";
            this.buttonSaveAutoPlan.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.buttonSaveAutoPlan.Size = new System.Drawing.Size(190, 85);
            this.buttonSaveAutoPlan.TabIndex = 6;
            this.buttonSaveAutoPlan.Text = "Сохранить изменённый план";
            this.buttonSaveAutoPlan.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(36)))), ((int)(((byte)(19)))));
            this.buttonSaveAutoPlan.UseVisualStyleBackColor = false;
            this.buttonSaveAutoPlan.Click += new System.EventHandler(this.buttonSaveAutoPlan_Click);
            this.buttonSaveAutoPlan.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.buttonSaveAutoPlan.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // buttonDownloadReport
            // 
            this.buttonDownloadReport.BackColor = System.Drawing.Color.White;
            this.buttonDownloadReport.BackgroundColor = System.Drawing.Color.White;
            this.buttonDownloadReport.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonDownloadReport.BorderRadius = 20;
            this.buttonDownloadReport.BorderSize = 0;
            this.buttonDownloadReport.FlatAppearance.BorderSize = 0;
            this.buttonDownloadReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(138)))), ((int)(((byte)(77)))));
            this.buttonDownloadReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDownloadReport.Font = new System.Drawing.Font("Circe", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDownloadReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(36)))), ((int)(((byte)(19)))));
            this.buttonDownloadReport.Location = new System.Drawing.Point(30, 277);
            this.buttonDownloadReport.Name = "buttonDownloadReport";
            this.buttonDownloadReport.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.buttonDownloadReport.Size = new System.Drawing.Size(190, 85);
            this.buttonDownloadReport.TabIndex = 5;
            this.buttonDownloadReport.Text = "Загрузить отчёт для автоплана";
            this.buttonDownloadReport.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(36)))), ((int)(((byte)(19)))));
            this.buttonDownloadReport.UseVisualStyleBackColor = false;
            this.buttonDownloadReport.Click += new System.EventHandler(this.buttonDownloadReport_Click);
            this.buttonDownloadReport.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.buttonDownloadReport.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(249, 28);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1098, 725);
            this.panel1.TabIndex = 6;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1347, 753);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкаЗначенийДляПлановогоПоказателяToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panel1;
        private MyControls.CustomBTN buttonAutoPlan;
        private MyControls.CustomBTN buttonCreateReport;
        private MyControls.CustomBTN buttonSaveAutoPlan;
        private MyControls.CustomBTN buttonDownloadReport;
        private System.Windows.Forms.Panel panel2;
    }
}

