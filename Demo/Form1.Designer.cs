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
            this.components = new System.ComponentModel.Container();
            this.weatherInfo = new System.Windows.Forms.Label();
            this.joggingBtn = new System.Windows.Forms.Button();
            this.weatherBtn = new System.Windows.Forms.Button();
            this.dietBtn = new System.Windows.Forms.Button();
            this.weatherPanel = new System.Windows.Forms.Panel();
            this.backBtnWeather = new System.Windows.Forms.Button();
            this.HomePanel = new System.Windows.Forms.Panel();
            this.dietPanel = new System.Windows.Forms.Panel();
            this.recordPanel = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.database2DataSet = new Demo.Database2DataSet();
            this.database2DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database2DataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.database2DataSet1 = new Demo.Database2DataSet1();
            this.sportRecordBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sportRecordTableAdapter = new Demo.Database2DataSet1TableAdapters.SportRecordTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.distanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weatherPanel.SuspendLayout();
            this.HomePanel.SuspendLayout();
            this.recordPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportRecordBindingSource)).BeginInit();
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
            this.weatherPanel.Location = new System.Drawing.Point(709, 29);
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
            this.dietPanel.Location = new System.Drawing.Point(709, 29);
            this.dietPanel.Name = "dietPanel";
            this.dietPanel.Size = new System.Drawing.Size(721, 532);
            this.dietPanel.TabIndex = 6;
            // 
            // recordPanel
            // 
            this.recordPanel.Controls.Add(this.dataGridView1);
            this.recordPanel.Location = new System.Drawing.Point(709, 29);
            this.recordPanel.Name = "recordPanel";
            this.recordPanel.Size = new System.Drawing.Size(721, 532);
            this.recordPanel.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.distanceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sportRecordBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(159, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(345, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // database2DataSet
            // 
            this.database2DataSet.DataSetName = "Database2DataSet";
            this.database2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // database2DataSetBindingSource
            // 
            this.database2DataSetBindingSource.DataSource = this.database2DataSet;
            this.database2DataSetBindingSource.Position = 0;
            this.database2DataSetBindingSource.CurrentChanged += new System.EventHandler(this.database2DataSetBindingSource_CurrentChanged);
            // 
            // database2DataSetBindingSource1
            // 
            this.database2DataSetBindingSource1.DataSource = this.database2DataSet;
            this.database2DataSetBindingSource1.Position = 0;
            // 
            // database2DataSet1
            // 
            this.database2DataSet1.DataSetName = "Database2DataSet1";
            this.database2DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sportRecordBindingSource
            // 
            this.sportRecordBindingSource.DataMember = "SportRecord";
            this.sportRecordBindingSource.DataSource = this.database2DataSet1;
            // 
            // sportRecordTableAdapter
            // 
            this.sportRecordTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // distanceDataGridViewTextBoxColumn
            // 
            this.distanceDataGridViewTextBoxColumn.DataPropertyName = "distance";
            this.distanceDataGridViewTextBoxColumn.HeaderText = "distance";
            this.distanceDataGridViewTextBoxColumn.Name = "distanceDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1482, 600);
            this.Controls.Add(this.recordPanel);
            this.Controls.Add(this.dietPanel);
            this.Controls.Add(this.HomePanel);
            this.Controls.Add(this.weatherPanel);
            this.Name = "Form1";
            this.Text = "健康管理";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.weatherPanel.ResumeLayout(false);
            this.HomePanel.ResumeLayout(false);
            this.recordPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportRecordBindingSource)).EndInit();
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
        private System.Windows.Forms.Panel recordPanel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource database2DataSetBindingSource;
        private Database2DataSet database2DataSet;
        private System.Windows.Forms.BindingSource database2DataSetBindingSource1;
        private Database2DataSet1 database2DataSet1;
        private System.Windows.Forms.BindingSource sportRecordBindingSource;
        private Database2DataSet1TableAdapters.SportRecordTableAdapter sportRecordTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn distanceDataGridViewTextBoxColumn;
    }
}

