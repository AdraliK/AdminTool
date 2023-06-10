namespace AdminTool2
{
    partial class SummaryUserControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelProceedsLastNow_Value = new System.Windows.Forms.Label();
            this.labelProceedsLastNow = new System.Windows.Forms.Label();
            this.labelProceedsLast_Value = new System.Windows.Forms.Label();
            this.labelProceedsLast = new System.Windows.Forms.Label();
            this.labelProceedsNow_Value = new System.Windows.Forms.Label();
            this.labelProceedsNow = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelAVGReceiptLastNow_Value = new System.Windows.Forms.Label();
            this.labelAVGReceiptLastNow = new System.Windows.Forms.Label();
            this.labelAVGReceiptLast_Value = new System.Windows.Forms.Label();
            this.labelAVGReceiptLast = new System.Windows.Forms.Label();
            this.labelAVGReceiptNow_Value = new System.Windows.Forms.Label();
            this.labelAVGReceiptNow = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelPoint5_Value = new System.Windows.Forms.Label();
            this.labelPoint5 = new System.Windows.Forms.Label();
            this.labelPoint4_Value = new System.Windows.Forms.Label();
            this.labelPoint4 = new System.Windows.Forms.Label();
            this.labelPoint3_Value = new System.Windows.Forms.Label();
            this.labelPoint3 = new System.Windows.Forms.Label();
            this.labelPoint2_Value = new System.Windows.Forms.Label();
            this.labelPoint2 = new System.Windows.Forms.Label();
            this.labelPoint1_Value = new System.Windows.Forms.Label();
            this.labelPoint1 = new System.Windows.Forms.Label();
            this.labelTopPoints = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelCointPositionsLastNow = new System.Windows.Forms.Label();
            this.labelCointPositionsLast = new System.Windows.Forms.Label();
            this.labelCointPositionsLastNow_Value = new System.Windows.Forms.Label();
            this.labelCointPositionsLast_Value = new System.Windows.Forms.Label();
            this.labelCointPositionsNow_Value = new System.Windows.Forms.Label();
            this.labelCointPositionsNow = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.labelPos5_Value = new System.Windows.Forms.Label();
            this.labelPos5 = new System.Windows.Forms.Label();
            this.labelPos4_Value = new System.Windows.Forms.Label();
            this.labelPos4 = new System.Windows.Forms.Label();
            this.labelPos3_Value = new System.Windows.Forms.Label();
            this.labelPos3 = new System.Windows.Forms.Label();
            this.labelPos2_Value = new System.Windows.Forms.Label();
            this.labelPos2 = new System.Windows.Forms.Label();
            this.labelPos1_Value = new System.Windows.Forms.Label();
            this.labelPos1 = new System.Windows.Forms.Label();
            this.labelTopPositions = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.labelDate1 = new System.Windows.Forms.Label();
            this.labelDate2 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.buttonAccept = new AdminTool2.MyControls.CustomBTN();
            this.buttonMonth = new AdminTool2.MyControls.CustomBTN();
            this.buttonWeek = new AdminTool2.MyControls.CustomBTN();
            this.buttonNowDay = new AdminTool2.MyControls.CustomBTN();
            this.buttonLastDay = new AdminTool2.MyControls.CustomBTN();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(173)))), ((int)(((byte)(96)))));
            this.panel1.Controls.Add(this.labelProceedsLastNow_Value);
            this.panel1.Controls.Add(this.labelProceedsLastNow);
            this.panel1.Controls.Add(this.labelProceedsLast_Value);
            this.panel1.Controls.Add(this.labelProceedsLast);
            this.panel1.Controls.Add(this.labelProceedsNow_Value);
            this.panel1.Controls.Add(this.labelProceedsNow);
            this.panel1.Location = new System.Drawing.Point(36, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 280);
            this.panel1.TabIndex = 4;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            this.panel1.MouseEnter += new System.EventHandler(this.panel_MouseEnter);
            this.panel1.MouseLeave += new System.EventHandler(this.panel_MouseLeave);
            // 
            // labelProceedsLastNow_Value
            // 
            this.labelProceedsLastNow_Value.AutoSize = true;
            this.labelProceedsLastNow_Value.Location = new System.Drawing.Point(199, 210);
            this.labelProceedsLastNow_Value.Name = "labelProceedsLastNow_Value";
            this.labelProceedsLastNow_Value.Size = new System.Drawing.Size(51, 16);
            this.labelProceedsLastNow_Value.TabIndex = 5;
            this.labelProceedsLastNow_Value.Text = "label19";
            // 
            // labelProceedsLastNow
            // 
            this.labelProceedsLastNow.AutoSize = true;
            this.labelProceedsLastNow.Location = new System.Drawing.Point(199, 168);
            this.labelProceedsLastNow.Name = "labelProceedsLastNow";
            this.labelProceedsLastNow.Size = new System.Drawing.Size(98, 16);
            this.labelProceedsLastNow.TabIndex = 4;
            this.labelProceedsLastNow.Text = "(прошлая now)";
            // 
            // labelProceedsLast_Value
            // 
            this.labelProceedsLast_Value.AutoSize = true;
            this.labelProceedsLast_Value.Font = new System.Drawing.Font("Circe", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelProceedsLast_Value.ForeColor = System.Drawing.Color.White;
            this.labelProceedsLast_Value.Location = new System.Drawing.Point(18, 210);
            this.labelProceedsLast_Value.Name = "labelProceedsLast_Value";
            this.labelProceedsLast_Value.Size = new System.Drawing.Size(110, 45);
            this.labelProceedsLast_Value.TabIndex = 3;
            this.labelProceedsLast_Value.Text = "label17";
            // 
            // labelProceedsLast
            // 
            this.labelProceedsLast.AutoSize = true;
            this.labelProceedsLast.Font = new System.Drawing.Font("Circe", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelProceedsLast.ForeColor = System.Drawing.Color.White;
            this.labelProceedsLast.Location = new System.Drawing.Point(18, 168);
            this.labelProceedsLast.Name = "labelProceedsLast";
            this.labelProceedsLast.Size = new System.Drawing.Size(142, 45);
            this.labelProceedsLast.TabIndex = 2;
            this.labelProceedsLast.Text = "Прошлая";
            // 
            // labelProceedsNow_Value
            // 
            this.labelProceedsNow_Value.AutoSize = true;
            this.labelProceedsNow_Value.Font = new System.Drawing.Font("Circe", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelProceedsNow_Value.ForeColor = System.Drawing.Color.White;
            this.labelProceedsNow_Value.Location = new System.Drawing.Point(18, 60);
            this.labelProceedsNow_Value.Name = "labelProceedsNow_Value";
            this.labelProceedsNow_Value.Size = new System.Drawing.Size(100, 45);
            this.labelProceedsNow_Value.TabIndex = 1;
            this.labelProceedsNow_Value.Text = "label2";
            // 
            // labelProceedsNow
            // 
            this.labelProceedsNow.AutoSize = true;
            this.labelProceedsNow.Font = new System.Drawing.Font("Circe", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelProceedsNow.ForeColor = System.Drawing.Color.White;
            this.labelProceedsNow.Location = new System.Drawing.Point(18, 15);
            this.labelProceedsNow.Name = "labelProceedsNow";
            this.labelProceedsNow.Size = new System.Drawing.Size(205, 45);
            this.labelProceedsNow.TabIndex = 0;
            this.labelProceedsNow.Text = "Выручка, руб";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(173)))), ((int)(((byte)(96)))));
            this.panel2.Controls.Add(this.labelAVGReceiptLastNow_Value);
            this.panel2.Controls.Add(this.labelAVGReceiptLastNow);
            this.panel2.Controls.Add(this.labelAVGReceiptLast_Value);
            this.panel2.Controls.Add(this.labelAVGReceiptLast);
            this.panel2.Controls.Add(this.labelAVGReceiptNow_Value);
            this.panel2.Controls.Add(this.labelAVGReceiptNow);
            this.panel2.Location = new System.Drawing.Point(376, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(320, 280);
            this.panel2.TabIndex = 5;
            this.panel2.Click += new System.EventHandler(this.panel2_Click);
            this.panel2.MouseEnter += new System.EventHandler(this.panel_MouseEnter);
            this.panel2.MouseLeave += new System.EventHandler(this.panel_MouseLeave);
            // 
            // labelAVGReceiptLastNow_Value
            // 
            this.labelAVGReceiptLastNow_Value.AutoSize = true;
            this.labelAVGReceiptLastNow_Value.Location = new System.Drawing.Point(190, 200);
            this.labelAVGReceiptLastNow_Value.Name = "labelAVGReceiptLastNow_Value";
            this.labelAVGReceiptLastNow_Value.Size = new System.Drawing.Size(51, 16);
            this.labelAVGReceiptLastNow_Value.TabIndex = 5;
            this.labelAVGReceiptLastNow_Value.Text = "label23";
            // 
            // labelAVGReceiptLastNow
            // 
            this.labelAVGReceiptLastNow.AutoSize = true;
            this.labelAVGReceiptLastNow.Location = new System.Drawing.Point(190, 168);
            this.labelAVGReceiptLastNow.Name = "labelAVGReceiptLastNow";
            this.labelAVGReceiptLastNow.Size = new System.Drawing.Size(98, 16);
            this.labelAVGReceiptLastNow.TabIndex = 4;
            this.labelAVGReceiptLastNow.Text = "(прошлая now)";
            // 
            // labelAVGReceiptLast_Value
            // 
            this.labelAVGReceiptLast_Value.AutoSize = true;
            this.labelAVGReceiptLast_Value.Font = new System.Drawing.Font("Circe", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAVGReceiptLast_Value.ForeColor = System.Drawing.Color.White;
            this.labelAVGReceiptLast_Value.Location = new System.Drawing.Point(20, 210);
            this.labelAVGReceiptLast_Value.Name = "labelAVGReceiptLast_Value";
            this.labelAVGReceiptLast_Value.Size = new System.Drawing.Size(111, 45);
            this.labelAVGReceiptLast_Value.TabIndex = 3;
            this.labelAVGReceiptLast_Value.Text = "label21";
            // 
            // labelAVGReceiptLast
            // 
            this.labelAVGReceiptLast.AutoSize = true;
            this.labelAVGReceiptLast.Font = new System.Drawing.Font("Circe", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAVGReceiptLast.ForeColor = System.Drawing.Color.White;
            this.labelAVGReceiptLast.Location = new System.Drawing.Point(19, 168);
            this.labelAVGReceiptLast.Name = "labelAVGReceiptLast";
            this.labelAVGReceiptLast.Size = new System.Drawing.Size(150, 45);
            this.labelAVGReceiptLast.TabIndex = 2;
            this.labelAVGReceiptLast.Text = "Прошлый";
            // 
            // labelAVGReceiptNow_Value
            // 
            this.labelAVGReceiptNow_Value.AutoSize = true;
            this.labelAVGReceiptNow_Value.Font = new System.Drawing.Font("Circe", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAVGReceiptNow_Value.ForeColor = System.Drawing.Color.White;
            this.labelAVGReceiptNow_Value.Location = new System.Drawing.Point(19, 63);
            this.labelAVGReceiptNow_Value.Name = "labelAVGReceiptNow_Value";
            this.labelAVGReceiptNow_Value.Size = new System.Drawing.Size(100, 45);
            this.labelAVGReceiptNow_Value.TabIndex = 1;
            this.labelAVGReceiptNow_Value.Text = "label3";
            // 
            // labelAVGReceiptNow
            // 
            this.labelAVGReceiptNow.AutoSize = true;
            this.labelAVGReceiptNow.Font = new System.Drawing.Font("Circe", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAVGReceiptNow.ForeColor = System.Drawing.Color.White;
            this.labelAVGReceiptNow.Location = new System.Drawing.Point(19, 15);
            this.labelAVGReceiptNow.Name = "labelAVGReceiptNow";
            this.labelAVGReceiptNow.Size = new System.Drawing.Size(269, 45);
            this.labelAVGReceiptNow.TabIndex = 0;
            this.labelAVGReceiptNow.Text = "Средний чек, руб";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(173)))), ((int)(((byte)(96)))));
            this.panel3.Controls.Add(this.labelPoint5_Value);
            this.panel3.Controls.Add(this.labelPoint5);
            this.panel3.Controls.Add(this.labelPoint4_Value);
            this.panel3.Controls.Add(this.labelPoint4);
            this.panel3.Controls.Add(this.labelPoint3_Value);
            this.panel3.Controls.Add(this.labelPoint3);
            this.panel3.Controls.Add(this.labelPoint2_Value);
            this.panel3.Controls.Add(this.labelPoint2);
            this.panel3.Controls.Add(this.labelPoint1_Value);
            this.panel3.Controls.Add(this.labelPoint1);
            this.panel3.Controls.Add(this.labelTopPoints);
            this.panel3.Location = new System.Drawing.Point(36, 403);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(320, 280);
            this.panel3.TabIndex = 6;
            this.panel3.Click += new System.EventHandler(this.panel3_Click);
            this.panel3.MouseEnter += new System.EventHandler(this.panel_MouseEnter);
            this.panel3.MouseLeave += new System.EventHandler(this.panel_MouseLeave);
            // 
            // labelPoint5_Value
            // 
            this.labelPoint5_Value.AutoSize = true;
            this.labelPoint5_Value.Font = new System.Drawing.Font("Circe", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPoint5_Value.ForeColor = System.Drawing.Color.White;
            this.labelPoint5_Value.Location = new System.Drawing.Point(236, 165);
            this.labelPoint5_Value.Name = "labelPoint5_Value";
            this.labelPoint5_Value.Size = new System.Drawing.Size(60, 25);
            this.labelPoint5_Value.TabIndex = 10;
            this.labelPoint5_Value.Text = "label11";
            // 
            // labelPoint5
            // 
            this.labelPoint5.AutoSize = true;
            this.labelPoint5.Font = new System.Drawing.Font("Circe", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPoint5.ForeColor = System.Drawing.Color.White;
            this.labelPoint5.Location = new System.Drawing.Point(28, 165);
            this.labelPoint5.Name = "labelPoint5";
            this.labelPoint5.Size = new System.Drawing.Size(70, 25);
            this.labelPoint5.TabIndex = 9;
            this.labelPoint5.Text = "label12";
            // 
            // labelPoint4_Value
            // 
            this.labelPoint4_Value.AutoSize = true;
            this.labelPoint4_Value.Font = new System.Drawing.Font("Circe", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPoint4_Value.ForeColor = System.Drawing.Color.White;
            this.labelPoint4_Value.Location = new System.Drawing.Point(236, 206);
            this.labelPoint4_Value.Name = "labelPoint4_Value";
            this.labelPoint4_Value.Size = new System.Drawing.Size(63, 25);
            this.labelPoint4_Value.TabIndex = 8;
            this.labelPoint4_Value.Text = "label13";
            // 
            // labelPoint4
            // 
            this.labelPoint4.AutoSize = true;
            this.labelPoint4.Font = new System.Drawing.Font("Circe", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPoint4.ForeColor = System.Drawing.Color.White;
            this.labelPoint4.Location = new System.Drawing.Point(27, 206);
            this.labelPoint4.Name = "labelPoint4";
            this.labelPoint4.Size = new System.Drawing.Size(70, 25);
            this.labelPoint4.TabIndex = 7;
            this.labelPoint4.Text = "label14";
            // 
            // labelPoint3_Value
            // 
            this.labelPoint3_Value.AutoSize = true;
            this.labelPoint3_Value.Font = new System.Drawing.Font("Circe", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPoint3_Value.ForeColor = System.Drawing.Color.White;
            this.labelPoint3_Value.Location = new System.Drawing.Point(236, 243);
            this.labelPoint3_Value.Name = "labelPoint3_Value";
            this.labelPoint3_Value.Size = new System.Drawing.Size(63, 25);
            this.labelPoint3_Value.TabIndex = 6;
            this.labelPoint3_Value.Text = "label15";
            // 
            // labelPoint3
            // 
            this.labelPoint3.AutoSize = true;
            this.labelPoint3.Font = new System.Drawing.Font("Circe", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPoint3.ForeColor = System.Drawing.Color.White;
            this.labelPoint3.Location = new System.Drawing.Point(28, 243);
            this.labelPoint3.Name = "labelPoint3";
            this.labelPoint3.Size = new System.Drawing.Size(71, 25);
            this.labelPoint3.TabIndex = 5;
            this.labelPoint3.Text = "label10";
            // 
            // labelPoint2_Value
            // 
            this.labelPoint2_Value.AutoSize = true;
            this.labelPoint2_Value.Font = new System.Drawing.Font("Circe", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPoint2_Value.ForeColor = System.Drawing.Color.White;
            this.labelPoint2_Value.Location = new System.Drawing.Point(236, 127);
            this.labelPoint2_Value.Name = "labelPoint2_Value";
            this.labelPoint2_Value.Size = new System.Drawing.Size(57, 25);
            this.labelPoint2_Value.TabIndex = 4;
            this.labelPoint2_Value.Text = "label9";
            // 
            // labelPoint2
            // 
            this.labelPoint2.AutoSize = true;
            this.labelPoint2.Font = new System.Drawing.Font("Circe", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPoint2.ForeColor = System.Drawing.Color.White;
            this.labelPoint2.Location = new System.Drawing.Point(27, 127);
            this.labelPoint2.Name = "labelPoint2";
            this.labelPoint2.Size = new System.Drawing.Size(64, 25);
            this.labelPoint2.TabIndex = 3;
            this.labelPoint2.Text = "label8";
            // 
            // labelPoint1_Value
            // 
            this.labelPoint1_Value.AutoSize = true;
            this.labelPoint1_Value.Font = new System.Drawing.Font("Circe", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPoint1_Value.ForeColor = System.Drawing.Color.White;
            this.labelPoint1_Value.Location = new System.Drawing.Point(236, 90);
            this.labelPoint1_Value.Name = "labelPoint1_Value";
            this.labelPoint1_Value.Size = new System.Drawing.Size(56, 25);
            this.labelPoint1_Value.TabIndex = 2;
            this.labelPoint1_Value.Text = "label7";
            // 
            // labelPoint1
            // 
            this.labelPoint1.AutoSize = true;
            this.labelPoint1.Font = new System.Drawing.Font("Circe", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPoint1.ForeColor = System.Drawing.Color.White;
            this.labelPoint1.Location = new System.Drawing.Point(28, 90);
            this.labelPoint1.Name = "labelPoint1";
            this.labelPoint1.Size = new System.Drawing.Size(63, 25);
            this.labelPoint1.TabIndex = 1;
            this.labelPoint1.Text = "label5";
            // 
            // labelTopPoints
            // 
            this.labelTopPoints.AutoSize = true;
            this.labelTopPoints.Font = new System.Drawing.Font("Circe", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTopPoints.ForeColor = System.Drawing.Color.White;
            this.labelTopPoints.Location = new System.Drawing.Point(25, 20);
            this.labelTopPoints.Name = "labelTopPoints";
            this.labelTopPoints.Size = new System.Drawing.Size(220, 45);
            this.labelTopPoints.TabIndex = 0;
            this.labelTopPoints.Text = "Лучшие точки";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(173)))), ((int)(((byte)(96)))));
            this.panel4.Controls.Add(this.labelCointPositionsLastNow);
            this.panel4.Controls.Add(this.labelCointPositionsLast);
            this.panel4.Controls.Add(this.labelCointPositionsLastNow_Value);
            this.panel4.Controls.Add(this.labelCointPositionsLast_Value);
            this.panel4.Controls.Add(this.labelCointPositionsNow_Value);
            this.panel4.Controls.Add(this.labelCointPositionsNow);
            this.panel4.Location = new System.Drawing.Point(717, 100);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(320, 280);
            this.panel4.TabIndex = 6;
            this.panel4.MouseEnter += new System.EventHandler(this.panel_MouseEnter);
            this.panel4.MouseLeave += new System.EventHandler(this.panel_MouseLeave);
            // 
            // labelCointPositionsLastNow
            // 
            this.labelCointPositionsLastNow.AutoSize = true;
            this.labelCointPositionsLastNow.Location = new System.Drawing.Point(196, 178);
            this.labelCointPositionsLastNow.Name = "labelCointPositionsLastNow";
            this.labelCointPositionsLastNow.Size = new System.Drawing.Size(98, 16);
            this.labelCointPositionsLastNow.TabIndex = 6;
            this.labelCointPositionsLastNow.Text = "(прошлая now)";
            // 
            // labelCointPositionsLast
            // 
            this.labelCointPositionsLast.AutoSize = true;
            this.labelCointPositionsLast.Font = new System.Drawing.Font("Circe", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCointPositionsLast.ForeColor = System.Drawing.Color.White;
            this.labelCointPositionsLast.Location = new System.Drawing.Point(17, 168);
            this.labelCointPositionsLast.Name = "labelCointPositionsLast";
            this.labelCointPositionsLast.Size = new System.Drawing.Size(147, 45);
            this.labelCointPositionsLast.TabIndex = 6;
            this.labelCointPositionsLast.Text = "Прошлое";
            // 
            // labelCointPositionsLastNow_Value
            // 
            this.labelCointPositionsLastNow_Value.AutoSize = true;
            this.labelCointPositionsLastNow_Value.Location = new System.Drawing.Point(197, 210);
            this.labelCointPositionsLastNow_Value.Name = "labelCointPositionsLastNow_Value";
            this.labelCointPositionsLastNow_Value.Size = new System.Drawing.Size(51, 16);
            this.labelCointPositionsLastNow_Value.TabIndex = 5;
            this.labelCointPositionsLastNow_Value.Text = "label24";
            // 
            // labelCointPositionsLast_Value
            // 
            this.labelCointPositionsLast_Value.AutoSize = true;
            this.labelCointPositionsLast_Value.Font = new System.Drawing.Font("Circe", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCointPositionsLast_Value.ForeColor = System.Drawing.Color.White;
            this.labelCointPositionsLast_Value.Location = new System.Drawing.Point(18, 210);
            this.labelCointPositionsLast_Value.Name = "labelCointPositionsLast_Value";
            this.labelCointPositionsLast_Value.Size = new System.Drawing.Size(117, 45);
            this.labelCointPositionsLast_Value.TabIndex = 3;
            this.labelCointPositionsLast_Value.Text = "label26";
            // 
            // labelCointPositionsNow_Value
            // 
            this.labelCointPositionsNow_Value.AutoSize = true;
            this.labelCointPositionsNow_Value.Font = new System.Drawing.Font("Circe", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCointPositionsNow_Value.ForeColor = System.Drawing.Color.White;
            this.labelCointPositionsNow_Value.Location = new System.Drawing.Point(17, 108);
            this.labelCointPositionsNow_Value.Name = "labelCointPositionsNow_Value";
            this.labelCointPositionsNow_Value.Size = new System.Drawing.Size(118, 45);
            this.labelCointPositionsNow_Value.TabIndex = 1;
            this.labelCointPositionsNow_Value.Text = "label28";
            // 
            // labelCointPositionsNow
            // 
            this.labelCointPositionsNow.Font = new System.Drawing.Font("Circe", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCointPositionsNow.ForeColor = System.Drawing.Color.White;
            this.labelCointPositionsNow.Location = new System.Drawing.Point(18, 17);
            this.labelCointPositionsNow.Name = "labelCointPositionsNow";
            this.labelCointPositionsNow.Size = new System.Drawing.Size(276, 91);
            this.labelCointPositionsNow.TabIndex = 0;
            this.labelCointPositionsNow.Text = "Количество позиций, шт";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(173)))), ((int)(((byte)(96)))));
            this.panel5.Controls.Add(this.labelPos5_Value);
            this.panel5.Controls.Add(this.labelPos5);
            this.panel5.Controls.Add(this.labelPos4_Value);
            this.panel5.Controls.Add(this.labelPos4);
            this.panel5.Controls.Add(this.labelPos3_Value);
            this.panel5.Controls.Add(this.labelPos3);
            this.panel5.Controls.Add(this.labelPos2_Value);
            this.panel5.Controls.Add(this.labelPos2);
            this.panel5.Controls.Add(this.labelPos1_Value);
            this.panel5.Controls.Add(this.labelPos1);
            this.panel5.Controls.Add(this.labelTopPositions);
            this.panel5.Location = new System.Drawing.Point(376, 403);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(320, 280);
            this.panel5.TabIndex = 11;
            this.panel5.Click += new System.EventHandler(this.panel5_Click);
            this.panel5.MouseEnter += new System.EventHandler(this.panel_MouseEnter);
            this.panel5.MouseLeave += new System.EventHandler(this.panel_MouseLeave);
            // 
            // labelPos5_Value
            // 
            this.labelPos5_Value.AutoSize = true;
            this.labelPos5_Value.Font = new System.Drawing.Font("Circe", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPos5_Value.ForeColor = System.Drawing.Color.White;
            this.labelPos5_Value.Location = new System.Drawing.Point(238, 243);
            this.labelPos5_Value.Name = "labelPos5_Value";
            this.labelPos5_Value.Size = new System.Drawing.Size(67, 25);
            this.labelPos5_Value.TabIndex = 10;
            this.labelPos5_Value.Text = "label30";
            // 
            // labelPos5
            // 
            this.labelPos5.AutoSize = true;
            this.labelPos5.Font = new System.Drawing.Font("Circe", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPos5.ForeColor = System.Drawing.Color.White;
            this.labelPos5.Location = new System.Drawing.Point(20, 243);
            this.labelPos5.Name = "labelPos5";
            this.labelPos5.Size = new System.Drawing.Size(70, 25);
            this.labelPos5.TabIndex = 9;
            this.labelPos5.Text = "label31";
            // 
            // labelPos4_Value
            // 
            this.labelPos4_Value.AutoSize = true;
            this.labelPos4_Value.Font = new System.Drawing.Font("Circe", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPos4_Value.ForeColor = System.Drawing.Color.White;
            this.labelPos4_Value.Location = new System.Drawing.Point(239, 206);
            this.labelPos4_Value.Name = "labelPos4_Value";
            this.labelPos4_Value.Size = new System.Drawing.Size(66, 25);
            this.labelPos4_Value.TabIndex = 8;
            this.labelPos4_Value.Text = "label32";
            // 
            // labelPos4
            // 
            this.labelPos4.AutoSize = true;
            this.labelPos4.Font = new System.Drawing.Font("Circe", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPos4.ForeColor = System.Drawing.Color.White;
            this.labelPos4.Location = new System.Drawing.Point(21, 206);
            this.labelPos4.Name = "labelPos4";
            this.labelPos4.Size = new System.Drawing.Size(73, 25);
            this.labelPos4.TabIndex = 7;
            this.labelPos4.Text = "label33";
            // 
            // labelPos3_Value
            // 
            this.labelPos3_Value.AutoSize = true;
            this.labelPos3_Value.Font = new System.Drawing.Font("Circe", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPos3_Value.ForeColor = System.Drawing.Color.White;
            this.labelPos3_Value.Location = new System.Drawing.Point(239, 165);
            this.labelPos3_Value.Name = "labelPos3_Value";
            this.labelPos3_Value.Size = new System.Drawing.Size(66, 25);
            this.labelPos3_Value.TabIndex = 6;
            this.labelPos3_Value.Text = "label34";
            // 
            // labelPos3
            // 
            this.labelPos3.AutoSize = true;
            this.labelPos3.Font = new System.Drawing.Font("Circe", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPos3.ForeColor = System.Drawing.Color.White;
            this.labelPos3.Location = new System.Drawing.Point(21, 165);
            this.labelPos3.Name = "labelPos3";
            this.labelPos3.Size = new System.Drawing.Size(73, 25);
            this.labelPos3.TabIndex = 5;
            this.labelPos3.Text = "label35";
            // 
            // labelPos2_Value
            // 
            this.labelPos2_Value.AutoSize = true;
            this.labelPos2_Value.Font = new System.Drawing.Font("Circe", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPos2_Value.ForeColor = System.Drawing.Color.White;
            this.labelPos2_Value.Location = new System.Drawing.Point(239, 127);
            this.labelPos2_Value.Name = "labelPos2_Value";
            this.labelPos2_Value.Size = new System.Drawing.Size(66, 25);
            this.labelPos2_Value.TabIndex = 4;
            this.labelPos2_Value.Text = "label36";
            // 
            // labelPos2
            // 
            this.labelPos2.AutoSize = true;
            this.labelPos2.Font = new System.Drawing.Font("Circe", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPos2.ForeColor = System.Drawing.Color.White;
            this.labelPos2.Location = new System.Drawing.Point(20, 127);
            this.labelPos2.Name = "labelPos2";
            this.labelPos2.Size = new System.Drawing.Size(72, 25);
            this.labelPos2.TabIndex = 3;
            this.labelPos2.Text = "label37";
            // 
            // labelPos1_Value
            // 
            this.labelPos1_Value.AutoSize = true;
            this.labelPos1_Value.Font = new System.Drawing.Font("Circe", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPos1_Value.ForeColor = System.Drawing.Color.White;
            this.labelPos1_Value.Location = new System.Drawing.Point(239, 90);
            this.labelPos1_Value.Name = "labelPos1_Value";
            this.labelPos1_Value.Size = new System.Drawing.Size(67, 25);
            this.labelPos1_Value.TabIndex = 2;
            this.labelPos1_Value.Text = "label38";
            // 
            // labelPos1
            // 
            this.labelPos1.AutoSize = true;
            this.labelPos1.Font = new System.Drawing.Font("Circe", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPos1.ForeColor = System.Drawing.Color.White;
            this.labelPos1.Location = new System.Drawing.Point(20, 90);
            this.labelPos1.Name = "labelPos1";
            this.labelPos1.Size = new System.Drawing.Size(73, 25);
            this.labelPos1.TabIndex = 1;
            this.labelPos1.Text = "label39";
            // 
            // labelTopPositions
            // 
            this.labelTopPositions.AutoSize = true;
            this.labelTopPositions.Font = new System.Drawing.Font("Circe", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTopPositions.ForeColor = System.Drawing.Color.White;
            this.labelTopPositions.Location = new System.Drawing.Point(18, 20);
            this.labelTopPositions.Name = "labelTopPositions";
            this.labelTopPositions.Size = new System.Drawing.Size(261, 45);
            this.labelTopPositions.TabIndex = 0;
            this.labelTopPositions.Text = "Лучшие позиции";
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(173)))), ((int)(((byte)(96)))));
            this.chart1.BorderSkin.BackColor = System.Drawing.Color.Transparent;
            this.chart1.BorderSkin.BorderColor = System.Drawing.Color.IndianRed;
            this.chart1.BorderSkin.BorderWidth = 10;
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(173)))), ((int)(((byte)(96)))));
            chartArea1.BorderColor = System.Drawing.Color.White;
            chartArea1.BorderWidth = 5;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(173)))), ((int)(((byte)(96)))));
            legend1.Font = new System.Drawing.Font("Circe", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            legend1.ForeColor = System.Drawing.Color.White;
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(717, 403);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(320, 280);
            this.chart1.TabIndex = 12;
            this.chart1.Text = "chart1";
            title1.Font = new System.Drawing.Font("Circe", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title1.ForeColor = System.Drawing.Color.White;
            title1.Name = "Title1";
            title1.Text = "Структура портфеля ТП";
            this.chart1.Titles.Add(title1);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(1154, 0);
            this.monthCalendar1.MaxSelectionCount = 10000;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.ShowToday = false;
            this.monthCalendar1.TabIndex = 13;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // labelDate1
            // 
            this.labelDate1.AutoSize = true;
            this.labelDate1.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDate1.Location = new System.Drawing.Point(777, 24);
            this.labelDate1.Name = "labelDate1";
            this.labelDate1.Size = new System.Drawing.Size(98, 24);
            this.labelDate1.TabIndex = 14;
            this.labelDate1.Text = "00.00.0000";
            this.labelDate1.Click += new System.EventHandler(this.labelDate_Click);
            // 
            // labelDate2
            // 
            this.labelDate2.AutoSize = true;
            this.labelDate2.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDate2.Location = new System.Drawing.Point(770, 48);
            this.labelDate2.Name = "labelDate2";
            this.labelDate2.Size = new System.Drawing.Size(105, 24);
            this.labelDate2.TabIndex = 15;
            this.labelDate2.Text = "-00.00.0000";
            this.labelDate2.Click += new System.EventHandler(this.labelDate_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.BackgroundImage = global::AdminTool2.Properties.Resources.Vector;
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel6.Location = new System.Drawing.Point(721, 29);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(35, 35);
            this.panel6.TabIndex = 22;
            // 
            // buttonAccept
            // 
            this.buttonAccept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(201)))), ((int)(((byte)(150)))));
            this.buttonAccept.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(201)))), ((int)(((byte)(150)))));
            this.buttonAccept.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(173)))), ((int)(((byte)(96)))));
            this.buttonAccept.BorderRadius = 25;
            this.buttonAccept.BorderSize = 0;
            this.buttonAccept.FlatAppearance.BorderSize = 0;
            this.buttonAccept.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(173)))), ((int)(((byte)(96)))));
            this.buttonAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAccept.Font = new System.Drawing.Font("Circe", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAccept.ForeColor = System.Drawing.Color.White;
            this.buttonAccept.Location = new System.Drawing.Point(887, 24);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.buttonAccept.Size = new System.Drawing.Size(150, 50);
            this.buttonAccept.TabIndex = 21;
            this.buttonAccept.Text = "Применить";
            this.buttonAccept.TextColor = System.Drawing.Color.White;
            this.buttonAccept.UseVisualStyleBackColor = false;
            this.buttonAccept.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonMonth
            // 
            this.buttonMonth.BackColor = System.Drawing.Color.White;
            this.buttonMonth.BackgroundColor = System.Drawing.Color.White;
            this.buttonMonth.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(173)))), ((int)(((byte)(96)))));
            this.buttonMonth.BorderRadius = 25;
            this.buttonMonth.BorderSize = 1;
            this.buttonMonth.FlatAppearance.BorderSize = 0;
            this.buttonMonth.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(173)))), ((int)(((byte)(96)))));
            this.buttonMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMonth.Font = new System.Drawing.Font("Circe", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMonth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(36)))), ((int)(((byte)(19)))));
            this.buttonMonth.Location = new System.Drawing.Point(546, 24);
            this.buttonMonth.Name = "buttonMonth";
            this.buttonMonth.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.buttonMonth.Size = new System.Drawing.Size(150, 50);
            this.buttonMonth.TabIndex = 20;
            this.buttonMonth.Text = "Месяц";
            this.buttonMonth.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(36)))), ((int)(((byte)(19)))));
            this.buttonMonth.UseVisualStyleBackColor = false;
            this.buttonMonth.Click += new System.EventHandler(this.button_Click);
            this.buttonMonth.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.buttonMonth.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // buttonWeek
            // 
            this.buttonWeek.BackColor = System.Drawing.Color.White;
            this.buttonWeek.BackgroundColor = System.Drawing.Color.White;
            this.buttonWeek.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(173)))), ((int)(((byte)(96)))));
            this.buttonWeek.BorderRadius = 25;
            this.buttonWeek.BorderSize = 1;
            this.buttonWeek.FlatAppearance.BorderSize = 0;
            this.buttonWeek.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(173)))), ((int)(((byte)(96)))));
            this.buttonWeek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWeek.Font = new System.Drawing.Font("Circe", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonWeek.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(36)))), ((int)(((byte)(19)))));
            this.buttonWeek.Location = new System.Drawing.Point(376, 24);
            this.buttonWeek.Name = "buttonWeek";
            this.buttonWeek.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.buttonWeek.Size = new System.Drawing.Size(150, 50);
            this.buttonWeek.TabIndex = 19;
            this.buttonWeek.Text = "Неделя";
            this.buttonWeek.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(36)))), ((int)(((byte)(19)))));
            this.buttonWeek.UseVisualStyleBackColor = false;
            this.buttonWeek.Click += new System.EventHandler(this.button_Click);
            this.buttonWeek.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.buttonWeek.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // buttonNowDay
            // 
            this.buttonNowDay.BackColor = System.Drawing.Color.White;
            this.buttonNowDay.BackgroundColor = System.Drawing.Color.White;
            this.buttonNowDay.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(173)))), ((int)(((byte)(96)))));
            this.buttonNowDay.BorderRadius = 25;
            this.buttonNowDay.BorderSize = 1;
            this.buttonNowDay.FlatAppearance.BorderSize = 0;
            this.buttonNowDay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(173)))), ((int)(((byte)(96)))));
            this.buttonNowDay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNowDay.Font = new System.Drawing.Font("Circe", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNowDay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(36)))), ((int)(((byte)(19)))));
            this.buttonNowDay.Location = new System.Drawing.Point(206, 24);
            this.buttonNowDay.Name = "buttonNowDay";
            this.buttonNowDay.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.buttonNowDay.Size = new System.Drawing.Size(150, 50);
            this.buttonNowDay.TabIndex = 18;
            this.buttonNowDay.Text = "Сегодня";
            this.buttonNowDay.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(36)))), ((int)(((byte)(19)))));
            this.buttonNowDay.UseVisualStyleBackColor = false;
            this.buttonNowDay.Click += new System.EventHandler(this.button_Click);
            this.buttonNowDay.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.buttonNowDay.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // buttonLastDay
            // 
            this.buttonLastDay.BackColor = System.Drawing.Color.White;
            this.buttonLastDay.BackgroundColor = System.Drawing.Color.White;
            this.buttonLastDay.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(173)))), ((int)(((byte)(96)))));
            this.buttonLastDay.BorderRadius = 25;
            this.buttonLastDay.BorderSize = 1;
            this.buttonLastDay.FlatAppearance.BorderSize = 0;
            this.buttonLastDay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(173)))), ((int)(((byte)(96)))));
            this.buttonLastDay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLastDay.Font = new System.Drawing.Font("Circe", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLastDay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(36)))), ((int)(((byte)(19)))));
            this.buttonLastDay.Location = new System.Drawing.Point(36, 24);
            this.buttonLastDay.Name = "buttonLastDay";
            this.buttonLastDay.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.buttonLastDay.Size = new System.Drawing.Size(150, 50);
            this.buttonLastDay.TabIndex = 17;
            this.buttonLastDay.Text = "Вчера";
            this.buttonLastDay.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(36)))), ((int)(((byte)(19)))));
            this.buttonLastDay.UseVisualStyleBackColor = false;
            this.buttonLastDay.Click += new System.EventHandler(this.button_Click);
            this.buttonLastDay.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.buttonLastDay.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // SummaryUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.buttonAccept);
            this.Controls.Add(this.buttonMonth);
            this.Controls.Add(this.buttonWeek);
            this.Controls.Add(this.buttonNowDay);
            this.Controls.Add(this.buttonLastDay);
            this.Controls.Add(this.labelDate2);
            this.Controls.Add(this.labelDate1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "SummaryUserControl";
            this.Size = new System.Drawing.Size(1095, 757);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelProceedsNow_Value;
        private System.Windows.Forms.Label labelProceedsNow;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelAVGReceiptNow_Value;
        private System.Windows.Forms.Label labelAVGReceiptNow;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelPoint1;
        private System.Windows.Forms.Label labelTopPoints;
        private System.Windows.Forms.Label labelPoint5_Value;
        private System.Windows.Forms.Label labelPoint5;
        private System.Windows.Forms.Label labelPoint4_Value;
        private System.Windows.Forms.Label labelPoint4;
        private System.Windows.Forms.Label labelPoint3_Value;
        private System.Windows.Forms.Label labelPoint3;
        private System.Windows.Forms.Label labelPoint2_Value;
        private System.Windows.Forms.Label labelPoint2;
        private System.Windows.Forms.Label labelPoint1_Value;
        private System.Windows.Forms.Label labelProceedsLastNow;
        private System.Windows.Forms.Label labelProceedsLast_Value;
        private System.Windows.Forms.Label labelProceedsLast;
        private System.Windows.Forms.Label labelProceedsLastNow_Value;
        private System.Windows.Forms.Label labelAVGReceiptLastNow_Value;
        private System.Windows.Forms.Label labelAVGReceiptLastNow;
        private System.Windows.Forms.Label labelAVGReceiptLast_Value;
        private System.Windows.Forms.Label labelAVGReceiptLast;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label labelCointPositionsLastNow;
        private System.Windows.Forms.Label labelCointPositionsLast;
        private System.Windows.Forms.Label labelCointPositionsLastNow_Value;
        private System.Windows.Forms.Label labelCointPositionsLast_Value;
        private System.Windows.Forms.Label labelCointPositionsNow_Value;
        private System.Windows.Forms.Label labelCointPositionsNow;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label labelPos5_Value;
        private System.Windows.Forms.Label labelPos5;
        private System.Windows.Forms.Label labelPos4_Value;
        private System.Windows.Forms.Label labelPos4;
        private System.Windows.Forms.Label labelPos3_Value;
        private System.Windows.Forms.Label labelPos3;
        private System.Windows.Forms.Label labelPos2_Value;
        private System.Windows.Forms.Label labelPos2;
        private System.Windows.Forms.Label labelPos1_Value;
        private System.Windows.Forms.Label labelPos1;
        private System.Windows.Forms.Label labelTopPositions;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label labelDate1;
        private System.Windows.Forms.Label labelDate2;
        private MyControls.CustomBTN buttonLastDay;
        private MyControls.CustomBTN buttonNowDay;
        private MyControls.CustomBTN buttonWeek;
        private MyControls.CustomBTN buttonMonth;
        private MyControls.CustomBTN buttonAccept;
        private System.Windows.Forms.Panel panel6;
    }
}
