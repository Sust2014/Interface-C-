using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MainSurface
{
    public partial class 曲线图 : Form
    {
        //图形显示横坐标
        public static int Graph_X = 0;

        //X轴为时间轴、次数轴标志
        private bool Graph_X_Type;

        //X轴为时间轴标志 次数标志
        private bool RealTimeFlag;
        private bool CountFlag;

        public 曲线图()
        {
            InitializeComponent();
            //GraphDraw();
        }

        private Random rand = new Random();

        private DateTime X_minValue;    //横坐标最初值

        /*初始化表格*/
        private void InitChart()
        {
            if (Graph_X_Type == false)
            {
                X_minValue = DateTime.Now;          //x轴最小刻度 
                RealTimeFlag = true;
            }
            //定义图表区域
            this.chart1.ChartAreas.Clear();
            ChartArea chartArea1 = new ChartArea("C1");
            this.chart1.ChartAreas.Add(chartArea1);
            //定义存储和显示点的容器
            this.chart1.Series.Clear();

            Series series1 = new Series("S1");
            series1.ChartArea = "C1";
            this.chart1.Series.Add(series1);

            /***************************允许X轴放大******************************/
            chartArea1.CursorX.IsUserEnabled = true;//
            chartArea1.CursorX.IsUserSelectionEnabled = true;
            chartArea1.CursorX.Interval = 0;
            chartArea1.CursorX.IntervalOffset = 0;
            chartArea1.CursorX.IntervalType = DateTimeIntervalType.Minutes;
            chartArea1.AxisX.ScaleView.Zoomable = true;
            chartArea1.AxisX.ScrollBar.IsPositionedInside = true;
            /***************************允许X轴放大******************************/


            //设置图表显示样式
            if (Graph_X_Type == false)
            {
                this.chart1.ChartAreas[0].AxisX.LabelStyle.Format = "HH:mm:ss";         //毫秒格式： hh:mm:ss.fff ，后面几个f则保留几位毫秒小数，此时要注意轴的最大值和最小值不要差太大
                this.chart1.ChartAreas[0].AxisX.LabelStyle.IntervalType = DateTimeIntervalType.Seconds;
                this.chart1.ChartAreas[0].AxisX.LabelStyle.Interval = 1;                //坐标值间隔1S
                this.chart1.ChartAreas[0].AxisX.LabelStyle.IsEndLabelVisible = false;   //防止X轴坐标跳跃
                this.chart1.ChartAreas[0].AxisX.MajorGrid.IntervalType = DateTimeIntervalType.Seconds;
                this.chart1.ChartAreas[0].AxisX.MajorGrid.Interval = 1;                 //网格间隔
                this.chart1.ChartAreas[0].AxisX.Minimum = DateTime.Now.ToOADate();      //当前时间
                this.chart1.ChartAreas[0].AxisX.Maximum = DateTime.Now.ToOADate();
            }
            else
            {
                this.chart1.ChartAreas[0].AxisX.LabelStyle.Interval = 1;                //坐标值间隔
                this.chart1.ChartAreas[0].AxisX.LabelStyle.IsEndLabelVisible = false;   //防止X轴坐标跳跃
                this.chart1.ChartAreas[0].AxisX.MajorGrid.Interval = 1;                 //网格间隔
                this.chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = System.Drawing.Color.Silver;
                this.chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = System.Drawing.Color.Silver;
                this.chart1.ChartAreas[0].AxisX.Minimum = 0;     //X轴最小值
                this.chart1.ChartAreas[0].AxisY.Minimum = 0;      //Y轴最小值
            }
            //设置标题
            this.chart1.Titles.Clear();
            this.chart1.Titles.Add("S01");
            this.chart1.Titles[0].Text = "XXX显示";
            this.chart1.Titles[0].ForeColor = Color.RoyalBlue;
            this.chart1.Titles[0].Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            //设置图表显示样式
            this.chart1.Series[0].Color = Color.Green;
            this.chart1.Series[0].ChartType = SeriesChartType.Line;
            this.chart1.Series[0].Points.Clear();
        }

        /*更新图标数据*/
        private void GraphUpdate(object sender, EventArgs e)
        {
            /*Graph_X_Type为true X轴切换为次数*/
            if (Graph_X_Type)
            {
                if (Graph_X++ == 1000000)
                    Graph_X = 0;
                chart1.Series[0].Points.AddXY(Graph_X, rand.Next(0, 10));
                chart1.ChartAreas[0].AxisX.Maximum = Graph_X + 1;   //X坐标后移1秒
                if (checkBoxType_X.Checked == true)
                    chart1.ChartAreas[0].AxisX.Minimum = Graph_X - 10;      //此刻后10位作为最初X轴，
            }
            else
            {
                chart1.Series[0].Points.AddXY(DateTime.Now.ToOADate(), rand.Next(0, 10));
                chart1.ChartAreas[0].AxisX.Maximum = DateTime.Now.AddSeconds(1).ToOADate();   //X坐标后移1秒
                if (checkBoxType_X.Checked == true)
                    chart1.ChartAreas[0].AxisX.Minimum = DateTime.Now.AddSeconds(-10).ToOADate();//此刻后10分钟作为最初X轴，
            }
        }

        private void 曲线图_Load(object sender, EventArgs e)
        {
            //InitChart();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            GraphTimer.Enabled = false;
            checkBoxType_X.Checked = false;
            checkBoxAutoAdjust_Y.Checked = false;
            checkBoxTimeOrCount.Checked = false;
            RealTimeFlag = false;
            GraphTimer.Stop();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (Graph_X_Type == false)
            {
                if (checkBoxType_X.Checked == false)           //X轴设置成显示最初时间坐标
                    chart1.ChartAreas[0].AxisX.Minimum = X_minValue.ToOADate();       //最初打开时候为X轴
            }
            else
            {
                if (checkBoxType_X.Checked == false)           //X轴设置成显示最初时间坐标
                    chart1.ChartAreas[0].AxisX.Minimum = 0;       //最初打开时候为X轴
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAutoAdjust_Y.Checked == true)          //允许放大Y轴
            {
                chart1.ChartAreas[0].CursorY.IsUserEnabled = true;
                chart1.ChartAreas[0].CursorY.IsUserSelectionEnabled = true;
            }
            else
            {
                chart1.ChartAreas[0].CursorY.IsUserEnabled = false;
                chart1.ChartAreas[0].CursorY.IsUserSelectionEnabled = false;
            }
        }

        private void checkBoxTimeOrCount_CheckedChanged(object sender, EventArgs e)
        {
            /*开始后，X轴为时间轴切换为次数轴
             * X轴为次数轴切换为时间轴
             * 提示停止后更换
             * */
            if (RealTimeFlag == (checkBoxTimeOrCount.Checked))
            {
                checkBoxTimeOrCount.Checked = false;
                MessageBox.Show("请停止后更换为次数轴");
                return;
            }
            /*选择X轴为时间轴、次数轴*/
            Graph_X_Type = !Graph_X_Type;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            InitChart();
            GraphTimer.Enabled = true;
            GraphTimer.Start();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            chart1.Series.Clear();
        }
    }
}
