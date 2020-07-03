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

namespace MainSurface
{
    public partial class BootLoader : Form
    {
        public BootLoader()
        {
            InitializeComponent();
        }

        //定义一个string变量存储文件路径
        string FilePath;

        //定义一个char数组存放文件内容
        char[] FileContent = new char[128];

        private void buttonSendFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenFile = new OpenFileDialog();
            OpenFile.Multiselect = true;
            OpenFile.Title = "请选择文件";
            OpenFile.Filter = "升级文件(*.txt;*.hex;*.s19)|*.txt;*.hex;*.s19";

            //选择文件
            OpenFile.ShowDialog();

            //获取文件路径
            FilePath = OpenFile.FileName;


            //选择文件
            //OpenFile.ShowDialog();

            //获取文件路径
            //FilePath = OpenFile.FileName;

            //获取文件内容
            //内容较大，采用流（Stream）的方式来读取内容
            //if (OpenFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            //{
            //    if (OpenFile.FileName.Contains("s19"))
            //        MessageBox.Show("这是一个后缀为s19的文件");
            //    if (OpenFile.FileName != null)
            //    {
            //        #region 采用流（Stream）的方式来读取内容
            //        try
            //        {
            //            FilePath = OpenFile.FileName;

            //            StreamReader ReadFile = new StreamReader(FilePath);

            //            string line;

            //            while ((line = ReadFile.ReadLine()) != null)
            //            {
            //                //Environment.NewLine为换行
            //                textBoxFileContent.Text += Environment.NewLine + line;
            //            }

            //            ReadFile.Close();
            //            ReadFile.Dispose();
            //        }
            //        catch (Exception)
            //        {
                        
            //            throw;
            //        }
            //        #endregion
            //    }
            //}
        }

        public void BootLoader_SendFile()
        {
            int i = 0;
            StreamReader SendFile = new StreamReader(FilePath);
            string line = SendFile.ReadLine();
            FileContent = line.ToCharArray();
            for (i = 0; i < FileContent.Length; i++)
            {

            }
        }

        private void BootLoader_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                this.Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
