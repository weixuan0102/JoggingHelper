namespace Demo
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.weatherInfo = new System.Windows.Forms.Label();
            this.joggingBtn = new System.Windows.Forms.Button();
            this.weatherBtn = new System.Windows.Forms.Button();
            this.dietBtn = new System.Windows.Forms.Button();
            this.weatherPanel = new System.Windows.Forms.Panel();
            this.backBtnWeather = new System.Windows.Forms.Button();
            this.HomePanel = new System.Windows.Forms.Panel();
            this.calorieBtn = new System.Windows.Forms.Button();
            this.bmiBtn = new System.Windows.Forms.Button();
            this.bmiPanel = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bmiResultLabel = new System.Windows.Forms.Label();
            this.bmiCalculateBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.bmiTitle = new System.Windows.Forms.Label();
            this.bmiStandard = new System.Windows.Forms.PictureBox();
            this.bmiWeight = new System.Windows.Forms.TextBox();
            this.bmiHeight = new System.Windows.Forms.TextBox();
            this.bmiWeightUnit = new System.Windows.Forms.Label();
            this.bmiHeightUnit = new System.Windows.Forms.Label();
            this.bmiWeightLabel = new System.Windows.Forms.Label();
            this.bmiHeightLabel = new System.Windows.Forms.Label();
            this.joggingPanel = new System.Windows.Forms.Panel();
            this.joggingInfo = new System.Windows.Forms.TabControl();
            this.jogWeekRecordPage = new System.Windows.Forms.TabPage();
            this.jogRecordTotal = new System.Windows.Forms.Label();
            this.jogRecordDay7 = new System.Windows.Forms.Label();
            this.jogRecordDay6 = new System.Windows.Forms.Label();
            this.jogRecordDay5 = new System.Windows.Forms.Label();
            this.jogRecordDay4 = new System.Windows.Forms.Label();
            this.jogRecordDay3 = new System.Windows.Forms.Label();
            this.jogRecordDay2 = new System.Windows.Forms.Label();
            this.jogRecordDay1 = new System.Windows.Forms.Label();
            this.jogModifyPage = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.jogDistance = new System.Windows.Forms.TextBox();
            this.jogTime = new System.Windows.Forms.TextBox();
            this.jogDay = new System.Windows.Forms.ComboBox();
            this.jogDeleteBtn = new System.Windows.Forms.Button();
            this.jogAddBtn = new System.Windows.Forms.Button();
            this.jogSearchBtn = new System.Windows.Forms.Button();
            this.jogDistanceUnit = new System.Windows.Forms.Label();
            this.jogTimeUnit = new System.Windows.Forms.Label();
            this.jogDistanceLabel = new System.Windows.Forms.Label();
            this.jogTimeLabel = new System.Windows.Forms.Label();
            this.jogHintLabel = new System.Windows.Forms.Label();
            this.jogDayLabel = new System.Windows.Forms.Label();
            this.jogRecordPage = new System.Windows.Forms.TabPage();
            this.backBtnJogging = new System.Windows.Forms.Button();
            this.dietPanel = new System.Windows.Forms.Panel();
            this.weatherPanel.SuspendLayout();
            this.HomePanel.SuspendLayout();
            this.bmiPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bmiStandard)).BeginInit();
            this.joggingPanel.SuspendLayout();
            this.joggingInfo.SuspendLayout();
            this.jogWeekRecordPage.SuspendLayout();
            this.jogModifyPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // weatherInfo
            // 
            this.weatherInfo.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.weatherInfo.Location = new System.Drawing.Point(150, 38);
            this.weatherInfo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.weatherInfo.Name = "weatherInfo";
            this.weatherInfo.Size = new System.Drawing.Size(1030, 773);
            this.weatherInfo.TabIndex = 0;
            this.weatherInfo.Text = "label1";
            // 
            // joggingBtn
            // 
            this.joggingBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.joggingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.joggingBtn.Location = new System.Drawing.Point(221, -64);
            this.joggingBtn.Margin = new System.Windows.Forms.Padding(5);
            this.joggingBtn.Name = "joggingBtn";
            this.joggingBtn.Size = new System.Drawing.Size(665, 283);
            this.joggingBtn.TabIndex = 0;
            this.joggingBtn.UseVisualStyleBackColor = false;
            this.joggingBtn.Click += new System.EventHandler(this.joggingBtn_Click);
            // 
            // weatherBtn
            // 
            this.weatherBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.weatherBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.weatherBtn.Location = new System.Drawing.Point(221, 254);
            this.weatherBtn.Margin = new System.Windows.Forms.Padding(5);
            this.weatherBtn.Name = "weatherBtn";
            this.weatherBtn.Size = new System.Drawing.Size(318, 345);
            this.weatherBtn.TabIndex = 2;
            this.weatherBtn.UseVisualStyleBackColor = false;
            this.weatherBtn.Click += new System.EventHandler(this.weatherButton_Click);
            // 
            // dietBtn
            // 
            this.dietBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dietBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dietBtn.Location = new System.Drawing.Point(568, 254);
            this.dietBtn.Margin = new System.Windows.Forms.Padding(5);
            this.dietBtn.Name = "dietBtn";
            this.dietBtn.Size = new System.Drawing.Size(318, 345);
            this.dietBtn.TabIndex = 3;
            this.dietBtn.UseVisualStyleBackColor = false;
            this.dietBtn.Click += new System.EventHandler(this.dietBtn_Click);
            // 
            // weatherPanel
            // 
            this.weatherPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.weatherPanel.Controls.Add(this.backBtnWeather);
            this.weatherPanel.Controls.Add(this.weatherInfo);
            this.weatherPanel.Location = new System.Drawing.Point(1182, 46);
            this.weatherPanel.Margin = new System.Windows.Forms.Padding(5);
            this.weatherPanel.Name = "weatherPanel";
            this.weatherPanel.Size = new System.Drawing.Size(1207, 847);
            this.weatherPanel.TabIndex = 4;
            this.weatherPanel.Visible = false;
            // 
            // backBtnWeather
            // 
            this.backBtnWeather.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.backBtnWeather.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtnWeather.Location = new System.Drawing.Point(5, 5);
            this.backBtnWeather.Margin = new System.Windows.Forms.Padding(5);
            this.backBtnWeather.Name = "backBtnWeather";
            this.backBtnWeather.Size = new System.Drawing.Size(72, 70);
            this.backBtnWeather.TabIndex = 1;
            this.backBtnWeather.UseVisualStyleBackColor = false;
            this.backBtnWeather.Click += new System.EventHandler(this.backBtnWeather_Click);
            // 
            // HomePanel
            // 
            this.HomePanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.HomePanel.Controls.Add(this.calorieBtn);
            this.HomePanel.Controls.Add(this.bmiBtn);
            this.HomePanel.Controls.Add(this.joggingBtn);
            this.HomePanel.Controls.Add(this.weatherBtn);
            this.HomePanel.Controls.Add(this.dietBtn);
            this.HomePanel.Location = new System.Drawing.Point(20, 25);
            this.HomePanel.Margin = new System.Windows.Forms.Padding(5);
            this.HomePanel.Name = "HomePanel";
            this.HomePanel.Size = new System.Drawing.Size(1120, 1009);
            this.HomePanel.TabIndex = 5;
            // 
            // calorieBtn
            // 
            this.calorieBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.calorieBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calorieBtn.Font = new System.Drawing.Font("新細明體", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.calorieBtn.Location = new System.Drawing.Point(568, 634);
            this.calorieBtn.Margin = new System.Windows.Forms.Padding(5);
            this.calorieBtn.Name = "calorieBtn";
            this.calorieBtn.Size = new System.Drawing.Size(318, 345);
            this.calorieBtn.TabIndex = 5;
            this.calorieBtn.Text = "Calorie";
            this.calorieBtn.UseVisualStyleBackColor = false;
            this.calorieBtn.Click += new System.EventHandler(this.calorieBtn_Click);
            // 
            // bmiBtn
            // 
            this.bmiBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bmiBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bmiBtn.Font = new System.Drawing.Font("新細明體", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.bmiBtn.Location = new System.Drawing.Point(222, 634);
            this.bmiBtn.Margin = new System.Windows.Forms.Padding(5);
            this.bmiBtn.Name = "bmiBtn";
            this.bmiBtn.Size = new System.Drawing.Size(318, 345);
            this.bmiBtn.TabIndex = 4;
            this.bmiBtn.Text = "BMI";
            this.bmiBtn.UseVisualStyleBackColor = false;
            this.bmiBtn.Click += new System.EventHandler(this.bmiBtn_Click);
            // 
            // bmiPanel
            // 
            this.bmiPanel.Controls.Add(this.textBox1);
            this.bmiPanel.Controls.Add(this.bmiResultLabel);
            this.bmiPanel.Controls.Add(this.bmiCalculateBtn);
            this.bmiPanel.Controls.Add(this.button1);
            this.bmiPanel.Controls.Add(this.bmiTitle);
            this.bmiPanel.Controls.Add(this.bmiStandard);
            this.bmiPanel.Controls.Add(this.bmiWeight);
            this.bmiPanel.Controls.Add(this.bmiHeight);
            this.bmiPanel.Controls.Add(this.bmiWeightUnit);
            this.bmiPanel.Controls.Add(this.bmiHeightUnit);
            this.bmiPanel.Controls.Add(this.bmiWeightLabel);
            this.bmiPanel.Controls.Add(this.bmiHeightLabel);
            this.bmiPanel.Location = new System.Drawing.Point(1182, 46);
            this.bmiPanel.Margin = new System.Windows.Forms.Padding(5);
            this.bmiPanel.Name = "bmiPanel";
            this.bmiPanel.Size = new System.Drawing.Size(1207, 847);
            this.bmiPanel.TabIndex = 3;
            this.bmiPanel.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(235, 262);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 30);
            this.textBox1.TabIndex = 11;
            // 
            // bmiResultLabel
            // 
            this.bmiResultLabel.AutoSize = true;
            this.bmiResultLabel.Location = new System.Drawing.Point(100, 268);
            this.bmiResultLabel.Name = "bmiResultLabel";
            this.bmiResultLabel.Size = new System.Drawing.Size(110, 19);
            this.bmiResultLabel.TabIndex = 10;
            this.bmiResultLabel.Text = "你的BMI為 :";
            // 
            // bmiCalculateBtn
            // 
            this.bmiCalculateBtn.Location = new System.Drawing.Point(455, 190);
            this.bmiCalculateBtn.Name = "bmiCalculateBtn";
            this.bmiCalculateBtn.Size = new System.Drawing.Size(124, 44);
            this.bmiCalculateBtn.TabIndex = 9;
            this.bmiCalculateBtn.Text = "開始計算";
            this.bmiCalculateBtn.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(631, 763);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 66);
            this.button1.TabIndex = 8;
            this.button1.Text = "查看紀錄";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // bmiTitle
            // 
            this.bmiTitle.AutoSize = true;
            this.bmiTitle.Font = new System.Drawing.Font("新細明體", 14.21053F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.bmiTitle.Location = new System.Drawing.Point(95, 68);
            this.bmiTitle.Name = "bmiTitle";
            this.bmiTitle.Size = new System.Drawing.Size(472, 31);
            this.bmiTitle.TabIndex = 7;
            this.bmiTitle.Text = "看看自己的BMI是否在理想範圍吧";
            // 
            // bmiStandard
            // 
            this.bmiStandard.Location = new System.Drawing.Point(99, 312);
            this.bmiStandard.Name = "bmiStandard";
            this.bmiStandard.Size = new System.Drawing.Size(452, 517);
            this.bmiStandard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bmiStandard.TabIndex = 6;
            this.bmiStandard.TabStop = false;
            // 
            // bmiWeight
            // 
            this.bmiWeight.Location = new System.Drawing.Point(235, 209);
            this.bmiWeight.Name = "bmiWeight";
            this.bmiWeight.Size = new System.Drawing.Size(100, 30);
            this.bmiWeight.TabIndex = 5;
            // 
            // bmiHeight
            // 
            this.bmiHeight.Location = new System.Drawing.Point(235, 154);
            this.bmiHeight.Name = "bmiHeight";
            this.bmiHeight.Size = new System.Drawing.Size(100, 30);
            this.bmiHeight.TabIndex = 4;
            // 
            // bmiWeightUnit
            // 
            this.bmiWeightUnit.AutoSize = true;
            this.bmiWeightUnit.Location = new System.Drawing.Point(349, 215);
            this.bmiWeightUnit.Name = "bmiWeightUnit";
            this.bmiWeightUnit.Size = new System.Drawing.Size(27, 19);
            this.bmiWeightUnit.TabIndex = 3;
            this.bmiWeightUnit.Text = "kg";
            // 
            // bmiHeightUnit
            // 
            this.bmiHeightUnit.AutoSize = true;
            this.bmiHeightUnit.Location = new System.Drawing.Point(345, 160);
            this.bmiHeightUnit.Name = "bmiHeightUnit";
            this.bmiHeightUnit.Size = new System.Drawing.Size(31, 19);
            this.bmiHeightUnit.TabIndex = 2;
            this.bmiHeightUnit.Text = "cm";
            // 
            // bmiWeightLabel
            // 
            this.bmiWeightLabel.AutoSize = true;
            this.bmiWeightLabel.Location = new System.Drawing.Point(99, 213);
            this.bmiWeightLabel.Name = "bmiWeightLabel";
            this.bmiWeightLabel.Size = new System.Drawing.Size(57, 19);
            this.bmiWeightLabel.TabIndex = 1;
            this.bmiWeightLabel.Text = "體重 :";
            // 
            // bmiHeightLabel
            // 
            this.bmiHeightLabel.AutoSize = true;
            this.bmiHeightLabel.Location = new System.Drawing.Point(99, 158);
            this.bmiHeightLabel.Name = "bmiHeightLabel";
            this.bmiHeightLabel.Size = new System.Drawing.Size(57, 19);
            this.bmiHeightLabel.TabIndex = 0;
            this.bmiHeightLabel.Text = "身高 :";
            // 
            // joggingPanel
            // 
            this.joggingPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.joggingPanel.Controls.Add(this.joggingInfo);
            this.joggingPanel.Controls.Add(this.backBtnJogging);
            this.joggingPanel.Location = new System.Drawing.Point(1182, 46);
            this.joggingPanel.Margin = new System.Windows.Forms.Padding(5);
            this.joggingPanel.Name = "joggingPanel";
            this.joggingPanel.Size = new System.Drawing.Size(1207, 847);
            this.joggingPanel.TabIndex = 7;
            this.joggingPanel.Visible = false;
            // 
            // joggingInfo
            // 
            this.joggingInfo.Controls.Add(this.jogWeekRecordPage);
            this.joggingInfo.Controls.Add(this.jogModifyPage);
            this.joggingInfo.Controls.Add(this.jogRecordPage);
            this.joggingInfo.Location = new System.Drawing.Point(117, 60);
            this.joggingInfo.Name = "joggingInfo";
            this.joggingInfo.SelectedIndex = 0;
            this.joggingInfo.Size = new System.Drawing.Size(1023, 767);
            this.joggingInfo.TabIndex = 2;
            // 
            // jogWeekRecordPage
            // 
            this.jogWeekRecordPage.Controls.Add(this.jogRecordTotal);
            this.jogWeekRecordPage.Controls.Add(this.jogRecordDay7);
            this.jogWeekRecordPage.Controls.Add(this.jogRecordDay6);
            this.jogWeekRecordPage.Controls.Add(this.jogRecordDay5);
            this.jogWeekRecordPage.Controls.Add(this.jogRecordDay4);
            this.jogWeekRecordPage.Controls.Add(this.jogRecordDay3);
            this.jogWeekRecordPage.Controls.Add(this.jogRecordDay2);
            this.jogWeekRecordPage.Controls.Add(this.jogRecordDay1);
            this.jogWeekRecordPage.Location = new System.Drawing.Point(4, 29);
            this.jogWeekRecordPage.Name = "jogWeekRecordPage";
            this.jogWeekRecordPage.Padding = new System.Windows.Forms.Padding(3);
            this.jogWeekRecordPage.Size = new System.Drawing.Size(1015, 734);
            this.jogWeekRecordPage.TabIndex = 0;
            this.jogWeekRecordPage.Text = "本周紀錄";
            this.jogWeekRecordPage.UseVisualStyleBackColor = true;
            // 
            // jogRecordTotal
            // 
            this.jogRecordTotal.Location = new System.Drawing.Point(506, 550);
            this.jogRecordTotal.Name = "jogRecordTotal";
            this.jogRecordTotal.Size = new System.Drawing.Size(483, 70);
            this.jogRecordTotal.TabIndex = 8;
            this.jogRecordTotal.Text = "Total      尚無紀錄";
            // 
            // jogRecordDay7
            // 
            this.jogRecordDay7.Location = new System.Drawing.Point(506, 375);
            this.jogRecordDay7.Name = "jogRecordDay7";
            this.jogRecordDay7.Size = new System.Drawing.Size(483, 70);
            this.jogRecordDay7.TabIndex = 7;
            this.jogRecordDay7.Text = "Day7      尚無紀錄";
            // 
            // jogRecordDay6
            // 
            this.jogRecordDay6.Location = new System.Drawing.Point(506, 200);
            this.jogRecordDay6.Name = "jogRecordDay6";
            this.jogRecordDay6.Size = new System.Drawing.Size(483, 70);
            this.jogRecordDay6.TabIndex = 6;
            this.jogRecordDay6.Text = "Day6      尚無紀錄";
            // 
            // jogRecordDay5
            // 
            this.jogRecordDay5.Location = new System.Drawing.Point(506, 25);
            this.jogRecordDay5.Name = "jogRecordDay5";
            this.jogRecordDay5.Size = new System.Drawing.Size(483, 70);
            this.jogRecordDay5.TabIndex = 5;
            this.jogRecordDay5.Text = "Day5      尚無紀錄";
            // 
            // jogRecordDay4
            // 
            this.jogRecordDay4.Location = new System.Drawing.Point(17, 550);
            this.jogRecordDay4.Name = "jogRecordDay4";
            this.jogRecordDay4.Size = new System.Drawing.Size(483, 70);
            this.jogRecordDay4.TabIndex = 4;
            this.jogRecordDay4.Text = "Day4      尚無紀錄";
            // 
            // jogRecordDay3
            // 
            this.jogRecordDay3.Location = new System.Drawing.Point(17, 375);
            this.jogRecordDay3.Name = "jogRecordDay3";
            this.jogRecordDay3.Size = new System.Drawing.Size(483, 70);
            this.jogRecordDay3.TabIndex = 3;
            this.jogRecordDay3.Text = "Day3      尚無紀錄";
            // 
            // jogRecordDay2
            // 
            this.jogRecordDay2.Location = new System.Drawing.Point(17, 200);
            this.jogRecordDay2.Name = "jogRecordDay2";
            this.jogRecordDay2.Size = new System.Drawing.Size(483, 70);
            this.jogRecordDay2.TabIndex = 2;
            this.jogRecordDay2.Text = "Day2      尚無紀錄";
            // 
            // jogRecordDay1
            // 
            this.jogRecordDay1.Location = new System.Drawing.Point(17, 25);
            this.jogRecordDay1.Name = "jogRecordDay1";
            this.jogRecordDay1.Size = new System.Drawing.Size(483, 70);
            this.jogRecordDay1.TabIndex = 1;
            this.jogRecordDay1.Text = "Day1      尚無紀錄";
            // 
            // jogModifyPage
            // 
            this.jogModifyPage.Controls.Add(this.label7);
            this.jogModifyPage.Controls.Add(this.jogDistance);
            this.jogModifyPage.Controls.Add(this.jogTime);
            this.jogModifyPage.Controls.Add(this.jogDay);
            this.jogModifyPage.Controls.Add(this.jogDeleteBtn);
            this.jogModifyPage.Controls.Add(this.jogAddBtn);
            this.jogModifyPage.Controls.Add(this.jogSearchBtn);
            this.jogModifyPage.Controls.Add(this.jogDistanceUnit);
            this.jogModifyPage.Controls.Add(this.jogTimeUnit);
            this.jogModifyPage.Controls.Add(this.jogDistanceLabel);
            this.jogModifyPage.Controls.Add(this.jogTimeLabel);
            this.jogModifyPage.Controls.Add(this.jogHintLabel);
            this.jogModifyPage.Controls.Add(this.jogDayLabel);
            this.jogModifyPage.Location = new System.Drawing.Point(4, 29);
            this.jogModifyPage.Name = "jogModifyPage";
            this.jogModifyPage.Padding = new System.Windows.Forms.Padding(3);
            this.jogModifyPage.Size = new System.Drawing.Size(1015, 734);
            this.jogModifyPage.TabIndex = 1;
            this.jogModifyPage.Text = "修改資料";
            this.jogModifyPage.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(296, 285);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 19);
            this.label7.TabIndex = 12;
            this.label7.Text = "顯示搜尋結果~~~";
            // 
            // jogDistance
            // 
            this.jogDistance.Location = new System.Drawing.Point(211, 669);
            this.jogDistance.Name = "jogDistance";
            this.jogDistance.Size = new System.Drawing.Size(121, 30);
            this.jogDistance.TabIndex = 11;
            // 
            // jogTime
            // 
            this.jogTime.Location = new System.Drawing.Point(211, 598);
            this.jogTime.Name = "jogTime";
            this.jogTime.Size = new System.Drawing.Size(121, 30);
            this.jogTime.TabIndex = 10;
            // 
            // jogDay
            // 
            this.jogDay.FormattingEnabled = true;
            this.jogDay.Items.AddRange(new object[] {
            "Day1",
            "Day2",
            "Day3",
            "Day4",
            "Day5",
            "Day6",
            "Day7"});
            this.jogDay.Location = new System.Drawing.Point(211, 45);
            this.jogDay.Name = "jogDay";
            this.jogDay.Size = new System.Drawing.Size(121, 27);
            this.jogDay.TabIndex = 9;
            // 
            // jogDeleteBtn
            // 
            this.jogDeleteBtn.Location = new System.Drawing.Point(591, 664);
            this.jogDeleteBtn.Name = "jogDeleteBtn";
            this.jogDeleteBtn.Size = new System.Drawing.Size(82, 35);
            this.jogDeleteBtn.TabIndex = 8;
            this.jogDeleteBtn.Text = "刪除";
            this.jogDeleteBtn.UseVisualStyleBackColor = true;
            // 
            // jogAddBtn
            // 
            this.jogAddBtn.Location = new System.Drawing.Point(481, 664);
            this.jogAddBtn.Name = "jogAddBtn";
            this.jogAddBtn.Size = new System.Drawing.Size(82, 35);
            this.jogAddBtn.TabIndex = 7;
            this.jogAddBtn.Text = "新增";
            this.jogAddBtn.UseVisualStyleBackColor = true;
            // 
            // jogSearchBtn
            // 
            this.jogSearchBtn.Location = new System.Drawing.Point(481, 40);
            this.jogSearchBtn.Name = "jogSearchBtn";
            this.jogSearchBtn.Size = new System.Drawing.Size(82, 35);
            this.jogSearchBtn.TabIndex = 6;
            this.jogSearchBtn.Text = "查詢";
            this.jogSearchBtn.UseVisualStyleBackColor = true;
            // 
            // jogDistanceUnit
            // 
            this.jogDistanceUnit.AutoSize = true;
            this.jogDistanceUnit.Location = new System.Drawing.Point(362, 672);
            this.jogDistanceUnit.Name = "jogDistanceUnit";
            this.jogDistanceUnit.Size = new System.Drawing.Size(32, 19);
            this.jogDistanceUnit.TabIndex = 5;
            this.jogDistanceUnit.Text = "km";
            // 
            // jogTimeUnit
            // 
            this.jogTimeUnit.AutoSize = true;
            this.jogTimeUnit.Location = new System.Drawing.Point(357, 601);
            this.jogTimeUnit.Name = "jogTimeUnit";
            this.jogTimeUnit.Size = new System.Drawing.Size(37, 19);
            this.jogTimeUnit.TabIndex = 4;
            this.jogTimeUnit.Text = "min";
            // 
            // jogDistanceLabel
            // 
            this.jogDistanceLabel.AutoSize = true;
            this.jogDistanceLabel.Location = new System.Drawing.Point(120, 672);
            this.jogDistanceLabel.Name = "jogDistanceLabel";
            this.jogDistanceLabel.Size = new System.Drawing.Size(57, 19);
            this.jogDistanceLabel.TabIndex = 3;
            this.jogDistanceLabel.Text = "里程 :";
            // 
            // jogTimeLabel
            // 
            this.jogTimeLabel.AutoSize = true;
            this.jogTimeLabel.Location = new System.Drawing.Point(120, 601);
            this.jogTimeLabel.Name = "jogTimeLabel";
            this.jogTimeLabel.Size = new System.Drawing.Size(57, 19);
            this.jogTimeLabel.TabIndex = 2;
            this.jogTimeLabel.Text = "時長 :";
            // 
            // jogHintLabel
            // 
            this.jogHintLabel.AutoSize = true;
            this.jogHintLabel.Location = new System.Drawing.Point(63, 548);
            this.jogHintLabel.Name = "jogHintLabel";
            this.jogHintLabel.Size = new System.Drawing.Size(190, 19);
            this.jogHintLabel.TabIndex = 1;
            this.jogHintLabel.Text = "請輸入欲修改的資料 :";
            // 
            // jogDayLabel
            // 
            this.jogDayLabel.AutoSize = true;
            this.jogDayLabel.Location = new System.Drawing.Point(63, 48);
            this.jogDayLabel.Name = "jogDayLabel";
            this.jogDayLabel.Size = new System.Drawing.Size(114, 19);
            this.jogDayLabel.TabIndex = 0;
            this.jogDayLabel.Text = "請選擇日期 :";
            // 
            // jogRecordPage
            // 
            this.jogRecordPage.Location = new System.Drawing.Point(4, 29);
            this.jogRecordPage.Name = "jogRecordPage";
            this.jogRecordPage.Size = new System.Drawing.Size(1015, 734);
            this.jogRecordPage.TabIndex = 2;
            this.jogRecordPage.Text = "查詢紀錄";
            this.jogRecordPage.UseVisualStyleBackColor = true;
            // 
            // backBtnJogging
            // 
            this.backBtnJogging.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.backBtnJogging.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtnJogging.Location = new System.Drawing.Point(5, 5);
            this.backBtnJogging.Margin = new System.Windows.Forms.Padding(5);
            this.backBtnJogging.Name = "backBtnJogging";
            this.backBtnJogging.Size = new System.Drawing.Size(72, 70);
            this.backBtnJogging.TabIndex = 1;
            this.backBtnJogging.UseVisualStyleBackColor = false;
            this.backBtnJogging.Click += new System.EventHandler(this.backBtnJogging_Click);
            // 
            // dietPanel
            // 
            this.dietPanel.Location = new System.Drawing.Point(1182, 46);
            this.dietPanel.Margin = new System.Windows.Forms.Padding(5);
            this.dietPanel.Name = "dietPanel";
            this.dietPanel.Size = new System.Drawing.Size(1202, 842);
            this.dietPanel.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1924, 1048);
            this.Controls.Add(this.bmiPanel);
            this.Controls.Add(this.joggingPanel);
            this.Controls.Add(this.dietPanel);
            this.Controls.Add(this.HomePanel);
            this.Controls.Add(this.weatherPanel);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "健康管理";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.weatherPanel.ResumeLayout(false);
            this.HomePanel.ResumeLayout(false);
            this.bmiPanel.ResumeLayout(false);
            this.bmiPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bmiStandard)).EndInit();
            this.joggingPanel.ResumeLayout(false);
            this.joggingInfo.ResumeLayout(false);
            this.jogWeekRecordPage.ResumeLayout(false);
            this.jogModifyPage.ResumeLayout(false);
            this.jogModifyPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label weatherInfo;
        private System.Windows.Forms.Button joggingBtn;
        private System.Windows.Forms.Button weatherBtn;
        private System.Windows.Forms.Button dietBtn;
        private System.Windows.Forms.Panel weatherPanel;
        private System.Windows.Forms.Panel HomePanel;
        private System.Windows.Forms.Button backBtnWeather;
        private System.Windows.Forms.Panel dietPanel;
        private System.Windows.Forms.Panel joggingPanel;
        private System.Windows.Forms.Button backBtnJogging;
        private System.Windows.Forms.Button calorieBtn;
        private System.Windows.Forms.Button bmiBtn;
        private System.Windows.Forms.TabControl joggingInfo;
        private System.Windows.Forms.TabPage jogWeekRecordPage;
        private System.Windows.Forms.TabPage jogModifyPage;
        private System.Windows.Forms.Label jogRecordDay7;
        private System.Windows.Forms.Label jogRecordDay6;
        private System.Windows.Forms.Label jogRecordDay5;
        private System.Windows.Forms.Label jogRecordDay4;
        private System.Windows.Forms.Label jogRecordDay3;
        private System.Windows.Forms.Label jogRecordDay2;
        private System.Windows.Forms.Label jogRecordDay1;
        private System.Windows.Forms.Label jogRecordTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox jogDistance;
        private System.Windows.Forms.TextBox jogTime;
        private System.Windows.Forms.ComboBox jogDay;
        private System.Windows.Forms.Button jogDeleteBtn;
        private System.Windows.Forms.Button jogAddBtn;
        private System.Windows.Forms.Button jogSearchBtn;
        private System.Windows.Forms.Label jogDistanceUnit;
        private System.Windows.Forms.Label jogTimeUnit;
        private System.Windows.Forms.Label jogDistanceLabel;
        private System.Windows.Forms.Label jogTimeLabel;
        private System.Windows.Forms.Label jogHintLabel;
        private System.Windows.Forms.Label jogDayLabel;
        private System.Windows.Forms.Panel bmiPanel;
        private System.Windows.Forms.TabPage jogRecordPage;
        private System.Windows.Forms.TextBox bmiWeight;
        private System.Windows.Forms.TextBox bmiHeight;
        private System.Windows.Forms.Label bmiWeightUnit;
        private System.Windows.Forms.Label bmiHeightUnit;
        private System.Windows.Forms.Label bmiWeightLabel;
        private System.Windows.Forms.Label bmiHeightLabel;
        private System.Windows.Forms.PictureBox bmiStandard;
        private System.Windows.Forms.Label bmiTitle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bmiCalculateBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label bmiResultLabel;
    }
}

