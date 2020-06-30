namespace MainSurface
{
    partial class 曲线图
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.GraphTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.buttonStop = new System.Windows.Forms.Button();
            this.checkBoxType_X = new System.Windows.Forms.CheckBox();
            this.checkBoxAutoAdjust_Y = new System.Windows.Forms.CheckBox();
            this.checkBoxTimeOrCount = new System.Windows.Forms.CheckBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "DataAnalysit";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(164, 10);
            this.chart1.Margin = new System.Windows.Forms.Padding(2);
            this.chart1.Name = "chart1";
            series1.ChartArea = "DataAnalysit";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(564, 314);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // GraphTimer
            // 
            this.GraphTimer.Interval = 50;
            this.GraphTimer.Tick += new System.EventHandler(this.GraphUpdate);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "数据选择：";
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(9, 76);
            this.buttonStop.Margin = new System.Windows.Forms.Padding(2);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(56, 23);
            this.buttonStop.TabIndex = 2;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // checkBoxType_X
            // 
            this.checkBoxType_X.AutoSize = true;
            this.checkBoxType_X.Location = new System.Drawing.Point(9, 129);
            this.checkBoxType_X.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxType_X.Name = "checkBoxType_X";
            this.checkBoxType_X.Size = new System.Drawing.Size(102, 16);
            this.checkBoxType_X.TabIndex = 3;
            this.checkBoxType_X.Text = "实时/历史数据";
            this.checkBoxType_X.UseVisualStyleBackColor = true;
            this.checkBoxType_X.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBoxAutoAdjust_Y
            // 
            this.checkBoxAutoAdjust_Y.AutoSize = true;
            this.checkBoxAutoAdjust_Y.Location = new System.Drawing.Point(9, 149);
            this.checkBoxAutoAdjust_Y.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxAutoAdjust_Y.Name = "checkBoxAutoAdjust_Y";
            this.checkBoxAutoAdjust_Y.Size = new System.Drawing.Size(90, 16);
            this.checkBoxAutoAdjust_Y.TabIndex = 4;
            this.checkBoxAutoAdjust_Y.Text = "Y轴自动调节";
            this.checkBoxAutoAdjust_Y.UseVisualStyleBackColor = true;
            this.checkBoxAutoAdjust_Y.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBoxTimeOrCount
            // 
            this.checkBoxTimeOrCount.AutoSize = true;
            this.checkBoxTimeOrCount.Location = new System.Drawing.Point(9, 169);
            this.checkBoxTimeOrCount.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxTimeOrCount.Name = "checkBoxTimeOrCount";
            this.checkBoxTimeOrCount.Size = new System.Drawing.Size(108, 16);
            this.checkBoxTimeOrCount.TabIndex = 5;
            this.checkBoxTimeOrCount.Text = "X轴为时间/次数";
            this.checkBoxTimeOrCount.UseVisualStyleBackColor = true;
            this.checkBoxTimeOrCount.CheckedChanged += new System.EventHandler(this.checkBoxTimeOrCount_CheckedChanged);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(9, 47);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(2);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(56, 25);
            this.buttonStart.TabIndex = 6;
            this.buttonStart.Text = "开始";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(9, 104);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(56, 20);
            this.buttonClear.TabIndex = 7;
            this.buttonClear.Text = "清除";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // 曲线图
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 335);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.checkBoxTimeOrCount);
            this.Controls.Add(this.checkBoxAutoAdjust_Y);
            this.Controls.Add(this.checkBoxType_X);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart1);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "曲线图";
            this.Text = "曲线图";
            this.Load += new System.EventHandler(this.曲线图_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Timer GraphTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.CheckBox checkBoxType_X;
        private System.Windows.Forms.CheckBox checkBoxAutoAdjust_Y;
        private System.Windows.Forms.CheckBox checkBoxTimeOrCount;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonClear;
    }
}