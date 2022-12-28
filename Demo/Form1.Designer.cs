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
            this.addRecord = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.jogWeekRecordPage = new System.Windows.Forms.TabPage();
            this.weekRecord = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.jogRecordPage = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.backBtnJogging = new System.Windows.Forms.Button();
            this.dietPanel = new System.Windows.Forms.Panel();
            this.labelCloseBtn = new System.Windows.Forms.Button();
            this.backBtnDiet = new System.Windows.Forms.Button();
            this.fruitLabel = new System.Windows.Forms.Label();
            this.oilLabel = new System.Windows.Forms.Label();
            this.grainLabel = new System.Windows.Forms.Label();
            this.vegLabel = new System.Windows.Forms.Label();
            this.proteinLabel = new System.Windows.Forms.Label();
            this.dietEnterBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grainTxt = new System.Windows.Forms.TextBox();
            this.oilTxt = new System.Windows.Forms.TextBox();
            this.proteinTxt = new System.Windows.Forms.TextBox();
            this.fruitTxt = new System.Windows.Forms.TextBox();
            this.vegTxt = new System.Windows.Forms.TextBox();
            this.fruitBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grainsBtn = new System.Windows.Forms.Button();
            this.oilBtn = new System.Windows.Forms.Button();
            this.proteinBtn = new System.Windows.Forms.Button();
            this.vegBtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.weatherPanel.SuspendLayout();
            this.HomePanel.SuspendLayout();
            this.bmiPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bmiStandard)).BeginInit();
            this.joggingPanel.SuspendLayout();
            this.joggingInfo.SuspendLayout();
            this.addRecord.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.jogWeekRecordPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.jogRecordPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.dietPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // weatherInfo
            // 
            this.weatherInfo.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.weatherInfo.Location = new System.Drawing.Point(90, 24);
            this.weatherInfo.Name = "weatherInfo";
            this.weatherInfo.Size = new System.Drawing.Size(618, 488);
            this.weatherInfo.TabIndex = 0;
            this.weatherInfo.Text = "label1";
            // 
            // joggingBtn
            // 
            this.joggingBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.joggingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.joggingBtn.Location = new System.Drawing.Point(133, -33);
            this.joggingBtn.Name = "joggingBtn";
            this.joggingBtn.Size = new System.Drawing.Size(399, 179);
            this.joggingBtn.TabIndex = 0;
            this.joggingBtn.UseVisualStyleBackColor = false;
            this.joggingBtn.Click += new System.EventHandler(this.joggingBtn_Click);
            // 
            // weatherBtn
            // 
            this.weatherBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.weatherBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.weatherBtn.Location = new System.Drawing.Point(133, 160);
            this.weatherBtn.Name = "weatherBtn";
            this.weatherBtn.Size = new System.Drawing.Size(191, 218);
            this.weatherBtn.TabIndex = 2;
            this.weatherBtn.UseVisualStyleBackColor = false;
            this.weatherBtn.Click += new System.EventHandler(this.weatherButton_Click);
            // 
            // dietBtn
            // 
            this.dietBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dietBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dietBtn.Location = new System.Drawing.Point(341, 160);
            this.dietBtn.Name = "dietBtn";
            this.dietBtn.Size = new System.Drawing.Size(191, 218);
            this.dietBtn.TabIndex = 3;
            this.dietBtn.UseVisualStyleBackColor = false;
            this.dietBtn.Click += new System.EventHandler(this.dietBtn_Click);
            // 
            // weatherPanel
            // 
            this.weatherPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.weatherPanel.Controls.Add(this.backBtnWeather);
            this.weatherPanel.Controls.Add(this.weatherInfo);
            this.weatherPanel.Location = new System.Drawing.Point(712, 16);
            this.weatherPanel.Name = "weatherPanel";
            this.weatherPanel.Size = new System.Drawing.Size(724, 535);
            this.weatherPanel.TabIndex = 4;
            this.weatherPanel.Visible = false;
            // 
            // backBtnWeather
            // 
            this.backBtnWeather.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.backBtnWeather.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtnWeather.Location = new System.Drawing.Point(3, 3);
            this.backBtnWeather.Name = "backBtnWeather";
            this.backBtnWeather.Size = new System.Drawing.Size(43, 44);
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
            this.HomePanel.Location = new System.Drawing.Point(12, 16);
            this.HomePanel.Name = "HomePanel";
            this.HomePanel.Size = new System.Drawing.Size(672, 637);
            this.HomePanel.TabIndex = 5;
            // 
            // calorieBtn
            // 
            this.calorieBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.calorieBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calorieBtn.Font = new System.Drawing.Font("新細明體", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.calorieBtn.Location = new System.Drawing.Point(341, 400);
            this.calorieBtn.Name = "calorieBtn";
            this.calorieBtn.Size = new System.Drawing.Size(191, 218);
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
            this.bmiBtn.Location = new System.Drawing.Point(133, 400);
            this.bmiBtn.Name = "bmiBtn";
            this.bmiBtn.Size = new System.Drawing.Size(191, 218);
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
            this.bmiPanel.Location = new System.Drawing.Point(709, 29);
            this.bmiPanel.Name = "bmiPanel";
            this.bmiPanel.Size = new System.Drawing.Size(724, 535);
            this.bmiPanel.TabIndex = 3;
            this.bmiPanel.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(141, 165);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(62, 22);
            this.textBox1.TabIndex = 11;
            // 
            // bmiResultLabel
            // 
            this.bmiResultLabel.AutoSize = true;
            this.bmiResultLabel.Location = new System.Drawing.Point(60, 169);
            this.bmiResultLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bmiResultLabel.Name = "bmiResultLabel";
            this.bmiResultLabel.Size = new System.Drawing.Size(69, 12);
            this.bmiResultLabel.TabIndex = 10;
            this.bmiResultLabel.Text = "你的BMI為 :";
            // 
            // bmiCalculateBtn
            // 
            this.bmiCalculateBtn.Location = new System.Drawing.Point(273, 120);
            this.bmiCalculateBtn.Margin = new System.Windows.Forms.Padding(2);
            this.bmiCalculateBtn.Name = "bmiCalculateBtn";
            this.bmiCalculateBtn.Size = new System.Drawing.Size(74, 28);
            this.bmiCalculateBtn.TabIndex = 9;
            this.bmiCalculateBtn.Text = "開始計算";
            this.bmiCalculateBtn.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(379, 482);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 42);
            this.button1.TabIndex = 8;
            this.button1.Text = "查看紀錄";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // bmiTitle
            // 
            this.bmiTitle.AutoSize = true;
            this.bmiTitle.Font = new System.Drawing.Font("新細明體", 14.21053F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.bmiTitle.Location = new System.Drawing.Point(57, 43);
            this.bmiTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bmiTitle.Name = "bmiTitle";
            this.bmiTitle.Size = new System.Drawing.Size(290, 19);
            this.bmiTitle.TabIndex = 7;
            this.bmiTitle.Text = "看看自己的BMI是否在理想範圍吧";
            // 
            // bmiStandard
            // 
            this.bmiStandard.Location = new System.Drawing.Point(59, 197);
            this.bmiStandard.Margin = new System.Windows.Forms.Padding(2);
            this.bmiStandard.Name = "bmiStandard";
            this.bmiStandard.Size = new System.Drawing.Size(271, 327);
            this.bmiStandard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bmiStandard.TabIndex = 6;
            this.bmiStandard.TabStop = false;
            // 
            // bmiWeight
            // 
            this.bmiWeight.Location = new System.Drawing.Point(141, 132);
            this.bmiWeight.Margin = new System.Windows.Forms.Padding(2);
            this.bmiWeight.Name = "bmiWeight";
            this.bmiWeight.Size = new System.Drawing.Size(62, 22);
            this.bmiWeight.TabIndex = 5;
            // 
            // bmiHeight
            // 
            this.bmiHeight.Location = new System.Drawing.Point(141, 97);
            this.bmiHeight.Margin = new System.Windows.Forms.Padding(2);
            this.bmiHeight.Name = "bmiHeight";
            this.bmiHeight.Size = new System.Drawing.Size(62, 22);
            this.bmiHeight.TabIndex = 4;
            // 
            // bmiWeightUnit
            // 
            this.bmiWeightUnit.AutoSize = true;
            this.bmiWeightUnit.Location = new System.Drawing.Point(209, 136);
            this.bmiWeightUnit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bmiWeightUnit.Name = "bmiWeightUnit";
            this.bmiWeightUnit.Size = new System.Drawing.Size(17, 12);
            this.bmiWeightUnit.TabIndex = 3;
            this.bmiWeightUnit.Text = "kg";
            // 
            // bmiHeightUnit
            // 
            this.bmiHeightUnit.AutoSize = true;
            this.bmiHeightUnit.Location = new System.Drawing.Point(207, 101);
            this.bmiHeightUnit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bmiHeightUnit.Name = "bmiHeightUnit";
            this.bmiHeightUnit.Size = new System.Drawing.Size(19, 12);
            this.bmiHeightUnit.TabIndex = 2;
            this.bmiHeightUnit.Text = "cm";
            // 
            // bmiWeightLabel
            // 
            this.bmiWeightLabel.AutoSize = true;
            this.bmiWeightLabel.Location = new System.Drawing.Point(59, 135);
            this.bmiWeightLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bmiWeightLabel.Name = "bmiWeightLabel";
            this.bmiWeightLabel.Size = new System.Drawing.Size(35, 12);
            this.bmiWeightLabel.TabIndex = 1;
            this.bmiWeightLabel.Text = "體重 :";
            // 
            // bmiHeightLabel
            // 
            this.bmiHeightLabel.AutoSize = true;
            this.bmiHeightLabel.Location = new System.Drawing.Point(59, 100);
            this.bmiHeightLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bmiHeightLabel.Name = "bmiHeightLabel";
            this.bmiHeightLabel.Size = new System.Drawing.Size(35, 12);
            this.bmiHeightLabel.TabIndex = 0;
            this.bmiHeightLabel.Text = "身高 :";
            // 
            // joggingPanel
            // 
            this.joggingPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.joggingPanel.Controls.Add(this.joggingInfo);
            this.joggingPanel.Controls.Add(this.backBtnJogging);
            this.joggingPanel.Location = new System.Drawing.Point(706, 531);
            this.joggingPanel.Name = "joggingPanel";
            this.joggingPanel.Size = new System.Drawing.Size(724, 535);
            this.joggingPanel.TabIndex = 7;
            this.joggingPanel.Visible = false;
            // 
            // joggingInfo
            // 
            this.joggingInfo.Controls.Add(this.addRecord);
            this.joggingInfo.Controls.Add(this.jogWeekRecordPage);
            this.joggingInfo.Controls.Add(this.jogRecordPage);
            this.joggingInfo.Location = new System.Drawing.Point(70, 38);
            this.joggingInfo.Margin = new System.Windows.Forms.Padding(2);
            this.joggingInfo.Name = "joggingInfo";
            this.joggingInfo.SelectedIndex = 0;
            this.joggingInfo.Size = new System.Drawing.Size(614, 484);
            this.joggingInfo.TabIndex = 2;
            // 
            // addRecord
            // 
            this.addRecord.Controls.Add(this.label8);
            this.addRecord.Controls.Add(this.textBox2);
            this.addRecord.Controls.Add(this.dateTimePicker1);
            this.addRecord.Controls.Add(this.button4);
            this.addRecord.Controls.Add(this.button3);
            this.addRecord.Controls.Add(this.button2);
            this.addRecord.Controls.Add(this.dataGridView1);
            this.addRecord.Location = new System.Drawing.Point(4, 22);
            this.addRecord.Name = "addRecord";
            this.addRecord.Size = new System.Drawing.Size(606, 458);
            this.addRecord.TabIndex = 3;
            this.addRecord.Text = "編輯紀錄";
            this.addRecord.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(445, 296);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 6;
            this.label8.Text = "公尺";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(328, 289);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 5;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(99, 289);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(409, 353);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "修改";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(250, 353);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "刪除";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(99, 353);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "新增";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(55, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(485, 197);
            this.dataGridView1.TabIndex = 0;
            // 
            // jogWeekRecordPage
            // 
            this.jogWeekRecordPage.Controls.Add(this.label9);
            this.jogWeekRecordPage.Controls.Add(this.weekRecord);
            this.jogWeekRecordPage.Controls.Add(this.dataGridView2);
            this.jogWeekRecordPage.Location = new System.Drawing.Point(4, 22);
            this.jogWeekRecordPage.Margin = new System.Windows.Forms.Padding(2);
            this.jogWeekRecordPage.Name = "jogWeekRecordPage";
            this.jogWeekRecordPage.Padding = new System.Windows.Forms.Padding(2);
            this.jogWeekRecordPage.Size = new System.Drawing.Size(606, 458);
            this.jogWeekRecordPage.TabIndex = 0;
            this.jogWeekRecordPage.Text = "本周紀錄";
            this.jogWeekRecordPage.UseVisualStyleBackColor = true;
            // 
            // weekRecord
            // 
            this.weekRecord.Location = new System.Drawing.Point(263, 356);
            this.weekRecord.Name = "weekRecord";
            this.weekRecord.Size = new System.Drawing.Size(75, 23);
            this.weekRecord.TabIndex = 1;
            this.weekRecord.Text = "重新載入";
            this.weekRecord.UseVisualStyleBackColor = true;
            this.weekRecord.Click += new System.EventHandler(this.weekRecord_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(83, 60);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(442, 199);
            this.dataGridView2.TabIndex = 0;
            // 
            // jogRecordPage
            // 
            this.jogRecordPage.Controls.Add(this.label7);
            this.jogRecordPage.Controls.Add(this.button5);
            this.jogRecordPage.Controls.Add(this.dateTimePicker3);
            this.jogRecordPage.Controls.Add(this.dateTimePicker2);
            this.jogRecordPage.Controls.Add(this.dataGridView3);
            this.jogRecordPage.Location = new System.Drawing.Point(4, 22);
            this.jogRecordPage.Margin = new System.Windows.Forms.Padding(2);
            this.jogRecordPage.Name = "jogRecordPage";
            this.jogRecordPage.Size = new System.Drawing.Size(606, 458);
            this.jogRecordPage.TabIndex = 2;
            this.jogRecordPage.Text = "查詢紀錄";
            this.jogRecordPage.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(288, 330);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(11, 12);
            this.label7.TabIndex = 4;
            this.label7.Text = "~";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(251, 386);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 3;
            this.button5.Text = "查詢";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(325, 323);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker3.TabIndex = 2;
            this.dateTimePicker3.ValueChanged += new System.EventHandler(this.dateTimePicker3_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(70, 323);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 1;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(96, 59);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(401, 214);
            this.dataGridView3.TabIndex = 0;
            // 
            // backBtnJogging
            // 
            this.backBtnJogging.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.backBtnJogging.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtnJogging.Location = new System.Drawing.Point(3, 3);
            this.backBtnJogging.Name = "backBtnJogging";
            this.backBtnJogging.Size = new System.Drawing.Size(43, 44);
            this.backBtnJogging.TabIndex = 1;
            this.backBtnJogging.UseVisualStyleBackColor = false;
            this.backBtnJogging.Click += new System.EventHandler(this.backBtnJogging_Click);
            // 
            // dietPanel
            // 
            this.dietPanel.Controls.Add(this.labelCloseBtn);
            this.dietPanel.Controls.Add(this.backBtnDiet);
            this.dietPanel.Controls.Add(this.fruitLabel);
            this.dietPanel.Controls.Add(this.oilLabel);
            this.dietPanel.Controls.Add(this.grainLabel);
            this.dietPanel.Controls.Add(this.vegLabel);
            this.dietPanel.Controls.Add(this.proteinLabel);
            this.dietPanel.Controls.Add(this.dietEnterBtn);
            this.dietPanel.Controls.Add(this.label6);
            this.dietPanel.Controls.Add(this.label5);
            this.dietPanel.Controls.Add(this.label4);
            this.dietPanel.Controls.Add(this.label3);
            this.dietPanel.Controls.Add(this.label2);
            this.dietPanel.Controls.Add(this.grainTxt);
            this.dietPanel.Controls.Add(this.oilTxt);
            this.dietPanel.Controls.Add(this.proteinTxt);
            this.dietPanel.Controls.Add(this.fruitTxt);
            this.dietPanel.Controls.Add(this.vegTxt);
            this.dietPanel.Controls.Add(this.fruitBtn);
            this.dietPanel.Controls.Add(this.label1);
            this.dietPanel.Controls.Add(this.grainsBtn);
            this.dietPanel.Controls.Add(this.oilBtn);
            this.dietPanel.Controls.Add(this.proteinBtn);
            this.dietPanel.Controls.Add(this.vegBtn);
            this.dietPanel.Location = new System.Drawing.Point(760, 16);
            this.dietPanel.Margin = new System.Windows.Forms.Padding(2);
            this.dietPanel.Name = "dietPanel";
            this.dietPanel.Size = new System.Drawing.Size(573, 548);
            this.dietPanel.TabIndex = 6;
            this.dietPanel.Visible = false;
            // 
            // labelCloseBtn
            // 
            this.labelCloseBtn.Enabled = false;
            this.labelCloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelCloseBtn.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelCloseBtn.Location = new System.Drawing.Point(467, 420);
            this.labelCloseBtn.Margin = new System.Windows.Forms.Padding(2);
            this.labelCloseBtn.Name = "labelCloseBtn";
            this.labelCloseBtn.Size = new System.Drawing.Size(73, 37);
            this.labelCloseBtn.TabIndex = 23;
            this.labelCloseBtn.Text = "確認";
            this.labelCloseBtn.UseVisualStyleBackColor = true;
            this.labelCloseBtn.Visible = false;
            this.labelCloseBtn.Click += new System.EventHandler(this.labelCloseBtn_Click);
            // 
            // backBtnDiet
            // 
            this.backBtnDiet.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.backBtnDiet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtnDiet.Location = new System.Drawing.Point(5, 3);
            this.backBtnDiet.Margin = new System.Windows.Forms.Padding(2);
            this.backBtnDiet.Name = "backBtnDiet";
            this.backBtnDiet.Size = new System.Drawing.Size(48, 51);
            this.backBtnDiet.TabIndex = 22;
            this.backBtnDiet.UseVisualStyleBackColor = false;
            this.backBtnDiet.Click += new System.EventHandler(this.backBtnDiet_Click);
            // 
            // fruitLabel
            // 
            this.fruitLabel.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.fruitLabel.Location = new System.Drawing.Point(210, 79);
            this.fruitLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fruitLabel.Name = "fruitLabel";
            this.fruitLabel.Size = new System.Drawing.Size(335, 312);
            this.fruitLabel.TabIndex = 21;
            this.fruitLabel.Visible = false;
            // 
            // oilLabel
            // 
            this.oilLabel.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.oilLabel.Location = new System.Drawing.Point(207, 86);
            this.oilLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.oilLabel.Name = "oilLabel";
            this.oilLabel.Size = new System.Drawing.Size(335, 312);
            this.oilLabel.TabIndex = 20;
            this.oilLabel.Visible = false;
            // 
            // grainLabel
            // 
            this.grainLabel.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grainLabel.Location = new System.Drawing.Point(210, 92);
            this.grainLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.grainLabel.Name = "grainLabel";
            this.grainLabel.Size = new System.Drawing.Size(335, 312);
            this.grainLabel.TabIndex = 19;
            this.grainLabel.Visible = false;
            // 
            // vegLabel
            // 
            this.vegLabel.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.vegLabel.Location = new System.Drawing.Point(205, 86);
            this.vegLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.vegLabel.Name = "vegLabel";
            this.vegLabel.Size = new System.Drawing.Size(335, 312);
            this.vegLabel.TabIndex = 17;
            this.vegLabel.Visible = false;
            // 
            // proteinLabel
            // 
            this.proteinLabel.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.proteinLabel.Location = new System.Drawing.Point(210, 86);
            this.proteinLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.proteinLabel.Name = "proteinLabel";
            this.proteinLabel.Size = new System.Drawing.Size(335, 312);
            this.proteinLabel.TabIndex = 18;
            this.proteinLabel.Visible = false;
            // 
            // dietEnterBtn
            // 
            this.dietEnterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dietEnterBtn.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dietEnterBtn.Location = new System.Drawing.Point(116, 420);
            this.dietEnterBtn.Margin = new System.Windows.Forms.Padding(2);
            this.dietEnterBtn.Name = "dietEnterBtn";
            this.dietEnterBtn.Size = new System.Drawing.Size(58, 37);
            this.dietEnterBtn.TabIndex = 16;
            this.dietEnterBtn.Text = "輸入";
            this.dietEnterBtn.UseVisualStyleBackColor = true;
            this.dietEnterBtn.Click += new System.EventHandler(this.dietEnterBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(158, 367);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 24);
            this.label6.TabIndex = 15;
            this.label6.Text = "份";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(158, 295);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 24);
            this.label5.TabIndex = 14;
            this.label5.Text = "湯匙";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(161, 225);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "份";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(161, 162);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "份";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(161, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "份";
            // 
            // grainTxt
            // 
            this.grainTxt.Location = new System.Drawing.Point(116, 367);
            this.grainTxt.Margin = new System.Windows.Forms.Padding(2);
            this.grainTxt.Name = "grainTxt";
            this.grainTxt.Size = new System.Drawing.Size(38, 22);
            this.grainTxt.TabIndex = 10;
            // 
            // oilTxt
            // 
            this.oilTxt.Location = new System.Drawing.Point(116, 295);
            this.oilTxt.Margin = new System.Windows.Forms.Padding(2);
            this.oilTxt.Name = "oilTxt";
            this.oilTxt.Size = new System.Drawing.Size(38, 22);
            this.oilTxt.TabIndex = 9;
            // 
            // proteinTxt
            // 
            this.proteinTxt.Location = new System.Drawing.Point(116, 225);
            this.proteinTxt.Margin = new System.Windows.Forms.Padding(2);
            this.proteinTxt.Name = "proteinTxt";
            this.proteinTxt.Size = new System.Drawing.Size(38, 22);
            this.proteinTxt.TabIndex = 8;
            // 
            // fruitTxt
            // 
            this.fruitTxt.Location = new System.Drawing.Point(116, 162);
            this.fruitTxt.Margin = new System.Windows.Forms.Padding(2);
            this.fruitTxt.Name = "fruitTxt";
            this.fruitTxt.Size = new System.Drawing.Size(38, 22);
            this.fruitTxt.TabIndex = 7;
            // 
            // vegTxt
            // 
            this.vegTxt.Location = new System.Drawing.Point(116, 100);
            this.vegTxt.Margin = new System.Windows.Forms.Padding(2);
            this.vegTxt.Name = "vegTxt";
            this.vegTxt.Size = new System.Drawing.Size(38, 22);
            this.vegTxt.TabIndex = 6;
            // 
            // fruitBtn
            // 
            this.fruitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fruitBtn.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.fruitBtn.Location = new System.Drawing.Point(33, 149);
            this.fruitBtn.Margin = new System.Windows.Forms.Padding(2);
            this.fruitBtn.Name = "fruitBtn";
            this.fruitBtn.Size = new System.Drawing.Size(79, 33);
            this.fruitBtn.TabIndex = 5;
            this.fruitBtn.Text = "水果";
            this.fruitBtn.UseVisualStyleBackColor = true;
            this.fruitBtn.Click += new System.EventHandler(this.fruitBtn_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(112, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 55);
            this.label1.TabIndex = 4;
            this.label1.Text = "請輸入當餐攝取的種類";
            // 
            // grainsBtn
            // 
            this.grainsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grainsBtn.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grainsBtn.Location = new System.Drawing.Point(24, 356);
            this.grainsBtn.Margin = new System.Windows.Forms.Padding(2);
            this.grainsBtn.Name = "grainsBtn";
            this.grainsBtn.Size = new System.Drawing.Size(88, 35);
            this.grainsBtn.TabIndex = 3;
            this.grainsBtn.Text = "全榖雜糧";
            this.grainsBtn.UseVisualStyleBackColor = true;
            this.grainsBtn.Click += new System.EventHandler(this.grainsBtn_Click);
            // 
            // oilBtn
            // 
            this.oilBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.oilBtn.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.oilBtn.Location = new System.Drawing.Point(33, 284);
            this.oilBtn.Margin = new System.Windows.Forms.Padding(2);
            this.oilBtn.Name = "oilBtn";
            this.oilBtn.Size = new System.Drawing.Size(79, 33);
            this.oilBtn.TabIndex = 2;
            this.oilBtn.Text = "油脂";
            this.oilBtn.UseVisualStyleBackColor = true;
            this.oilBtn.Click += new System.EventHandler(this.oilBtn_Click);
            // 
            // proteinBtn
            // 
            this.proteinBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.proteinBtn.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.proteinBtn.Location = new System.Drawing.Point(33, 214);
            this.proteinBtn.Margin = new System.Windows.Forms.Padding(2);
            this.proteinBtn.Name = "proteinBtn";
            this.proteinBtn.Size = new System.Drawing.Size(79, 33);
            this.proteinBtn.TabIndex = 1;
            this.proteinBtn.Text = "蛋白質";
            this.proteinBtn.UseVisualStyleBackColor = true;
            this.proteinBtn.Click += new System.EventHandler(this.proteinBtn_Click);
            // 
            // vegBtn
            // 
            this.vegBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.vegBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vegBtn.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.vegBtn.Location = new System.Drawing.Point(33, 89);
            this.vegBtn.Margin = new System.Windows.Forms.Padding(2);
            this.vegBtn.Name = "vegBtn";
            this.vegBtn.Size = new System.Drawing.Size(79, 33);
            this.vegBtn.TabIndex = 0;
            this.vegBtn.Text = "蔬菜";
            this.vegBtn.UseVisualStyleBackColor = false;
            this.vegBtn.Click += new System.EventHandler(this.vegBtn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(150, 298);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(298, 24);
            this.label9.TabIndex = 2;
            this.label9.Text = "顯示周一到今日的運動紀錄";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1499, 1061);
            this.Controls.Add(this.weatherPanel);
            this.Controls.Add(this.dietPanel);
            this.Controls.Add(this.joggingPanel);
            this.Controls.Add(this.HomePanel);
            this.Controls.Add(this.bmiPanel);
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
            this.addRecord.ResumeLayout(false);
            this.addRecord.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.jogWeekRecordPage.ResumeLayout(false);
            this.jogWeekRecordPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.jogRecordPage.ResumeLayout(false);
            this.jogRecordPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.dietPanel.ResumeLayout(false);
            this.dietPanel.PerformLayout();
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
        private System.Windows.Forms.Panel bmiPanel;
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

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button grainsBtn;
        private System.Windows.Forms.Button oilBtn;
        private System.Windows.Forms.Button proteinBtn;
        private System.Windows.Forms.Button vegBtn;
        private System.Windows.Forms.Button fruitBtn;
        private System.Windows.Forms.Label fruitLabel;
        private System.Windows.Forms.Label oilLabel;
        private System.Windows.Forms.Label grainLabel;
        private System.Windows.Forms.Label proteinLabel;
        private System.Windows.Forms.Label vegLabel;
        private System.Windows.Forms.Button dietEnterBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox grainTxt;
        private System.Windows.Forms.TextBox oilTxt;
        private System.Windows.Forms.TextBox proteinTxt;
        private System.Windows.Forms.TextBox fruitTxt;
        private System.Windows.Forms.TextBox vegTxt;
        private System.Windows.Forms.Button backBtnDiet;
        private System.Windows.Forms.Button labelCloseBtn;
        private System.Windows.Forms.TabControl joggingInfo;
        private System.Windows.Forms.TabPage addRecord;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage jogWeekRecordPage;
        private System.Windows.Forms.TabPage jogRecordPage;
        private System.Windows.Forms.Button weekRecord;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Label label9;
    }
}

