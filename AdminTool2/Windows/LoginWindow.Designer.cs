namespace AdminTool2.Windows
{
    partial class LoginWindow
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
            this.labelStatus = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.customBTN1 = new AdminTool2.MyControls.CustomBTN();
            this.passwordTextBox = new AdminTool2.MyControls.RoundTB();
            this.usernameTextBox = new AdminTool2.MyControls.RoundTB();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelStatus
            // 
            this.labelStatus.Font = new System.Drawing.Font("Circe", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStatus.ForeColor = System.Drawing.Color.Red;
            this.labelStatus.Location = new System.Drawing.Point(3, 404);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(535, 23);
            this.labelStatus.TabIndex = 3;
            this.labelStatus.Text = "label1";
            this.labelStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelStatus.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(173)))), ((int)(((byte)(96)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(552, 594);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.labelStatus);
            this.panel2.Controls.Add(this.customBTN1);
            this.panel2.Controls.Add(this.passwordTextBox);
            this.panel2.Controls.Add(this.usernameTextBox);
            this.panel2.Location = new System.Drawing.Point(5, 5);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(542, 584);
            this.panel2.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::AdminTool2.Properties.Resources.logo_1;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Location = new System.Drawing.Point(3, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(535, 68);
            this.panel3.TabIndex = 9;
            // 
            // customBTN1
            // 
            this.customBTN1.BackColor = System.Drawing.Color.White;
            this.customBTN1.BackgroundColor = System.Drawing.Color.White;
            this.customBTN1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(173)))), ((int)(((byte)(96)))));
            this.customBTN1.BorderRadius = 28;
            this.customBTN1.BorderSize = 2;
            this.customBTN1.FlatAppearance.BorderSize = 0;
            this.customBTN1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(173)))), ((int)(((byte)(96)))));
            this.customBTN1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customBTN1.Font = new System.Drawing.Font("Circe", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.customBTN1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(36)))), ((int)(((byte)(19)))));
            this.customBTN1.Location = new System.Drawing.Point(106, 446);
            this.customBTN1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.customBTN1.Name = "customBTN1";
            this.customBTN1.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.customBTN1.Size = new System.Drawing.Size(340, 57);
            this.customBTN1.TabIndex = 4;
            this.customBTN1.Text = "ВОЙТИ";
            this.customBTN1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(36)))), ((int)(((byte)(19)))));
            this.customBTN1.UseVisualStyleBackColor = false;
            this.customBTN1.Click += new System.EventHandler(this.loginButton_Click);
            this.customBTN1.MouseEnter += new System.EventHandler(this.customBTN1_MouseEnter);
            this.customBTN1.MouseLeave += new System.EventHandler(this.customBTN1_MouseLeave);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.Color.White;
            this.passwordTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(36)))), ((int)(((byte)(19)))));
            this.passwordTextBox.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(36)))), ((int)(((byte)(19)))));
            this.passwordTextBox.BorderRadius = 28;
            this.passwordTextBox.BorderSize = 2;
            this.passwordTextBox.Font = new System.Drawing.Font("Circe", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(53)))));
            this.passwordTextBox.Location = new System.Drawing.Point(106, 330);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.passwordTextBox.Multiline = false;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Padding = new System.Windows.Forms.Padding(20, 12, 20, 7);
            this.passwordTextBox.PasswordChar = true;
            this.passwordTextBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.passwordTextBox.PlaceholderText = "";
            this.passwordTextBox.Size = new System.Drawing.Size(340, 56);
            this.passwordTextBox.TabIndex = 8;
            this.passwordTextBox.Texts = "Пароль";
            this.passwordTextBox.UnderlinedStyle = false;
            this.passwordTextBox.MouseEnter += new System.EventHandler(this.textBox_MouseEnter);
            this.passwordTextBox.MouseLeave += new System.EventHandler(this.textBox_MouseLeave);
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.usernameTextBox.BackColor = System.Drawing.Color.White;
            this.usernameTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(36)))), ((int)(((byte)(19)))));
            this.usernameTextBox.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(36)))), ((int)(((byte)(19)))));
            this.usernameTextBox.BorderRadius = 28;
            this.usernameTextBox.BorderSize = 2;
            this.usernameTextBox.Font = new System.Drawing.Font("Circe", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usernameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(53)))));
            this.usernameTextBox.Location = new System.Drawing.Point(106, 253);
            this.usernameTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.usernameTextBox.Multiline = false;
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Padding = new System.Windows.Forms.Padding(20, 12, 20, 7);
            this.usernameTextBox.PasswordChar = false;
            this.usernameTextBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.usernameTextBox.PlaceholderText = "";
            this.usernameTextBox.Size = new System.Drawing.Size(340, 56);
            this.usernameTextBox.TabIndex = 5;
            this.usernameTextBox.Texts = "Логин";
            this.usernameTextBox.UnderlinedStyle = false;
            this.usernameTextBox.MouseEnter += new System.EventHandler(this.textBox_MouseEnter);
            this.usernameTextBox.MouseLeave += new System.EventHandler(this.textBox_MouseLeave);
            // 
            // LoginWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(576, 617);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LoginWindow";
            this.Text = "LoginWindow";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelStatus;
        private MyControls.CustomBTN customBTN1;
        private MyControls.RoundTB usernameTextBox;
        private MyControls.RoundTB passwordTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}