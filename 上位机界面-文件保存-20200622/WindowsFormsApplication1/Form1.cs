using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;
using Microsoft.Office.Interop.Excel;

//int Num_Rows = 0 ;//显示接收数据的行数
//  设备型号定义
//  DEV_CAN232B 1
//  DEV_USBCAN 2
//  DEV_USBCAN200 3
//  DEV_NETCAN100 4
//  DEV_NETCAN200 5

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
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
        uint m_nNum = 0;//发送和接收的总帧数
        #endregion
        #endregion

        //数据格式
        bool DataFormat = false;

        //循环发送次数
        Int16 CycleSendNum = 0;

        //开始数据接收标志
        int StartReceiveFlag;

        //数据接收缓冲区
        //PVCI_CAN_OBJ[] databuf = new PVCI_CAN_OBJ[300];
        //定义数据存储数组
        int[] array = new int[5];
        int[] array1 = new int[6];
        int[] array2 = new int[7];

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listViewRecieve.View = View.Details;
            UInt32 test_data = 0;

            listViewRecieve.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            ComBoxFrameFormat.SelectedIndex = 0;
            ComBoxFrameType.SelectedIndex = 0;
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void 信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ////MessageBox.Show("作者：赵文卓");
            //var form = new Infor();
            //form.Show();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            //tsslab_1.Text = e.X.ToString() + "  " + e.Y.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tssLab_1.Text = DateTime.Now.ToString();
        }

        private void 关于作者ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("作者：赵文卓");
            var form = new Infor();
            //form.Show();
            form.ShowDialog();
        }

        private void cAN参数设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new CAN参数设置();
            form.ShowDialog();
        }

        public int HexChar(char c)
        {
            if ((c >= '0') && (c <= '9'))
                return c - 0x30;
            else if ((c >= 'A') && (c <= 'F'))
                return c - 'A' + 10;
            else if ((c >= 'a') && (c <= 'f'))
                return c - 'a' + 10;
            else
                return 0x10;
        }

        public int Str2Hex(string str)
        {
            int len = str.Length;
            if (len == 2)
            {
                int a = HexChar(str[0]);
                int b = HexChar(str[1]);
                if (a == 16 || b == 16)
                {
                    MessageBox.Show("format error！");
                    return 256;
                }
                else
                {
                    return a * 16 + b;

                }

            }
            else
            {
                MessageBox.Show("len must be 2");
                return 256;
            }
        }

        private void SendData()
        {
            PVCI_CAN_OBJ sendbuf = new PVCI_CAN_OBJ();
            sendbuf.ID = new byte[4];
            sendbuf.Data = new byte[8];
            sendbuf.Reserved = new byte[3];
            string[] str5 = new string[32];
            byte[] buf = new byte[50];
            byte[] SendID = new byte[10];
            string strtemp, strtemp1;
            string str1;
            int len, datanum = 0, IDnum = 0, newflag = 1;
            string strSendID = textBoxID.Text.ToString();
            char[] m_strSendID = strSendID.ToCharArray();

            len = m_strSendID.Length;
            for (int i = 0; i < len; i++)
            {
                strtemp = m_strSendID[i].ToString();
                if (strtemp == " ")
                    newflag = 1;
                else if (newflag == 1)
                {
                    newflag = 0;
                    strtemp = m_strSendID[i].ToString();
                    if (i == (len - 1))
                    {
                        str5[IDnum] = "0" + strtemp;

                    }
                    else
                    {
                        strtemp1 = m_strSendID[i + 1].ToString();

                        if (strtemp1 == " ")
                            str5[IDnum] = "0" + strtemp;
                        else
                            str5[IDnum] = strtemp + strtemp1;
                    }

                    SendID[IDnum] = (byte)Str2Hex(str5[IDnum]);
                    IDnum++;
                    if (IDnum >= 4)
                        break;
                }
            }
            newflag = 1;

            byte[] SendID_New = new byte[10];
            for (int i = 0; i < 4; i++)
            {
                SendID_New[i] = SendID[3 - i];
            }

            string strSendData = TextBoxSend.Text.ToString();
            char[] m_strSendData = strSendData.ToCharArray();
            len = m_strSendData.Length;

            for (int i = 0; i < len; i++)
            {

                strtemp = m_strSendData[i].ToString();
                if (strtemp == " ")
                    newflag = 1;
                else if (newflag == 1)
                {

                    newflag = 0;
                    strtemp = m_strSendData[i].ToString();
                    if (i == (len - 1))
                    {
                        str5[datanum] = "0" + strtemp;

                    }
                    else
                    {
                        strtemp1 = m_strSendData[i + 1].ToString();

                        if (strtemp1 == " ")
                        {
                            str5[datanum] = "0" + strtemp;

                        }
                        else
                            str5[datanum] = strtemp + strtemp1;

                    }
                    buf[datanum] = (byte)Str2Hex(str5[datanum]);
                    datanum++;
                    if (datanum >= 8)
                        break;

                }

            }
            byte m_nSendFrameType = 0;
            byte m_nSendFrameFormat = 0;
            byte m_radioIDFormat = 0;
            sendbuf.ExternFlag = m_nSendFrameType;//1
            sendbuf.DataLen = (byte)datanum;//8
            sendbuf.RemoteFlag = m_nSendFrameFormat;//0
            if (m_nSendFrameFormat == 1)//if remote frame, data is invalid
                for (int i = 0; i < datanum; i++)
                    buf[i] = 0;
            byte[] SendID2 = new byte[4];

            if ((sendbuf.ExternFlag) == 1)//Extend ID progress
            {
                if (m_radioIDFormat != 0)//将直接ID值进行转换到CAN2.0B格式
                {
                    SendID[0] &= 0x1F;
                    SendID2[0] = (byte)((SendID[0] << 3) | (SendID[1] >> 5));
                    SendID2[1] = (byte)((SendID[1] << 3) | (SendID[2] >> 5));
                    SendID2[2] = (byte)((SendID[2] << 3) | (SendID[3] >> 5));
                    SendID2[3] = (byte)(SendID[3] << 3);
                    for (int i = 0; i < 4; i++)
                        sendbuf.ID[i] = SendID2[i];
                    //	sendbuf->ID=(SendID2[0]<<24)+(SendID2[1]<<16)+(SendID2[2]<<8)+SendID2[3];
                }
                else
                {
                    SendID[3] = (byte)(SendID[3] & 0xF8);//the last 3 bits is invalid,clear to 0
                    for (int i = 0; i < 4; i++)
                        sendbuf.ID[i] = SendID[i];
                    //	sendbuf->ID=(SendID[0]<<24)+(SendID[1]<<16)+(SendID[2]<<8)+SendID[3];

                }
            }
            else//Basic CAN
            {

                if (m_radioIDFormat != 0)//Direct id value to SJA1000 format
                {
                    SendID[2] &= 0x07;
                    SendID2[0] = (byte)((SendID[2] << 5) | (SendID[3] >> 3));
                    SendID2[1] = (byte)(SendID[3] << 5);
                    for (int i = 0; i < 2; i++)
                        sendbuf.ID[i] = SendID2[i];
                    //sendbuf->ID=(SendID2[0]<<24)+(SendID2[1]<<16)+(SendID2[2]<<8)+SendID2[3];

                }
                else
                {
                    //SendID[1] = (byte)(SendID[1] & 0xE0);//the last 5 bits is invalid, clear to 0
                    for (int i = 0; i < 2; i++)
                        sendbuf.ID[i] = SendID[i];
                    //	sendbuf->ID=(SendID[0]<<24)+(SendID[1]<<16)+(SendID[2]<<8)+SendID[3];

                }
            }

            for (int i = 0; i < datanum; i++)
                sendbuf.Data[i] = buf[i];

            int flag;

            sendbuf.ID[0] = SendID_New[0];
            sendbuf.ID[1] = SendID_New[1];
            sendbuf.ID[2] = SendID_New[2];
            sendbuf.ID[3] = SendID_New[3];

            flag = VCI_Transmit(2, 0, 0, ref sendbuf);//CAN DATA SEND
            PVCI_CAN_OBJ[] TempBuf = new PVCI_CAN_OBJ[50];
            TempBuf[0] = sendbuf;
            showCan(0, 0, TempBuf, 1);
            if (flag != 1)
            {
                if (flag == -1)
                    //MessageBox.Show("fail,device not open\n");
                //else if (flag == 0)
                    //MessageBox.Show("fail\n");
                return;

            }
            string str = "";
            for (int i = 0; i < sendbuf.DataLen; i++)			//DATA
            {
                uint data = sendbuf.Data[i];
                str1 = Convert.ToString(data, 16);
                str += str1 + " ";

            }
        }

        public void Receive()
        {
            int ReceiveFlag;
            PVCI_CAN_OBJ[] databuf = new PVCI_CAN_OBJ[300];
            PVCI_CAN_OBJ receivebuf = new PVCI_CAN_OBJ();
            receivebuf.ID = new byte[4];
            receivebuf.Data = new byte[8];
            receivebuf.Reserved = new byte[3];

            receivebuf.DataLen = 8;
            PVCI_CAN_OBJ[] TempBuf = new PVCI_CAN_OBJ[50];
            ReceiveFlag = VCI_Receive(2, 0, 0,  databuf);
            if (ReceiveFlag == 0)
            {
                MessageBox.Show("接收数据错误！");
            }
            else
            {
                for (int i = 0; i < 8; i++)
                {
                    receivebuf.Data[i] = databuf[0].Data[i] ;
                }

                byte[] ReceiveID_New = new byte[4];
                ReceiveID_New[0] = databuf[0].ID[0];
                ReceiveID_New[1] = databuf[0].ID[1];
                ReceiveID_New[2] = databuf[0].ID[2];
                ReceiveID_New[3] = databuf[0].ID[3];

                receivebuf.ID[0] = (byte)((ReceiveID_New[0] >> 1) | (ReceiveID_New[1] >> 1));

                TempBuf[0] = receivebuf;
                showCan(0, 1, TempBuf, 1);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SendData();
        }

        private void timerRecieve_Tick(object sender, EventArgs e)
        {
            //PVCI_CAN_OBJ[] sendbuf = new PVCI_CAN_OBJ[200];
            //int NumValue = 0;
            //NumValue = VCI_Receive(2, 0, 0, sendbuf);
            //showCan(0, 1, sendbuf, NumValue);
        }

        private void CycelSendData(object sender, EventArgs e)
        {

        }

        private void showCan(byte byCanIndex, byte byOrientation, PVCI_CAN_OBJ[] buf, int nLength)
        {
            DateTime CurrentTime = new DateTime();
            for (uint i = 0; i < nLength; i++)
            {
                PVCI_CAN_OBJ temp = buf[i];
                ListViewItem Item = new ListViewItem();
                string strNum = Convert.ToString(m_nNum);
                string strTime = DateTime.Now.ToString();//strHour + ":" + strMinute + "" + strSecond;
                int foundS1 = strTime.IndexOf(" ");
                strTime = strTime.Remove(0, foundS1);

                string strCanIndex = Convert.ToString(byCanIndex);
                string strOrientation;
                if (byOrientation == 0)
                    strOrientation = "发送";
                else
                    strOrientation = "接收";
                byte a = temp.ID[0];
                //string test_data ;
                string strID0 = Convert.ToString((buf[i]).ID[0], 16);
                //十进制转换为十六进制
                //test_data = Convert.ToString(buf[i].ID[1],16);
                string strID1 = Convert.ToString((buf[i]).ID[1], 16);
                string strID2 = Convert.ToString((buf[i]).ID[2], 16);
                string strID3 = Convert.ToString((buf[i]).ID[3], 16);
                //string strID = strID3 + " " + strID2 + " " + strID1 + " " + strID0;
                string strID;
                if (buf[i].ExternFlag == 1)
                    strID = strID3 + " " + strID2 + " " + strID1 + " " + strID0;
                else
                    strID = strID1 + " " + strID0;

                //选择发送的数据格式和数据类型
                string strFrame;
                buf[i].RemoteFlag = (byte)ComBoxFrameType.SelectedIndex;
                if ((buf[i]).RemoteFlag == 1)
                    strFrame = "远程帧";
                else
                    strFrame = "数据帧";
                string strType;
                buf[i].ExternFlag = (byte)ComBoxFrameFormat.SelectedIndex;
                if (buf[i].ExternFlag == 1)
                    strType = "扩展帧";
                else
                    strType = "标准帧";

                //数据长度
                string strDataLen = Convert.ToString(buf[i].DataLen);
                string strData;

                if (DataFormat == false)
                {
                    strData = Convert.ToString(buf[i].Data[0]);
                }
                else
                {
                    strData = Convert.ToString(buf[i].Data[0], 16);
                }
                for (int j = 1; j < 8; j++)
                {
                    string strTemp;
                    if (DataFormat == false)
                    {
                        strTemp = Convert.ToString(buf[i].Data[j]);
                    }
                    else
                    {
                        strTemp = Convert.ToString(buf[i].Data[j],16);
                    }
                    strData = strData + " " + strTemp;
                }
                Item.SubItems.Clear();
                Item.SubItems[0].Text = strNum;
                Item.SubItems.Add(strTime);
                Item.SubItems.Add(strCanIndex);
                Item.SubItems.Add(strOrientation);
                Item.SubItems.Add(strID);
                Item.SubItems.Add(strFrame);
                Item.SubItems.Add(strType);
                Item.SubItems.Add(strDataLen);
                Item.SubItems.Add(strData);
                if (byOrientation == 0)
                    Item.BackColor = Color.MediumSpringGreen;
                else
                    Item.BackColor = Color.Aqua;
                listViewRecieve.Items.Add(Item);
                m_nNum++;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void 新建ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new test();
            form.MdiParent = this;
            form.Show();
        }

        private void 全部最大化ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var item in this.MdiChildren)
            {
                item.WindowState = FormWindowState.Maximized;
            }
        }

        private void 全部最小化ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var item in this.MdiChildren)
            {
                item.WindowState = FormWindowState.Minimized;
            }
        }

        private void 层叠ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void 水平ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void 垂直ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void 图标ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            var filename = openFileDialog1.FileName;

            var form = new test();
            form.MdiParent = this;
            form.Text = new FileInfo(filename).Name;

            form.txtcontent.Text = File.ReadAllText(openFileDialog1.FileName);

            form.Show();
        }

        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void 另存为ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                saveFileDialog1.ShowDialog();
            }
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            var fileName = saveFileDialog1.FileName;
            var content = (ActiveMdiChild as test).txtcontent.Text;

            File.WriteAllText(fileName, content);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tssLab_1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        public void 启动设备ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //设备型号定义 DEV_USBCAN 2
            if (VCI_OpenDevice(2, 0, 0) != 1)
            {
                MessageBox.Show("Open USB_CAN fail");
            }
            else
            {
                MessageBox.Show("Open USB_CAN Successfully !");
                PVCI_INIT_CONFIG[] config = new PVCI_INIT_CONFIG[1];
                config[0].AccCode = 0x80000008;
                config[0].AccMask = 0xFFFFFFFF;
                config[0].Reserved = 204;
                config[0].Filter = 0;
                //config[0].kCanBaud = 15;
                //config[0].Timing0 = 0x00;
                //config[0].Timing1 = 0x14;
                config[0].CanRx_IER = 1;
                config[0].Mode = 0;//1~自发自收模式，0~正常工作模式

                if (VCI_InitCAN(2, 0, 0, ref config[0]) != 1)
                {
                    MessageBox.Show("Init USB_CAN fail");
                    return;
                }

                if (VCI_StartCAN(2, 0, 0) != 1)
                {
                    MessageBox.Show("Start USB_CAN fail");
                    return;
                }
            }
        }

        private void comForMat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void OpenBootLoaderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //将BootLoader界面关联到启动BootLOader菜单
            var form = new BootLoader();
            form.ShowDialog();
        }

        private void textBoxID_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxOfDataFormat_CheckedChanged(object sender, EventArgs e)
        {
            DataFormat = !DataFormat;
        }

        private void button6_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MessageBox.Show("left");
            }
            else
            {
                MessageBox.Show("right");
            }
        }

        private void listViewRecieve_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MessageBox.Show("left");
            }
            else
            {
                MessageBox.Show("right");
            }
        }

        private void textBoxCycleSendNum_TextChanged(object sender, EventArgs e)
        {
            CycleSendNum = Convert.ToInt16(textBoxCycleSendNum.Text.ToString());
        }

        private void 设备操作ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void checkBoxReceive_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxReceive.Checked == true)
                StartReceiveFlag = 1;
            else
            {
                StartReceiveFlag = 0;
                MessageBox.Show("关闭接收功能！");
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                this.Close();
            }
        }

        private void ReceiveTime_Tick(object sender, EventArgs e)
        {
            if (StartReceiveFlag == 1)
            {
                Receive();
            }
        }

        private void ButtonEmpty_Click(object sender, EventArgs e)
        {
            listViewRecieve.Items.Clear() ;
        }

        private void CycleSendData(object sender, EventArgs e)
        {
            if (CycleSendNum > 0)
            {
                CycleSendNum--;
                SendData();
            }
        }

        private void TextBoxSendInterTime_TextChanged(object sender, EventArgs e)
        {
            SendTime.Interval = Convert.ToInt16(TextBoxSendInterTime.Text.ToString());
        }

        #region 数据保存到excel

        public static void ExportToExcel(ListView pListView)
        {
            if (pListView.Items == null) return;

            string saveFileName = "";
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.DefaultExt = "xls";
            saveDialog.Filter = "Excel文件|*.xls";
            saveDialog.FileName = DateTime.Now.ToString("yyyy-MM-dd");
            saveDialog.ShowDialog();
            saveFileName = saveDialog.FileName;
            if (saveFileName.IndexOf(":") < 0)
                return;
            //这里直接删除，因为saveDialog已经做了文件是否存在的判断
            if (File.Exists(saveFileName)) File.Delete(saveFileName);
            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            if (xlApp == null)
            {
                MessageBox.Show("无法创建Excel对象，可能您的机器未安装Excel");
                return;
            }
            Microsoft.Office.Interop.Excel.Workbooks workbooks = xlApp.Workbooks;
            Microsoft.Office.Interop.Excel.Workbook workbook = workbooks.Add(true);
            Microsoft.Office.Interop.Excel.Worksheet worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Worksheets[1];
            xlApp.Visible = false;
            //填充列
            for (int i = 0; i < pListView.Columns.Count; i++)
            {
                worksheet.Cells[1, i + 1] = pListView.Columns[i].Text.ToString();
                ((Microsoft.Office.Interop.Excel.Range)worksheet.Cells[1, i + 1]).Font.Bold = true;
            }
            //填充数据（这里分了两种情况，1：lv带CheckedBox，2：不带CheckedBox）

            //带CheckedBoxes
            if (pListView.CheckBoxes == true)
            {
                int tmpCnt = 0;
                for (int i = 0; i < pListView.Items.Count; i++)
                {
                    if (pListView.Items[i].Checked == true)
                    {
                        for (int j = 0; j < pListView.Columns.Count; j++)
                        {
                            if (j == 0)
                            {
                                worksheet.Cells[2 + tmpCnt, j + 1] = pListView.Items[i].Text.ToString();
                                ((Microsoft.Office.Interop.Excel.Range)worksheet.Cells[2 + tmpCnt, j + 1]).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
                            }
                            else
                            {
                                worksheet.Cells[2 + tmpCnt, j + 1] = pListView.Items[i].SubItems[j].Text.ToString();
                                ((Microsoft.Office.Interop.Excel.Range)worksheet.Cells[2 + tmpCnt, j + 1]).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
                            }
                        }
                        tmpCnt++;
                    }
                }
            }
            else //不带Checkedboxe
            {
                for (int i = 0; i < pListView.Items.Count; i++)
                {
                    for (int j = 0; j < pListView.Columns.Count; j++)
                    {
                        if (j == 0)
                        {
                            worksheet.Cells[2 + i, j + 1] = pListView.Items[i].Text.ToString();
                            ((Microsoft.Office.Interop.Excel.Range)worksheet.Cells[2 + i, j + 1]).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
                        }
                        else
                        {
                            worksheet.Cells[2 + i, j + 1] = pListView.Items[i].SubItems[j].Text.ToString();
                            ((Microsoft.Office.Interop.Excel.Range)worksheet.Cells[2 + i, j + 1]).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
                        }
                    }
                }
            }
            object missing = System.Reflection.Missing.Value;
            try
            {
                workbook.Saved = true;
                workbook.SaveAs(saveFileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlXMLSpreadsheet, missing, missing, false, false, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange, missing, missing, missing, missing, missing);
            }
            catch (Exception e1)
            {
                MessageBox.Show("导出文件时出错,文件可能正被打开！\n" + e1.Message);
            }
            finally
            {
                xlApp.Quit();
                System.GC.Collect();
            }
            MessageBox.Show("导出Excle成功！");
        }

        #endregion

        private void ButtonOfSaveData_Click(object sender, EventArgs e)
        {
            ExportToExcel(listViewRecieve);
        }
    }
}
