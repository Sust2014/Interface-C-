namespace WindowsFormsApplication1
{
    partial class CAN参数设置
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
            this.ComBoxChannelChoose = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ComBoxBaudChoose = new System.Windows.Forms.ComboBox();
            this.ParaSet_Button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.ComBoxWorkMode = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // ComBoxChannelChoose
            // 
            this.ComBoxChannelChoose.FormattingEnabled = true;
            this.ComBoxChannelChoose.Items.AddRange(new object[] {
            "0",
            "1"});
            this.ComBoxChannelChoose.Location = new System.Drawing.Point(100, 6);
            this.ComBoxChannelChoose.Name = "ComBoxChannelChoose";
            this.ComBoxChannelChoose.Size = new System.Drawing.Size(56, 23);
            this.ComBoxChannelChoose.TabIndex = 0;
            this.ComBoxChannelChoose.SelectedIndexChanged += new System.EventHandler(this.ComBoxChannelChoose_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "通道选择：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "波特率选择：";
            // 
            // ComBoxBaudChoose
            // 
            this.ComBoxBaudChoose.FormattingEnabled = true;
            this.ComBoxBaudChoose.Items.AddRange(new object[] {
            "5",
            "10",
            "20",
            "40",
            "50",
            "80",
            "100",
            "125",
            "200",
            "250",
            "400",
            "500",
            "666",
            "800",
            "1000"});
            this.ComBoxBaudChoose.Location = new System.Drawing.Point(111, 25);
            this.ComBoxBaudChoose.Name = "ComBoxBaudChoose";
            this.ComBoxBaudChoose.Size = new System.Drawing.Size(59, 23);
            this.ComBoxBaudChoose.TabIndex = 3;
            this.ComBoxBaudChoose.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // ParaSet_Button
            // 
            this.ParaSet_Button.Location = new System.Drawing.Point(220, 23);
            this.ParaSet_Button.Name = "ParaSet_Button";
            this.ParaSet_Button.Size = new System.Drawing.Size(75, 23);
            this.ParaSet_Button.TabIndex = 4;
            this.ParaSet_Button.Text = "设置";
            this.ParaSet_Button.UseVisualStyleBackColor = true;
            this.ParaSet_Button.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.ComBoxWorkMode);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(14, 108);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(313, 54);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "工作模式选择：";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(218, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "设置";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ComBoxWorkMode
            // 
            this.ComBoxWorkMode.FormattingEnabled = true;
            this.ComBoxWorkMode.Items.AddRange(new object[] {
            "正常工作",
            "自发自收测试"});
            this.ComBoxWorkMode.Location = new System.Drawing.Point(86, 19);
            this.ComBoxWorkMode.Name = "ComBoxWorkMode";
            this.ComBoxWorkMode.Size = new System.Drawing.Size(97, 23);
            this.ComBoxWorkMode.TabIndex = 6;
            this.ComBoxWorkMode.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "工作模式：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.comboBox5);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(14, 168);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(313, 98);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "滤波器：";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(218, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "设置";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(99, 70);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 25);
            this.textBox2.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "过滤屏蔽ID：";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(99, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 25);
            this.textBox1.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "过滤验收ID：";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(184, 16);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(149, 19);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "自定义屏蔽寄存器";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            "单滤波",
            "双滤波"});
            this.comboBox5.Location = new System.Drawing.Point(86, 14);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(71, 23);
            this.comboBox5.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "过滤模式：";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ParaSet_Button);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.ComBoxBaudChoose);
            this.groupBox3.Location = new System.Drawing.Point(12, 32);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(315, 70);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "常规参数：";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(232, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "设置";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // CAN参数设置
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.ClientSize = new System.Drawing.Size(341, 275);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ComBoxChannelChoose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CAN参数设置";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CAN参数设置";
            this.Load += new System.EventHandler(this.CAN参数设置_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CAN参数设置_KeyPress);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label paraset_BaudRate;
        private System.Windows.Forms.Label paraset_Channel;
        private System.Windows.Forms.ComboBox paraset_ChannelChoose;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ParaSetbt;
        private System.Windows.Forms.ComboBox ComBoxChannelChoose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ComBoxBaudChoose;
        private System.Windows.Forms.Button ParaSet_Button;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox ComBoxWorkMode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button3;
    }
}