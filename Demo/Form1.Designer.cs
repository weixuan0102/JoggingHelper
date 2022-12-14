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
            this.weatherPanel.SuspendLayout();
            this.HomePanel.SuspendLayout();
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
            this.joggingBtn.Location = new System.Drawing.Point(133, 37);
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
            this.weatherBtn.Location = new System.Drawing.Point(133, 252);
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
            this.dietBtn.Location = new System.Drawing.Point(341, 252);
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
            this.weatherPanel.Location = new System.Drawing.Point(722, 16);
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
            this.HomePanel.Controls.Add(this.joggingBtn);
            this.HomePanel.Controls.Add(this.weatherBtn);
            this.HomePanel.Controls.Add(this.dietBtn);
            this.HomePanel.Location = new System.Drawing.Point(12, 16);
            this.HomePanel.Name = "HomePanel";
            this.HomePanel.Size = new System.Drawing.Size(672, 525);
            this.HomePanel.TabIndex = 5;
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
            this.dietPanel.Location = new System.Drawing.Point(706, 29);
            this.dietPanel.Name = "dietPanel";
            this.dietPanel.Size = new System.Drawing.Size(740, 559);
            this.dietPanel.TabIndex = 6;
            this.dietPanel.Visible = false;
            // 
            // labelCloseBtn
            // 
            this.labelCloseBtn.Enabled = false;
            this.labelCloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelCloseBtn.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelCloseBtn.Location = new System.Drawing.Point(629, 502);
            this.labelCloseBtn.Name = "labelCloseBtn";
            this.labelCloseBtn.Size = new System.Drawing.Size(83, 37);
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
            this.backBtnDiet.Location = new System.Drawing.Point(3, 3);
            this.backBtnDiet.Name = "backBtnDiet";
            this.backBtnDiet.Size = new System.Drawing.Size(43, 44);
            this.backBtnDiet.TabIndex = 22;
            this.backBtnDiet.UseVisualStyleBackColor = false;
            this.backBtnDiet.Click += new System.EventHandler(this.backBtnDiet_Click);
            // 
            // fruitLabel
            // 
            this.fruitLabel.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.fruitLabel.Location = new System.Drawing.Point(317, 133);
            this.fruitLabel.Name = "fruitLabel";
            this.fruitLabel.Size = new System.Drawing.Size(395, 366);
            this.fruitLabel.TabIndex = 21;
            this.fruitLabel.Visible = false;
            // 
            // oilLabel
            // 
            this.oilLabel.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.oilLabel.Location = new System.Drawing.Point(317, 133);
            this.oilLabel.Name = "oilLabel";
            this.oilLabel.Size = new System.Drawing.Size(395, 366);
            this.oilLabel.TabIndex = 20;
            this.oilLabel.Visible = false;
            // 
            // grainLabel
            // 
            this.grainLabel.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grainLabel.Location = new System.Drawing.Point(329, 140);
            this.grainLabel.Name = "grainLabel";
            this.grainLabel.Size = new System.Drawing.Size(395, 359);
            this.grainLabel.TabIndex = 19;
            this.grainLabel.Visible = false;
            // 
            // vegLabel
            // 
            this.vegLabel.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.vegLabel.Location = new System.Drawing.Point(317, 133);
            this.vegLabel.Name = "vegLabel";
            this.vegLabel.Size = new System.Drawing.Size(395, 366);
            this.vegLabel.TabIndex = 17;
            this.vegLabel.Visible = false;
            // 
            // proteinLabel
            // 
            this.proteinLabel.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.proteinLabel.Location = new System.Drawing.Point(329, 133);
            this.proteinLabel.Name = "proteinLabel";
            this.proteinLabel.Size = new System.Drawing.Size(395, 366);
            this.proteinLabel.TabIndex = 18;
            this.proteinLabel.Visible = false;
            // 
            // dietEnterBtn
            // 
            this.dietEnterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dietEnterBtn.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dietEnterBtn.Location = new System.Drawing.Point(178, 502);
            this.dietEnterBtn.Name = "dietEnterBtn";
            this.dietEnterBtn.Size = new System.Drawing.Size(60, 37);
            this.dietEnterBtn.TabIndex = 16;
            this.dietEnterBtn.Text = "輸入";
            this.dietEnterBtn.UseVisualStyleBackColor = true;
            this.dietEnterBtn.Click += new System.EventHandler(this.dietEnterBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(244, 448);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 24);
            this.label6.TabIndex = 15;
            this.label6.Text = "份";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(244, 375);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 24);
            this.label5.TabIndex = 14;
            this.label5.Text = "湯匙";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(244, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "份";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(244, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "份";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(244, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "份";
            // 
            // grainTxt
            // 
            this.grainTxt.Location = new System.Drawing.Point(178, 450);
            this.grainTxt.Name = "grainTxt";
            this.grainTxt.Size = new System.Drawing.Size(60, 22);
            this.grainTxt.TabIndex = 10;
            // 
            // oilTxt
            // 
            this.oilTxt.Location = new System.Drawing.Point(178, 377);
            this.oilTxt.Name = "oilTxt";
            this.oilTxt.Size = new System.Drawing.Size(60, 22);
            this.oilTxt.TabIndex = 9;
            // 
            // proteinTxt
            // 
            this.proteinTxt.Location = new System.Drawing.Point(178, 298);
            this.proteinTxt.Name = "proteinTxt";
            this.proteinTxt.Size = new System.Drawing.Size(60, 22);
            this.proteinTxt.TabIndex = 8;
            // 
            // fruitTxt
            // 
            this.fruitTxt.Location = new System.Drawing.Point(178, 222);
            this.fruitTxt.Name = "fruitTxt";
            this.fruitTxt.Size = new System.Drawing.Size(60, 22);
            this.fruitTxt.TabIndex = 7;
            // 
            // vegTxt
            // 
            this.vegTxt.Location = new System.Drawing.Point(178, 153);
            this.vegTxt.Name = "vegTxt";
            this.vegTxt.Size = new System.Drawing.Size(60, 22);
            this.vegTxt.TabIndex = 6;
            // 
            // fruitBtn
            // 
            this.fruitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fruitBtn.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.fruitBtn.Location = new System.Drawing.Point(87, 209);
            this.fruitBtn.Name = "fruitBtn";
            this.fruitBtn.Size = new System.Drawing.Size(85, 35);
            this.fruitBtn.TabIndex = 5;
            this.fruitBtn.Text = "水果";
            this.fruitBtn.UseVisualStyleBackColor = true;
            this.fruitBtn.Click += new System.EventHandler(this.fruitBtn_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(186, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 49);
            this.label1.TabIndex = 4;
            this.label1.Text = "請輸入當餐攝取的種類";
            // 
            // grainsBtn
            // 
            this.grainsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grainsBtn.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grainsBtn.Location = new System.Drawing.Point(87, 437);
            this.grainsBtn.Name = "grainsBtn";
            this.grainsBtn.Size = new System.Drawing.Size(85, 35);
            this.grainsBtn.TabIndex = 3;
            this.grainsBtn.Text = "全榖雜糧";
            this.grainsBtn.UseVisualStyleBackColor = true;
            this.grainsBtn.Click += new System.EventHandler(this.grainsBtn_Click);
            // 
            // oilBtn
            // 
            this.oilBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.oilBtn.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.oilBtn.Location = new System.Drawing.Point(87, 364);
            this.oilBtn.Name = "oilBtn";
            this.oilBtn.Size = new System.Drawing.Size(85, 35);
            this.oilBtn.TabIndex = 2;
            this.oilBtn.Text = "油脂";
            this.oilBtn.UseVisualStyleBackColor = true;
            this.oilBtn.Click += new System.EventHandler(this.oilBtn_Click);
            // 
            // proteinBtn
            // 
            this.proteinBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.proteinBtn.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.proteinBtn.Location = new System.Drawing.Point(87, 285);
            this.proteinBtn.Name = "proteinBtn";
            this.proteinBtn.Size = new System.Drawing.Size(85, 35);
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
            this.vegBtn.Location = new System.Drawing.Point(87, 140);
            this.vegBtn.Name = "vegBtn";
            this.vegBtn.Size = new System.Drawing.Size(85, 35);
            this.vegBtn.TabIndex = 0;
            this.vegBtn.Text = "蔬菜";
            this.vegBtn.UseVisualStyleBackColor = false;
            this.vegBtn.Click += new System.EventHandler(this.vegBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1482, 600);
            this.Controls.Add(this.dietPanel);
            this.Controls.Add(this.weatherPanel);
            this.Controls.Add(this.HomePanel);
            this.Name = "Form1";
            this.Text = "健康管理";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.weatherPanel.ResumeLayout(false);
            this.HomePanel.ResumeLayout(false);
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
    }
}

