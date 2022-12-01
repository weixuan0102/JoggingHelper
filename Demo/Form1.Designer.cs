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
            this.weatherPanel.SuspendLayout();
            this.HomePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // weatherInfo
            // 
            this.weatherInfo.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.weatherInfo.Location = new System.Drawing.Point(14, 13);
            this.weatherInfo.Name = "weatherInfo";
            this.weatherInfo.Size = new System.Drawing.Size(644, 458);
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
            this.weatherPanel.Controls.Add(this.weatherInfo);
            this.weatherPanel.Controls.Add(this.backBtnWeather);
            this.weatherPanel.Location = new System.Drawing.Point(709, 29);
            this.weatherPanel.Name = "weatherPanel";
            this.weatherPanel.Size = new System.Drawing.Size(724, 535);
            this.weatherPanel.TabIndex = 4;
            this.weatherPanel.Visible = false;
            // 
            // backBtnWeather
            // 
            this.backBtnWeather.Location = new System.Drawing.Point(316, 474);
            this.backBtnWeather.Name = "backBtnWeather";
            this.backBtnWeather.Size = new System.Drawing.Size(109, 32);
            this.backBtnWeather.TabIndex = 4;
            this.backBtnWeather.Text = "返回";
            this.backBtnWeather.UseVisualStyleBackColor = true;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1482, 600);
            this.Controls.Add(this.HomePanel);
            this.Controls.Add(this.weatherPanel);
            this.Name = "Form1";
            this.Text = "健康管理";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.weatherPanel.ResumeLayout(false);
            this.HomePanel.ResumeLayout(false);
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
    }
}

