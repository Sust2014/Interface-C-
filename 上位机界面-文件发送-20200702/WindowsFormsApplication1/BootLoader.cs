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

        private void buttonSendFile_Click(object sender, EventArgs e)
        {
            //定义一个string变量存储文件路径
            string FilePath ;

            OpenFileDialog OpenFile = new OpenFileDialog();
            OpenFile.Multiselect = true;
            OpenFile.Title = "请选择文件";
            OpenFile.Filter = "升级文件(*.txt;*.hex;*.s19)|*.txt;*.hex;*.s19";


            //选择文件
            //OpenFile.ShowDialog();

            //获取文件路径
            //FilePath = OpenFile.FileName;

            //获取文件内容
            //内容较大，采用流（Stream）的方式来读取内容
            if (OpenFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (OpenFile.FileName.Contains("s19"))
                    MessageBox.Show("这是一个后缀为s19的文件");
                if (OpenFile.FileName != null)
                {
                    #region 采用流（Stream）的方式来读取内容
                    try
                    {
                        FilePath = OpenFile.FileName;

                        StreamReader ReadFile = new StreamReader(FilePath);

                        string line;

                        while ((line = ReadFile.ReadLine()) != null)
                        {
                            //Environment.NewLine为换行
                            textBoxFileContent.Text += Environment.NewLine + line;
                        }

                        ReadFile.Close();
                        ReadFile.Dispose();
                    }
                    catch (Exception)
                    {
                        
                        throw;
                    }
                    #endregion
                }
            }
        }

        private void BootLoader_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
