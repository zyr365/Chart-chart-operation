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



namespace WindowsFormsApp13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Queue<double> dataQueue = new Queue<double>(100);
        private void Form1_Load(object sender, EventArgs e)
        {
            /* https://www.cnblogs.com/topmount/p/8430689.html */
            // 定义图表区域
            this.chart1.ChartAreas.Clear();
            ChartArea chartArea1 = new ChartArea("C1");
            this.chart1.ChartAreas.Add(chartArea1);
            //定义存储和显示点的容器
            this.chart1.Series.Clear();
            Series series1 = new Series("S1");
            series1.ChartArea = "C1";
            this.chart1.Series.Add(series1);
            chart1.Series[0].Points.Clear();
            chart1.Series[0].ChartType = SeriesChartType.Spline;//设置图表类型
            chart1.ChartAreas[0].AxisX.Interval = 5;   //设置X轴坐标的间隔为5
            chart1.ChartAreas[0].AxisX.IntervalOffset = 0;  //设置X轴坐标偏移为0
            chart1.ChartAreas[0].AxisX.Minimum = 0;//设置X轴最小值
            chart1.ChartAreas[0].AxisX.Maximum = 100;//设置X轴最大值
            chart1.ChartAreas[0].AxisX.LabelStyle.IsStaggered = true; //设置是否交错显示,比如数据多的时间分成两行来显示 
            chart1.ChartAreas[0].AxisX.LabelStyle.Angle = -45;//X轴标签的角度
            chart1.ChartAreas[0].AxisY.LabelStyle.Format = "0%";//Y轴标签以百分数格式显示
            chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;//不显示网格线

            chart1.ChartAreas[0].AxisY.Minimum = 0.0;
            chart1.ChartAreas[0].AxisY.Maximum = 1.0;
            chart1.ChartAreas[0].AxisY.Interval = 0.1;
            chart1.Legends[0].Enabled = false;//不显示图例
            chart1.ChartAreas[0].BackColor = Color.White;//设置背景为白色
            chart1.ChartAreas[0].Area3DStyle.Enable3D = true;//设置3D效果
            chart1.ChartAreas[0].Area3DStyle.PointDepth = 50;
            chart1.ChartAreas[0].Area3DStyle.PointGapDepth = 50;//设置一下深度，看起来舒服点……
            chart1.ChartAreas[0].Area3DStyle.WallWidth = 0;//设置墙的宽度为0；
            //chart1.Series[0].Label = "#VAL{P}";//设置标签文本 (在设计期通过属性窗口编辑更直观) 标签变成百分数
            //chart1.Series[0].IsValueShownAsLabel = true;//显示标签
            chart1.Series[0].CustomProperties = "DrawingStyle=Cylinder, PointWidth=1";//设置为圆柱形 (在设计期通过属性窗口编辑更直观)
            chart1.Series[0].Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;//设置调

            this.chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = System.Drawing.Color.Red;
            this.chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = System.Drawing.Color.Red;
            //设置标题
            this.chart1.Titles.Clear();
            this.chart1.Titles.Add("S01");
            this.chart1.Titles[0].Text = "XXX显示";
            this.chart1.Titles[0].ForeColor = Color.RoyalBlue;
            this.chart1.Titles[0].Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            //设置图表显示样式
            this.chart1.Series[0].Color = Color.Red;
           

            for (int j = 0; j < 100; j++)
                chart1.Series[0].Points.AddXY(j, j/100.0);
        }

        private void button1_Click(object sender, EventArgs e)
        {


        }
    }
}
