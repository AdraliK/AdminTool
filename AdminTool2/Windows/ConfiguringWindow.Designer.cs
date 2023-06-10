namespace AdminTool2
{
    partial class ConfiguringWindow
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
            this.textBox_T_MM = new System.Windows.Forms.TextBox();
            this.textBox_EB_MM = new System.Windows.Forms.TextBox();
            this.textBox_T_C = new System.Windows.Forms.TextBox();
            this.textBox_EB_C = new System.Windows.Forms.TextBox();
            this.textBox_T_K = new System.Windows.Forms.TextBox();
            this.textBox_EB_K = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_T_MM
            // 
            this.textBox_T_MM.Location = new System.Drawing.Point(45, 78);
            this.textBox_T_MM.Name = "textBox_T_MM";
            this.textBox_T_MM.Size = new System.Drawing.Size(67, 22);
            this.textBox_T_MM.TabIndex = 0;
            // 
            // textBox_EB_MM
            // 
            this.textBox_EB_MM.Location = new System.Drawing.Point(187, 78);
            this.textBox_EB_MM.Name = "textBox_EB_MM";
            this.textBox_EB_MM.Size = new System.Drawing.Size(67, 22);
            this.textBox_EB_MM.TabIndex = 1;
            // 
            // textBox_T_C
            // 
            this.textBox_T_C.Location = new System.Drawing.Point(45, 133);
            this.textBox_T_C.Name = "textBox_T_C";
            this.textBox_T_C.Size = new System.Drawing.Size(67, 22);
            this.textBox_T_C.TabIndex = 2;
            // 
            // textBox_EB_C
            // 
            this.textBox_EB_C.Location = new System.Drawing.Point(187, 133);
            this.textBox_EB_C.Name = "textBox_EB_C";
            this.textBox_EB_C.Size = new System.Drawing.Size(67, 22);
            this.textBox_EB_C.TabIndex = 3;
            // 
            // textBox_T_K
            // 
            this.textBox_T_K.Location = new System.Drawing.Point(45, 194);
            this.textBox_T_K.Name = "textBox_T_K";
            this.textBox_T_K.Size = new System.Drawing.Size(67, 22);
            this.textBox_T_K.TabIndex = 4;
            // 
            // textBox_EB_K
            // 
            this.textBox_EB_K.Location = new System.Drawing.Point(187, 194);
            this.textBox_EB_K.Name = "textBox_EB_K";
            this.textBox_EB_K.Size = new System.Drawing.Size(67, 22);
            this.textBox_EB_K.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Целевое значение";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Точка безубыточности";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(299, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Микромаркеты";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(299, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Кофе";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(299, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Киоски";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(163, 246);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(121, 40);
            this.saveButton.TabIndex = 11;
            this.saveButton.Text = "Прменить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // ConfiguringWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 307);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_EB_K);
            this.Controls.Add(this.textBox_T_K);
            this.Controls.Add(this.textBox_EB_C);
            this.Controls.Add(this.textBox_T_C);
            this.Controls.Add(this.textBox_EB_MM);
            this.Controls.Add(this.textBox_T_MM);
            this.Name = "ConfiguringWindow";
            this.Text = "ConfiguringWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_T_MM;
        private System.Windows.Forms.TextBox textBox_EB_MM;
        private System.Windows.Forms.TextBox textBox_T_C;
        private System.Windows.Forms.TextBox textBox_EB_C;
        private System.Windows.Forms.TextBox textBox_T_K;
        private System.Windows.Forms.TextBox textBox_EB_K;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button saveButton;
    }
}