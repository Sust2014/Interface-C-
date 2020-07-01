using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 控制台测试代码
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 读取文件内容

            #region 全部读取到字符串变量
            string text = System.IO.File.ReadAllText(@"E:\1---软件\1---C#上位机\1---USB-CAN上位机界面\1---C#代码\1---上位机代码\Test.txt");

            System.Console.WriteLine("Contents of Test.txt = {0}", text);
            #endregion

            #region 一次读取一行
            int counter = 0;
            string line;

            System.IO.StreamReader file =
                new System.IO.StreamReader(@"E:\1---软件\1---C#上位机\1---USB-CAN上位机界面\1---C#代码\1---上位机代码\test.txt");
            while ((line = file.ReadLine()) != null)
            {
                System.Console.WriteLine(line);
                counter++;
            }

            file.Close();
            System.Console.WriteLine("There were {0} lines.", counter);
            #endregion

            #region 全部读取到字符串数组中，每个数组元素存储一行文本
            string[] lines = System.IO.File.ReadAllLines(@"E:\1---软件\1---C#上位机\1---USB-CAN上位机界面\1---C#代码\1---上位机代码\Test.txt");
            System.Console.WriteLine("Contents of Test.txt = ");
            foreach (string line2 in lines)
            {
                Console.WriteLine("\t" + line2);
            }
            #endregion

            Console.Read();
            #endregion
        }
    }
}
