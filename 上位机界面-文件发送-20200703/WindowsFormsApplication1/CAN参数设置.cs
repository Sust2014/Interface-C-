using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace MainSurface
{
    public partial class CAN参数设置 : Form
    {
        #region 设备厂家定义数据及DLL文件调用
        [StructLayout(LayoutKind.Sequential)]
        public struct PVCI_INIT_CONFIG
        {
            public uint AccCode;//过滤验收码
            public uint AccMask;//过滤屏蔽码
            public uint Reserved;//保留不用
            public byte Filter;//过滤方式。 0 表示单滤波， 1 表示双滤波
            public byte kCanBaud;//CAN 波特率索引号
            public byte Timing0;//CAN 波特率定时器 BTR0
            public byte Timing1;//CAN 波特率定时器 BTR1
            public byte Mode;//工作模式。 0 表示正常模式， 1 表示自发自收模式
            public byte CanRx_IER;
        }
        [StructLayout(LayoutKind.Sequential)]
        public struct PVCI_CAN_OBJ
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]//声明数组大小为4
            public byte[] ID; //4
            public UInt32 TimeStamp;//C++的UINT对应32位
            public byte TimeFlag;
            public byte SendType;
            public byte RemoteFlag; //=0
            public byte ExternFlag; //=1
            public byte DataLen; //=8
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]//声明数组大小为8
            public byte[] Data; //8
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]//声明数组大小为3
            public byte[] Reserved;//3
        }
        #region DllImport是System.Runtime.InteropServices命名空间下的一个属性类，其功能是提供从非托管DLL导出的函数的必要调用信息
        [DllImport("VCI_CAN.dll", EntryPoint = "VCI_OpenDevice")]//入口点名称是开启设备
        public static extern int VCI_OpenDevice(uint Devtype, uint Devindex, uint Reserved);
        [DllImport("VCI_CAN.dll", EntryPoint = "VCI_StartCAN")]//入口点名称是开始CAN通信
        public static extern int VCI_StartCAN(uint Devtype, uint Devindex, uint CANInd);
        [DllImport("VCI_CAN.dll", EntryPoint = "VCI_CloseDevice")]//入口点名称是关闭设备
        public static extern int VCI_CloseDevice(int DeviceType, int DeviceInd);
        [DllImport("VCI_CAN.dll", EntryPoint = "VCI_SetReference")]//入口点名称是引用
        public static extern int VCI_SetReference(uint DeviceType, uint DeviceInd, uint CANInd, uint RefType, ref byte pData);
        [DllImport("VCI_CAN.dll", EntryPoint = "VCI_InitCAN")]//入口点名称是CAN的Init
        public static extern int VCI_InitCAN(uint DevType, uint DevIndex, uint CANIndex, ref PVCI_INIT_CONFIG pInitConfig);
        [DllImport("VCI_CAN.dll", EntryPoint = "VCI_Transmit")]//入口点名称是开始传输
        public static extern int VCI_Transmit(uint DevType, uint DevIndex, uint CANIndex, ref PVCI_CAN_OBJ pSend);
        [DllImport("VCI_CAN.dll", EntryPoint = "VCI_Receive")]//入口点名称是接收
        public static extern int VCI_Receive(uint DevType, uint DevIndex, uint CANIndex, [Out]/*声明参数为输出*/ PVCI_CAN_OBJ[] pReceive);
        #endregion
        #endregion

        //定义CAN参数配置结构体
        PVCI_INIT_CONFIG[] config = new PVCI_INIT_CONFIG[1];

        //定义一个变量存放DevIndex的通道
        uint DevIndex = 0;

        ////定义一个数组，存放波特率与序号的关系
        //int[,] BaudArray = new int[15, 2];

        public CAN参数设置()
        {
            InitializeComponent();
        }

        public static void BaudArrayInit()
        {
             //定义一个数组，存放波特率与序号的关系
            int[,] BaudArray = new int[15, 2];

            BaudArray[0, 0] = 1; BaudArray[0, 1] = 5;
            BaudArray[1, 0] = 2; BaudArray[1, 1] = 10;
            BaudArray[2, 0] = 3; BaudArray[2, 1] = 20;
            BaudArray[3, 0] = 4; BaudArray[3, 1] = 40;
            BaudArray[4, 0] = 5; BaudArray[4, 1] = 50;
            BaudArray[5, 0] = 6; BaudArray[5, 1] = 80;
            BaudArray[6, 0] = 7; BaudArray[6, 1] = 100;
            BaudArray[7, 0] = 8; BaudArray[7, 1] = 125;
            BaudArray[8, 0] = 9; BaudArray[8, 1] = 200;
            BaudArray[9, 0] = 10; BaudArray[9, 1] = 250;
            BaudArray[10, 0] = 11; BaudArray[10, 1] = 400;
            BaudArray[11, 0] = 12; BaudArray[11, 1] = 500;
            BaudArray[12, 0] = 13; BaudArray[12, 1] = 666;
            BaudArray[13, 0] = 14; BaudArray[13, 1] = 800;
            BaudArray[14, 0] = 15; BaudArray[14, 1] = 1000;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CAN参数设置_Load(object sender, EventArgs e)
        {
            //BaudArrayInit();
            config[0].AccCode = 0x00000000;
            config[0].AccMask = 0xFFFFFFFF;
            config[0].Reserved = 204;
            config[0].Filter = 0;
            config[0].CanRx_IER = 1;

            ComBoxChannelChoose.SelectedIndex = 0;
            ComBoxBaudChoose.SelectedIndex = 6;
            ComBoxWorkMode.SelectedIndex = 0;

            config[0].kCanBaud = 6;
            config[0].Timing0 = 0x04;
            config[0].Timing1 = 0x1C;
            config[0].Mode = 0;

            if (VCI_InitCAN(2, 0, 0, ref config[0]) != 1)
            {
                MessageBox.Show("Init USB_CAN Fail");
                return;
            }

            if (VCI_StartCAN(2, 0, 0) != 1)
            {
                MessageBox.Show("Start USB_CAN fail");
                return;
            }

            //MessageBox.Show("启动成功！");
        }


        //KeyPress事件
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //显示下拉框的内容
            //comboBox3.DroppedDown = true;

            //定义一个数组，存放波特率与序号的关系
            int[,] BaudArray = new int[15, 4];

            BaudArray[0, 0] = 1; BaudArray[0, 1] = 5; BaudArray[0, 2] = 0xBF; BaudArray[0, 3] = 0xFF;
            BaudArray[1, 0] = 2; BaudArray[1, 1] = 10; BaudArray[1, 2] = 0x31; BaudArray[1, 3] = 0x1C;
            BaudArray[2, 0] = 3; BaudArray[2, 1] = 20; BaudArray[2, 2] = 0x18; BaudArray[2, 3] = 0x1C;
            BaudArray[3, 0] = 4; BaudArray[3, 1] = 40; BaudArray[3, 2] = 0x87; BaudArray[3, 3] = 0xFF;
            BaudArray[4, 0] = 5; BaudArray[4, 1] = 50; BaudArray[4, 2] = 0x09; BaudArray[4, 3] = 0x1C;
            BaudArray[5, 0] = 6; BaudArray[5, 1] = 80; BaudArray[5, 2] = 0x83; BaudArray[5, 3] = 0xFF;
            BaudArray[6, 0] = 7; BaudArray[6, 1] = 100; BaudArray[6, 2] = 0x04; BaudArray[6, 3] = 0x1C;
            BaudArray[7, 0] = 8; BaudArray[7, 1] = 125; BaudArray[7, 2] = 0x03; BaudArray[7, 3] = 0x1C;
            BaudArray[8, 0] = 9; BaudArray[8, 1] = 200; BaudArray[8, 2] = 0x81; BaudArray[8, 3] = 0xFA;
            BaudArray[9, 0] = 10; BaudArray[9, 1] = 250; BaudArray[9, 2] = 0x01; BaudArray[9, 3] = 0x1C;
            BaudArray[10, 0] = 11; BaudArray[10, 1] = 400; BaudArray[10, 2] = 0x80; BaudArray[10, 3] = 0xFA;
            BaudArray[11, 0] = 12; BaudArray[11, 1] = 500; BaudArray[11, 2] = 0x00; BaudArray[11, 3] = 0x1C;
            BaudArray[12, 0] = 13; BaudArray[12, 1] = 666; BaudArray[12, 2] = 0x80; BaudArray[12, 3] = 0xB6;
            BaudArray[13, 0] = 14; BaudArray[13, 1] = 800; BaudArray[13, 2] = 0x00; BaudArray[13, 3] = 0x16;
            BaudArray[14, 0] = 15; BaudArray[14, 1] = 1000; BaudArray[14, 2] = 0x00; BaudArray[14, 3] = 0x14;

            int Baud = 0;
            Baud = Convert.ToInt16(ComBoxBaudChoose.Text);

            //循环检测与波特率匹配的Index值
            for (int i = 0; i < BaudArray.GetLength(0); i++)
            {
                if (BaudArray[i, 1] == Baud)
                {
                    byte test = 0;
                    test = (byte)BaudArray[i, 0];
                    config[0].kCanBaud = test;
                    config[0].Timing0 = (byte)BaudArray[i, 2];
                    config[0].Timing1 = (byte)BaudArray[i, 3];
                    string Info = "波特率设置为" + BaudArray[i,1].ToString() + "Kpbs";
                    MessageBox.Show(Info, "提示",MessageBoxButtons.OKCancel,MessageBoxIcon.Exclamation);
                }
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //定义一个数组，存放工作模式与Index的关系
            int[] WorkModeArray = new int[2];
            WorkModeArray[0] = 0;
            WorkModeArray[1] = 1;

            int WorkMode = 0;
            //WorkMode = Convert.ToInt16(comboBox4.Text) ;
            WorkMode = Convert.ToInt16(ComBoxWorkMode.SelectedIndex);

            for(int i = 0 ; i < WorkModeArray.GetLength(0) ; i ++)
            {
                if(WorkModeArray[i] == WorkMode)
                {
                    config[0].Mode = (byte)WorkModeArray[i];
                    string Info = "工作模式设置为：" + ComBoxWorkMode.Text.ToString() + "模式";
                    MessageBox.Show(Info, "工作模式选择", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                }
            }

            if (VCI_InitCAN(2, 0, 0, ref config[0]) != 1)
            {
                MessageBox.Show("Init USB_CAN Fail");
                return;
            }

            if (VCI_StartCAN(2, 0, 0) != 1)
            {
                MessageBox.Show("Start USB_CAN fail");
                return;
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void ComBoxChannelChoose_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CAN参数设置_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
