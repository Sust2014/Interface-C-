namespace MainSurface
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.libFormat = new System.Windows.Forms.Label();
            this.ComBoxFrameFormat = new System.Windows.Forms.ComboBox();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.设备操作ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.启动设备ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.参数设定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cAN参数设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于作者ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新建ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.窗口ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.全部最大化ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.全部最小化ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.层叠ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.水平ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.垂直ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.图标ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.文件操作ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.另存为ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bootLoaderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.启动BootLoaderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.tssLab_1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.RececiveTime = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.ComBoxFrameType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBoxSend = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxCycleSendNum = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TextBoxSendInterTime = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.checkBoxReceive = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.ButtonEmpty = new System.Windows.Forms.Button();
            this.buttonSaveFile = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBoxOfDataFormat = new System.Windows.Forms.CheckBox();
            this.SendTime = new System.Windows.Forms.Timer(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.listViewRecieve = new MainSurface.ListViewNF();
            this.Index = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CanChannal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Orientation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Frame = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Length = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Data = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // libFormat
            // 
            this.libFormat.AutoSize = true;
            this.libFormat.Location = new System.Drawing.Point(16, 41);
            this.libFormat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.libFormat.Name = "libFormat";
            this.libFormat.Size = new System.Drawing.Size(67, 15);
            this.libFormat.TabIndex = 0;
            this.libFormat.Text = "帧格式：";
            // 
            // ComBoxFrameFormat
            // 
            this.ComBoxFrameFormat.FormattingEnabled = true;
            this.ComBoxFrameFormat.Items.AddRange(new object[] {
            "标准帧",
            "扩展帧"});
            this.ComBoxFrameFormat.Location = new System.Drawing.Point(95, 38);
            this.ComBoxFrameFormat.Margin = new System.Windows.Forms.Padding(4);
            this.ComBoxFrameFormat.Name = "ComBoxFrameFormat";
            this.ComBoxFrameFormat.Size = new System.Drawing.Size(99, 23);
            this.ComBoxFrameFormat.TabIndex = 2;
            this.ComBoxFrameFormat.SelectedIndexChanged += new System.EventHandler(this.comForMat_SelectedIndexChanged);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.设备操作ToolStripMenuItem,
            this.参数设定ToolStripMenuItem,
            this.信息ToolStripMenuItem,
            this.文件ToolStripMenuItem,
            this.窗口ToolStripMenuItem,
            this.文件操作ToolStripMenuItem,
            this.bootLoaderToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.MdiWindowListItem = this.窗口ToolStripMenuItem;
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip2.Size = new System.Drawing.Size(487, 28);
            this.menuStrip2.TabIndex = 4;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // 设备操作ToolStripMenuItem
            // 
            this.设备操作ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.启动设备ToolStripMenuItem});
            this.设备操作ToolStripMenuItem.Name = "设备操作ToolStripMenuItem";
            this.设备操作ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.设备操作ToolStripMenuItem.Text = "设备操作";
            this.设备操作ToolStripMenuItem.Click += new System.EventHandler(this.设备操作ToolStripMenuItem_Click);
            // 
            // 启动设备ToolStripMenuItem
            // 
            this.启动设备ToolStripMenuItem.Name = "启动设备ToolStripMenuItem";
            this.启动设备ToolStripMenuItem.Size = new System.Drawing.Size(146, 24);
            this.启动设备ToolStripMenuItem.Text = "USB-CAN";
            this.启动设备ToolStripMenuItem.Click += new System.EventHandler(this.启动设备ToolStripMenuItem_Click);
            // 
            // 参数设定ToolStripMenuItem
            // 
            this.参数设定ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cAN参数设置ToolStripMenuItem});
            this.参数设定ToolStripMenuItem.Name = "参数设定ToolStripMenuItem";
            this.参数设定ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.参数设定ToolStripMenuItem.Text = "参数设定";
            // 
            // cAN参数设置ToolStripMenuItem
            // 
            this.cAN参数设置ToolStripMenuItem.Name = "cAN参数设置ToolStripMenuItem";
            this.cAN参数设置ToolStripMenuItem.Size = new System.Drawing.Size(171, 24);
            this.cAN参数设置ToolStripMenuItem.Text = "CAN参数设置";
            this.cAN参数设置ToolStripMenuItem.Click += new System.EventHandler(this.cAN参数设置ToolStripMenuItem_Click);
            // 
            // 信息ToolStripMenuItem
            // 
            this.信息ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于作者ToolStripMenuItem});
            this.信息ToolStripMenuItem.Name = "信息ToolStripMenuItem";
            this.信息ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.信息ToolStripMenuItem.Text = "信息";
            this.信息ToolStripMenuItem.Click += new System.EventHandler(this.信息ToolStripMenuItem_Click);
            // 
            // 关于作者ToolStripMenuItem
            // 
            this.关于作者ToolStripMenuItem.Name = "关于作者ToolStripMenuItem";
            this.关于作者ToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.关于作者ToolStripMenuItem.Text = "关于作者";
            this.关于作者ToolStripMenuItem.Click += new System.EventHandler(this.关于作者ToolStripMenuItem_Click);
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建ToolStripMenuItem,
            this.toolStripMenuItem2});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 新建ToolStripMenuItem
            // 
            this.新建ToolStripMenuItem.Name = "新建ToolStripMenuItem";
            this.新建ToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.新建ToolStripMenuItem.Text = "新建";
            this.新建ToolStripMenuItem.Click += new System.EventHandler(this.新建ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(108, 24);
            this.toolStripMenuItem2.Text = " ";
            // 
            // 窗口ToolStripMenuItem
            // 
            this.窗口ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.全部最大化ToolStripMenuItem,
            this.全部最小化ToolStripMenuItem,
            this.层叠ToolStripMenuItem,
            this.水平ToolStripMenuItem,
            this.垂直ToolStripMenuItem,
            this.图标ToolStripMenuItem});
            this.窗口ToolStripMenuItem.Name = "窗口ToolStripMenuItem";
            this.窗口ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.窗口ToolStripMenuItem.Text = "窗口";
            // 
            // 全部最大化ToolStripMenuItem
            // 
            this.全部最大化ToolStripMenuItem.Name = "全部最大化ToolStripMenuItem";
            this.全部最大化ToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this.全部最大化ToolStripMenuItem.Text = "全部最大化";
            this.全部最大化ToolStripMenuItem.Click += new System.EventHandler(this.全部最大化ToolStripMenuItem_Click);
            // 
            // 全部最小化ToolStripMenuItem
            // 
            this.全部最小化ToolStripMenuItem.Name = "全部最小化ToolStripMenuItem";
            this.全部最小化ToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this.全部最小化ToolStripMenuItem.Text = "全部最小化";
            this.全部最小化ToolStripMenuItem.Click += new System.EventHandler(this.全部最小化ToolStripMenuItem_Click);
            // 
            // 层叠ToolStripMenuItem
            // 
            this.层叠ToolStripMenuItem.Name = "层叠ToolStripMenuItem";
            this.层叠ToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this.层叠ToolStripMenuItem.Text = "层叠";
            this.层叠ToolStripMenuItem.Click += new System.EventHandler(this.层叠ToolStripMenuItem_Click);
            // 
            // 水平ToolStripMenuItem
            // 
            this.水平ToolStripMenuItem.Name = "水平ToolStripMenuItem";
            this.水平ToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this.水平ToolStripMenuItem.Text = "水平";
            this.水平ToolStripMenuItem.Click += new System.EventHandler(this.水平ToolStripMenuItem_Click);
            // 
            // 垂直ToolStripMenuItem
            // 
            this.垂直ToolStripMenuItem.Name = "垂直ToolStripMenuItem";
            this.垂直ToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this.垂直ToolStripMenuItem.Text = "垂直";
            this.垂直ToolStripMenuItem.Click += new System.EventHandler(this.垂直ToolStripMenuItem_Click);
            // 
            // 图标ToolStripMenuItem
            // 
            this.图标ToolStripMenuItem.Name = "图标ToolStripMenuItem";
            this.图标ToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this.图标ToolStripMenuItem.Text = "图标";
            this.图标ToolStripMenuItem.Click += new System.EventHandler(this.图标ToolStripMenuItem_Click);
            // 
            // 文件操作ToolStripMenuItem
            // 
            this.文件操作ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开ToolStripMenuItem,
            this.另存为ToolStripMenuItem});
            this.文件操作ToolStripMenuItem.Name = "文件操作ToolStripMenuItem";
            this.文件操作ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.文件操作ToolStripMenuItem.Text = "文件操作";
            // 
            // 打开ToolStripMenuItem
            // 
            this.打开ToolStripMenuItem.Name = "打开ToolStripMenuItem";
            this.打开ToolStripMenuItem.Size = new System.Drawing.Size(123, 24);
            this.打开ToolStripMenuItem.Text = "打开";
            this.打开ToolStripMenuItem.Click += new System.EventHandler(this.打开ToolStripMenuItem_Click);
            // 
            // 另存为ToolStripMenuItem
            // 
            this.另存为ToolStripMenuItem.Name = "另存为ToolStripMenuItem";
            this.另存为ToolStripMenuItem.Size = new System.Drawing.Size(123, 24);
            this.另存为ToolStripMenuItem.Text = "另存为";
            this.另存为ToolStripMenuItem.Click += new System.EventHandler(this.另存为ToolStripMenuItem_Click);
            // 
            // bootLoaderToolStripMenuItem
            // 
            this.bootLoaderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.启动BootLoaderToolStripMenuItem});
            this.bootLoaderToolStripMenuItem.Name = "bootLoaderToolStripMenuItem";
            this.bootLoaderToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.bootLoaderToolStripMenuItem.Text = "程序升级";
            // 
            // 启动BootLoaderToolStripMenuItem
            // 
            this.启动BootLoaderToolStripMenuItem.Name = "启动BootLoaderToolStripMenuItem";
            this.启动BootLoaderToolStripMenuItem.Size = new System.Drawing.Size(204, 24);
            this.启动BootLoaderToolStripMenuItem.Text = "OpenBootLoader";
            this.启动BootLoaderToolStripMenuItem.Click += new System.EventHandler(this.OpenBootLoaderToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1,
            this.tssLab_1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 600);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.ShowItemToolTips = true;
            this.statusStrip1.Size = new System.Drawing.Size(1014, 26);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(133, 20);
            // 
            // tssLab_1
            // 
            this.tssLab_1.Name = "tssLab_1";
            this.tssLab_1.Size = new System.Drawing.Size(167, 21);
            this.tssLab_1.Text = "toolStripStatusLabel1";
            this.tssLab_1.Click += new System.EventHandler(this.tssLab_1_Click);
            // 
            // RececiveTime
            // 
            this.RececiveTime.Enabled = true;
            this.RececiveTime.Interval = 1000;
            this.RececiveTime.Tick += new System.EventHandler(this.ReceiveTime_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(216, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "帧类型：";
            // 
            // ComBoxFrameType
            // 
            this.ComBoxFrameType.FormattingEnabled = true;
            this.ComBoxFrameType.Items.AddRange(new object[] {
            "数据帧",
            "远程帧"});
            this.ComBoxFrameType.Location = new System.Drawing.Point(295, 38);
            this.ComBoxFrameType.Margin = new System.Windows.Forms.Padding(4);
            this.ComBoxFrameType.Name = "ComBoxFrameType";
            this.ComBoxFrameType.Size = new System.Drawing.Size(99, 23);
            this.ComBoxFrameType.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(416, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "帧ID：";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(479, 36);
            this.textBoxID.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(113, 25);
            this.textBoxID.TabIndex = 9;
            this.textBoxID.Text = "00 00  03 11";
            this.textBoxID.TextChanged += new System.EventHandler(this.textBoxID_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 72);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "发送数据：";
            // 
            // TextBoxSend
            // 
            this.TextBoxSend.Location = new System.Drawing.Point(111, 69);
            this.TextBoxSend.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxSend.Name = "TextBoxSend";
            this.TextBoxSend.Size = new System.Drawing.Size(191, 25);
            this.TextBoxSend.TabIndex = 11;
            this.TextBoxSend.Text = "11 22 33 44 55 66 77 88";
            this.TextBoxSend.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(312, 68);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 29);
            this.button1.TabIndex = 12;
            this.button1.Text = "发送";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(601, 39);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "发送总帧数：";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBoxCycleSendNum
            // 
            this.textBoxCycleSendNum.Location = new System.Drawing.Point(712, 35);
            this.textBoxCycleSendNum.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCycleSendNum.Name = "textBoxCycleSendNum";
            this.textBoxCycleSendNum.Size = new System.Drawing.Size(99, 25);
            this.textBoxCycleSendNum.TabIndex = 14;
            this.textBoxCycleSendNum.TextChanged += new System.EventHandler(this.textBoxCycleSendNum_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(601, 69);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "帧与帧间隔：";
            // 
            // TextBoxSendInterTime
            // 
            this.TextBoxSendInterTime.Location = new System.Drawing.Point(712, 65);
            this.TextBoxSendInterTime.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxSendInterTime.Name = "TextBoxSendInterTime";
            this.TextBoxSendInterTime.Size = new System.Drawing.Size(99, 25);
            this.TextBoxSendInterTime.TabIndex = 16;
            this.TextBoxSendInterTime.TextChanged += new System.EventHandler(this.TextBoxSendInterTime_TextChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(8, 21);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(189, 19);
            this.radioButton1.TabIndex = 18;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "SJA1000格式（左对齐）";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(8, 49);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(164, 19);
            this.radioButton2.TabIndex = 19;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "直接ID号（右对齐）";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Location = new System.Drawing.Point(20, 105);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(207, 80);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ID格式：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton4);
            this.groupBox2.Controls.Add(this.radioButton3);
            this.groupBox2.Location = new System.Drawing.Point(235, 105);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(177, 80);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "接收滤波ID设置：";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(8, 49);
            this.radioButton4.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(58, 19);
            this.radioButton4.TabIndex = 1;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "关闭";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(8, 21);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(58, 19);
            this.radioButton3.TabIndex = 0;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "使能";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // checkBoxReceive
            // 
            this.checkBoxReceive.AutoSize = true;
            this.checkBoxReceive.Location = new System.Drawing.Point(420, 150);
            this.checkBoxReceive.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxReceive.Name = "checkBoxReceive";
            this.checkBoxReceive.Size = new System.Drawing.Size(113, 19);
            this.checkBoxReceive.TabIndex = 22;
            this.checkBoxReceive.Text = "打开CAN接收";
            this.checkBoxReceive.UseVisualStyleBackColor = true;
            this.checkBoxReceive.CheckedChanged += new System.EventHandler(this.checkBoxReceive_CheckedChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(561, 100);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 29);
            this.button2.TabIndex = 23;
            this.button2.Text = "停止发送";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(681, 100);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 29);
            this.button3.TabIndex = 24;
            this.button3.Text = "发送文件";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // ButtonEmpty
            // 
            this.ButtonEmpty.Location = new System.Drawing.Point(561, 145);
            this.ButtonEmpty.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonEmpty.Name = "ButtonEmpty";
            this.ButtonEmpty.Size = new System.Drawing.Size(100, 29);
            this.ButtonEmpty.TabIndex = 25;
            this.ButtonEmpty.Text = "清空";
            this.ButtonEmpty.UseVisualStyleBackColor = true;
            this.ButtonEmpty.Click += new System.EventHandler(this.ButtonEmpty_Click);
            // 
            // buttonSaveFile
            // 
            this.buttonSaveFile.Location = new System.Drawing.Point(681, 145);
            this.buttonSaveFile.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSaveFile.Name = "buttonSaveFile";
            this.buttonSaveFile.Size = new System.Drawing.Size(100, 29);
            this.buttonSaveFile.TabIndex = 26;
            this.buttonSaveFile.Text = "保存文件";
            this.buttonSaveFile.UseVisualStyleBackColor = true;
            this.buttonSaveFile.Click += new System.EventHandler(this.buttonSaveFile_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBox1);
            this.groupBox3.Controls.Add(this.checkBoxOfDataFormat);
            this.groupBox3.Location = new System.Drawing.Point(832, 35);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(160, 139);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "辅助功能";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(7, 25);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(134, 19);
            this.checkBox1.TabIndex = 23;
            this.checkBox1.Text = "开启图形化显示";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBoxOfDataFormat
            // 
            this.checkBoxOfDataFormat.AutoSize = true;
            this.checkBoxOfDataFormat.Location = new System.Drawing.Point(8, 52);
            this.checkBoxOfDataFormat.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxOfDataFormat.Name = "checkBoxOfDataFormat";
            this.checkBoxOfDataFormat.Size = new System.Drawing.Size(134, 19);
            this.checkBoxOfDataFormat.TabIndex = 22;
            this.checkBoxOfDataFormat.Text = "开启十进制显示";
            this.checkBoxOfDataFormat.UseVisualStyleBackColor = true;
            this.checkBoxOfDataFormat.CheckedChanged += new System.EventHandler(this.checkBoxOfDataFormat_CheckedChanged);
            // 
            // SendTime
            // 
            this.SendTime.Enabled = true;
            this.SendTime.Tick += new System.EventHandler(this.CycleSendData);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.listViewRecieve);
            this.groupBox4.Location = new System.Drawing.Point(19, 192);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(984, 391);
            this.groupBox4.TabIndex = 29;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "接收数据";
            // 
            // listViewRecieve
            // 
            this.listViewRecieve.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Index,
            this.Time,
            this.CanChannal,
            this.Orientation,
            this.Id,
            this.Frame,
            this.Type,
            this.Length,
            this.Data});
            this.listViewRecieve.FullRowSelect = true;
            this.listViewRecieve.Location = new System.Drawing.Point(8, 25);
            this.listViewRecieve.Margin = new System.Windows.Forms.Padding(4);
            this.listViewRecieve.Name = "listViewRecieve";
            this.listViewRecieve.Size = new System.Drawing.Size(965, 358);
            this.listViewRecieve.TabIndex = 27;
            this.listViewRecieve.UseCompatibleStateImageBehavior = false;
            this.listViewRecieve.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listViewRecieve.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listViewRecieve_MouseDown);
            // 
            // Index
            // 
            this.Index.Text = "序号";
            this.Index.Width = 40;
            // 
            // Time
            // 
            this.Time.Text = "时间";
            this.Time.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Time.Width = 80;
            // 
            // CanChannal
            // 
            this.CanChannal.Text = "CAN通道";
            this.CanChannal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Orientation
            // 
            this.Orientation.Text = "传输方向";
            this.Orientation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Orientation.Width = 70;
            // 
            // Id
            // 
            this.Id.Text = "ID号";
            this.Id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Frame
            // 
            this.Frame.Text = "帧类型";
            this.Frame.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Type
            // 
            this.Type.Text = "帧格式";
            this.Type.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Length
            // 
            this.Length.Text = "数据长度";
            this.Length.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Length.Width = 70;
            // 
            // Data
            // 
            this.Data.Text = "数据";
            this.Data.Width = 200;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 626);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.buttonSaveFile);
            this.Controls.Add(this.ButtonEmpty);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.checkBoxReceive);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TextBoxSendInterTime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxCycleSendNum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TextBoxSend);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ComBoxFrameType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ComBoxFrameFormat);
            this.Controls.Add(this.libFormat);
            this.Controls.Add(this.menuStrip2);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.Text = "CANTools V1.0.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label libFormat;
        private System.Windows.Forms.ComboBox ComBoxFrameFormat;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem 设备操作ToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem 启动设备ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 参数设定ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 信息ToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel tssLab_1;
        private System.Windows.Forms.Timer RececiveTime;
        private System.Windows.Forms.ToolStripMenuItem 关于作者ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cAN参数设置ToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ComBoxFrameType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextBoxSend;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxCycleSendNum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TextBoxSendInterTime;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.CheckBox checkBoxReceive;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button ButtonEmpty;
        private System.Windows.Forms.Button buttonSaveFile;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新建ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem 窗口ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 全部最大化ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 全部最小化ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 层叠ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 水平ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 垂直ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 图标ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 文件操作ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 另存为ToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        //private System.Windows.Forms.ListView listViewRecieve;
        private ListViewNF listViewRecieve;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ToolStripMenuItem bootLoaderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 启动BootLoaderToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader Index;
        private System.Windows.Forms.ColumnHeader Time;
        private System.Windows.Forms.ColumnHeader CanChannal;
        private System.Windows.Forms.ColumnHeader Orientation;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader Frame;
        private System.Windows.Forms.ColumnHeader Type;
        private System.Windows.Forms.ColumnHeader Length;
        private System.Windows.Forms.ColumnHeader Data;
        private System.Windows.Forms.CheckBox checkBoxOfDataFormat;
        private System.Windows.Forms.Timer SendTime;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

